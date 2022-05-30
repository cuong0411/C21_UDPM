USE QLSANPHAM;
GO
SET DATEFORMAT dmy;
GO
-- TAO VIEW
-- 1.Danh sách các loại sản phẩm có nhiều sản phẩm nhất (Tên loại SP, số sản phẩm).
ALTER VIEW V01
AS
    SELECT TOP(1) WITH TIES lsp.MaLoai, COUNT(sp.MaSP) AS [So Luong SP]
    FROM LOAISP lsp, SANPHAM sp
    WHERE lsp.MaLoai = sp.MaLoai
    GROUP BY lsp.MaLoai
    ORDER BY [So Luong SP] DESC
SELECT * FROM dbo.V01
-- 2.Danh sách khách hàng không đặt hàng trong tháng 3/2010 (Tên KH, địa chỉ).
ALTER VIEW V02
AS
    SELECT TenKH, DC, NgayDat
    FROM KHACHHANG kh, DONDH dh
    WHERE kh.MaKH = dh.MaKH
    AND NOT (YEAR(NgayDat) = 2010 AND MONTH(NgayDat) = 3)
SELECT * FROM dbo.DONDH
SELECT * FROM dbo.V02
-- 3.DS khách hàng đặt nhiều đơn đặt hàng nhất trong tháng 3/2010 (Tên KH, địa chỉ).
ALTER VIEW V03
AS
    SELECT TOP(1) WITH TIES TenKH, DC, COUNT(dh.SoDDH) AS [So Luong DDH]
    FROM KHACHHANG kh
    INNER JOIN DONDH dh
    ON kh.MaKH = dh.MaKH
    WHERE YEAR(NgayDat) = 2010 AND MONTH(NgayDat) = 3
    GROUP BY kh.MaKH, TenKH, DC
    ORDER BY [So Luong DDH] DESC
SELECT * FROM V03
-- 4.Danh sách các sản phẩm không được đặt trong tháng 3/2010 (Tên SP, mô tả).
CREATE VIEW V04
AS
    SELECT TenSP, MoTa
    FROM SANPHAM
    WHERE MaSP IN (
        SELECT sp.MaSP
        FROM SANPHAM sp, CTDDH ct, DONDH dh
        WHERE sp.MaSP = ct.MaSP AND dh.SoDDH = ct.SoDDH
            AND NOT (YEAR(NgayDat) = 2010 AND MONTH(NgayDat) = 3) -- khong tinh sp khong duoc mua
    )
SELECT * FROM V04
-- 5.Danh sách khách hàng có đặt trên 10 cái tủ DDA (Tên KH, địa chỉ, tổng số lượng).
CREATE VIEW V05
AS
    SELECT kh.TenKH, kh.DC, SUM(ct.SoLuong) AS [Tong SL]
    FROM KHACHHANG kh, DONDH dh, CTDDH ct, SANPHAM sp
    WHERE kh.MaKH = dh.MaKH AND dh.SoDDH = ct.SoDDH AND ct.MaSP = sp.MaSP
        AND sp.TenSP = N'Tủ DDA'
    GROUP BY kh.MaKH, kh.TenKH, kh.DC
    HAVING SUM(ct.SoLuong) > 1
SELECT * FROM V05
-- 6.DS các sản phẩm được làm từ nhiều loại nguyên liệu nhất (Tên SP, Giá, Số loại).
ALTER VIEW V06
AS
    SELECT TOP(2) sp.MaSP, sp.TenSP, sp.Gia, COUNT(LAM.MaNL) AS [Tong So Loai NL]
    FROM LAM, SANPHAM sp
    WHERE LAM.MaSP = sp.MaSP
    GROUP BY sp.MaSP, sp.TenSP, sp.Gia
    ORDER BY [Tong So Loai NL] DESC
SELECT * FROM V06

-- 7.Danh sách các sản phẩm có giá thành SX hơn 1 triệu (Tên SP, Giá thành SX).
CREATE VIEW V07
AS
    SELECT sp.MaSP, SUM(l.SoLuong * nl.GIA) AS [Gia thanh NL]
    FROM SANPHAM sp, LAM l, NGUYENLIEU nl
    WHERE sp.MaSP = l.MaSP AND l.MaNL = nl.MaNL
    GROUP BY sp.MaSP
    HAVING SUM(l.SoLuong * nl.GIA) > 1000000
