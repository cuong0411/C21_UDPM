-- 1.Procedure tên là P1 cho có 2 tham số sau:
-- •	1 tham số nhận vào là: tên sản phẩm.
-- •	1 tham số trả về cho biết: tổng số lượng xuất kho của tên sản phẩm này trong năm 2010
-- (Không viết lại truy vấn, hãy sử dụng Function F1 ở câu 4 để thực hiện)
CREATE PROCEDURE P1 (@TENSP NVARCHAR(20))
AS
    PRINT 'TONG SO LUONG XUAT KHO: ' + STR(dbo.F1(@TENSP, 2010))
EXEC dbo.P1 N'Xi măng'
-- 2.Procedure tên là P2 có 2 tham số sau:
-- •	1 tham số nhận vào là: tên sản phẩm.
-- •	1 tham số trả về cho biết: tổng số lượng xuất kho của tên sản phẩm này
--     trong khoảng thời gian từ đầu tháng 4/2010 đến hết tháng 6/2010
--     (Chú ý: Nếu tên sản phẩm này không tồn tại thì trả về 0)

-- 3.Procedure tên là P3 chỉ có duy nhất 1 tham số nhận vào là tên sản phẩm.
-- Trong Procedure này có khai báo 1 biến cục bộ được gán giá trị là:
-- số lượng xuất kho của tên sản phẩm này trong khoảng thời gian
-- từ đầu tháng 4/2010 đến hết tháng 6/2010.
-- Việc gán trị này chỉ được thực hiện bằng cách gọi Procedure P2.

-- 4.Procedure P4 để INSERT một record vào trong table LOAI.
-- Giá trị các field là tham số truyền vào.

-- 5.Procedure P5 để DELETE một record trong Table NhânViên theo mã nhân viên.
-- Mã NV là tham số truyền vào.
