-- function
--1.Viết hàm tính doanh thu của năm, với năm là tham số truyền vào.
CREATE FUNCTION F1 (@NAM INT)
RETURNS INT
AS
BEGIN
	DECLARE @DOANHTHU FLOAT
	SET @DOANHTHU =
		(SELECT SUM(SL * GIABAN) AS [DOANH THU]
		FROM HOADON hd, CTHD ct
		WHERE hd.MAHD = ct.MAHD AND YEAR(hd.NGAY) = @NAM)
	RETURN @DOANHTHU
END
PRINT 'Doanh thu' +  str(dbo.F1(2010))
--2.Viết hàm tính doanh thu của tháng, năm, với tháng và năm là 2 tham số truyền vào.
CREATE FUNCTION F2 (@NAM INT, @THANG INT)
RETURNS INT
AS
BEGIN
	DECLARE @DOANHTHU FLOAT
	SET @DOANHTHU =
		(SELECT SUM(SL * GIABAN) AS [DOANH THU]
		FROM HOADON hd, CTHD ct
		WHERE hd.MAHD = ct.MAHD AND YEAR(hd.NGAY) = @NAM AND MONTH(hd.NGAY) = @THANG)
	RETURN @DOANHTHU
END
PRINT 'Doanh thu theo thang va nam' + STR(dbo.F2(2010, 7))
--3.Viết hàm tính doanh thu của khách hàng với mã khách hàng là tham số truyền vào.
CREATE FUNCTION F3 (@MAKH VARCHAR(5))
RETURNS INT
AS
BEGIN
	DECLARE @DOANHTHU FLOAT
	SET @DOANHTHU =
		(SELECT SUM(ct.SL * ct.GIABAN) AS [DOANH THU]
		FROM KHACHHANG kh, HOADON hd, CTHD ct
		WHERE kh.MAKH = hd.MAKH AND hd.MAHD = ct.MAHD AND kh.MAKH = @MAKH)
	RETURN @DOANHTHU
END
PRINT 'Doanh thu theo MAKH' + STR(dbo.F3('KH04'))
--4.Viết hàm tính tổng số lượng bán được cho từng mặt hàng theo tháng, năm nào đó.
--Với mã hàng, tháng và năm là các tham số truyền vào, nếu tháng không nhập vào tức là tính tất cả các tháng.
ALTER FUNCTION F4 (@MAVT VARCHAR(5), @NAM INT, @THANG INT)
RETURNS INT
AS
BEGIN
	DECLARE @SOLUONG INT
	IF @THANG IS NULL
		BEGIN
		SET @SOLUONG =
			(SELECT SUM(ct.SL)
			FROM VATTU vt, HOADON hd, CTHD ct
			WHERE vt.MAVT = ct.MAVT AND hd.MAHD = ct.MAHD
				AND vt.MAVT = @MAVT AND YEAR(hd.NGAY) = @NAM)
		END
	ELSE
		BEGIN
		SET @SOLUONG =
			(SELECT SUM(ct.SL)
			FROM VATTU vt, HOADON hd, CTHD ct
			WHERE vt.MAVT = ct.MAVT AND hd.MAHD = ct.MAHD
				AND vt.MAVT = @MAVT AND MONTH(hd.NGAY) = @THANG AND YEAR(hd.NGAY) = @NAM)
		END
	RETURN @SOLUONG
END
PRINT 'So luong' + STR(dbo.F4('VT05', 2010, 5))
PRINT 'So luong' + STR(dbo.F4('VT05', 2010, NULL))


SELECT *
FROM VATTU vt, HOADON hd, CTHD ct
WHERE vt.MAVT = ct.MAVT AND hd.MAHD = ct.MAHD
--5.Viết hàm tính lãi (giá bán – giá mua) * số lượng bán được cho từng mặt hàng,
--với mã mặt hàng là tham số truyền vào. Nếu mã mặt hàng không truyền vào thì tính cho tất cả các mặt hàng.

-- CAU TRUC IF
CREATE FUNCTION F5 (@MAVT VARCHAR(5))
RETURNS INT
AS
BEGIN
	DECLARE @LAI INT
	IF @MAVT IS NULL
		BEGIN
		SET @LAI =
			(SELECT SUM((ct.GIABAN - vt.GIAMUA) * ct.SL)
			FROM VATTU vt, CTHD ct
			WHERE vt.MAVT = ct.MAVT)
		END
	ELSE
		BEGIN
		SET @LAI =
			(SELECT SUM((ct.GIABAN - vt.GIAMUA) * ct.SL)
			FROM VATTU vt, CTHD ct
			WHERE vt.MAVT = ct.MAVT AND vt.MAVT = @MAVT)
		END
	RETURN @LAI
END
PRINT 'Lai ' + STR(dbo.F5('VT01'))
PRINT 'Lai ' + STR(dbo.F5(NULL))

-- HAM IIF
CREATE FUNCTION F5_VER2 (@MAVT VARCHAR(5))
RETURNS INT
AS
BEGIN
	DECLARE @LAI INT
	SET @LAI =
	IIF(@MAVT IS NULL,
			(SELECT SUM((ct.GIABAN - vt.GIAMUA) * ct.SL)
				FROM VATTU vt, CTHD ct
				WHERE vt.MAVT = ct.MAVT),

			(SELECT SUM((ct.GIABAN - vt.GIAMUA) * ct.SL)
				FROM VATTU vt, CTHD ct
				WHERE vt.MAVT = ct.MAVT AND vt.MAVT = @MAVT))
	RETURN @LAI
END
PRINT 'Lai ' + STR(dbo.F5_VER2('VT01'))
PRINT 'Lai ' + STR(dbo.F5_VER2(NULL))

-- CASE WHEN
CREATE FUNCTION F5_VER3 (@MAVT VARCHAR(5))
RETURNS INT
AS
BEGIN
	DECLARE @LAI INT
	SET @LAI =
		CASE
			WHEN @MAVT IS NULL THEN
				(SELECT SUM((ct.GIABAN - vt.GIAMUA) * ct.SL)
					FROM VATTU vt, CTHD ct
					WHERE vt.MAVT = ct.MAVT)
			ELSE
				(SELECT SUM((ct.GIABAN - vt.GIAMUA) * ct.SL)
					FROM VATTU vt, CTHD ct
					WHERE vt.MAVT = ct.MAVT AND vt.MAVT = @MAVT)
		END
	RETURN @LAI
END
PRINT 'Lai ' + STR(dbo.F5_VER3('VT01'))
PRINT 'Lai ' + STR(dbo.F5_VER3(NULL))