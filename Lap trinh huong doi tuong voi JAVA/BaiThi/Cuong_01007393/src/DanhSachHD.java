import java.util.ArrayList;
import java.util.Scanner;

public class DanhSachHD {

	private ArrayList<HoaDon> ds = new ArrayList<HoaDon>();

	public void nhapDS() {
		HoaDon x;
		Scanner sc = new Scanner(System.in);
		int chose;

		do {
			System.out.println("Nhap 3 - thoat, 1 - hoa don theo ngay, 2 - hoa don theo gio");
			chose = sc.nextInt();
			switch (chose) {
			case 3:
				break;
			case 1:
				x = new HoaDonTheoNgay();
				x.nhap();
				ds.add(x);
				break;
			case 2:
				x = new HoaDonTheoGio();
				x.nhap();
				ds.add(x);
				break;
			default:
				System.out.println("Khong hop le");
				break;
			}
		} while (chose != 3);
	}

	public void xuatDS() {
		for (HoaDon x : ds) {
			System.out.println(x.xuat());
		}
	}

	public void CapNhatNgay(String maHD, String ngayLap) {
		boolean flag = false;
		for (HoaDon x : ds) {
			if (x.maHD.equals(maHD)) {
				flag = true;
				x.ngayLap = ngayLap;
				break;
			}
		}
		if (flag == false) {
			System.out.println("Tim khong thay!");
		}
	}

	public void xoaHD(String maHD) {
		boolean flag = false;
		for (HoaDon x : ds) {
			if (x.maHD.equals(maHD)) {
				flag = true;
				ds.remove(x);
				break;
			}
		}
		if (flag == false) {
			System.out.println("Tim khong thay!");
		}
	}

	public void TinhTBThanhTien() {
		double ThanhTienTheoNgay = 0.0;
		int slTheoNgay = 0;
		double ThanhTienTheoGio = 0.0;
		int slTheoGio = 0;
		for (HoaDon x : ds) {
			if (x instanceof HoaDonTheoNgay) {
				double thanhTien = ((HoaDonTheoNgay) x).ThanhTien();
				ThanhTienTheoNgay += thanhTien;
				slTheoNgay++;
			} else {
				double thanhTien = ((HoaDonTheoGio) x).ThanhTien();
				ThanhTienTheoGio += thanhTien;
				slTheoGio++;
			}
		}

		if (slTheoNgay == 0) {
			System.out.println("Khong ton tai hoa don theo ngay");
		} else {
			System.out.println("Trung binh thanh tien theo ngay: " + ThanhTienTheoNgay / slTheoNgay);
		}

		if (slTheoGio == 0) {
			System.out.println("Khong ton tai hoa don theo gio");
		} else {
			System.out.println("Trung binh thanh tien theo gio: " + ThanhTienTheoGio / slTheoGio);
		}
	}

}
