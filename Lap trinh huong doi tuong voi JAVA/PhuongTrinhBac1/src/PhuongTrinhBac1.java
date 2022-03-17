import java.util.Scanner;

public class PhuongTrinhBac1 {

	public static void main(String[] args) {
		
		int a, b;
		Scanner input = new Scanner(System.in);
		System.out.print("Nhap a = ");
		a = input.nextInt();
		System.out.print("Nhap b = ");
		b = input.nextInt();
		input.close();
		
		if (a == 0) {
			if (b == 0) {
				System.out.println("Phuong trinh vo so nghiem");
			} else {
				System.out.println("Phuong trinh vo nghiem");
			}
		} else {
			float nghiem;
			nghiem = (float) -b / a;
			System.out.format("Phuong trinh %d*x + %d = 0 co 1 nghiem x = %.2f",
					a, b, nghiem);
		}

	}

}
