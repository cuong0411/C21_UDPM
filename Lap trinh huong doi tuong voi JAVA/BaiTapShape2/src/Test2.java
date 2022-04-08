
public class Test2 {

	public static void main(String[] args) {

		DSHCN ds = new DSHCN();
		ds.nhapDS();
		ds.xuatDS();

		double tong = ds.tinhTongDT();
		System.out.println("Tong DT = " + tong);

//		Rectangle hcnMax = ds.hcnCVMax();
//		System.out.println("HCN co cv max = " + hcnMax.toString());

	}

}
