--7.1 Tạo sp cho biết tổng số đơn hàng theo từng nhân viên

CREATE PROC sp_TongDonDangTheoNV
AS
    BEGIN
        SELECT NhanVienID, COUNT(DonHangID) AS [Tong so don hang]
        FROM DONHANG
        GROUP BY NhanVienID;
    END
EXEC sp_TongDonDangTheoNV
DROP PROC sp_TongDonDangTheoNV


--7.9 Tạo sp thêm một sản phẩm vào bảng Sản Phẩm
CREATE PROC sp_ThemSP
	@spid INT, @tensp NVARCHAR(70), @cungcapid INT, @danhmucid INT, @donvi NVARCHAR(10), @gia FLOAT
AS
	BEGIN
		INSERT INTO SANPHAM
		VALUES
			(@spid, @tensp, @cungcapid, @danhmucid, @donvi, @gia)
	END
EXEC sp_ThemSP 1000, N'Tăng lực Monster', 1, 1, N'chai', 35000

DECLARE @var1 NVARCHAR(20)
SET @var1 = 'Demo'
SELECT @var1 AS TEST


--7.6 Tạo sp cập nhật thông tin họ tên khách hàng theo mã khách hàng tùy ý.

CREATE PROC sp_CapNhatHoTenKH @khid INT, @hotenkh NVARCHAR(50)
AS
	BEGIN
		UPDATE KHACHHANG
		SET HoTen = @hotenkh
		WHERE KhachHangID=@khid
	END
EXEC sp_CapNhatHoTenKH 91, N'Ngyễn Cường'


--7.7 Tạo sp xóa nhân viên theo mã nhân viên được nhập vào,
--nếu không xóa được thì thông báo "Không xóa được."

CREATE PROC sp_XoaNV @manv INT
AS
	BEGIN
		IF (@manv NOT IN (SELECT NhanVienID FROM NHANVIEN WHERE NhanVienID=@manv))
			PRINT 'KHONG XOA DUOC'
		ELSE IF (@manv IN (SELECT NhanVienID FROM DONHANG)) --update cause conflicted FK
			PRINT 'KHONG XOA DUOC VI ' + CAST(@manv AS VARCHAR(5)) + ' TON TAI TRONG BANG DONHANG' 
		ELSE
			BEGIN
			DELETE FROM NHANVIEN
			WHERE NhanVienID=@manv
			PRINT 'XOA THANH CONG' --cau lenh thu 2 cua else
			END
	END
DROP PROC sp_XoaNV
ALTER PROC sp_XoaNV
EXEC sp_XoaNV 11 --khong xoa duoc
EXEC sp_XoaNV 9 --The DELETE statement conflicted with the REFERENCE constraint "FK_NHANVIENID"
EXEC sp_XoaNV 10


--7.5 Tạo sp cho biết thông tin: Tên khách hàng, tên nhân viên, ngày đặt hàng
--theo mã đơn hàng và mã shipper tùy ý.
ALTER PROC sp_ThongTin @madh INT, @mashipper INT
AS
	IF @madh NOT IN (SELECT DonHangID FROM DONHANG)
		PRINT 'Don hang da nhap khong ton tai'
	ELSE IF @mashipper NOT IN (SELECT DISTINCT ShipperID FROM DONHANG)
		PRINT 'Shiper ID da nhap khong ton tai'
	ELSE
		BEGIN
			SELECT
				KHACHHANG.HoTen AS [Ho ten KH],
				(NHANVIEN.Ho + NHANVIEN.Ten) AS [Ho ten NV],
				NgayDatHang
			FROM DONHANG, KHACHHANG, NHANVIEN
			WHERE (DONHANG.KhachHangID=KHACHHANG.KhachHangID
				AND DONHANG.NhanVienID=NHANVIEN.NhanVienID)
				AND DonHangID=@madh
				AND ShipperID=@mashipper
		END
EXEC sp_ThongTin 102489, 1000 --loi
EXEC sp_ThongTin 10248, 3 --ok
EXEC sp_ThongTin 10248, 10 --loi
