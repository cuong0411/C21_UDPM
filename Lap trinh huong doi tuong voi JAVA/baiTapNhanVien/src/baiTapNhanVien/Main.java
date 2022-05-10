package baiTapNhanVien;

public class Main {

	public static void main(String[] args) {
		
//		Nguoi nguoi = new Nguoi("Cuong", "1996");
//		System.out.println(nguoi.xuat());
//		
//		HocVien hv = new HocVien();
//		System.out.println(hv.xuat());
//		
//		PhongBanKhoa pbk = new PhongBanKhoa();
//		System.out.println(pbk.xuat());
//		
//		NhanVien nv = new NhanVien();
//		System.out.println(nv.xuat());
		
		NVQuanLy nvql = new NVQuanLy(30);
		System.out.println("Luong nvql = " + nvql.tinhLuong());
		
		GiaoVien gv = new GiaoVien(36);
		System.out.println("Luong giao vien = " + gv.tinhLuong());
		
		nvql.nhap();
		nvql.xuat();
		System.out.println("Luong nvql = " + nvql.tinhLuong());
		

	}

}
