import java.util.Scanner;

public class HangSanhSu extends HangHoa {

	private String loaiNguyenLieu;

	public String getLoaiNguyenLieu() {
		return loaiNguyenLieu;
	}

	public void setLoaiNguyenLieu(String loaiNguyenLieu) {
		this.loaiNguyenLieu = loaiNguyenLieu;
	}

	public HangSanhSu() {
		super();
		this.loaiNguyenLieu = "loai nguyen lieu";
	}

	public HangSanhSu(String loaiNguyenLieu) {
		super();
		this.loaiNguyenLieu = loaiNguyenLieu;
	}

	public void nhap() {
		super.nhap();
		Scanner sc = new Scanner(System.in);
		System.out.println("Nhap loai nguyen lieu: ");
		this.loaiNguyenLieu = sc.nextLine();
	}

	public String xuat() {
		return super.xuat() + ", " + ", loai nguyen lieu: " + this.loaiNguyenLieu;
	}

}
