import java.util.Scanner;

public class GiaoDichDat extends GiaoDich {
	
	private double dienTich;
	private NhanVien nv;
	private char loaiDat;
	public double getDienTich() {
		return dienTich;
	}
	public void setDienTich(double dienTich) {
		this.dienTich = dienTich;
	}
	public NhanVien getNv() {
		return nv;
	}
	public void setNv(NhanVien nv) {
		this.nv = nv;
	}
	public char getLoaiDat() {
		return loaiDat;
	}
	public void setLoaiDat(char loaiDat) {
		this.loaiDat = loaiDat;
	}
	public GiaoDichDat(String maGiaoDich, String ngayGiaoDich, double donGia, double dienTich, NhanVien nv,
			char loaiDat) {
		super(maGiaoDich, ngayGiaoDich, donGia);
		this.dienTich = dienTich;
		this.nv = nv;
		this.loaiDat = loaiDat;
	}
	public GiaoDichDat() {
		super();
		this.dienTich = 100;
		this.nv = new NhanVien();
		this.loaiDat = 'A';
	}
	
	public double tinhHoaHong() {
		double tienHoaHong = (Character.toUpperCase(this.loaiDat) == 'A') ? 0.02 : 0.01;
		return tienHoaHong * this.donGia * this.dienTich;
	}
	public void input() {
		super.input();
		Scanner sc = new Scanner(System.in);
		do {
			System.out.print("Nhap loai dat (A, B, C): ");
			this.loaiDat = sc.next().charAt(0);
		} while (Character.toUpperCase(this.loaiDat) != 'A' &&
				Character.toUpperCase(this.loaiDat) != 'B' &&
				Character.toUpperCase(this.loaiDat) != 'C');
		this.nv.input();
		System.out.print("Nhap dien tich: ");
		this.dienTich = sc.nextDouble();
		sc.nextLine();
	}
	public String output() {
		return super.output() + ", loai dat: " + this.loaiDat + ", dien tich: " + this.dienTich + ". " + this.nv.output();
	}
	
	
	

}
