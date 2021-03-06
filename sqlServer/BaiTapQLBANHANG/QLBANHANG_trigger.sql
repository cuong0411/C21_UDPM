use QLBANHANG2;
go

--1.Thực hiện việc kiểm tra các ràng buộc khóa ngoại.

--2.Không cho phép CASCADE DELETE trong các ràng buộc khóa ngoại.
--Ví dụ không cho phép xóa các HOADON nào có SOHD còn trong table CTHD.
select * from HOADON
select * from CTHD
CREATE TRIGGER T2 ON HOADON
FOR INSERT, UPDATE, DELETE
AS
	DECLARE @mahd VARCHAR(10)
	SET @mahd = (SELECT MAHD FROM deleted)
	IF EXISTS (SELECT * FROM CTHD WHERE MAHD = @mahd)
	BEGIN
		PRINT N'Mã hoá đơn này đã tồn tại trong bảng CTHD'
		ROLLBACK TRANSACTION
	END
DELETE HOADON
WHERE MAHD = 'HD001'
--3.Không cho phép user nhập vào hai vật tư có cùng tên.
CREATE TRIGGER T3 ON VATTU
FOR INSERT, UPDATE, DELETE
AS
	BEGIN
		DECLARE @tenvt NVARCHAR(30), @mavt VARCHAR(5)
		SET @tenvt = (SELECT TENVT FROM inserted)
		SET @mavt = (SELECT MAVT FROM inserted)
		IF EXISTS (SELECT * FROM VATTU WHERE TENVT = @tenvt AND MAVT <> @mavt)
		BEGIN
			PRINT N'Trùng tên vật tư'
			ROLLBACK TRANSACTION
		END
	END
INSERT INTO VATTU VALUES ('VT10', N'Xi măng', N'Bao', 50000, 5000)
--4.Khi user đặt hàng thì KHUYENMAI là 5% nếu SL > 100, 10% nếu SL > 500.
SELECT * FROM CTHD
CREATE TRIGGER T4 ON CTHD
FOR INSERT, UPDATE, DELETE
AS
	BEGIN
		DECLARE @mavt VARCHAR(5), @mahd VARCHAR(5), @sl INT
		SELECT @mahd = MAHD, @mavt = MAVT, @sl = SL FROM inserted
			IF @SL > 500
				UPDATE CTHD
				SET KHUYENMAI = 0.1
				WHERE MAHD = @mahd AND MAVT = @mavt
			ELSE
				IF @SL > 100
					UPDATE CTHD
					SET KHUYENMAI = 0.05
					WHERE MAHD = @mahd AND MAVT = @mavt
				ELSE
					UPDATE CTHD
					SET KHUYENMAI = 0
					WHERE MAHD = @mahd AND MAVT = @mavt
	END

INSERT INTO CTHD (MAHD, MAVT, SL) VALUES ('HD001', 'VT03', 600)
INSERT INTO CTHD (MAHD, MAVT, SL) VALUES ('HD001', 'VT04', 120)
INSERT INTO CTHD (MAHD, MAVT, SL) VALUES ('HD002', 'VT04', 50)

DROP TRIGGER dbo.T4
SELECT * FROM CTHD
--5.Chỉ cho phép mua các mặt hàng có số lượng tồn lớn hơn hoặc bằng số lượng cần mua và \
--tính lại số lượng tồn mỗi khi có đơn hàng.
ALTER TRIGGER T5 ON CTHD FOR INSERT, UPDATE, DELETE
AS
	BEGIN
		DECLARE @mavt VARCHAR(5), @sl INT
		DECLARE @slton INT
		SELECT @slton = SLTON FROM VATTU WHERE MAVT = @mavt
		
		SELECT @mavt = MAVT, @sl = SL FROM inserted
		IF (@sl > @slton)
			BEGIN
				PRINT N'Số lượng mua lớn hơn số lượng tồn của vật tư'
				ROLLBACK TRANSACTION
			END
		ELSE
			BEGIN
				UPDATE VATTU
				SET SLTON = SLTON - @sl
				WHERE MAVT = @mavt
				PRINT 'GIAO DICH THANH CONG'
			END
	END
UPDATE VATTU
SET SLTON = 5000
WHERE MAVT = 'VT01'

SELECT * FROM VATTU
SELECT * FROM CTHD
INSERT INTO CTHD (MAHD, MAVT, SL) VALUES ('HD013', 'VT01', 10)
INSERT INTO CTHD VALUES ('HD019', 'VT01', 5, NULL, 52000)

-- VER 2
ALTER TRIGGER T5 ON CTHD FOR INSERT, UPDATE, DELETE
AS
	BEGIN
		DECLARE @slmua INT, @mavt VARCHAR(5), @sltonkho INT
		SELECT @mavt = MAVT, @slmua = SL FROM inserted
		SELECT @sltonkho = SUM(SLTON) FROM VATTU WHERE MAVT = @mavt
		IF (@slmua <= @sltonkho)
			BEGIN
				UPDATE VATTU
				SET SLTON = (SLTON - @slmua)
				WHERE MAVT = @mavt
				PRINT 'GIAO DICH THANH CONG'
			END
		ELSE
			BEGIN
				PRINT N'Số lượng mua lớn hơn số lượng tồn của vật tư'
				ROLLBACK TRANSACTION
			END
			
	END
