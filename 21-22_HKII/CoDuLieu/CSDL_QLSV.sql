--DB01 với dung lượng khởi đầu là 25MB,
--dung lượng tối đa là 250MB, và lưu trữ tại thư mục C:\DataSQL.

--Tao db DB01 bang giao dien
EXEC sp_renamedb 'DB01', 'DB02' --doi ten db DB01 thanh DB02
DROP DATABASE DB02;
CREATE DATABASE QLSV;
CREATE DATABASE QLDDH;

--BAI 3
--Tạo bảng, khóa chính, khoá ngoại
--Xoa bang
SET DATEFORMAT dmy

DROP TABLE IF EXISTS KEHOACH
DROP TABLE IF EXISTS KETQUA
DROP TABLE IF EXISTS MONHOC
DROP TABLE IF EXISTS SINHVIEN
DROP TABLE IF EXISTS KHOA
GO
--Tao bang va khoa chinh
CREATE TABLE KHOA (
    MAKHOA VARCHAR(4) NOT NULL CONSTRAINT PK_MAKHOA PRIMARY KEY,
    TEMKHOA NVARCHAR(30) NOT NULL,
    SO_CBGD TINYINT NOT NULL
)
CREATE TABLE MONHOC (
    MAMH NVARCHAR(4) NOT NULL CONSTRAINT PK_MAMH PRIMARY KEY,
    TENMH NVARCHAR(20) NOT NULL,
    SOTIET_LT TINYINT NOT NULL,
    SOTIET_TH TINYINT NOT NULL
)
CREATE TABLE SINHVIEN (
    MASV INT NOT NULL CONSTRAINT PK_MASV PRIMARY KEY,
    HOSV NVARCHAR(30),
    TENSV NVARCHAR(30) NOT NULL,
    NU NVARCHAR(3) NOT NULL CONSTRAINT DF_GIOITINHNU DEFAULT('Yes'),
    NSINH DATE NOT NULL,
    DIACHI_SV NVARCHAR(50) NOT NULL,
    TINH TINYINT NOT NULL,
    TTGD NVARCHAR(4) NOT NULL,
    MAKHOA VARCHAR(4) NOT NULL,
    NAMHOC TINYINT NOT NULL,
    HOCBONG INT
)
CREATE TABLE KEHOACH (
    GIAMTHI NVARCHAR(30) NOT NULL CONSTRAINT PK_GIAMTHI PRIMARY KEY,
    MAMH NVARCHAR(4) NOT NULL,
    GV_DAY NVARCHAR(30) NOT NULL,
    NG_THI DATE NOT NULL,
    GIO_THI CHAR(3) NOT NULL,
    PHG_THI NCHAR(3) NOT NULL
)
CREATE TABLE KETQUA (
    MASV INT NOT NULL,
    MAMH NVARCHAR(4) NOT NULL,
    LANTHI TINYINT NOT NULL,
    DIEM TINYINT NOT NULL
)
--Tao khoa ngoai
ALTER TABLE SINHVIEN ADD
    CONSTRAINT FK_MAKHOA FOREIGN KEY (MAKHOA) REFERENCES KHOA(MAKHOA)
ALTER TABLE KEHOACH ADD
    CONSTRAINT FK_MAMH FOREIGN KEY (MAMH) REFERENCES MONHOC(MAMH)
ALTER TABLE KETQUA ADD
    CONSTRAINT FK_MAMH2 FOREIGN KEY (MAMH) REFERENCES MONHOC(MAMH),
    CONSTRAINT FK_MASV FOREIGN KEY (MASV) REFERENCES SINHVIEN(MASV)
