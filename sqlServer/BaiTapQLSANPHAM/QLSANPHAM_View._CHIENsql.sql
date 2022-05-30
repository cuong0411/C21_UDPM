﻿USE master
go
IF Exists(SELECT name FROM sys.databases WHERE name ='QLSP')
DROP DATABASE QLSP
CREATE DATABASE QLSP
ON (NAME='SANPHAM_DATA',FILENAME='D:\c21_udpm\SQLNANGCAO\SANPHAM.MDF')
LOG ON (NAME='SANPHAM_LOG',FILENAME='D:\c21_udpm\SQLNANGCAO\SANPHAM.LDF')
USE QLSP

--TABLE 
CREATE TABLE LOAISP
(
	MaLoai varchar(4) NOT NULL,
	TenLoai Nvarchar(50) NOT NULL,
	Primary Key (MaLoai),
)
GO
CREATE TABLE SANPHAM
(
	MASP varchar(5) UNIQUE,
	TenSP nvarchar(70) NOT NULL,
	MoTa nvarchar(100) NOT NULL,
	Gia int NOT NULL,
	MaLoai varchar(4),
	Primary Key (MASP),
	Constraint PK_MALOAI FOREIGN KEY (MaLoai) REFERENCES LOAISP(MaLoai)
)
GO
CREATE TABLE KHACHHANG
(
	MaKH varchar(6) NOT NULL,
	TenKH nvarchar(50) NOT NULL,
	DC nvarchar(70) NOT NULL,
	DT varchar(13) NOT NULL,
	Primary Key (MaKH),
)
GO
CREATE TABLE DONDH
(
	SoDDH varchar(6) UNIQUE,
	NgayDat date NOT NULL,
	MaKH varchar(6) NOT NULL,
	Constraint PK_MAKH FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH),
	Primary Key (SoDDH)
)
GO
CREATE TABLE CTDDH
(
	SoDDH varchar(6),
	MASP varchar(5),
	SoLuong INT,
	Constraint PK_DONDH FOREIGN KEY (SoDDH) REFERENCES DONDH(SoDDH),
	Constraint PK_MAKH2 FOREIGN KEY (MaSP) REFERENCES SANPHAM(MaSP),
	Primary Key (SoDDH,MaSP)
)
GO
CREATE TABLE NGUYENLIEU
(
	MaNL varchar(5) NOT NULL,
	TenNL nvarchar(50) NOT NULL,
	DVT varchar(4) NOT NULL,
	Gia int,
	Primary Key (MaNL)
)
GO
CREATE TABLE LAM
(
	MaNL varchar(5),
	MASP varchar(5),
	SoLuong float,
	Constraint PK_LAM1 FOREIGN KEY (MaSP) REFERENCES SANPHAM(MaSP),
	Constraint PK_LAM2 FOREIGN KEY (MaNL) REFERENCES NGUYENLIEU(MaNL),
	Primary Key (MaNL,MaSP)
)
-- INSERT DU LIEU
GO 
INSERT INTO LOAISP(MaLoai,TenLoai) VALUES
('L01',N'Tủ'),
('L02',N'Bàn'),
('L03',N'Giường')
GO
INSERT INTO SANPHAM(MaSP,TenSP,MoTa,Gia,MaLoai) VALUES
('SP01',N'Tủ trang điểm',N'Cao 1.4m, rộng 2.2m','1000000','L01'),
('SP02',N'Giường đơn Cali',N'Rộng 1.4m','1500000','L03'),
('SP03',N'Tủ DDA',N'Cao 1.6m rộng 2.0m,cửa kiếng','800000','L01'),
('SP04',N'Bàn ăn',N'1m x 1.5m','650000','L02'),
('SP05',N'Bàn uống trà',N'Tròn,1.8m','1100000','L02')
GO
INSERT INTO KHACHHANG(MAKH,TenKH,DC,DT) VALUES
('KH001',N'Trần Hải Cường',N'731 Trần Hưng Đạo, Q.1,TP.HCM','08-9776655'),
('KH002',N'Nguyễn Thị Bé',N'638 Nguyễn Văn Cừ, Q.5,TP.HCM','0913-666123'),
('KH003',N'Trần Thị Minh Hòa',N'543 Mai Thị Lựu, Ba Đình, Hà Nội','04-9238777'),
('KH004',N'Phạm Đình Tuân',N'975 Lê Lai, P.3, TP. Vũng Tàu','064-543678'),
('KH005',N'Lê Xuân Nguyện',N'450 Trưng Vương, TP. Mỹ Tho,Tiền Giang','073-987123'),
('KH006',N'Văn Hùng Dũng',N'291 Hồ Văn Huê, Q. PN, TP.HCM','08-8222111'),
('KH012',N'Lê Thị Hương Hoa',N'980 Lê Hồng Phong, TP. Vũng Tàu','064-452100'),
('KH016',N'Hà Minh Trí',N'332 Nguyễn Thái Học, TP. Quy Nhơn','056-565656')
GO
SET DATEFORMAT dmy;
INSERT INTO DONDH(SoDDH,NgayDat,MAKH) VALUES
('DH001',N'15/03/2010','KH001'),
('DH002',N'15/03/2010','KH016'),
('DH003',N'16/03/2010','KH003'),
('DH004',N'16/03/2010','KH012'),
('DH005',N'17/03/2010','KH001'),
('DH006',N'01/04/2010','KH002'),
('DH009',N'05/9/2022','KH016')
GO
INSERT INTO CTDDH VALUES
('DH001','SP01','5'),
('DH001','SP03','1'),
('DH002','SP02','2'),
('DH003','SP01','2'),
('DH003','SP04','10'),
('DH003','SP05','5'),
('DH004','SP02','2'),
('DH004','SP05','2'),
('DH005','SP03','3'),
('DH006','SP02','4'),
('DH006','SP04','3'),
('DH006','SP05','6'),
('DH009','SP03','20')
GO
INSERT INTO NGUYENLIEU(MaNL,TenNL,DVT,Gia) VALUES
('NL01',N'Gỗ Lim XP','m3','1200000'),
('NL02',N'Gỗ Sao NT','m3','1000000'),
('NL03',N'Gỗ tạp nham','m3','500000'),
('NL04',N'Đinh lớn','kg','40000'),
('NL05',N'Đinh nhỏ','kg','30000'),
('NL06',N'Kiếng','m2','350000')
GO
INSERT INTO LAM VALUES
('NL01','SP01',1.2),
('NL03','SP01',0.3),
('NL06','SP01',2.5),
('NL02','SP02',1.1),
('NL04','SP02',2.2),
('NL02','SP03',0.9),
('NL05','SP03',2.1),
('NL02','SP04',1.3),
('NL04','SP04',1.7),
('NL03','SP05',0.8),
('NL05','SP05',0.5),
('NL06','SP05',2.4)

