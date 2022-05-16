USE master;
GO
DROP DATABASE IF EXISTS QLSANXUAT;
GO
CREATE DATABASE QLSANXUAT;
GO
USE QLSANXUAT;
GO
SET DATEFORMAT dmy;
go

-- DROP TABLE
DROP TABLE IF EXISTS LOAI
DROP TABLE IF EXISTS SANPHAM
DROP TABLE IF EXISTS NHANVIEN
DROP TABLE IF EXISTS PHIEUXUAT
DROP TABLE IF EXISTS CTPX
GO
-- CREATE TABLE
CREATE TABLE LOAI (
    MaLoai CHAR(5) NOT NULL,
    TenLoai NVARCHAR(20)
)
CREATE TABLE SANPHAM (
    MaSP CHAR(5) NOT NULL,
    TenSP NVARCHAR(20) NOT NULL,
    MaLoai CHAR(5) NOT NULL
)
CREATE TABLE NHANVIEN (
    MaNV CHAR(5) NOT NULL,
    HoTen NVARCHAR(30),
    NgaySinh DATE,
    Phai TINYINT
)
CREATE TABLE PHIEUXUAT (
    MaPX INT NOT NULL IDENTITY(1,1),
    NgayLap DATE,
    MaNV CHAR(5) NOT NULL
)
CREATE TABLE CTPX (
    MaPX INT NOT NULL,
    MaSP CHAR(5) NOT NULL,
    SoLuong INT
)

-- CONSTRAINT
ALTER TABLE LOAI ADD
CONSTRAINT PK_MALOAI PRIMARY KEY (MaLoai)
ALTER TABLE SANPHAM ADD
    CONSTRAINT PK_MASP PRIMARY KEY (MaSP),
    CONSTRAINT UQ_TENSP UNIQUE (TenSP),
    CONSTRAINT FK_MALOAI FOREIGN KEY (MaLoai) REFERENCES LOAI(MaLoai)
ALTER TABLE NHANVIEN ADD
    CONSTRAINT PK_MANV PRIMARY KEY (MaNV),
    CONSTRAINT DF_PHAI DEFAULT 0 FOR Phai,
    CONSTRAINT CK_PHAI CHECK (PHAI IN (0, 1)),
    CONSTRAINT CK_NGAYSINH CHECK (
        (YEAR(GETDATE()) - YEAR(NgaySinh) >= 18) AND
        (YEAR(GETDATE()) - YEAR(NgaySinh) <= 55)
    )
ALTER TABLE PHIEUXUAT ADD
    CONSTRAINT PK_MAPX PRIMARY KEY (MaPX),
    CONSTRAINT FK_MANV FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)
ALTER TABLE CTPX ADD
    CONSTRAINT PK_MAPXMASP PRIMARY KEY (MaPX, MaSP),
	CONSTRAINT FK_MAPX FOREIGN KEY (MaPX) REFERENCES PHIEUXUAT(MaPX),
	CONSTRAINT FK_MASP FOREIGN KEY (MaSP) REFERENCES SANPHAM(MaSP),
    CONSTRAINT CK_SOLUONG CHECK (SoLuong > 0)
GO

-- INSERT
INSERT INTO LOAI
VALUES
    (1, N'Vật liệu xây dựng'),
    (2, N'Hàng tiêu dùng'),
    (3, N'Ngũ cốc')
INSERT INTO SANPHAM
VALUES
    (1, N'Xi măng', 1),
    (2, N'Gạch', 1),
    (3, N'Gạo nàng hương', 3),
    (4, N'Bột mì', 3),
    (5, N'Kệ chén', 2),
    (6, N'Đậu xanh', 3)
INSERT INTO NHANVIEN
VALUES
    ('NV01', N'Nguyễn Mai Thi', '15/5/82', 0),
    ('NV02', N'Trần Đình Chiến', '2/12/80', 1),
    ('NV03', N'Lê Thị Chi', '23/1/79', 0)
INSERT INTO PHIEUXUAT (NgayLap, MaNV)
VALUES
    ('12/3/2010', 'NV01'),
    ('3/2/2010', 'NV02'),
    ('1/6/2010', 'NV03'),
    ('16/6/2010', 'NV01')
INSERT INTO CTPX
VALUES
    (1, 1, 10),
    (1, 2, 15),
    (1, 3, 5),
    (2, 2, 20),
    (3, 1, 20),
    (3, 3, 25),
    (4, 5, 12)