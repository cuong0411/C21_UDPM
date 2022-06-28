--1.Mỗi ngày mỗi khách hàng chỉ đặt tối đa 2 đơn hàng.
SELECT MaKH, COUNT(SoDDH) FROM DONDH GROUP BY MaKH
--2.Mỗi đơn đặt hàng có tổng số lượng sản phẩm không quá 100.

--3.Đảm bảo rằng mỗi sản phẩm không bị lỗ hơn 50%.
