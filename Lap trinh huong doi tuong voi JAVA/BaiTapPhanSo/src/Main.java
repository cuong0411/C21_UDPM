
public class Main {

	public static void main(String[] args) {
		
//		PhanSo ps1 = new PhanSo(4, 5);
//		PhanSo ps2 = new PhanSo(3, 2);
//		PhanSo ps3 = new PhanSo(ps2);
//		PhanSo kq = new PhanSo();
//		
//		ps1.xuatPhanSo();
//		ps2.xuatPhanSo();
//		ps3.xuatPhanSo();
		
		PhanSo ps1 = new PhanSo();
		ps1.nhapPhanSo();
		PhanSo ps3 = new PhanSo();
		ps3.nhapPhanSo();
		PhanSo kq = new PhanSo();
		
		ps1.xuatPhanSo();
		ps3.xuatPhanSo();
		
		
		System.out.println("Cong: ");
		kq = ps1.congPS(ps3);
		kq.xuatPhanSo();
		System.out.println("Tru: ");
		kq = ps1.truPS(ps3);
		kq.xuatPhanSo();
		System.out.println("Nhan: ");
		kq = ps1.nhanPS(ps3);
		kq.xuatPhanSo();
		System.out.println("Chia");
		kq = ps1.chiaPS(ps3);
		kq.xuatPhanSo();
		
	}

}
