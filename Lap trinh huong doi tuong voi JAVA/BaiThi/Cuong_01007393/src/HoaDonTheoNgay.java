import java.util.Scanner;

public class HoaDonTheoNgay extends HoaDon {

	private String loaiPhong;
	private KhachHang kh;
	private int soNgayThue;

	public String getLoaiPhong() {
		return loaiPhong;
	}

	public void setLoaiPhong(String loaiPhong) {
		this.loaiPhong = loaiPhong;
	}

	public KhachHang getKh() {
		return kh;
	}

	public void setKh(KhachHang kh) {
		this.kh = kh;
	}

	public int getSoNgayThue() {
		return soNgayThue;
	}

	public void setSoNgayThue(int soNgayThue) {
		this.soNgayThue = soNgayThue;
	}

	public HoaDonTheoNgay(String maHD, String ngayLap, String maPhong, double donGia, String loaiPhong, KhachHang kh,
			int soNgayThue) {
		super(maHD, ngayLap, maPhong, donGia);
		this.loaiPhong = loaiPhong;
		this.kh = kh;
		this.soNgayThue = soNgayThue;
	}

	public HoaDonTheoNgay() {
		super();
		this.loaiPhong = "P001";
		this.kh = new KhachHang();
		this.soNgayThue = 1;
	}

	public void nhap() {
		Scanner sc = new Scanner(System.in);
		super.nhap();
		do {
			System.out.print("Nhap loai phong (bt - binh thuong, db - dac biet): ");
			this.loaiPhong = sc.nextLine();
		} while (!this.loaiPhong.equals("bt") && !this.loaiPhong.equals("db"));
		this.kh.nhap();
		
		do {
			System.out.print("Nhap so ngay thue: ");
			this.soNgayThue = sc.nextInt();
		} while (this.soNgayThue <= 0);
		sc.nextLine();
	}

	public String xuat() {
		return super.xuat() + ", loai phong: " + this.loaiPhong + ".\n\t" + this.kh.xuat() + ", so ngay thue: "
				+ this.soNgayThue;
	}
	
	public double ThanhTien() {
		if (this.soNgayThue > 5 && this.loaiPhong.equals("db")) {
			return 5 * this.donGia + (this.soNgayThue - 5) * this.donGia * 0.9; 
		} else {
			return this.donGia * this.soNgayThue;
		}
	}

}
