import java.util.Scanner;

public class NVNghienCuu extends NhanVien {
	
	private String truongDaoTao;
	private String chuyenMon;
	private double phuCapDH;
	
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
	public double getPhuCapDH() {
		return phuCapDH;
	}
	public void setPhuCapDH(double phuCapDH) {
		this.phuCapDH = phuCapDH;
	}
	
	// constructor
	public NVNghienCuu() {
		super();
		this.truongDaoTao = "truong dao tao";
		this.chuyenMon = "chuyen mon";
		this.phuCapDH = 400000;
	}
	
	public NVNghienCuu(int maNV, String tenNV, int namSinh, String trinhDo, double luongCB,
				String truongDaoTao, String chuyenMon, double phuCapDH) {
		super(maNV, tenNV, namSinh, trinhDo, luongCB);
		this.truongDaoTao = truongDaoTao;
		this.chuyenMon = chuyenMon;
		this.phuCapDH = phuCapDH;
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
			System.out.print("Nhap phu cap doc hai: ");
			this.phuCapDH = sc.nextDouble();
		} while (this.phuCapDH <= 0);
		sc.nextLine();
	}
	public String output() {
		return super.output() + ", truong dao tao: " + this.truongDaoTao + ", chuyen mon: " + this.chuyenMon
				+ ", phu cap doc hai: " + this.phuCapDH;
	}
	
	public double tinhLuong() {
		return this.luongCB + this.phuCapDH;
	}
	
	
	
	

}
