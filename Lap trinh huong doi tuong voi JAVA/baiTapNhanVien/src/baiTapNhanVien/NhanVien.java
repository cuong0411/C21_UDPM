package baiTapNhanVien;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Scanner;



public class NhanVien extends Nguoi {
	final static String DATE_FORMAT = "dd-MM-yyyy";

	protected double luong;
	protected String ngayNhanViec;
	protected PhongBanKhoa pbk;

	public double getLuong() {
		return luong;
	}

	public void setLuong(double luong) {
		this.luong = luong;
	}

	public String getNgayNhanViec() {
		return ngayNhanViec;
	}

	public void setNgayNhanViec(String ngayNhanViec) {
		this.ngayNhanViec = ngayNhanViec;
	}

	public PhongBanKhoa getPbk() {
		return pbk;
	}

	public void setPbk(PhongBanKhoa pbk) {
		this.pbk = pbk;
	}

	public NhanVien(String ten, String namSinh, double luong, String ngayNhanViec, PhongBanKhoa pbk) {
		super(ten, namSinh);
		this.luong = luong;
		this.ngayNhanViec = ngayNhanViec;
		this.pbk = pbk;
	}

	public NhanVien() {
		super();
		this.luong = 100;
		this.ngayNhanViec = "06-05-2022";
		this.pbk = new PhongBanKhoa();
	}

	public void nhap() {
		super.nhap();
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap luong: ");
		this.luong = sc.nextDouble();
		sc.nextLine();
		System.out.print("Nhap ngay nhan viec: ");
		this.ngayNhanViec = sc.nextLine();
		this.pbk.nhap();
	}

	public String xuat() {
		return super.xuat() + ", luong= " + this.luong + ", ngay nhan viec= " + this.ngayNhanViec + ". "
				+ this.pbk.xuat();
	}
	public static boolean isDateValid(String date) 
	{
	        try {
	            DateFormat df = new SimpleDateFormat(DATE_FORMAT);
	            df.setLenient(false);
	            df.parse(date);
	            return true;
	        } catch (ParseException e) {
	            return false;
	        }
	}

}
