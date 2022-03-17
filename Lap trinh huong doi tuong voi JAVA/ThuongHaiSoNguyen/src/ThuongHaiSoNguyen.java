import java.util.Scanner;

public class ThuongHaiSoNguyen {

	public static void main(String[] args) {
		
		int num1, num2;
		float kq;
		Scanner input = new Scanner(System.in);
		
		System.out.print("Nhap so thu nhat: ");
		num1 = input.nextInt();
		System.out.print("Nhap so thu hai: ");
		num2 = input.nextInt();
		
		input.close();
		
		kq = (float) num1 / num2;
		
		System.out.format("Ket qua cua %d / %d = %.2f", num1, num2, kq);

	}

}
