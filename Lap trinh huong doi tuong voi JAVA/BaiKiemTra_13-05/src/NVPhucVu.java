
public class NVPhucVu extends NhanVien {

	// constructor
	public NVPhucVu() {
		super();
	}

	public NVPhucVu(int maNV, String tenNV, int namSinh, String trinhDo, double luongCB) {
		super(maNV, tenNV, namSinh, trinhDo, luongCB);
	}

	// method
	public void input() {
		super.input();
	}

	public String output() {
		return super.output();
	}

	public double tinhLuong() {
		return this.luongCB;
	}

}
