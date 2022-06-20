USE master
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'QLHOCVIEN')
DROP DATABASE [QLHOCVIEN]
GO

--DROP DATABASE IF EXISTS QLHOCVIEN

CREATE DATABASE [QLHOCVIEN]
 ON  PRIMARY 
( NAME = N'QLHOCVIEN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLSERVER2019\MSSQL\DATA\QLHOCVIEN.mdf')
 LOG ON 
( NAME = N'QLHOCVIEN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLSERVER2019\MSSQL\DATA\QLHOCVIEN_log.ldf')
GO

USE QLHOCVIEN
GO

SET DATEFORMAT dmy
GO

-- TAO TABLE
CREATE TABLE DSLOP (
	LOP NVARCHAR(20) NOT NULL,
	GVCN NVARCHAR(20) NOT NULL,
	SISODK INT
)
GO
CREATE TABLE HOCVIEN (
	MAHV CHAR(5) NOT NULL,
	HOTEN NVARCHAR(20) NOT NULL,
	NGAYSINH DATE,
	PHAI NVARCHAR(10),
	LOP NVARCHAR(20) NOT NULL
)
GO
CREATE TABLE DS_MONHOC (
	MAMH CHAR(5) NOT NULL,
	TENMH NVARCHAR(20) NOT NULL,
	SOTIET INT
)
GO
CREATE TABLE DIEM_KT (
	MAHV CHAR(5) NOT NULL,
	MAMH CHAR(5) NOT NULL,
	DIEM FLOAT
)
GO

-- TAO KHOA CHINH, KHOA NGOAI
ALTER TABLE DSLOP ADD CONSTRAINT PK_LOP PRIMARY KEY (LOP)
ALTER TABLE HOCVIEN ADD
	CONSTRAINT PK_MAHV PRIMARY KEY (MAHV),
	CONSTRAINT FK_LOP FOREIGN KEY (LOP) REFERENCES DSLOP(LOP)
ALTER TABLE DS_MONHOC ADD CONSTRAINT PK_MAMH PRIMARY KEY (MAMH)
ALTER TABLE DIEM_KT ADD
	CONSTRAINT PK_MAHV_MAMH PRIMARY KEY (MAHV, MAMH),
	CONSTRAINT FK_MAHV FOREIGN KEY (MAHV) REFERENCES HOCVIEN(MAHV),
	CONSTRAINT FK_MAMH FOREIGN KEY (MAMH) REFERENCES DS_MONHOC(MAMH)
GO

-- INSERT DU LIEU
INSERT INTO DSLOP VALUES (N'Internet', N'Hoàng Tuấn', 70)
INSERT INTO DSLOP VALUES (N'Mạng', N'Minh Đăng', 75)
INSERT INTO DSLOP VALUES (N'May thiết kế', N'Ngọc Nga', 39)
INSERT INTO DSLOP VALUES (N'Đồ hoạ', N'Ngân Hà', 70)
INSERT INTO DSLOP VALUES (N'Văn phòng', N'Hải Yến', 65)
GO

INSERT INTO HOCVIEN VALUES ('TD01', N'Nguyễn Tuấn Trung', '11/12/1983', N'Nam', N'Đồ hoạ')
INSERT INTO HOCVIEN VALUES ('TD02', N'Nguyễn Hoàng Tú', '10/06/1984', N'Nữ', N'Đồ hoạ')
INSERT INTO HOCVIEN VALUES ('TI02', N'Nguyễn Văn Toàn', '05/12/1982', N'Nam', N'Internet')
INSERT INTO HOCVIEN VALUES ('TI03', N'Nguyễn Mỹ Hạnh', '09/05/1983', N'Nữ', N'Mạng')
INSERT INTO HOCVIEN VALUES ('TM01', N'Nguyễn Hoài Vân', '01/10/1980', N'Nữ', N'Mạng')
INSERT INTO HOCVIEN VALUES ('TM02', N'Nguyễn Minh Hải', '08/06/1984', N'Nam', N'Mạng')
GO

INSERT INTO DS_MONHOC VALUES ('CTMT', N'Cấu trúc máy tính', 90)
INSERT INTO DS_MONHOC VALUES ('LRBT', N'Lắp ráp bảo trì', 60)
INSERT INTO DS_MONHOC VALUES ('THCB', N'Tin học căn bản', 60)
INSERT INTO DS_MONHOC VALUES ('THVP1', N'TH văn phòng 1', 90)
INSERT INTO DS_MONHOC VALUES ('THVP2', N'TH văn phòng 2', 90)
GO

