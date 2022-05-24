create database QLSANXUAT
create table LOAI
(
	MALOAI varchar(5) primary key,
	TENLOAI nvarchar(30)
)
create table SANPHAM
(
	MASP varchar(5) primary key,
	TENSP nvarchar(30) unique,
	MALOAI varchar(5) foreign key references LOAI(MALOAI)
)
create table NHANVIEN
(
	MANV varchar(10) primary key ,
	HOTEN nvarchar (50),
	NGAYSINH date check (year(getdate())-year(NGAYSINH) between 18 and 55),
	--check (year(getdate())-year(NGAYSINH)>=18 and year(getdate())-year(NGAYSINH)<=55)
	PHAI varchar (1) check (PHAI in ('0','1')) default '0'
)
create table PHIEUXUAT
(
	MAPX int identity (1,1),--ma phieu xuat tu dong tang 
	NGAYLAP date,
	MANV varchar(10) foreign key references NHANVIEN(MANV),
	primary key(MAPX)
)
create table CTPX
(
	MAPX int foreign key references PHIEUXUAT(MAPX),
	MASP varchar(5) foreign key references SANPHAM(MASP),
	SOLUONG int check (SOLUONG>0),
	primary key(MAPX, MASP)
)
-------------------nhập liệu---------------------
insert into LOAI
values
(1, N'Vật liệu xây dựng'),
(2, N' Hàng tiêu dùng'),
(3, N' Ngũ cốc')

insert into SANPHAM
values
(1,N'Xi Măng',1),
(2,N'Gạch',1),
(3,N'Gạo Nàng Hương',3),
(4,N'Bột mì',3),
(5,N'Kệ chén',2),
(6,N'Đậu xanh',3)

set dateformat dmy
insert into NHANVIEN
values
('NV01',N'Nguyễn Mai Thi','15/5/82','0'),
('NV02',N'Trần Đình Chiến','2/12/80','1'),
('NV03',N'Lê Thị Chi','23/1/79','0')

insert into PHIEUXUAT
values
('12/3/2010','NV01'),
('3/2/2010','NV02'),
('1/6/2010','NV03'),
('16/6/2010','NV01')

insert into CTPX
values
('1','1',10),
('1','2',15),
('1','3',5),
('2','2',20),
('3','1',20),
('3','3',25),
('4','5',12)


--1. Cho biết mã sản phẩm, tên sản phẩm, tổng số lượng xuất của từng sản phẩm
--trong năm 2010. Lấy dữ liệu từ View này sắp xếp tăng dần theo tên sản
--phẩm.
	alter view c1
	as
	select s.MASP,s.TENSP,SUM(SOLUONG) as [TỔNG SL XUẤT]
	from SANPHAM s,CTPX ct,PHIEUXUAT p
	where s.MASP=ct.MASP and p.MAPX=ct.MAPX and YEAR(p.NGAYLAP)=2010
	group by s.MASP,s.TENSP
	select*from c1 order by TENSP asc 
--2. Cho biết mã sản phẩm, tên sản phẩm, tên loại sản phẩm mà đã được bán từ
--ngày 1/1/2010 đến 30/6/2010.
	alter  view c2
	as
	select s.MASP,TENSP,l.TENLOAI
	from SANPHAM s, LOAI l,PHIEUXUAT p,CTPX ct
	where l.MALOAI=s.MALOAI and ct.MASP=s.MASP and ct.MAPX=p.MAPX and NGAYLAP  between '1/1/2010' and '30/6/2010'

	select * from c2 
--3. Cho biết số lượng sản phẩm trong từng loại sản phẩm gồm các thông tin: mã
--loại sản phẩm, tên loại sản phẩm, số lượng các sản phẩm.
	create view c3
	as
	select l.MALOAI,l.TENLOAI,COUNT(MASP) as [SoLuongSP]
	from SANPHAM s , LOAI l
	where l.MALOAI=s.MALOAI
	group by l.MALOAI,l.TENLOAI

    select* from c3
--4. Cho biết tổng số lượng phiếu xuất trong tháng 6 năm 2010.
	create view c4
	as
	select COUNT(MAPX) as[TongSLPX]
	from PHIEUXUAT
	where MONTH(NGAYLAP)=6
	select*from c4
--5. Cho biết thông tin về các phiếu xuất mà nhân viên có mã NV01 đã xuất.
	create view c5
	as
	select p.MAPX,p.NGAYLAP,p.MANV,ct.MASP,ct.SOLUONG
	from CTPX ct,PHIEUXUAT p
	where ct.MAPX=p.MAPX and MANV='NV01'
	select* from c5
--6. Cho biết danh sách nhân viên nam có tuổi trên 25 nhưng dưới 30.
	create view c6
	as
	select n.HOTEN,n.MANV
	from NHANVIEN n 
	where PHAI=1 and YEAR(GETDATE())-YEAR(NGAYSINH) between 25 and 30
	select *from c6
--7. Thống kê số lượng phiếu xuất theo từng nhân viên.
	create view c7 
	as
	select n.MANV,COUNT(MAPX) as [SoLuongPhieu]
	from NHANVIEN n , PHIEUXUAT p
	where n.MANV=p.MANV
	group by n.MANV
	select*from c7
