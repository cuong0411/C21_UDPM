USE master;
GO
DROP DATABASE IF EXISTS QLSANPHAM;
GO
CREATE DATABASE QLSANPHAM;
GO
USE QLSANPHAM;
GO
SET DATEFORMAT dmy;
GO

-- TAO TABLE
CREATE TABLE LOAISP (
    MaLoai CHAR(5) NOT NULL,
    TenLoai NVARCHAR(20) NOT NULL
)
CREATE TABLE SANPHAM (
    MaSP CHAR(5) NOT NULL,
    TenSP NVARCHAR(30) NOT NULL,
    MoTa NVARCHAR(40),
    Gia INT,
    MaLoai CHAR(5) NOT NULL
)
CREATE TABLE KHACHHANG (
    MaKH CHAR(5) NOT NULL,
    TenKH NVARCHAR(20) NOT NULL,
    DC NVARCHAR(50),
    DT VARCHAR(12)
)
CREATE TABLE DONDH (
    SoDDH CHAR(5) NOT NULL,
    NgayDat DATE,
    MaKH CHAR(5) NOT NULL
)
CREATE TABLE CTDDH (
    SoDDH CHAR(5) NOT NULL,
    MaSP CHAR(5) NOT NULL,
    SoLuong INT
)
CREATE TABLE NGUYENLIEU (
    MaNL CHAR(5) NOT NULL,
    TenNL NVARCHAR(20),
    DVT NVARCHAR(5),
    GIA INT
)
CREATE TABLE LAM (
    MaNL CHAR(5) NOT NULL,
    MaSP CHAR(5) NOT NULL,
    SoLuong FLOAT
)
GO

-- TAO CONSTRAINT PRIMARY KEY, FOREIGN KEY GIUA CAC TABLE
ALTER TABLE LOAISP ADD
    CONSTRAINT PK_MaLoai PRIMARY KEY (MaLoai)
ALTER TABLE SANPHAM ADD
    CONSTRAINT PK_MaSP PRIMARY KEY (MaSP),
    CONSTRAINT FK_MaLoai FOREIGN KEY (MaLoai) REFERENCES LOAISP(MaLoai)
ALTER TABLE KHACHHANG ADD
    CONSTRAINT PK_MaKH PRIMARY KEY (MaKH)
ALTER TABLE DONDH ADD
    CONSTRAINT PK_SoDDH PRIMARY KEY (SoDDH),
    CONSTRAINT FK_MaKH FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH)
ALTER TABLE CTDDH ADD
    CONSTRAINT PK_SoDDH_MaSP PRIMARY KEY (SoDDH, MaSP),
    CONSTRAINT FK_SoDDH FOREIGN KEY (SoDDH) REFERENCES DONDH(SoDDH),
    CONSTRAINT FK_MaSP FOREIGN KEY (MaSP) REFERENCES SANPHAM(MaSP)
ALTER TABLE NGUYENLIEU ADD
    CONSTRAINT PK_MaNL PRIMARY KEY (MaNL)
ALTER TABLE LAM ADD
    CONSTRAINT PK_MaNL_MaSP PRIMARY KEY (MaNL, MaSP),
    CONSTRAINT FK_MaSP_LOAI FOREIGN KEY (MaSP) REFERENCES SANPHAM(MaSP),
    CONSTRAINT FK_MaNL FOREIGN KEY (MaNL) REFERENCES NGUYENLIEU(MaNL)
GO
-- INSERT
INSERT INTO LOAISP
VALUES
    ('L01', N'Tủ'),
    ('L02', N'Bàn'),
    ('L03', N'Giường')
