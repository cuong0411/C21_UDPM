package baiTapNhanVien;

import java.util.Scanner;

public class HocVien extends Nguoi {

	private double point1;
	private double point2;
	private double point3;

	public double getPoint1() {
		return point1;
	}

	public void setPoint1(double point1) {
		this.point1 = point1;
	}

	public double getPoint2() {
		return point2;
	}

	public void setPoint2(double point2) {
		this.point2 = point2;
	}

	public double getPoint3() {
		return point3;
	}

	public void setPoint3(double point3) {
		this.point3 = point3;
	}

	public HocVien() {
		super();
		this.point1 = 10;
		this.point2 = 9;
		this.point3 = 8;
	}

	public HocVien(String ten, String namSinh, double point1, double point2, double point3) {
		super(ten, namSinh);
		this.point1 = point1;
		this.point2 = point2;
		this.point3 = point3;
	}

	public void nhap() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap diem 1: ");
		this.point1 = sc.nextDouble();
		System.out.print("Nhap diem 2: ");
		this.point2 = sc.nextDouble();
		System.out.print("Nhap diem 3: ");
		this.point3 = sc.nextDouble();
		sc.nextLine();
	}

	public String xuat() {
		return super.xuat() + ", diem1= " + this.point1 + ", diem2= " + this.point2 + ", diem3= " + this.point3;
	}

}
