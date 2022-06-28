import java.util.Scanner;

public class KhachHang {

	private String maKH;
	private String tenKH;
	private String soDT;

	public String getMaKH() {
		return maKH;
	}

	public void setMaKH(String maKH) {
		this.maKH = maKH;
	}

	public String getTenKH() {
		return tenKH;
	}

	public void setTenKH(String tenKH) {
		this.tenKH = tenKH;
	}

	public String getSoDT() {
		return soDT;
	}

	public void setSoDT(String soDT) {
		this.soDT = soDT;
	}

	public KhachHang(String maKH, String tenKH, String soDT) {

		this.maKH = maKH;
		this.tenKH = tenKH;
		this.soDT = soDT;
	}

	public KhachHang() {

		this.maKH = "KH001";
		this.tenKH = "Tuan";
		this.soDT = "0123456789";
	}

	public void nhap() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap ma KH: ");
		this.maKH = sc.nextLine();
		System.out.print("Nhap ten KH: ");
		this.tenKH = sc.nextLine();
		System.out.print("Nhap std KH: ");
		this.soDT = sc.nextLine();
	}

	public String xuat() {
		return "Ten ma KH: " + this.maKH + ", ten KH: " + this.tenKH + ", so dt: " + this.soDT;
	}

}
