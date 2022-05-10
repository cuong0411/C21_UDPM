package baiTapNhanVien;

import java.util.Scanner;

public class Nguoi {

	protected String ten;
	protected String namSinh;

	public String getTen() {
		return ten;
	}

	public void setTen(String ten) {
		this.ten = ten;
	}

	public String getNamSinh() {
		return namSinh;
	}

	public void setNamSinh(String namSinh) {
		this.namSinh = namSinh;
	}

	public Nguoi(String ten, String namSinh) {
		this.ten = ten;
		this.namSinh = namSinh;
	}

	public Nguoi() {
		this.ten = "ten";
		this.namSinh = "nam sinh";
	}

	public void nhap() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap ten: ");
		this.ten = sc.nextLine();
		System.out.print("Nhap nam sinh: ");
		this.namSinh = sc.nextLine();
	}

	public String xuat() {
		return "Ten= " + this.ten + ", nam sinh= " + this.namSinh;
	}
//	public String nhapNamSinh() {
//		int ngay, thang, nam;
//		int[] thang_31 = {1, 3, 5, 7, 8, 10, 12};
//		int[] thang_30 = {4, 6, 9, 11};
//		Scanner sc = new Scanner(System.in);
//		do {
//			System.out.println("Nhap nam: ");
//			nam = sc.nextInt();
//		} while (nam < 0);
//		
//		if (laNamNhuan(nam) == true) {
//			for (int thang: thang_30)
//		}
//		
//		
//	}
//	
//	boolean laNamNhuan(int nam) {
//		if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0)) {
//			return true;
//		}
//		return false;
//	}

}
