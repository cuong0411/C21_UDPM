import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.Scanner;

public class DanhSachGiaoDich {

	private ArrayList<GiaoDich> ds = new ArrayList<GiaoDich>();

	public void nhapDS() {
		GiaoDich x;
		Scanner sc = new Scanner(System.in);
		int chose;

		do {
			System.out.println("Nhap 0 - thoat, 1 - giao dich dat, 2 - giao dich nha");
			chose = sc.nextInt();
			switch (chose) {
			case 0:
				break;
			case 1:
				x = new GiaoDichDat();
				x.input();
				ds.add(x);
				break;
			case 2:
				x = new GiaoDichNha();
				x.input();
				ds.add(x);
				break;
			default:
				System.out.println("Khong hop le");
				break;
			}
		} while (chose != 0);
	}

	public void xuatDS() {
		for (GiaoDich x : ds) {
			System.out.println(x.output());
		}
	}

	public void tongHoaHong() {
		double hoaHongDat = 0;
		double hoaHongNha = 0;
		for (GiaoDich x : ds) {
			if (x instanceof GiaoDichDat) {
				hoaHongDat += x.tinhHoaHong();
			} else {
				hoaHongNha += x.tinhHoaHong();
			}
		}
		System.out.println("Tong tien hoa hong giao dich nha:  " + hoaHongNha);
		System.out.println("Tong tien hoa hong giao dich dat: " + hoaHongDat);
	}

	public void xuatTheoMaGD(String magd) {
		boolean flag = false;
		for (GiaoDich x : ds) {
			if (x.maGiaoDich.equals(magd)) {
				flag = true;
				System.out.println(x.output());
			}
		}
		if (flag == false) {
			System.out.println("Ma gd khong ton tai");
		}
	}
	public void suaDonGiaTheoMaGD(String magd, double donGia) {
		boolean flag = false;
		for (GiaoDich x : ds) {
			if (x.maGiaoDich.equals(magd)) {
				flag = true;
				x.donGia = donGia;
			}
		}
		if (flag == false) {
			System.out.println("Ma gd khong ton tai");
		}
	}

	public void themGD(GiaoDich x) {
		ds.add(x);
	}

	public void xoaTheoMaGD(String magd) {
		boolean flag = false;
		for (GiaoDich x : ds) {
			if (x.maGiaoDich.equals(magd)) {
				flag = true;
				ds.remove(x);
			}
		}
		if (flag == false) {
			System.out.println("Ma gd khong ton tai");
		}
	}
	public void sx() {
		Collections.sort(ds, new sxDonGia());
	}
	

}
