import java.util.Scanner;

public class NVQuanLy extends NhanVien {

	private String truongDaoTao;
	private String chuyenMon;
	private double phuCapCV;

	// set, get
	public String getTruongDaoTao() {
		return truongDaoTao;
	}

	public void setTruongDaoTao(String truongDaoTao) {
		this.truongDaoTao = truongDaoTao;
	}

	public String getChuyenMon() {
		return chuyenMon;
	}

	public void setChuyenMon(String chuyenMon) {
		this.chuyenMon = chuyenMon;
	}

	public double getPhuCapCV() {
		return phuCapCV;
	}

	public void setPhuCapCV(double phuCapCV) {
		this.phuCapCV = phuCapCV;
	}

	// constructor
	public NVQuanLy() {
		super();
		this.truongDaoTao = "truong dao tao";
		this.chuyenMon = "chuyen mon";
		this.phuCapCV = 500000;
	}

	public NVQuanLy(int maNV, String tenNV, int namSinh, String trinhDo, double luongCB, String truongDaoTao,
			String chuyenMon, double phuCapCV) {
		super(maNV, tenNV, namSinh, trinhDo, luongCB);
		this.truongDaoTao = truongDaoTao;
		this.chuyenMon = chuyenMon;
		this.phuCapCV = phuCapCV;
	}

	// method
	public void input() {
		super.input();
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap truong dao tao: ");
		this.truongDaoTao = sc.nextLine();
		System.out.print("Nhap chuyen mon: ");
		this.chuyenMon = sc.nextLine();
		do {
			System.out.print("Nhap phu cap chuc vu: ");
			this.phuCapCV = sc.nextDouble();
		} while (this.phuCapCV <= 0);
		sc.nextLine();

	}

	public String output() {
		return super.output() + ", truong dao tao: " + this.truongDaoTao + ", chuyen mon: " + this.chuyenMon
				+ ", phu cap chuc vu: " + this.phuCapCV;
	}

	public double tinhLuong() {
		return this.luongCB + this.phuCapCV;
	}

}
