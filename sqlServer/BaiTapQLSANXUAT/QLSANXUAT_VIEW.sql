USE QLSANXUAT;
GO
SET DATEFORMAT dmy;
GO
-- 1.Cho biết mã sản phẩm, tên sản phẩm, tổng số lượng xuất của từng sản phẩm trong năm 2010.
-- Lấy dữ liệu từ View này sắp xếp tăng dần theo tên sản phẩm.
CREATE VIEW C01
AS
	SELECT sp.MaSP, sp.TenSP, SUM(ct.SoLuong) AS [Tong so luong nam 2010]
	FROM SANPHAM sp, CTPX ct, PHIEUXUAT px
	WHERE sp.MaSP = ct.MaSP AND px.MaPX = ct.MaPX
		AND YEAR(px.NgayLap) = 2010
	GROUP BY sp.MaSP, sp.TenSP
SELECT * FROM dbo.C01 ORDER BY TenSP
-- 2.Cho biết mã sản phẩm, tên sản phẩm, tên loại sản phẩm mà đã được bán từ ngày 1/1/2010 đến 30/6/2010.
CREATE VIEW C02
AS
SELECT sp.MaSP, sp.TenSP, l.TenLoai
	FROM SANPHAM sp, CTPX ct, PHIEUXUAT px, LOAI l
	WHERE sp.MaSP = ct.MaSP AND px.MaPX = ct.MaPX AND sp.MaLoai = l.MaLoai
		AND px.NgayLap BETWEEN '1/1/2010' AND '30/6/2010'
SELECT * FROM dbo.C02
-- 3.Cho biết số lượng sản phẩm trong từng loại sản phẩm gồm các thông tin:
-- mã loại sản phẩm, tên loại sản phẩm, số lượng các sản phẩm.
CREATE VIEW C03
AS
	SELECT l.MaLoai, l.TenLoai, SUM(ct.SoLuong) AS [So luong sp]
	FROM LOAI l, SANPHAM sp, CTPX ct
	WHERE l.MaLoai = sp.MaLoai AND sp.MaSP = ct.MaSP
	GROUP BY l.MaLoai, l.TenLoai
SELECT * FROM dbo.C03
-- 4.Cho biết tổng số lượng phiếu xuất trong tháng 6 năm 2010.
CREATE VIEW C04
AS
	SELECT SUM(ct.SoLuong) [Tong so luong px trong thang 6]
	FROM PHIEUXUAT px, CTPX ct
	WHERE px.MaPX = ct.MaPX
		AND MONTH(px.NgayLap) = 6
SELECT * FROM dbo.C04
-- 5.Cho biết thông tin về các phiếu xuất mà nhân viên có mã NV01 đã xuất.
ALTER VIEW C05
AS
	SELECT px.MaPX, px.MaNV, px.NgayLap, ct.MaSP, ct.SoLuong
	FROM PHIEUXUAT px, CTPX ct
	WHERE PX.MaPX = CT.MaPX
		AND px.MaNV = N'NV01'
SELECT * FROM dbo.C05
-- 6.Cho biết danh sách nhân viên nam có tuổi trên 25 nhưng dưới 30.
CREATE VIEW C06
AS
	SELECT *
	FROM NHANVIEN p
	WHERE p.Phai = 1 AND ((YEAR(GETDATE()) - YEAR(p.NgaySinh)) BETWEEN 26 AND 42)
SELECT * FROM dbo.C06
-- 7.Thống kê số lượng phiếu xuất theo từng nhân viên.
CREATE VIEW C07
AS
	SELECT nv.MaNV, COUNT(px.MaPX) AS [So luong px]
	FROM NHANVIEN nv, PHIEUXUAT px
	WHERE nv.MaNV = px.MaNV
	GROUP BY nv.MaNV
SELECT * FROM dbo.C07
-- 8.Thống kê số lượng sản phẩm đã xuất theo từng sản phẩm.
CREATE VIEW C08
AS
	SELECT sp.MaSP, sp.TenSP, SUM(ct.SoLuong) AS[So luong da xuat]
	FROM SANPHAM sp, CTPX ct
	WHERE sp.MaSP = ct.MaSP
	GROUP BY sp.MaSP, sp.TenSP
SELECT * FROM dbo.C08
-- 9.Lấy ra tên của nhân viên có số lượng phiếu xuất lớn nhất.
CREATE VIEW C09
AS
	SELECT nv.HoTen
	FROM NHANVIEN nv
	WHERE nv.MaNV = (
		SELECT TOP(1) MaNV FROM dbo.C07
		ORDER BY [So luong px] DESC
		)
SELECT * FROM dbo.C09
-- 10.Lấy ra tên sản phẩm được xuất nhiều nhất trong năm 2010.
CREATE VIEW C10
AS
	SELECT TOP(1) sp.TenSP
	FROM SANPHAM sp, CTPX ct, PHIEUXUAT px
	WHERE sp.MaSP = ct.MaSP AND ct.MaPX = px.MaPX
		AND YEAR(px.NgayLap) = 2010
	GROUP BY sp.MaSP, sp.TenSP
	ORDER BY SUM(ct.SoLuong) DESC
SELECT * FROM dbo.C10