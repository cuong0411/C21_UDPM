import java.util.Scanner;

public class NhanVien {

	protected String maNV;
	protected String tenNV;
	protected String dt;

	public String getMaNV() {
		return maNV;
	}

	public void setMaNV(String maNV) {
		this.maNV = maNV;
	}

	public String getTenNV() {
		return tenNV;
	}

	public void setTenNV(String tenNV) {
		this.tenNV = tenNV;
	}

	public String getDt() {
		return dt;
	}

	public void setDt(String dt) {
		this.dt = dt;
	}

	public NhanVien(String maNV, String tenNV, String dt) {
		this.maNV = maNV;
		this.tenNV = tenNV;
		this.dt = dt;
	}

	public NhanVien() {
		this.maNV = "ma nv";
		this.tenNV = "ten nv";
		this.dt = "23423048";
	}

	public void input() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap ma NV: ");
		this.maNV = sc.nextLine();
		System.out.print("Nhap ten NV: ");
		this.tenNV = sc.nextLine();
		System.out.print("Nhap dt: ");
		this.dt = sc.nextLine();
	}

	public String output() {
		return "Ma nv: " + this.maNV + ", ten nv: " + this.tenNV + ", dt: " + this.dt;
	}

}
