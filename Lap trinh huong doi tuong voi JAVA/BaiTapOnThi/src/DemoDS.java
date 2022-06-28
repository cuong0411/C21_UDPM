import java.util.Comparator;
import java.util.Iterator;
import java.util.Collections;

public class DemoDS {

	public static void main(String[] args) {
		
		DanhSachGiaoDich ds = new DanhSachGiaoDich();
		ds.nhapDS();
		ds.xuatDS();
		
		// ds.tongHoaHong();
		
//		// ma giao dich
//		Scanner sc = new Scanner(System.in);
//		System.out.println("Nhap ma giao dich");
//		String magd = sc.nextLine();
//		ds.xuatTheoMaGD(magd);
		
		GiaoDichDat x = new GiaoDichDat();
		x.input();
		ds.themGD(x);
		ds.xuatDS();
		
		ds.sx();
		ds.xuatDS();

	}

}
