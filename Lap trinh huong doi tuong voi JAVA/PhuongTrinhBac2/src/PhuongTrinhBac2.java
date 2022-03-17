public class PhuongTrinhBac2 {
	public static void main(String[] args) {	
		int a, b, c;
		if(args.length != 3) {
			System.out.println("Tham so nhap khong hop le");
		} else {
			a = Integer.parseInt(args[0]);
			b = Integer.parseInt(args[1]);
			c = Integer.parseInt(args[2]);
			if(a == 0) {
				if (b == 0) {
					if (c == 0) {
						System.out.println("Phuong trinh vo so nghiem");
					} else {
						System.out.println("Phuong trinh vo nghiem");
					}
				} else {
					float nghiem;
					nghiem = (float) -c / b;
					System.out.format("Phuong trinh %d*x + %d = 0 co 1 nghiem x = %.2f", b, c, nghiem);
				}
			} else {
				double delta;
				delta = b*b - 4*a*c;
				if(delta < 0)
					System.out.println("Phuong trinh vo nghiem");
				else if (delta == 0) {
					double nghiem;
					nghiem = -b / (2* a);
					System.out.println("Phuong trinh co nghiem kep x1 = x2 = " + nghiem);
				} else {
					double nghiem1, nghiem2;
					nghiem1 = (-b - Math.sqrt(delta)) / (2*a);
					nghiem2 = (-b + Math.sqrt(delta)) / (2*a);
					System.out.println("Phuong trinh co 2 nghiem x1 = " + nghiem1 + " va x2 = " + nghiem2);
				}
			}
		}
	}
}
