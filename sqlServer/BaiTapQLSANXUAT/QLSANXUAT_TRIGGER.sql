--1.Chỉ cho phép một phiếu xuất có tối đa 5 chi tiết phiếu xuất.
SELECT MaPX, COUNT(MaPX) FROM CTPX GROUP BY MaPX
SELECT * FROM PHIEUXUAT
SELECT * FROM SANPHAM
CREATE TRIGGER T1 ON CTPX FOR INSERT, UPDATE, DELETE
AS
BEGIN
	DECLARE @sl INT
	SET @sl =
		(SELECT COUNT(MaPX) FROM CTPX GROUP BY MaPX HAVING MaPX = (SELECT MaPX FROM inserted))
		+ (SELECT COUNT(MaPX) FROM inserted GROUP BY MaPX HAVING MaPX = (SELECT MaPX FROM inserted))
	IF (@sl > 5)
		BEGIN
			PRINT N'Chỉ cho phép một phiếu xuất có tối đa 5 chi tiết phiếu xuất'
			ROLLBACK TRANSACTION
		END
END
DROP TRIGGER T1
SELECT * FROM CTPX
INSERT INTO CTPX VALUES (1, 4, 10)
INSERT INTO CTPX VALUES (1, 6, 15),
 (1, 6, 15)
DELETE FROM CTPX
WHERE MaPX = 1 AND MaSP = '6'
--2.Chỉ cho phép một nhân viên lập tối đa 10 phiếu xuất trong một ngày.
SELECT * FROM PHIEUXUAT
--3.Khi người dùng viết 1 câu truy vấn nhập 1 dòng cho bảng chi tiết phiếu xuất
--thì CSDL kiểm tra, nếu mã phiếu xuất mới đó chưa tồn tại trong bảng phiếu xuất
--thì CSDL sẽ không cho phép nhập và thông báo lỗi “Phiếu xuất này không tồn tại”.
--Hãy viết 1 trigger đảm bảo điều này.
