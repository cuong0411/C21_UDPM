package baiTapNhanVien;

import java.util.Scanner;

public class NVQuanLy extends NhanVienCLCao {

	private double phuCapCV;

	public double getPhuCapCV() {
		return phuCapCV;
	}

	public void setPhuCapCV(double phuCapCV) {
		this.phuCapCV = phuCapCV;
	}

	public NVQuanLy(double phuCapCV) {
		super();
		this.phuCapCV = phuCapCV;
	}

	public NVQuanLy() {
		super();
		this.phuCapCV = 50;
	}

	public void nhap() {
		super.nhap();
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap phu cap cong viec: ");
		this.phuCapCV = sc.nextDouble();
		sc.nextLine();
	}

	public String xuat() {
		return super.xuat() + ", phu cap cong viec= " + this.phuCapCV;
	}

	public double tinhLuong() {
		return this.luong + this.phuCapCV;
	}

}
