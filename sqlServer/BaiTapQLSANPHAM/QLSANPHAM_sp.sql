USE QLSANPHAM;
GO
SET DATEFORMAT dmy;
GO

--1.Liệt kê DS khách hàng (TênKH, DC) có đặt hàng vào Ngày tháng năm X.
CREATE PROC P01 (@date DATE)
AS
    SELECT *
    FROM KHACHHANG kh, DONDH dh
    WHERE kh.MaKH = dh.MaKH
        AND dh.NgayDat = @date
EXEC P01 @date='15/03/2010'
--2.Liệt kê DS khách hàng (TênKH, DC) có đặt hàng sản phẩm có mã số X.
CREATE PROC P02 (@maso CHAR(5))
AS
    SELECT kh.TenKH, kh.DC
    FROM KHACHHANG kh, DONDH dh, CTDDH ct
    WHERE kh.MaKH = dh.MaKH AND dh.SoDDH = ct.SoDDH
        AND ct.MaSP = @maso
EXEC P02 @maso='SP02'
--3.Liệt kê DS khách hàng (TênKH, DC) có đặt hàng với tổng số tiền trên X (1 đơn).
CREATE PROC P03 @sotien INT
AS
    SELECT kh.TenKH, kh.DC, dh.SoDDH, SUM(ct.SoLuong * sp.Gia) AS [Tong Gia Tien Theo Don Hang]
    FROM KHACHHANG kh, DONDH dh, CTDDH ct, SANPHAM sp
    WHERE kh.MaKH = dh.MaKH AND dh.SoDDH = ct.SoDDH AND ct.MaSP = sp.MaSP
    GROUP BY dh.SoDDH, kh.TenKH, kh.DC
    HAVING SUM(ct.SoLuong * sp.Gia) > @sotien
EXEC P03 @sotien = 3000000
--4.Liệt kê DS khách hàng (TênKH, DC) có đặt hàng với tổng số tiền trên X (tất cả).
CREATE PROC P04 @sotien INT
AS
    SELECT kh.MaKH,kh.TenKH, kh.DC, SUM(ct.SoLuong * sp.Gia) AS [Tong Gia Tien Theo Toan Bo Don Hang]
    FROM KHACHHANG kh, DONDH dh, CTDDH ct, SANPHAM sp
    WHERE kh.MaKH = dh.MaKH AND dh.SoDDH = ct.SoDDH AND ct.MaSP = sp.MaSP
    GROUP BY kh.MaKH, kh.TenKH, kh.DC
    HAVING SUM(ct.SoLuong * sp.Gia) > @sotien
EXEC P04 @sotien = 3000000
--5.Liệt kê DS sản phẩm (TênSP, Giá thành SX, Giá) bán lãi trên X.
SELECT sp.MaSP, sp.Gia, nl.GIA AS [Gia Nguyen Lieu], l.SoLuong, SUM(l.SoLuong * nl.GIA) AS [Gia SX]
FROM SANPHAM sp, LAM l, NGUYENLIEU nl
WHERE sp.MaSP = l.MaSP AND l.MaNL = nl.MaNL
GROUP BY sp.MaSP, sp.Gia, nl.GIA, l.SoLuong
--6.Liệt kê DS khách hàng (TênKH, DC) đã trên X ngày rồi chưa đặt hàng.
CREATE PROC P06 (@ngay INT)
AS
    SELECT kh.MaKH, kh.TenKH, kh.DC
    FROM KHACHHANG kh LEFT JOIN DONDH dh
    ON kh.MaKH = dh.MaKH
    WHERE DATEDIFF(DAY, dh.NgayDat, GETDATE()) > @ngay
        OR DATEDIFF(DAY, dh.NgayDat, GETDATE()) IS NULL
    GROUP BY kh.MaKH, kh.TenKH, kh.DC
EXEC P06 @ngay=4457
--7.Liệt kê DS sản phẩm (TênSP, Số đơn) có tổng số đơn đặt hàng trên X.
ALTER PROC P07 (@x INT)
AS
    SELECT sp.TenSP, COUNT(SoDDH) AS [So DDH]
    FROM CTDDH ct, SANPHAM sp
    WHERE ct.MaSP = sp.MaSP
    GROUP BY sp.MaSP, sp.TenSP
    HAVING COUNT(SoDDH) > @x
EXEC P07 @x=2
--8.Liệt kê DS sản phẩm (TênSP, Tổng SL) có tổng số lượng đặt hàng trên X.
CREATE PROC P08 (@x INT)
AS
    SELECT sp.TenSP, SUM(ct.SoLuong) AS [Tong So Luong]
    FROM CTDDH ct, SANPHAM sp
    WHERE ct.MaSP = sp.MaSP
    GROUP BY sp.MaSP, sp.TenSP
    HAVING SUM(ct.SoLuong) > @x
EXEC P08 @x=0
--9.Liệt kê DS sản phẩm (TênSP, Tổng số tiền) có tổng số tiền đặt hàng trên X.
CREATE PROCEDURE P09 (@x INT)
AS
    SELECT sp.TenSP, SUM(ct.SoLuong * sp.Gia) AS [Tong So Tien]
    FROM CTDDH ct, SANPHAM sp
    WHERE ct.MaSP = sp.MaSP
    GROUP BY sp.MaSP, sp.TenSP
    HAVING SUM(ct.SoLuong * sp.Gia) > @x
EXEC P09 @x=10000000