GO
--BAI 4
--Tao rang buoc mien gia tri
ALTER TABLE SINHVIEN ADD
    CONSTRAINT CK_MSSV CHECK (MASV>=10000 AND MASV<=99999), --Mã số sinh viên bao gồm 5 ký số
    CONSTRAINT CK_TTGD CHECK (TTGD IN (N'ĐT', N'GĐ')), --Tình trạng gia đình chi hai giá trị {ĐT: Độc thân, GĐ: Đã lập gia đình}
    CONSTRAINT CK_NAMHOC CHECK (NAMHOC IN (1, 2, 3, 4)) --Năm học chỉ gồm {1,2,3,4}
ALTER TABLE SINHVIEN ALTER COLUMN TINH CHAR(2) ----Tỉnh bao gồm hai ký số
ALTER TABLE KHOA ADD
    CONSTRAINT CK_SO_CBGD CHECK (SO_CBGD>0) --Số cán bộ giảng dạy phải >0
ALTER TABLE MONHOC ADD
    CONSTRAINT CK_SOTIET_LT CHECK (SOTIET_LT>=15), --Số tiết lý thuyết >=15
    CONSTRAINT CK_SOTIET_TH CHECK (SOTIET_TH>=0) --Số tiết thực hành >=0
ALTER TABLE KETQUA ADD
    CONSTRAINT CK_LANTHI CHECK (LANTHI>0), --Lần thi>0
    CONSTRAINT CK_DIEMTHI CHECK (DIEM>=0 AND DIEM<=10) --Diểm thi >=0 và điểm thi <=10

--BAI 5
--nhap du lieu cho bang QLSV
--thu tu nhap lieu KHOA, MONHOC -> SINHVIEN, KETQUA, GIAMTHI

INSERT INTO dbo.KHOA
VALUES
    ('AV', N'Anh văn', 17),
    ('CNTT', N'Công nghệ thông tin', 26),
    ('TR', N'Triết', 14)
GO
INSERT INTO dbo.MONHOC
VALUES
    (N'CSDL', N'Cơ sở dữ liệu', 45, 0),
    (N'CTDL', N'Cấu trúc dữ liệu', 60, 30),
    (N'ĐT', N'Đàm thoại', 60, 60),
    (N'TH', N'Triết học', 60, 0),
    (N'VP', N'Văn phạm', 60, 0)
