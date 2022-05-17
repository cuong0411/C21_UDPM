import java.text.DecimalFormat;

public class Demo {

	public static void main(String[] args) {
		
		DanhSachNV ds = new DanhSachNV();
		ds.inputList();
		ds.outputList();
		
		System.out.println("Bang luong");
		ds.inLuong();
		
		// System.out.println("Tong luong nhan vien trong ds: " + ds.tinhTongLuong());
		DecimalFormat formatter = new DecimalFormat("0.00");
		System.out.println("Tong luong nhan vien trong ds: " + formatter.format(ds.tinhTongLuong()));
		
		System.out.println("So luong tung nhan vien");
		ds.soLuongNV();
	}

}