SELECT * FROM V07
SELECT * FROM SANPHAM
SELECT * FROM LAM
-- 8.DS các sản phẩm có lãi trên 20% (Tên SP, Giá thành SX, Giá bán, phần trăm lãi).
SELECT sp.MaSP,sp.Gia AS [Gia Ban],
    SUM(l.SoLuong * nl.GIA) AS [Gia thanh NL],
    (sp.GIA - SUM(l.SoLuong * nl.GIA)) AS [Lai]
FROM SANPHAM sp, LAM l, NGUYENLIEU nl
WHERE sp.MaSP = l.MaSP AND l.MaNL = nl.MaNL
GROUP BY sp.MaSP, sp.Gia
-- 9.Danh sách đơn đặt hàng có tổng số tiền lớn hơn 100 triệu (Số DDH, Ngày đặt, Tổng tiền).
CREATE VIEW V09
AS
    SELECT dh.SoDDH, dh.NgayDat, SUM(ct.SoLuong * sp.Gia) AS [Tong so tien]
    FROM DONDH dh, CTDDH ct, SANPHAM sp
    WHERE dh.SoDDH = ct.SoDDH AND ct.MaSP = sp.MaSP
    GROUP BY dh.SoDDH, dh.NgayDat
    HAVING SUM(ct.SoLuong * sp.Gia) > 100000000
SELECT * FROM V09
-- 10.Danh sách các loại nguyên liệu dùng để làm tất cả các sản phẩm (TênNL, Giá).
CREATE VIEW V10
AS
    SELECT MaNL, COUNT(MaSP) AS [So luong SP]
    FROM LAM
    GROUP BY MaNL
    HAVING COUNT(MaSP) = (SELECT COUNT(MaSP) FROM SANPHAM)
SELECT * FROM V10
-- 11.Danh sách khách hàng có đặt tất cả các sản phẩm (Tên KH, DC).
SELECT * FROM SANPHAM
SELECT * FROM DONDH
-- KH1 mua toan bo SP
INSERT INTO DONDH
VALUES ('DH007', '15/03/2010', 'KH001')
INSERT INTO CTDDH
VALUES
    ('DH007', 'SP02', 5),
    ('DH007', 'SP04', 1),
    ('DH007', 'SP05', 2)
ALTER VIEW V11
AS
    SELECT kh.MaKH, kh.TenKH, kh.DC, COUNT(DISTINCT ct.MaSP) AS [So luong SP]
    FROM DONDH dh, CTDDH ct, KHACHHANG kh
    WHERE dh.SoDDH = ct.SoDDH AND dh.MaKH = kh.MaKH
    GROUP BY kh.MaKH, kh.TenKH, kh.DC
    HAVING COUNT(DISTINCT ct.MaSP) = (SELECT COUNT(MaSP) FROM SANPHAM)
SELECT * FROM V11
-- 12.Danh sách các sản phẩm tất cả các khách hàng đều đặt (Tên SP, Mô tả).
SELECT sp.MaSP, COUNT(dh.MaKH) AS [So Lan KH DAT], COUNT(DISTINCT dh.MaKH) AS [So KH khong trung]
FROM DONDH dh, CTDDH ct, SANPHAM sp
WHERE dh.SoDDH = ct.SoDDH AND ct.MaSP = sp.MaSP
GROUP BY sp.MaSP
HAVING COUNT(DISTINCT dh.MaKH) = (SELECT COUNT(MaKH) AS [SL KH] FROM KHACHHANG)
-- 13.Danh sách khách hàng lâu nhất chưa đặt hàng (Tên KH, địa chỉ).

SELECT TOP(1) WITH TIES *, (DATEDIFF(DAY, dh.NgayDat, GETDATE())) AS [Number of Days]
FROM KHACHHANG kh, DONDH dh
WHERE kh.MaKH = dh.MaKH
ORDER BY (DATEDIFF(DAY, dh.NgayDat, GETDATE())) DESC

SELECT DATEDIFF(DAY, '15/03/2010', '17/04/2010') AS DATEDIFF