GO
SET DATEFORMAT dmy
INSERT INTO dbo.SINHVIEN
VALUES
    (91002, N'Trần Đan', N'Thu', N'Yes', '12/04/75', N'215/47/20 Tân Hóa_Q6', '02', N'ĐT', 'CNTT', 2, NULL),
    (91007, N'Nguyền Hà Dạ', N'Thảo', N'Yes', '04/02/75', N'115 Nguyễn Du', '41', N'ĐT', 'CNTT', 2, 80000),
    (91023, N'Phạm Ng Anh', N'Huy', N'No', '05/03/74', N'17/6 Trần Phú', '56', N'ĐT', 'CNTT', 2, NULL),
    (91024, N'Nguyễn Ngọc', N'Thuận', N'No', '15/06/75', N'52 Bàu Cát - QTB', '02', N'ĐT', 'CNTT', 2, NULL),
    (91045, N'Lê Thanh', N'Trung', N'No', '22/06/75', N'23/18 Lê Hồng Phong', '34', N'ĐT', 'AV', 2, 80000),
    (91088, N'Nguyễn Hồng', N'Vân', N'Yes', '12/07/75', N'43/17/Trần Hưng Đạo', '02', N'ĐT', 'AV', 2, NULL),
    (91102, N'Võ Thị Kim', N'Loan', N'Yes', '04/02/74', N'69 Trưng Nhị', '46', N'ĐT', 'AV',  2, NULL),
    (91109, N'Trương Kim', N'Quan', N'No', '21/04/72', N'236 Lê Quang Định - QTB', '02', N'GĐ', 'AV', 2,120000),
    (91120, N'Tôn Thất', N'Quyền', N'No', '26/06/71', N'340/4 Đông Hồ - QTB', '02', N'GĐ', 'AV', 2, NULL),
    (91133, N'Hà Thị Giang', N'Long', N'Yes', '23/07/76', N'43A Trang Tử -Q5','02', N'ĐT', 'AV', 2, NULL),
    (92001, N'Bùi Văn', N'Anh', N'No', '30/09/77', N'466 Hưng Phú - Q8','02', N'ĐT', 'CNTT',  1, NULL),
    (92013, N'Lê Hữu', N'Chí', N'No', '19/11/77', N'233 Võ Thị Sáu - Q3', '02', N'ĐT', 'AV', 1, NULL),
    (92024, N'Võ Thành', N'Công', N'No', '27/06/77', N'B8 Cx 155 Tô Hiến Thành', '02', N'ĐT', 'CNTT', 1, NULL),
    (92025, N'Trần Quang', N'Cường', N'No', '25/03/78', N'516 Lê Văn Sỹ - Q3', '02', N'ĐT', 'CNTT',1,  NULL),
    (92027, N'Phạm Văn', N'Hải', N'No', '04/01/77', N'322 XV Nghệ Tỉnh - QBT','02', N'ĐT', 'AV', 1, NULL),
    (92031, N'Phan Văn', N'Hoàng', N'No', '05/01/77', N'28 Bình Giả','51',N'ĐT', 'CNTT', 1,80000),
    (92048, N'Huỳnh Thanh', N'Lâm', N'No', '20/10/77', N'243/16 Phú Mỹ - Phú Tân', '50', N'ĐT', 'AV', 1, NULL),
    (92173, N'Trần Minh', N'Sang', N'No', '16/06/77', N'49/1 Hồ Biểu Chánh - QPN', '02', N'ĐT', 'CNTT', 1, NULL),
    (92188, N'Phạm Văn', N'Hiền', N'No', '19/05/76', N'17/6 Trần Phú', '56',N'ĐT', 'AV', 1, NULL),
    (92242, N'Phạm Thị Anh', N'Thu', N'Yes', '21/12/77', N'134 Lạc long Quân - QTB','02', N'ĐT', 'CNTT', 1, NULL)
GO
INSERT INTO dbo.KETQUA
VALUES
     (91002, N'CSDL', 1, 8),
     (91007, N'CSDL', 2, 9),
     (91023, N'CSDL', 1, 4),
     (91023, N'CSDL', 2, 5),
     (91024, N'CSDL', 1, 7),
     (91045, N'VP', 1, 7),
     (91088, N'VP', 1, 4),
     (91088, N'VP', 2, 6),
     (91102, N'VP', 1, 7),
     (91109, N'VP', 1, 9),
     (91120, N'VP', 1, 8),
     (91133, N'VP', 1, 8),
     (92001, N'CTDL', 1, 5),
     (92013, N'ĐT', 1, 4),
     (92013, N'ĐT', 2, 5),
     (92024, N'CTDL', 1, 7),
     (92025, N'CTDL', 1, 6),
     (92027, N'ĐT', 1, 7),
     (92031, N'CTDL', 1, 9),
     (92048, N'ĐT', 1, 9),
     (92173, N'CTDL', 1, 7),
     (92242, N'CTDL', 1, 8)
GO
INSERT INTO dbo.KEHOACH
VALUES
    (N'Lê Ngọc An', N'TH', N'Lê Ngọc An', '30/5/96', '08h', N'GĐ2'),
    (N'Lê Văn Đỉnh', N'VP', N'Lê Văn Đỉnh', '12/5/96', '08h', 'GĐ2'),
    (N'Ng An Tế', N'CSDL', N'Ng An Tế', '25/5/96', '18h', 'GĐ1'),
    (N'Ng Tri Tuấn', N'CSDL', N'Ng Tri Tuấn', '30/5/96', '18h', 'GĐ1'),
    (N'Vũ Thị Hà', N'ĐT', N'Lê Văn Đỉnh', '17/5/96', '08h', 'GĐ2')
GO