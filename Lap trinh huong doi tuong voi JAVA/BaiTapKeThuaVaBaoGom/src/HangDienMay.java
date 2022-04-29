import java.util.Scanner;

public class HangDienMay extends HangHoa {

	private int tgBaoHang;
	private double dienAp;
	private double congSuat;

	public int getTgBaoHang() {
		return tgBaoHang;
	}

	public void setTgBaoHang(int tgBaoHang) {
		this.tgBaoHang = tgBaoHang;
	}

	public double getDienAp() {
		return dienAp;
	}

	public void setDienAp(double dienAp) {
		this.dienAp = dienAp;
	}

	public double getCongSuat() {
		return congSuat;
	}

	public void setCongSuat(double congSuat) {
		this.congSuat = congSuat;
	}

	public HangDienMay() {
		super();
		this.tgBaoHang = 12;
		this.dienAp = 7;
		this.congSuat = 2;

	}

	public HangDienMay(String maHang, String tenHang, NSX nsx, double gia, int tgBaoHang, double dienAp,
			double congSuat) {
		super(maHang, tenHang, nsx, gia);
		this.tgBaoHang = tgBaoHang;
		this.dienAp = dienAp;
		this.congSuat = congSuat;
	}

	public void nhap() {
		super.nhap();
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap thoi gian bao hanh: ");
		this.tgBaoHang = sc.nextInt();
		System.out.print("Nhap dien ap: ");
		this.dienAp = sc.nextDouble();
		System.out.print("Nhap cong suat: ");
		this.congSuat = sc.nextDouble();
		sc.nextLine();
	}

	public String xuat() {
		return super.xuat() + ", thoi gian bao hanh: " + this.tgBaoHang + ", " + this.dienAp + ", cong suat: "
				+ this.congSuat;
	}

}