-- VIEW
--1.Danh sách các loại sản phẩm có nhiều sản phẩm nhất (Tên loại SP, số sản phẩm).
	Go
	CREATE VIEW V1 AS
	SELECT TOP(1) WITH TIES TenLoai,COUNT(MASP) as [Số Sản Phẩm] FROM SANPHAM s,LOAISP l
	WHERE s.MaLoai=l.MaLoai GROUP BY TenLoai ORDER BY COUNT(MASP) DESC 
	Go
--2.Danh sách khách hàng không đặt hàng trong tháng 3/2010 (Tên KH, địa chỉ).
	CREATE VIEW V2 AS
	SELECT TenKH,DC FROM DONDH d,KHACHHANG k WHERE d.MaKH=K.MaKH AND NOT (MONTH(NgayDat)=3 AND YEAR(NgayDat)=2010)
	Go
	SELECT * FROM V2
	Go
--3.DS khách hàng đặt nhiều đơn đặt hàng nhất trong tháng 3/2010 (Tên KH, địa chỉ).
	CREATE VIEW V3 AS
	SELECT TOP(1) WITH TIES TenKH,DC,COUNT(d.MaKH) AS [Số Đơn Đặt Hàng] FROM DONDH d,KHACHHANG k WHERE d.MaKH=K.MaKH 
	AND MONTH(NgayDat)=3 AND YEAR(NgayDat)=2010 GROUP BY TenKH,DC
	ORDER BY COUNT(d.MaKH) DESC 
	Go
