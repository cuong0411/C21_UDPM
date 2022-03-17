public class App {

	public static void main(String[] args) {
		System.out.print("nhap hai phan so de tinh tong");
		PhanSo ps=new PhanSo();
		ps.nhapPS();
		//ps.RutgonPS();
		
		PhanSo ps2 = new PhanSo();
		ps2.nhapPS();
		
		ps.congPS(ps2);
		
//			//TONGHAIPHANSO
//			System.out.print("nhap hai phan so de tinh tong");
//			ps.nhapPS();
//			PhanSo ps2=new PhanSo();
//			ps2.nhapPS();
//			ps.congPS(ps2);
//			//HIEUHAIPHANSO
//			System.out.print("nhap hai phan so de tinh hieu");
//			ps.nhapPS();
//			PhanSo ps2=new PhanSo();
//			ps2.nhapPS();
//			ps.truPS(ps2);
//			//TICHHAIPHANSO
//			System.out.print("nhap hai phan so de tinh tich");
//			ps.nhapPS();
//			PhanSo ps2=new PhanSo();
//			ps2.nhapPS();
//			//THUONGHAIPHANSO
//			System.out.print("nhap hai phan so de tinh tich");
//			ps.nhapPS();
//			PhanSo ps2=new PhanSo();
//			ps2.nhapPS();
//			ps2.chiaPS(ps7);
	
	}
	}