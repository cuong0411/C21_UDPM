import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Scanner;

public abstract class GiaoDich {

	protected String maGiaoDich;
	protected String ngayGiaoDich;
	protected double donGia;

	protected abstract double tinhHoaHong();

	public String getMaGiaoDich() {
		return maGiaoDich;
	}

	public void setMaGiaoDich(String maGiaoDich) {
		this.maGiaoDich = maGiaoDich;
	}

	public String getNgayGiaoDich() {
		return ngayGiaoDich;
	}

	public void setNgayGiaoDich(String ngayGiaoDich) {
		this.ngayGiaoDich = ngayGiaoDich;
	}

	public double getDonGia() {
		return donGia;
	}

	public void setDonGia(double donGia) {
		this.donGia = donGia;
	}

	public GiaoDich(String maGiaoDich, String ngayGiaoDich, double donGia) {

		this.maGiaoDich = maGiaoDich;
		this.ngayGiaoDich = ngayGiaoDich;
		this.donGia = donGia;
	}

	public GiaoDich() {
		this.maGiaoDich = "001";
		this.ngayGiaoDich = "10/06/2022";
		this.donGia = 12000;
	}

	public void input() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap ma giao dich: ");
		this.maGiaoDich = sc.nextLine();
		do {
			System.out.print("Nhap ngay giao dich (dd/mm/yyyy): ");
			this.ngayGiaoDich = sc.nextLine();
		} while (checkDate(this.ngayGiaoDich) != 1);

		System.out.print("Nhap don gia: ");
		this.donGia = sc.nextDouble();
		sc.nextLine();
	}

	public String output() {
		return "Ma GD: " + this.maGiaoDich + ", ngay GD: " + this.ngayGiaoDich + ", don gia: " + this.donGia;
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

}
