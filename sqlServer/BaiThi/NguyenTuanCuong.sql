﻿use master
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'QLKS')
DROP DATABASE QLKS
GO

CREATE DATABASE QLKS
 ON 
( NAME = N'QLKS', FILENAME = N'D:\BaiThi\QLKS.mdf')
 LOG ON 
( NAME = N'QLKS_log', FILENAME = N'D:\BaiThi\QLKS_log.ldf')
GO

USE QLKS
GO

SET DATEFORMAT dmy
GO

-- tao table
CREATE TABLE KHACHHANG (
	MAKH CHAR(6) NOT NULL,
	TENKH NVARCHAR(20) NOT NULL,
	SCMND CHAR(10) NOT NULL
)
GO
CREATE TABLE PHONG (
	MAPH CHAR(5) NOT NULL,
	TENPH NVARCHAR(30) NOT NULL,
	MALOAI CHAR(5) NOT NULL
)
GO
CREATE TABLE  LOAIPHONG (
	MALOAI CHAR(5) NOT NULL,
	TENLOAI NVARCHAR(20) NOT NULL,
	DG INT
)
GO
CREATE TABLE THUEPHONG (
	MAKH CHAR(6) NOT NULL,
	MAPH CHAR(5) NOT NULL,
	NGAYTHUE DATE,
	NGAYTRA DATE,
	TIENTHUE INT
)
GO

-- KHOA CHINH, KHOA NGOAI
ALTER TABLE KHACHHANG ADD CONSTRAINT PK_MAKH PRIMARY KEY (MAKH)
ALTER TABLE LOAIPHONG ADD CONSTRAINT PK_MALOAI PRIMARY KEY (MALOAI)
ALTER TABLE PHONG ADD
	CONSTRAINT PK_MAPH PRIMARY KEY (MAPH),
	CONSTRAINT FK_MALOAI FOREIGN KEY (MALOAI) REFERENCES LOAIPHONG (MALOAI)
ALTER TABLE THUEPHONG ADD
	CONSTRAINT PK_MAKH_MAPH PRIMARY KEY (MAKH, MAPH),
	CONSTRAINT FK_MAKH FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
	CONSTRAINT FK_MAPH FOREIGN KEY (MAPH) REFERENCES PHONG(MAPH)
GO

-- INSERT
INSERT INTO  KHACHHANG VALUES ('KH0001', N'A.Trung', '2731000000')
INSERT INTO  KHACHHANG VALUES ('KH0002', N'C.Trang', '2731000001')
INSERT INTO  KHACHHANG VALUES ('KH0003', N'Đoàn du lịch TN', '2731000002')
INSERT INTO  KHACHHANG VALUES ('KH0004', N'Vãng lai', '2731000003')
INSERT INTO  KHACHHANG VALUES ('KH0005', N'Vãng lai', '2731000004')
GO
INSERT INTO LOAIPHONG VALUES ('001', N'P.Quạt', 80000)
INSERT INTO LOAIPHONG VALUES ('002', N'P.M lạnh', 150000)
INSERT INTO LOAIPHONG VALUES ('003', N'P.VIP', 300000)
GO
INSERT INTO PHONG VALUES ('A101', N'Phòng 01 lầu 1 dãy A', '001')
INSERT INTO PHONG VALUES ('A102', N'Phòng 02 lầu 1 dãy A', '001')
INSERT INTO PHONG VALUES ('B202', N'Phòng 02 lầu 2 dãy B', '002')
INSERT INTO PHONG VALUES ('C201', N'Phòng 01 lầu 2 dãy C', '003')
INSERT INTO PHONG VALUES ('D103', N'Phòng 03 lầu 1 dãy D', '002')
GO
INSERT INTO THUEPHONG VALUES ('KH0001', 'A102', '10/02/2004', '15/02/2004', 400000)
INSERT INTO THUEPHONG VALUES ('KH0002', 'B202', '10/02/2004', '12/02/2004', 300000)
INSERT INTO THUEPHONG VALUES ('KH0003', 'B202', '09/03/2004', '19/03/2004', 1500000)
INSERT INTO THUEPHONG VALUES ('KH0004', 'C201', '08/02/2004', '12/03/2004', 600000)
INSERT INTO THUEPHONG VALUES ('KH0005', 'D103', '05/02/2004', '07/02/2004', 300000)
INSERT INTO THUEPHONG VALUES ('KH0003', 'C201', '15/03/2004', '17/03/2004', 300000)
GO

-- CAU 2
ALTER TABLE PHONG ADD CONSTRAINT CK_MAPH CHECK (MAPH LIKE '_[0-9][0-9][0-9]')
ALTER TABLE KHACHHANG ADD CONSTRAINT CK_MAKH CHECK (MAKH LIKE '__[0-9][0-9][0-9][0-9]')
ALTER TABLE LOAIPHONG ADD CONSTRAINT DF_DG DEFAULT 80000 FOR DG

INSERT INTO PHONG VALUES ('AA01', N'Phòng 01 lầu 1 dãy A', '001')
INSERT INTO  KHACHHANG VALUES ('KHH005', N'Vãng lai', '2731000004')

-- CAU 3
SELECT k.MAKH, k.TENKH
FROM KHACHHANG k, THUEPHONG tp, PHONG p, LOAIPHONG l
WHERE k.MAKH = tp.MAKH AND p.MAPH = tp.MAPH AND p.MALOAI = l.MALOAI
	AND L.TENLOAI = N'P.VIP'

-- CAU 4
SELECT TOP(1) WITH TIES k.MAKH, k.TENKH, p.TENPH
FROM KHACHHANG k, THUEPHONG tp, PHONG p
WHERE k.MAKH = tp.MAKH AND p.MAPH = tp.MAPH
ORDER BY (DATEDIFF(DAY, NGAYTHUE, NGAYTRA) + 1) DESC

-- CAU 5
ALTER VIEW V05
AS
	SELECT DISTINCT k.MAKH
	FROM KHACHHANG k, THUEPHONG tp
	WHERE k.MAKH = tp.MAKH
		AND YEAR(tp.NGAYTHUE) = 2004 AND MONTH(tp.NGAYTHUE) = 3

SELECT * FROM dbo.V05

-- CAU 6
CREATE VIEW V06
AS
	SELECT TOP(1) WITH TIES MAPH, COUNT(MAPH) [SO LAN THUE]
	FROM THUEPHONG
	GROUP BY MAPH
	ORDER BY COUNT(MAPH) DESC

SELECT * FROM dbo.V06

-- CAU 7
CREATE PROC P07 @MAPH CHAR(5), @TENPH NVARCHAR(30), @MALOAI CHAR(5)
AS
	BEGIN
	INSERT INTO PHONG VALUES (@MAPH, @TENPH, @MALOAI)
	END

EXEC P07 @MAPH='E101', @TENPH = N'Phòng 01 lầu 1 dãy E', @MALOAI = '002'
SELECT * FROM PHONG

-- CAU 8
CREATE PROC P08 @MAKH CHAR(6)
AS
	BEGIN
		SELECT p.TENPH
		FROM KHACHHANG k, THUEPHONG tp, PHONG p
		WHERE k.MAKH = tp.MAKH AND tp.MAPH = p.MAPH
			AND k.MAKH = @MAKH
	END

EXEC P08 @MAKH='KH0003'