--8. Thống kê số lượng sản phẩm đã xuất theo từng sản phẩm.
	create view c8 
	as
	select ct.MASP,SUM(SOLUONG) as [SoLuongPX]
	from CTPX ct
	group by ct.MASP
	select * from c8
--9. Lấy ra tên của nhân viên có số lượng phiếu xuất lớn nhất.
	create view c9
	as
	select top(1) HOTEN,COUNT(MAPX) as [SoLuongPX]
	from NHANVIEN n , PHIEUXUAT p
	where n.MANV=p.MANV
	group by HOTEN,n.MANV
	order by COUNT(MAPX) desc
	select* from c9
--10. Lấy ra tên sản phẩm được xuất nhiều nhất trong năm 2010
	create view c10
	as
	select top(1) TENSP,SUM(SOLUONG) as [SoLuongXuat]
	from SANPHAM s,CTPX ct,PHIEUXUAT p
	where ct.MASP=s.MASP and p.MAPX=ct.MAPX and YEAR(NGAYLAP)=2010
	group by TENSP
	order by SUM(SOLUONG) desc
	select* from c10
	-------------------------------Tạo function------------------------------
--	1. Function F1 có 2 tham số vào là: tên sản phẩm, năm. Function cho biết: số
--lượng xuất kho của tên sản phẩm đó trong năm này. (Chú ý: Nếu tên sản phẩm
--đó không tồn tại thì phải trả về 0)
create function F1 (@TenSP nvarchar(50), @nNam int )
returns int 
as
begin
	declare @SOLUONG int 
	if not exists(select * from SANPHAM where TenSP=@TenSP)
		set @SOLUONG=0
	else
		set @SOLUONG=(select SUM(SOLUONG) as TongSL
						from SANPHAM s , PHIEUXUAT p , CTPX c
						where s.MaSP=c.MASP and c.MAPX=p.MaPX and s.TenSP=N'Xi Măng' and YEAR(NgayLap)=2010)
	return @SOLUONG
	end
	print N'Tổng số lượng mặt hàng theo từng năm : '+ str(dbo.F1(N'Xi Măng',2010))
	
--2. Function F2 có 1 tham số nhận vào là mã nhân viên. Function trả về số lượng
--phiếu xuất của nhân viên truyền vào. Nếu nhân viên này không tồn tại thì trả
--về 0.
	create function F2 (@MaNV varchar(5))
	returns int 
	as
	begin
		declare @SOLUONG int 
		if not exists (select * from NHANVIEN where MaNV=@MaNV)
		set @SOLUONG=0
		else
			set @SOLUONG=(select SUM(SOLUONG) as TongSL 
							from NHANVIEN n ,CTPX c , PHIEUXUAT p
							where n.MaNV=p.MaNV and p.MaPX=c.MAPX and n.MaNV='NV01')
	return @SOLUONG
	end
	print N'Tổng số lượng :'+ str(dbo.F2('NV01'))
--3. Function F3 có 1 tham số vào là năm, trả về danh sách các sản phẩm được xuất
--trong năm truyền vào.
create function F3(@Nam int)
returns table
as
	return(select s.*
	from SANPHAM s , PHIEUXUAT p , CTPX c
	where s.MaSP=c.MASP and c.MAPX=p.MaPX and YEAR(NgayLap)=@Nam)

	select * from F3(2010)
--4. Function F4 có một tham số vào là mã nhân viên để trả về danh sách các phiếu
--xuất của nhân viên đó. Nếu mã nhân viên không truyền vào thì trả về tất cả
--các phiếu xuất.
create function N4(@MaNV varchar(5))
returns @pPHIEUXUAT table 
(MaPX int ,
NgayLap date , 
MaNV varchar(5))
as
begin 
	if (@MaNV is NULL)
		insert into @pPHIEUXUAT
		select * from PHIEUXUAT
	else
		insert into @pPHIEUXUAT
		select * from PHIEUXUAT where MaNV=@MaNV
		return 
end
 select *from N4(NULL)
--5. Function F5 để cho biết tên nhân viên của một phiếu xuất có mã phiếu xuất là
--tham số truyền vào.
 create function F5 (@MaPX int )
 returns nvarchar(40)
 as
 begin
	declare @TenNV nvarchar(40)
	set @TenNV=(select HoTen	
				from NHANVIEN n ,PHIEUXUAT p
				where p.MaNV=n.MaNV and MaPX=@MaPX)
	return @TenNV
	end
	print dbo.F5(2)
--6. Function F6 để cho biết danh sách các phiếu xuất từ ngày T1 đến ngày T2. (T1,
--T2 là tham số truyền vào). Chú ý: T1 &lt;= T2.
	create function F6(@T1 int , @T2 int)
	returns @PHIEUXUAT table
	(MaPX int , NgayLap date , MaNV char(5))
	as 
	begin
	if @T1<=@T2
	insert into @PHIEUXUAT
	select * from PHIEUXUAT where DAY(NgayLap) between @T1 and @T2
	return 
	end
	select * from F6 (1,12)
--7. Function F7 để cho biết ngày xuất của một phiếu xuất với mã phiếu xuất là
--tham số truyền vào.
create function F7(@MaPX int)
returns int 
as
begin 
declare @NGAY int
set @NGAY=(select day(NgayLap) from PHIEUXUAT where MaPX=@MaPX)
return @NGAY
end
print dbo.F7(4)