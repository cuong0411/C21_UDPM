import java.util.Scanner;

public class HangThucPham extends HangHoa {

	private String ngaySanXuat;
	private String ngayHetHan;

	public String getNgaySanXuat() {
		return ngaySanXuat;
	}

	public void setNgaySanXuat(String ngaySanXuat) {
		this.ngaySanXuat = ngaySanXuat;
	}

	public String getNgayHetHan() {
		return ngayHetHan;
	}

	public void setNgayHetHan(String ngayHetHan) {
		this.ngayHetHan = ngayHetHan;
	}

	public HangThucPham() {
		this.ngaySanXuat = "ngay san xuat";
		this.ngayHetHan = "ngay het han";
	}

	public HangThucPham(String ngaySanXuat, String ngayHetHan) {
		super();
		this.ngaySanXuat = ngaySanXuat;
		this.ngayHetHan = ngayHetHan;
	}

	public void nhap() {
		super.nhap();
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap ngay san xuat: ");
		this.ngaySanXuat = sc.nextLine();
		System.out.print("Nhap ngay het han: ");
		this.ngayHetHan = sc.nextLine();
	}

	public String xuat() {
		return super.xuat() + ", ngay san xuat: " + this.ngaySanXuat + ", ngay het han: " + this.ngayHetHan;
	}

}
