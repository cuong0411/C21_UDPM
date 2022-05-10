package baiTapNhanVien;

import java.util.Scanner;

public abstract class NhanVienCLCao extends NhanVien {

	protected String trinhDo;
	protected String nganh;
	protected String noiDaoTao;
	public abstract double tinhLuong();

	public String getTrinhDo() {
		return trinhDo;
	}

	public void setTrinhDo(String trinhDo) {
		this.trinhDo = trinhDo;
	}

	public String getNganh() {
		return nganh;
	}

	public void setNganh(String nganh) {
		this.nganh = nganh;
	}

	public String getNoiDaoTao() {
		return noiDaoTao;
	}

	public void setNoiDaoTao(String noiDaoTao) {
		this.noiDaoTao = noiDaoTao;
	}
	
	public NhanVienCLCao() {
		super();
		this.trinhDo = "trinh do";
		this.nganh = "nganh";
		this.noiDaoTao = "noi dao tao";
	}

	public NhanVienCLCao(String ten, String namSinh, double luong, String ngayNhanViec, PhongBanKhoa pbk,
			String trinhDo, String nganh, String noiDaoTao) {
		super(ten, namSinh, luong, ngayNhanViec, pbk);
		this.trinhDo = trinhDo;
		this.nganh = nganh;
		this.noiDaoTao = noiDaoTao;
	}
	public void nhap() {
		super.nhap();
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap trinh do: ");
		this.trinhDo = sc.nextLine();
		System.out.print("Nhap nganh: ");
		this.nganh = sc.nextLine();
		System.out.print("Nhap nao dao tao: ");
		this.noiDaoTao = sc.nextLine();
	}
	public String xuat() {
		return super.xuat() + ", " + this.trinhDo + ", " + this.nganh + ", " + this.noiDaoTao;
	}

}
