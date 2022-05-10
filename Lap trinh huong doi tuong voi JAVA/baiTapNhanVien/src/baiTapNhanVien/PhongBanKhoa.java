package baiTapNhanVien;

import java.util.Scanner;

public class PhongBanKhoa {

	private int maPBK;
	private String tenPBk;

	public int getMaPBK() {
		return maPBK;
	}

	public void setMaPBK(int maPBK) {
		this.maPBK = maPBK;
	}

	public String getTenPBk() {
		return tenPBk;
	}

	public void setTenPBk(String tenPBk) {
		this.tenPBk = tenPBk;
	}

	public PhongBanKhoa(int maPBK, String tenPBk) {
		this.maPBK = maPBK;
		this.tenPBk = tenPBk;
	}

	public PhongBanKhoa() {
		this.maPBK = 1;
		this.tenPBk = "ten PBK";
	}

	public void nhap() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap ma PBK: ");
		this.maPBK = sc.nextInt();
		sc.nextLine();
		System.out.print("Nhap ten PBK:");
		this.tenPBk = sc.nextLine();
	}

	public String xuat() {
		return "Ma pbk= " + this.maPBK + ", ten pbk= " + this.tenPBk;
	}

}