INSERT INTO DIEM_KT VALUES ('TD01', 'CTMT', 6.00)
INSERT INTO DIEM_KT VALUES ('TD02', 'THVP2', 8.00)
INSERT INTO DIEM_KT VALUES ('TD02', 'THCB', 5.00)
INSERT INTO DIEM_KT VALUES ('TD01', 'THVP1', 6.00)
INSERT INTO DIEM_KT VALUES ('TM01', 'THVP2', 7.00)
INSERT INTO DIEM_KT VALUES ('TM01', 'THCB', 5.00)
GO

-- CAU 2
--­	MAHV: có 2 ký tự chữ và 2 ký số.
ALTER TABLE HOCVIEN ADD CONSTRAINT CK_MAHV CHECK (MAHV LIKE '__[0-9][0-9]')
GO
--INSERT INTO HOCVIEN VALUES ('TDD1', N'Nguyễn Tuấn Trung', '11/12/1983', N'Nam', N'Đồ hoạ')

-- ­	PHAI: nhận một trong hai giá trị ‘Nam’ hoặc ‘Nữ’.
ALTER TABLE HOCVIEN ADD CONSTRAINT CK_PHAI CHECK (PHAI LIKE N'Nam' OR PHAI LIKE N'Nữ')
GO
--INSERT INTO HOCVIEN VALUES ('TD09', N'Nguyễn Tuấn Trung', '11/12/1983', N'Namm', N'Đồ hoạ')

-- CAU 3
--Tạo view cho hiển thị thông tin kết quả học tập của các học viên.
--Thông tin hiển thị gồm: mã học viên, họ tên học viên, tên môn học, điểm thi và kết quả.
--Biết rằng kết quả là đậu nếu điểm thi >=5 và ngược lại có kết quả là rớt.
CREATE VIEW VIEW3
AS
	SELECT d.MAHV, hv.HOTEN, m.TENMH, d.DIEM,
		(CASE
			WHEN DIEM >= 5 THEN N'Đậu'
			ELSE N'Rớt'
		END) AS [KETQUA]
	FROM DIEM_KT d, HOCVIEN hv, DS_MONHOC m
	WHERE d.MAHV = hv.MAHV AND d.MAMH = m.MAMH
GO
SELECT * FROM dbo.VIEW3

-- CAU 4
--Tạo view thống kê số lượng học viên thực tế theo học của từng lớp.
--Thông tin hiển thị gồm: tên lớp, giáo viên chủ nhiệm và số lượng học viên thực tế trong lớp đó.
--Sắp xếp dữ liệu giảm dần theo số lượng học viên trong từng lớp.
CREATE VIEW VIEW4
AS
	SELECT TOP(10) l.LOP, l.GVCN, COUNT(h.MAHV) AS [So luong HV]
	FROM HOCVIEN h, DSLOP l
	WHERE h.LOP = l.LOP
	GROUP BY l.LOP, l.GVCN
	ORDER BY COUNT(h.MAHV) DESC
GO
SELECT * FROM dbo.VIEW4

-- CAU 5
--Tạo Store Procedure cho xem thông tin kết quả học tập trung bình cuối khóa của học viên có mã số truyền vào.
--Thông tin hiển thị gồm: mã học viên, họ tên học viên, số lượng môn học (Slmon)
--và điểm trung bình các môn học của học viên đó.
ALTER PROC CAU5 @MAHV CHAR(5)
AS
	SELECT h.MAHV, h.HOTEN, COUNT(d.MAMH) AS [Slmon], SUM(d.DIEM) / COUNT(d.MAMH) AS [Diem trung binh]
	FROM DIEM_KT d, HOCVIEN h
	WHERE d.MAHV = h.MAHV
	GROUP BY h.MAHV, h.HOTEN
	HAVING h.MAHV = @MAHV
GO

EXEC CAU5 @MAHV='TD02'

-- CAU 6
--Tạo Store Procedure tính tuổi trung bình của các học viên trong các lớp.
--Biết rằng tuổi của mỗi học viên được tính bằng cách lấy năm hiện tại trừ đi năm sinh của học viên. 
--Thông tin hiển thị gồm: tên lớp và tuổi trung bình của các học viên
CREATE PROC CAU6
AS
	SELECT LOP, cast(SUM((YEAR(GETDATE()) - YEAR(NGAYSINH))) as float) / COUNT(MAHV) AS [Tuoi trung binh]
	FROM HOCVIEN
	GROUP BY LOP
GO

EXEC CAU6
