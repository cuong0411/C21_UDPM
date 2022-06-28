import java.util.Scanner;

public class HoaDonTheoGio extends HoaDon {
	
	private int soGioThue;

	public int getSoGioThue() {
		return soGioThue;
	}

	public void setSoGioThue(int soGioThue) {
		this.soGioThue = soGioThue;
	}

	public HoaDonTheoGio(String maHD, String ngayLap, String maPhong, double donGia, int soGioThue) {
		super(maHD, ngayLap, maPhong, donGia);
		this.soGioThue = soGioThue;
	}

	public HoaDonTheoGio() {
		super();
		this.soGioThue = 10;
	}
	
	public void nhap() {
		super.nhap();
		Scanner sc = new Scanner(System.in);
		do {
			System.out.print("Nhap so gio thue: ");
			this.soGioThue = sc.nextInt();
		} while (this.soGioThue <= 0);
		sc.nextLine();
	}
	public String xuat() {
		return super.xuat() + ", so gio thue: " + this.soGioThue;
	}
	
	public double ThanhTien() {
		if (this.soGioThue > 24) {
			return this.soGioThue * this.donGia * 1.05;
		} else {
			return this.soGioThue * this.donGia;
		}
	}
	
	

}
