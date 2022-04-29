
public class Main {

	public static void main(String[] args) {
		
//		NSX nsx = new NSX();
//		System.out.println(nsx.xuat());
		
//		HangHoa hh = new HangHoa();
//		System.out.println(hh.xuat());
		
//		HangDienMay hdm = new HangDienMay();
//		hdm.nhap();
//		System.out.println(hdm.xuat());
		
//		HangSanhSu hss = new HangSanhSu();
//		hss.nhap();
//		System.out.println(hss.xuat());
		
//		HangThucPham htp = new HangThucPham();
//		htp.nhap();
//		System.out.println(htp.xuat());
		
//		HangHoa htp2 = new HangThucPham();
//		htp2.nhap();
//		System.out.println(htp2.xuat());
		
		MangHangHoa ds = new MangHangHoa();
		ds.inputList();
		ds.outputList();
		ds.slMatHang();
		ds.timHang("001");
	}

}
