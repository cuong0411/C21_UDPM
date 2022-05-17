import java.util.ArrayList;
import java.util.Scanner;

public class DanhSachNV {

	private ArrayList<NhanVien> dsNhanVien = new ArrayList<NhanVien>();

	public void inputList() {
		NhanVien x;
		Scanner sc = new Scanner(System.in);
		int chose;
		do {

			System.out
					.println("input 1 - Nhan vien quan ly, 2 - Nhan vien nghien cuu, 3 - Nhan vien phuc vu, 0 - Thoat");
			chose = sc.nextInt();

			switch (chose) {
			case 0:
				break;
			case 1:
				x = new NVQuanLy();
				x.input();
				dsNhanVien.add(x);
				break;
			case 2:
				x = new NVNghienCuu();
				x.input();
				dsNhanVien.add(x);
				break;
			case 3:
				x = new NVPhucVu();
				x.input();
				dsNhanVien.add(x);
				break;
			default:
				System.out.println("So da nhap khong hop le");
				break;
			}
		} while (chose != 0);
	}

	public void outputList() {
		for (NhanVien x : dsNhanVien) {
			System.out.println(x.output());
		}
	}
	public void inLuong() {
		for (NhanVien x: dsNhanVien) {
			System.out.println(x.getTenNV() + "co luong: " + x.tinhLuong());
		}
	}
	
	public double tinhTongLuong() {
		double tongLuong = 0;
		for (NhanVien x: dsNhanVien) {
			tongLuong += x.tinhLuong();
		}
		return tongLuong;
	}
	
	public void soLuongNV() {
		int slNVQuanLy = 0;
		int slNVNghienCuu = 0;
		int slNVPhucVu = 0;
		
		for (NhanVien x: dsNhanVien) {
			if (x instanceof NVQuanLy) {
				slNVQuanLy++;
			} else if (x instanceof NVNghienCuu) {
				slNVNghienCuu++;
			} else {
				slNVPhucVu++;
			}
		}
		System.out.println("NV quan ly: " + slNVQuanLy +
							"\nNV nghien cuu: " + slNVNghienCuu +
							"\nNV phuc vu: " + slNVPhucVu);
	}

}
