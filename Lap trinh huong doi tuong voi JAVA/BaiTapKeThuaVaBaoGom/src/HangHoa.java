import java.util.Scanner;

public class HangHoa {

	protected String maHang;
	protected String tenHang;
	protected NSX nsx;
	protected double gia;

	public String getMaHang() {
		return maHang;
	}

	public void setMaHang(String maHang) {
		this.maHang = maHang;
	}

	public String getTenHang() {
		return tenHang;
	}

	public void setTenHang(String tenHang) {
		this.tenHang = tenHang;
	}

	public NSX getNsx() {
		return nsx;
	}

	public void setNsx(NSX nsx) {
		this.nsx = nsx;
	}

	public double getGia() {
		return gia;
	}

	public void setGia(double gia) {
		this.gia = gia;
	}

	public HangHoa() {
		this.maHang = "ma hang";
		this.tenHang = "ten hang";
		this.nsx = new NSX();
		this.gia = 100;
	}

	public HangHoa(String maHang, String tenHang, NSX nsx, double gia) {
		this.maHang = maHang;
		this.tenHang = tenHang;
		this.nsx = nsx;
		this.gia = gia;
	}
	
	public void nhap() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap ma hang: ");
		this.maHang = sc.nextLine();
		System.out.print("Nhap ten hang: ");
		this.tenHang = sc.nextLine();
		nsx.nhap();
		System.out.print("Nhap gia: ");
		this.gia = sc.nextDouble();
		sc.nextLine();
	}
	
	public String xuat() {
		return "ma hang: " + this.maHang + ", ten hang: " + this.tenHang + ", " + nsx.xuat() + ", gia: " + this.gia;
	}

}
