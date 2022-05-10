use QLBANHANG2;
go
set dateformat dmy
--tao cac procedure:
--1.Lấy ra danh các khách hàng đã mua hàng trong ngày X, với X là tham số truyền vào.
CREATE PROC p1 @x INT
AS
SELECT k.MAKH, k.TENKH, h.NGAY
FROM KHACHHANG k, HOADON h
WHERE k.MAKH = h.MAKH and day(h.NGAY) = @x
GO
EXEC p1 25
--2.Lấy ra danh sách khách hàng có tổng trị giá các đơn hàng lớn hơn X (X là tham số).
CREATE PROC p2 @x INT
AS
SELECT k.MAKH, SUM(ct.SL * ct.GIABAN) AS [TONG TRI GIA]
FROM KHACHHANG k, HOADON h, CTHD ct
WHERE k.MAKH = h.MAKH AND h.MAHD = ct.MAHD
GROUP BY k.MAKH
HAVING SUM(ct.SL * ct.GIABAN) > @x
GO
EXEC p2 5000000
--3.Lấy ra danh sách X khách hàng có tổng trị giá các đơn hàng lớn nhất (X là tham số).
ALTER PROC p3 @x INT
AS
SELECT TOP(@x) WITH TIES k.MAKH, SUM(ct.SL * ct.GIABAN) AS [TONG TRI GIA]
FROM KHACHHANG k, HOADON h, CTHD ct
WHERE k.MAKH = h.MAKH AND h.MAHD = ct.MAHD
GROUP BY k.MAKH
ORDER BY [TONG TRI GIA] DESC
GO
EXEC p3 3
--4.Lấy ra danh sách X mặt hàng có số lượng bán lớn nhất (X là tham số).
ALTER PROC p4 @x INT
AS
SELECT TOP(@x) WITH TIES vt.MAVT, SUM(ct.SL) AS [TONG SO LUONG]
FROM VATTU vt, CTHD ct
WHERE vt.MAVT = ct.MAVT
GROUP BY vt.MAVT
ORDER BY SUM(ct.SL) DESC
GO
EXEC p4 3
--5.Lấy ra danh sách X mặt hàng bán ra có lãi ít nhất (X là tham số).
ALTER PROC p5 @x INT
AS
SELECT TOP(@x) WITH TIES vt.MAVT, SUM(ct.SL * (ct.GIABAN - vt.GIAMUA)) AS [LAI]
FROM VATTU vt, CTHD ct
WHERE vt.MAVT = ct.MAVT
GROUP BY vt.MAVT
ORDER BY [LAI] ASC
GO
EXEC p5 3
--6.Lấy ra danh sách X đơn hàng có tổng trị giá lớn nhất (X là tham số).
ALTER PROC p6 @x INT
AS
SELECT TOP(@x) WITH TIES hd.MAHD, SUM(ct.SL * ct.GIABAN) AS [TONG TRI GIA]
FROM HOADON hd, CTHD ct
WHERE hd.MAHD = ct.MAHD
GROUP BY hd.MAHD
ORDER BY [TONG TRI GIA] DESC
GO
EXEC p6 3
--7.Tính giá trị cho cột khuyến mãi như sau: Khuyến mãi 5% nếu SL > 100, 10% nếu SL > 500.
ALTER PROCEDURE p7
AS
UPDATE CTHD
SET KHUYENMAI = IIF(SL > 500, 0.1, (IIF(SL > 100, 0.05, 0))) *SL * GIABAN
FROM CTHD
GO
	--CASE
	--	WHEN SL > 500 THEN 0.1
	--	WHEN SL > 100 THEN 0.05
	--	ELSE 0
	--END

EXEC p7
SELECT * FROM CTHD
--8.Tính lại số lượng tồn cho tất cả các mặt hàng (SLTON = SLTON – tổng SL bán được).
ALTER PROCEDURE p8
AS
SELECT vt.MAVT,vt.SLTON, sum(ct.SL) AS [TONG SO LUONG BAN], (vt.SLTON - sum(ct.SL)) AS [SO LUONG TON]
FROM VATTU vt, CTHD ct
WHERE vt.MAVT = ct.MAVT
GROUP BY vt.MAVT, vt.SLTON
GO
EXEC p8
--9.Tính trị giá cho mỗi hóa đơn.
ALTER PROCEDURE p9
AS
SELECT ct.MAHD,
	SUM(ct.SL * ct.GIABAN -  KHUYENMAI) AS [TONG TRI GIA SAU KHUYEN MAI]
FROM HOADON h, CTHD ct
WHERE h.MAHD = ct.MAHD
GROUP BY ct.MAHD
GO
EXEC p9
--10.Tạo ra table KH_VIP có cấu trúc giống với cấu trúc table KHACHHANG.
--Lưu các khách hàng có tổng trị giá của tất cả các đơn hàng >=10,000,000 vào table KH_VIP.
alter PROC p10 @x INT
AS
    DROP TABLE IF EXISTS KH_VIP
    SELECT *
    INTO KH_VIP
    FROM dbo.KHACHHANG
    WHERE MAKH IN
    (
        SELECT kh.MAKH
        FROM KHACHHANG kh, HOADON hd, CTHD ct
        WHERE kh.MAKH = hd.MAKH AND hd.MAHD = ct.MAHD
        GROUP BY kh.MAKH
        HAVING SUM(ct.SL * ct.GIABAN -  KHUYENMAI) > @x
    )
GO
EXEC p10 10000000
SELECT * FROM dbo.KH_VIP

--10. Cach thay chi (09/05/22)
ALTER PROC c10_VER2
AS
BEGIN
	DROP TABLE IF EXISTS KHVIP
	CREATE TABLE KHVIP
	(
		MAKH VARCHAR(5) NOT NULL,
		TENKH NVARCHAR(30),
		DIACHIKH NVARCHAR(50),
		DT VARCHAR(11),
		EMAIL VARCHAR(30)
	)
	ALTER TABLE KHACHHANG ADD
	CONSTRAINT CK_DT_VER2 CHECK (DT LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')

	INSERT INTO KHVIP
	SELECT kh.MAKH, TENKH, DIACHIKH, DT, EMAIL
	FROM KHACHHANG kh, HOADON hd, CTHD ct
	WHERE kh.MAKH = hd.MAKH AND hd.MAHD = ct.MAHD
    GROUP BY kh.MAKH, TENKH, DIACHIKH, DT, EMAIL
    HAVING SUM(ct.SL * ct.GIABAN -  KHUYENMAI) > 10000000
END
EXEC c10_VER2

SELECT * FROM KHVIP