import java.util.ArrayList;
import java.util.Scanner;

public class MangHangHoa {

	private ArrayList<HangHoa> dsHangHoa = new ArrayList<HangHoa>();

	public void inputList() {
		HangHoa x;
		Scanner sc = new Scanner(System.in);
		int chose;
		do {

			System.out.println("Nhap 1 - Hang dien may, 2 - Hang sanh su, 3 - Hang thuc pham, 0 - Thoat");
			chose = sc.nextInt();

			switch (chose) {
			case 0:
				break;
			case 1:
				x = new HangDienMay();
				x.nhap();
				dsHangHoa.add(x);
				break;
			case 2:
				x = new HangSanhSu();
				x.nhap();
				dsHangHoa.add(x);
				break;
			case 3:
				x = new HangThucPham();
				x.nhap();
				dsHangHoa.add(x);
				break;
			default:
				System.out.println("So da nhap khong hop le");
				break;
			}
		} while (chose != 0);
	}

	public void outputList() {
		for (HangHoa x : dsHangHoa) {
			System.out.println(x.xuat());
		}
	}

	public void slMatHang() {
		int hDienMay = 0;
		int hSanhSu = 0;
		int hThucPham = 0;

		for (HangHoa x : dsHangHoa) {
			if (x instanceof HangDienMay) {
				hDienMay++;
			} else if (x instanceof HangSanhSu) {
				hSanhSu++;
			} else {
				hThucPham++;
			}
		}
		System.out.println("Hang dien may: " + hDienMay + " cai" + ", hang sanh su: " + hSanhSu + " cai"
				+ ", hang thuc phan: " + hThucPham + " cai.");
	}

	public void timHang(String maHang) {
		for (HangHoa x : dsHangHoa) {
			if (x.maHang.equals(maHang)) {
				System.out.println(x.xuat());
				break;
			}
		}
	}
	
	public void xoaHang(String maHang) {
		for (HangHoa x : dsHangHoa) {
			if (x.maHang.equals(maHang)) {
				dsHangHoa.remove(maHang);
				break;
			}
		}
	}
	
	public void themHang(int index, HangHoa x) {
		dsHangHoa.add(index, x);
	}
	
	

}