--6.Không cho phép user xóa một lúc nhiều hơn một vật tư.
ALTER TRIGGER T6 ON VATTU FOR INSERT, UPDATE, DELETE
AS
	BEGIN
		DECLARE @SoLuongVT INT
		SET @SoLuongVT = (SELECT COUNT(*) FROM deleted)
		IF (@SoLuongVT >= 2)
			BEGIN
				PRINT 'Khong the xoa hon 1 vat tu'
				ROLLBACK TRANSACTION
			END
	END
SELECT * FROM VATTU
DELETE FROM VATTU
WHERE MAVT IN ('VT01', 'VT06')
--7.Mỗi hóa đơn cho phép bán tối đa 5 mặt hàng.
SELECT MAHD, COUNT(DISTINCT MAVT) AS [SL VT] FROM CTHD GROUP BY MAHD

ALTER TRIGGER T7 ON CTHD FOR INSERT, UPDATE, DELETE
AS
	BEGIN
		DECLARE @mahd VARCHAR(5), @SoLuongMH INT
		SET @mahd = (SELECT MAHD FROM inserted)
		SET @SoLuongMH =
		(
			SELECT COUNT(DISTINCT MAVT)
			FROM CTHD
			GROUP BY MAHD
			HAVING MAHD = @mahd
		) + 
		(
			SELECT COUNT(DISTINCT MAVT)
			FROM inserted
			GROUP BY MAHD
			HAVING MAHD = @mahd
		)
		IF (@SoLuongMH > 5)
			BEGIN
				PRINT N'Mỗi hóa đơn cho phép bán tối đa 5 mặt hàng'
				ROLLBACK TRANSACTION
			END
	END
SELECT * FROM CTHD WHERE MAHD = 'HD001'
INSERT INTO CTHD VALUES ('HD001', 'VT08', 5, NULL, 52000)
INSERT INTO CTHD VALUES ('HD001', 'VT07', 600, NULL, 30000)
DELETE FROM CTHD
WHERE MAHD = 'HD001' AND MAVT = 'VT07'

DELETE FROM CTHD
WHERE MAHD = 'HD001' AND MAVT = 'VT08'
--8.Mỗi hóa đơn có tổng trị giá tối đa 50000000.
ALTER TRIGGER T08 ON CTHD FOR INSERT, UPDATE, DELETE
AS
	BEGIN
		DECLARE @TongTriGia INT
		SET @TongTriGia =
		(
			SELECT SUM(SL * GIABAN
				 *(1 - (CASE WHEN KHUYENMAI IS NULL THEN 0 ELSE KHUYENMAI END)))
			FROM CTHD
			GROUP BY MAHD
			HAVING MAHD IN (SELECT MAHD FROM inserted)
		) +
		(
			SELECT SUM(SL * GIABAN
				* (1 - (CASE WHEN KHUYENMAI IS NULL THEN 0 ELSE KHUYENMAI END)))
			FROM inserted
			GROUP BY MAHD
			HAVING MAHD IN (SELECT MAHD FROM inserted)
		)
		IF (@TongTriGia > 50000000)
			BEGIN
				PRINT N'Mỗi hóa đơn có tổng trị giá tối đa 50000000'
				ROLLBACK TRANSACTION
			END
	END
SELECT * FROM CTHD


INSERT INTO CTHD VALUES ('HD020', 'VT04', 500, NULL, 300000)
INSERT INTO CTHD VALUES ('HD020', 'VT01', 400, NULL, 300000)

DELETE FROM CTHD
WHERE MAHD = 'HD020'

SELECT MAHD, SUM(SL * GIABAN 
	* (1 - (CASE WHEN KHUYENMAI IS NULL THEN 0 ELSE KHUYENMAI END))) AS [Tong tri gia]
FROM CTHD
GROUP BY MAHD
having SUM(SL * GIABAN) > 50000000
--9.Không được phép bán hàng lỗ quá 50%.
CREATE TRIGGER T9 ON CTHD FOR INSERT, UPDATE, DELETE
AS
BEGIN
	DECLARE @giaban INT, @dinhmuc INT
	SET @giaban = (SELECT GIABAN FROM inserted)
	SET @dinhmuc = (SELECT GIAMUA*0.5 FROM inserted, VATTU WHERE inserted.MAVT = VATTU.MAVT)
	IF (@giaban < @dinhmuc)
		BEGIN
			PRINT N'Không được phép bán hàng lỗ quá 50%'
			ROLLBACK TRANSACTION
		END
END

INSERT INTO CTHD VALUES ('HD020', 'VT01', 400, NULL, 30000)

SELECT *
FROM CTHD, VATTU
WHERE CTHD.MAVT = VATTU.MAVT
--10.Chỉ bán mặt hàng Gạch (các loại gạch) với số lượng là bội số của 100.
SELECT * FROM CTHD
SELECT * FROM VATTU WHERE TENVT LIKE N'Gạch%'

ALTER TRIGGER T10 ON CTHD FOR INSERT, UPDATE, DELETE
AS
	BEGIN
		DECLARE @SoLuongBan INT
		SET @SoLuongBan = (
			SELECT SL
			FROM inserted, VATTU
			WHERE inserted.MAVT = VATTU.MAVT
			AND TENVT LIKE N'Gạch%')
		IF (@SoLuongBan % 100 <> 0)
			BEGIN
				PRINT N'Chỉ bán mặt hàng Gạch (các loại gạch) với số lượng là bội số của 100'
				ROLLBACK TRANSACTION
			END
	END

INSERT INTO CTHD VALUES ('HD020', 'VT03', 600, NULL, 30000)
INSERT INTO CTHD VALUES ('HD021', 'VT03', 601, NULL, 30000)