INSERT INTO SANPHAM
VALUES
    ('SP01', N'Tủ trang điểm', N'Cao 1.4m, rộng 2.2m', 1000000, 'L01'),
    ('SP02', N'Giường đơn Cali', N'Rộng 1.4m', 1500000, 'L03'),
    ('SP03', N'Tủ DDA', N'Cao 1.6m, rộng 2.0m, cửa kiếng', 800000, 'L01'),
    ('SP04', N'Bàn ăn', N'1m x 1.5m', 6500000, 'L02'),
    ('SP05', N'Bàn uống trà', N'Tròn, 1.8m', 1100000, 'L02')
INSERT INTO KHACHHANG
VALUES
    ('KH001', N'Trần Hải Cường', N'731 Trần Hưng Đạo, Q.1, TP.HCM', '08-9776655'),
    ('KH002', N'Nguyễn Thị Bé', N'638 Nguyễn Văn Cừ, Q.5, TP.HCM', '0913-666123'),
    ('KH003', N'Trần Thị Minh Hoà', N'543 Mai Thị Lựu, Ba Đình, Hà Nội', '04-9238777'),
    ('KH004', N'Phạm Đình Tuân', N'975 Lê Lai, P.3, TP. Vũng Tàu', '064-543678'),
    ('KH005', N'Lê Xuân Nguyện', N'450 Trưng Vương, TP. Mỹ Tho, Tiền Giang', '073-987123'),
    ('KH006', N'Văn Hùng Dũng', N'291 Hồ Văn Huê, Q.PN, TP.HCM', '08-8222111'),
    ('KH012', N'Lê Thị Hương Hoa', N'980 Lê Hồng Phong, TP. Vũng Tàu', '064-452100'),
    ('KH016', N'Hà Minh Trí', N'322 Nguyễn Thái Học, TP. Quy Nhơn', '056-565656')
INSERT INTO DONDH
VALUES
    ('DH001', '15/03/2010', 'KH001'),
    ('DH002', '15/03/2010', 'KH016'),
    ('DH003', '16/03/2010', 'KH003'),
    ('DH004', '16/03/2010', 'KH012'),
    ('DH005', '17/03/2010', 'KH001'),
    ('DH006', '01/04/2010', 'KH002')
INSERT INTO CTDDH
VALUES
    ('DH001', 'SP01', 5),
    ('DH001', 'SP03', 1),
    ('DH002', 'SP02', 2),
    ('DH003', 'SP01', 2),
    ('DH003', 'SP04', 10),
    ('DH003', 'SP05', 5),
    ('DH004', 'SP02', 2),
    ('DH004', 'SP05', 2),
    ('DH005', 'SP03', 3),
    ('DH006', 'SP02', 4),
    ('DH006', 'SP04', 3),
    ('DH006', 'SP05', 6)
INSERT INTO NGUYENLIEU
VALUES
    ('NL01', N'Gỗ Lim XP', N'm3', 1200000),
    ('NL02', N'Gỗ Sao NT', N'm3', 1000000),
    ('NL03', N'Gỗ tạp nham', N'm3', 500000),
    ('NL04', N'Đinh lớn', N'kg', 40000),
    ('NL05', N'Đinh nhỏ', N'kg', 30000),
    ('NL06', N'Kiếng', N'm2', 350000)
INSERT INTO LAM
VALUES
    ('NL01', 'SP01', 1.2),
    ('NL03', 'SP01', 0.3),
    ('NL06', 'SP01', 2.5),
    ('NL02', 'SP02', 1.1),
    ('NL04', 'SP02', 2.2),
    ('NL02', 'SP03', 0.9),
    ('NL05', 'SP03', 2.1),
    ('NL02', 'SP04', 1.3),
    ('NL04', 'SP04', 1.7),
    ('NL03', 'SP05', 0.8),
    ('NL05', 'SP05', 0.5),
    ('NL06', 'SP05', 2.4)
GO

SELECT * FROM CTDDH
SELECT * FROM DONDH
SELECT * FROM KHACHHANG
SELECT * FROM LAM
SELECT * FROM LOAISP
SELECT * FROM NGUYENLIEU
SELECT * FROM SANPHAM