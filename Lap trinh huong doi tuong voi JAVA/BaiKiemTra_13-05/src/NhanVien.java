import java.util.Scanner;

public abstract class NhanVien {

	protected int maNV;
	protected String tenNV;
	protected int namSinh;
	protected String trinhDo;
	protected double luongCB;

	protected abstract double tinhLuong();

	// set, get
	public int getMaNV() {
		return maNV;
	}

	public void setMaNV(int maNV) {
		this.maNV = maNV;
	}

	public String getTenNV() {
		return tenNV;
	}

	public void setTenNV(String tenNV) {
		this.tenNV = tenNV;
	}

	public int getNamSinh() {
		return namSinh;
	}

	public void setNamSinh(int namSinh) {
		this.namSinh = namSinh;
	}

	public String getTrinhDo() {
		return trinhDo;
	}

	public void setTrinhDo(String trinhDo) {
		this.trinhDo = trinhDo;
	}

	public double getLuongCB() {
		return luongCB;
	}

	public void setLuongCB(double luongCB) {
		this.luongCB = luongCB;
	}

	// contructor
	public NhanVien() {
		this.maNV = 1;
		this.tenNV = "Nguyen";
		this.namSinh = 2022;
		this.trinhDo = "quan ly";
		this.luongCB = 1000000;
	}

	public NhanVien(int maNV, String tenNV, int namSinh, String trinhDo, double luongCB) {
		this.maNV = maNV;
		this.tenNV = tenNV;
		this.namSinh = namSinh;
		this.trinhDo = trinhDo;
		this.luongCB = luongCB;
	}

	// method
	public void input() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap ma NV: ");
		this.maNV = sc.nextInt();
		sc.nextLine();
		System.out.print("Nhap ten NV: ");
		this.tenNV = sc.nextLine();
		
		do {
			System.out.print("Nhap nam sinh NV: ");
			this.namSinh = sc.nextInt();
		} while (this.namSinh <= 0);
		
		sc.nextLine();
		System.out.print("Nhap trinh do NV: ");
		this.trinhDo = sc.nextLine();
		
		do {
			System.out.print("Nhap luong co ban NV: ");
			this.luongCB = sc.nextDouble();
		} while (this.luongCB <= 0);
		sc.nextLine();
	}

	public String output() {
		return "Ma nv: " + this.maNV + ", ten nv: " + this.tenNV + ", nam sinh: " + this.namSinh + ", trinh do: "
				+ this.trinhDo + ", luong cb: " + this.luongCB;
	}

}
