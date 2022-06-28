import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Scanner;

public abstract class HoaDon {

	protected String maHD;
	protected String ngayLap;
	protected String maPhong;
	protected double donGia;

	public abstract double ThanhTien();

	public String getMaHD() {
		return maHD;
	}

	public void setMaHD(String maHD) {
		this.maHD = maHD;
	}

	public String getNgayLap() {
		return ngayLap;
	}

	public void setNgayLap(String ngayLap) {
		this.ngayLap = ngayLap;
	}

	public String getMaPhong() {
		return maPhong;
	}

	public void setMaPhong(String maPhong) {
		this.maPhong = maPhong;
	}

	public double getDonGia() {
		return donGia;
	}

	public void setDonGia(double donGia) {
		this.donGia = donGia;
	}

	public HoaDon(String maHD, String ngayLap, String maPhong, double donGia) {

		this.maHD = maHD;
		this.ngayLap = ngayLap;
		this.maPhong = maPhong;
		this.donGia = donGia;
	}

	public HoaDon() {

		this.maHD = "HD001";
		this.ngayLap = "17/6/22";
		this.maPhong = "P001";
		this.donGia = 100;
	}
	
	public static int checkDate(String date) {
		Boolean flag = true;

		SimpleDateFormat ngay = new SimpleDateFormat("dd/mm/yyyy");
		ngay.setLenient(false);
		try {
			ngay.parse(date);
		} catch (ParseException e) {
			System.out.println("Nhap sai ngay");
			flag = false;
		}
		return (flag == true) ? 1 : 0;

	}
	public void nhap() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap ma hoa don: ");
		this.maHD = sc.nextLine();
		do {
			System.out.print("Nhap ngay giao dich (dd/mm/yyyy): ");
			this.ngayLap = sc.nextLine();
		} while (checkDate(this.ngayLap) != 1);
		System.out.print("Nhap ma phong: ");
		this.maPhong = sc.nextLine();
		
		
		do {
			System.out.print("Nhap don gia: ");
			this.donGia = sc.nextDouble();
		} while (this.donGia <= 0);
		sc.nextLine();
	}
	
	public String xuat() {
		return "Ma hoa don: " + this.maHD + ", ngay lap: " + this.ngayLap + ", ma phong: " + this.maPhong + ", don gia: " + this.donGia;
	}

}
