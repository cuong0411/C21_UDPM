import java.util.Scanner;

public class ktSoNguyenTo {

	public static void main(String[] args) {
		
		int num;
		boolean isNguyenTo = true;
		Scanner input = new Scanner(System.in);
		System.out.print("Nhap so = ");
		num = input.nextInt();
		input.close();
		if(num < 2)
			isNguyenTo = false;
		else if (num == 2)
			isNguyenTo = true;
		else {
			for(int i = 2; i < num; i++) {
				if (num % i == 0) {
					isNguyenTo = false;
					break;
				}
			}
		}
		
		if(isNguyenTo)
			System.out.println(num + " la so nguyen to");
		else
			System.out.println(num + " khong la so nguyen to");
	}

}