--4.Danh sách các sản phẩm không được đặt trong tháng 3/2010 (Tên SP, mô tả).
	CREATE VIEW V4 AS
	SELECT TenSP,MoTa FROM DONDH d,SANPHAM s,CTDDH ct WHERE s.MASP=ct.MASP AND d.SoDDH=ct.SoDDH
	AND NOT MONTH(NgayDat)=3 AND YEAR(NgayDat)=2010
	Go
--5.Danh sách khách hàng có đặt trên 10 cái tủ DDA (Tên KH, địa chỉ, tổng số lượng).
	CREATE VIEW V5 AS
	SELECT TenKH,DC,SUM(SoLuong) AS [Số Lượng Đặt] FROM KHACHHANG k,DONDH d,CTDDH ct,SANPHAM s 
	WHERE k.MaKH=d.MaKH AND ct.SoDDH=d.SoDDH AND s.MASP=ct.MASP
	AND TenSP=N'Tủ DDA' AND SoLuong > 10 GROUP BY TenKH,DC
	GO

--6.DS các sản phẩm được làm từ nhiều loại nguyên liệu nhất (Tên SP, Giá, Số loại).
	CREATE VIEW V6 AS
	SELECT TOP(1) WITH TIES TenSP,Gia, COUNT(MaNL) AS [Số Nguyên Liệu]  FROM SANPHAM s,LAM l 
	WHERE s.MASP=l.MASP GROUP BY TenSP,Gia ORDER BY COUNT(MaNL) DESC
	SELECT * FROM V6
--7.Danh sách các sản phẩm có giá thành SX hơn 1 triệu (Tên SP, Giá thành SX).
	CREATE VIEW V7 AS
	SELECT TenSP,SUM(n.Gia) AS [Giá Thành SX] FROM SANPHAM s,NGUYENLIEU n,LAM l WHERE s.MASP=l.MASP AND n.MaNL=l.MaNL 
	GROUP BY TenSP
	HAVING SUM(n.Gia)>1000000 
	SELECT * FROM V7
--8.DS các sản phẩm có lãi trên 20% (Tên SP, Giá thành SX, Giá bán, phần trăm lãi).
	CREATE VIEW V8 AS
	SELECT s.TenSP,v7.[Giá Thành SX],s.Gia,((((Sum(ct.SoLuong)*s.Gia)-v7.[Giá Thành SX]))/(Sum(SoLuong)*s.Gia))*100 as [Phần Trăm Lãi] 
	FROM SANPHAM s,CTDDH ct,NGUYENLIEU n,V7
	WHERE s.MASP=ct.MASP AND v7.TenSP=s.TenSP
	GROUP BY s.TenSP,s.Gia,v7.[Giá Thành SX]
	HAVING ((((Sum(SoLuong)*s.Gia)-v7.[Giá Thành SX]))/(Sum(SoLuong)*s.Gia))*100 >20
--9.Danh sách đơn đặt hàng có tổng số tiền lớn hơn 100 triệu (Số DDH, Ngày đặt, Tổng tiền).
	SELECT d.SoDDH,NgayDat,SUM(ct.SoLuong*s.Gia) AS [Tổng Tiền] FROM DONDH d, CTDDH ct,SANPHAM s
	WHERE d.SoDDH=ct.SoDDH AND s.MASP=ct.MASP
	GROUP BY d.SoDDH,NgayDat

--10.Danh sách các loại nguyên liệu dùng để làm tất cả các sản phẩm (TênNL, Giá).
--11.Danh sách khách hàng có đặt tất cả các sản phẩm (Tên KH, DC).
--12.Danh sách các sản phẩm tất cả các khách hàng đều đặt (Tên SP, Mô tả).
--13.Danh sách khách hàng lâu nhất chưa đặt hàng (Tên KH, địa chỉ).
SELECT * FROM SANPHAM,NGUYENLIEU,CTDDH,