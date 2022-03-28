--TAO VIEW

--1.Hiển thị danh sách các khách hàng có địa chỉ là “Tân Bình”
--gồm mã khách hàng, tên khách hàng, địa chỉ, điện thoại, và địa chỉ E-mail.
CREATE VIEW KH_TANBINH
AS
	SELECT * FROM DBO.KHACHHANG
	WHERE DIACHIKH = N'Tân Bình'
GO
--2.Hiển thị danh sách các khách hàng gồm các thông tin mã khách hàng,
--tên khách hàng, địa chỉ và địa chỉ E-mail của những khách hàng chưa có số điện thoại.
CREATE VIEW KH_CHUA_CO_SDT
AS
	SELECT MAKH, TENKH, DIACHIKH, EMAIL
	FROM DBO.KHACHHANG
	WHERE DT IS NULL
GO