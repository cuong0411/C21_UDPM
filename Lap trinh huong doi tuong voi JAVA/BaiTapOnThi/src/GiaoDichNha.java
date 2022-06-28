import java.util.Scanner;

public class GiaoDichNha extends GiaoDich {

	private String diaChi;
	private String moTa;

	public String getDiaChi() {
		return diaChi;
	}

	public void setDiaChi(String diaChi) {
		this.diaChi = diaChi;
	}

	public String getMoTa() {
		return moTa;
	}

	public void setMoTa(String moTa) {
		this.moTa = moTa;
	}

	public GiaoDichNha(String maGiaoDich, String ngayGiaoDich, double donGia, String diaChi, String moTa) {
		super(maGiaoDich, ngayGiaoDich, donGia);
		this.diaChi = diaChi;
		this.moTa = moTa;
	}

	public GiaoDichNha() {
		super();
		this.diaChi = "dia chi";
		this.moTa = "mo ta";
	}

	public double tinhHoaHong() {
		return this.donGia * 0.05;
	}

	public void input() {
		Scanner sc = new Scanner(System.in);
		super.input();
		System.out.print("Nhap dia chi");
		this.diaChi = sc.nextLine();
		System.out.print("Nhap mo ta: ");
		this.moTa = sc.nextLine();
	}

	public String output() {
		return super.output() + ", dia chi: " + this.diaChi + ", mo ta: " + this.moTa;
	}

}
