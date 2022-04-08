import java.util.Scanner;

public class DSHCN {
	protected static Scanner scanner = new Scanner(System.in);
	private Shape ds[];
	private int n;

	public DSHCN() {
	}

	public void nhapDS() {

		do {
			System.out.println("Nhap so hinh = ");
			n = scanner.nextInt();
			scanner.nextLine();
		} while (n <= 0);
		ds = new Shape[this.n];

		int select;
		for (int i = 0; i < n; i++) {
			System.out.println("1 - Rectangle, 2 - Circle");
			select = scanner.nextInt();
			scanner.nextLine();
			if (select == 1) {
				ds[i] = new Rectangle();
				ds[i].input();
			} else {
				ds[i] = new Circle();
				ds[i].input();
			}

		}
	}

	public void xuatDS() {
		for (int i = 0; i < n; i++) {
			System.out.println(ds[i].toString());
		}
	}

	public double tinhTongDT() {
		double tong = 0;
		for (int i = 0; i < n; i++) {
			if (ds[i] instanceof Rectangle) {
				tong += ((Rectangle) ds[i]).getArea();
			}

		}
		return tong;
	}

//	public Rectangle hcnCVMax() {
//		Rectangle hcnMax = new Rectangle();
//		hcnMax = ds[0];
//		double cvMax = hcnMax.getPerimeter();
//		for (int i = 1; i < n; i++) {
//			if (ds[i].getPerimeter() > cvMax) {
//				hcnMax = ds[i];
//			}
//		}
//		return hcnMax;
//	}

}
