-- Demo databasee
DROP DATABASE IF EXISTS Demo
GO
CREATE DATABASE Demo
GO
SET DATEFORMAT dmy
GO
-- NgayThangNam table
USE Demo
DROP TABLE IF EXISTS NgayThangNam
CREATE TABLE NgayThangNam(
    ThuTu int IDENTITY(1,1),
    DinhDangMacDinh date
)
GO
INSERT INTO NgayThangNam (DinhDangMacDinh)
VALUES ('31-12-2021') --ddmmyyyy
GO
INSERT INTO NgayThangNam (DinhDangMacDinh)
VALUES ('31-12-21') --ddmmyy
GO
SELECT * FROM dbo.NgayThangNam
GO

sp_helplanguage
GO
-- 
USE Demo
DROP TABLE IF EXISTS NgayThangNam2
CREATE TABLE NgayThangNam2(
    ThuTu int IDENTITY(1,1),
    DinhDangMacDinh date
)
INSERT INTO NgayThangNam2 (DinhDangMacDinh)
VALUES ('12-31-2021') --ddmmyyyy
SELECT * FROM dbo.NgayThangNam2
GO

-- Linh tinh
-- Tuy chinh dinh dang output cua date
SELECT GETDATE() AS [NotFormatedDate],
CONVERT(Varchar(50),GETDATE(),103) AS [FormatDate103],
CONVERT(Varchar(50),GETDATE(),105) AS [FormatDate105],
CONVERT(Varchar(50),GETDATE(),5) AS [FormatDate5]
GO

SELECT CONVERT(NVARCHAR, GETDATE(), 3)

SET DATEFORMAT dmy
GO
DECLARE @datevar DATE = '31-12-2021'--GETDATE()
SELECT @datevar --CONVERT(DATE, @datevar, 103) as [FormatDate103]
GO

SELECT * FROM NgayThangNam
GO