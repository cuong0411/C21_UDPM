-- 1.Function F1 có 2 tham số vào là: tên sản phẩm, năm.
-- Function cho biết: số lượng xuất kho của tên sản phẩm đó trong năm này.
-- (Chú ý: Nếu tên sản phẩm đó không tồn tại thì phải trả về 0)
ALTER FUNCTION F1 (@TENSP NVARCHAR(20), @NAM INT)
RETURNS INT
AS
BEGIN
    DECLARE @SL INT
    IF @TENSP NOT IN (SELECT TenSP FROM SANPHAM)
        BEGIN
            SET @SL = 0
        END
    ELSE
        BEGIN
            SET @SL =
                (
                    SELECT SUM(ct.SoLuong)
                    FROM SANPHAM sp, CTPX ct, PHIEUXUAT px
                    WHERE sp.MaSP = ct.MaSP AND ct.MaPX = px.MaPX
                        AND sp.TenSP = @TENSP
                        AND YEAR(px.NgayLap) = @NAM
                    GROUP BY sp.TenSP
                )
        END
    RETURN @SL
END
DECLARE @TENSP NVARCHAR(20)
SET @TENSP = N'Xi măng'
PRINT 'So luong cua ' + @TENSP + ' la ' + STR(dbo.F1(@TENSP, 2010))
-- 2.Function F2 có 1 tham số nhận vào là mã nhân viên.
-- Function trả về số lượng phiếu xuất của nhân viên truyền vào.
-- Nếu nhân viên này không tồn tại thì trả về 0.
CREATE FUNCTION F2 (@MANV CHAR(5))
RETURNS INT
AS
BEGIN
    DECLARE @SL INT
    IF @MANV NOT IN (SELECT MaNV FROM NHANVIEN)
        SET @SL = 0
    ELSE
        SET @SL =
        (
            SELECT COUNT(px.MaPX)
            FROM NHANVIEN nv, PHIEUXUAT px
            WHERE nv.MaNV = px.MaNV AND nv.MaNV = @MANV
            GROUP BY nv.MaNV
        )
    RETURN @SL
END
PRINT 'So luong phieu xuat: ' + STR(dbo.F2('NV06'))
-- 3.Function F3 có 1 tham số vào là năm,
-- trả về danh sách các sản phẩm được xuất trong năm truyền vào. 
CREATE FUNCTION F3 (@NAM INT)
RETURNS TABLE
AS
    RETURN
        (
            SELECT DISTINCT(sp.TenSP)
            FROM SANPHAM sp, CTPX ct, PHIEUXUAT px
            WHERE sp.MaSP = ct.MaSP AND ct.MaPX = px.MaPX
                AND YEAR(px.NgayLap) = @NAM
        )
SELECT * FROM dbo.F3(2010)
-- 4.Function F4 có một tham số vào là mã nhân viên
-- để trả về danh sách các phiếu xuất của nhân viên đó.
-- Nếu mã nhân viên không truyền vào thì trả về tất cả các phiếu xuất.
CREATE FUNCTION F4 (@MANV CHAR(5))
    RETURNS @pPHIEUXUAT TABLE (
        MaPX INT,
        NgayLap DATE,
        MaNV CHAR(5)
    )
AS
BEGIN
    IF @MANV IS NULL
        BEGIN
            INSERT INTO @pPHIEUXUAT
            SELECT * FROM PHIEUXUAT
        END
    ELSE
        BEGIN
            INSERT INTO @pPHIEUXUAT
            SELECT * FROM PHIEUXUAT WHERE MaNV = @MANV
        END
    RETURN
END
SELECT * FROM dbo.F4('NV01')
-- 5.Function F5 để cho biết tên nhân viên của một phiếu xuất
-- có mã phiếu xuất là tham số truyền vào.
CREATE FUNCTION F5 (@MAPX CHAR(5))
RETURNS NVARCHAR(20)
AS
BEGIN
    DECLARE @TEN NVARCHAR(20)
    SET @TEN =
    (
        SELECT HoTen
    FROM NHANVIEN
    WHERE MaNV = (SELECT MaNV FROM PHIEUXUAT WHERE MaPX = @MAPX)
    )
    RETURN @TEN
END
PRINT 'TEN: ' + (dbo.F5(1))
-- 6.Function F6 để cho biết danh sách các phiếu xuất
-- từ ngày T1 đến ngày T2. (T1, T2 là tham số truyền vào).
-- Chú ý: T1 <= T2.
CREATE FUNCTION F6 (@T1 INT, @T2 INT)
RETURNS @pPHIEUXUAT TABLE (
        MaPX INT,
        NgayLap DATE,
        MaNV CHAR(5)
    )
AS
BEGIN
    IF @T1 <= @T2
        BEGIN
            INSERT INTO @pPHIEUXUAT
            SELECT * FROM PHIEUXUAT WHERE DAY(NgayLap) BETWEEN @T1 AND @T2
        END
    RETURN
END
SELECT * FROM dbo.F6(1, 10)
-- 7.Function F7 để cho biết ngày xuất của một phiếu xuất
-- với mã phiếu xuất là tham số truyền vào.
CREATE FUNCTION F7 (@MAPX CHAR(5))
RETURNS INT
AS
BEGIN
    DECLARE @NGAY INT
    SET @NGAY =
    (
        SELECT DAY(NgayLap)
        FROM PHIEUXUAT
        WHERE MaPX = @MAPX
    )
    RETURN @NGAY
END
PRINT 'NGAY: ' + STR(dbo.F7(1))