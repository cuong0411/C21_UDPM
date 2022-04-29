import java.util.Scanner;

public class NSX {

	private String maNSX;
	private String tenNSX;
	private String sdt;

	public String getMaNSX() {
		return maNSX;
	}

	public void setMaNSX(String maNSX) {
		this.maNSX = maNSX;
	}

	public String getTenNSX() {
		return tenNSX;
	}

	public void setTenNSX(String tenNSX) {
		this.tenNSX = tenNSX;
	}

	public String getSdt() {
		return sdt;
	}

	public void setSdt(String sdt) {
		this.sdt = sdt;
	}

	public NSX() {
		this.maNSX = "ma nsx";
		this.tenNSX = "ten nsx";
		this.sdt = "sdt";
	}

	public NSX(String maNSX, String tenNSX, String sdt) {
		this.maNSX = maNSX;
		this.tenNSX = tenNSX;
		this.sdt = sdt;
	}

	public void nhap() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap ma nsx: ");
		this.maNSX = sc.nextLine();
		System.out.print("Nhap ten nsx: ");
		this.tenNSX = sc.nextLine();
		System.out.print("Nhap sdt: ");
		this.sdt = sc.nextLine();
	}

	public String xuat() {
		return "Ma nsx: " + this.maNSX + ", ten nsx: " + this.tenNSX + ", std: " + this.sdt;
	}

}
