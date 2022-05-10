package baiTapNhanVien;

import java.util.Scanner;

public class GiaoVien extends NhanVienCLCao {

	private double thuLaoGD;

	public double getThuLaoGD() {
		return thuLaoGD;
	}

	public void setThuLaoGD(double thuLaoGD) {
		this.thuLaoGD = thuLaoGD;
	}

	public GiaoVien(double thuLaoGD) {
		super();
		this.thuLaoGD = thuLaoGD;
	}

	public GiaoVien() {
		super();
		this.thuLaoGD = 100;
	}

	public void nhap() {
		super.nhap();
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap thu lao giang day: ");
		this.thuLaoGD = sc.nextDouble();
		sc.nextLine();
	}

	public String xuat() {
		return super.xuat() + ", thu lao giang day= " + this.thuLaoGD;
	}

	public double tinhLuong() {
		return this.luong + this.thuLaoGD;
	}

}
