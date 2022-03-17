import java.util.Scanner;

public class TinhTongS {

	public static void main(String[] args) {
		
		int num;
		double tong = 0;
		Scanner nhapLieu = new Scanner(System.in);
		System.out.print("Nhap n = ");
		num = nhapLieu.nextInt();
		nhapLieu.close();
		
		if(num <= 0)
			System.out.println("So nhap khong hop le");
		else {
			int x = 1;
			for(int i = 1; i <= num; i++) {
				x = x * i;
				tong = tong + (double) 1 / x;
			}
			System.out.println("Tong = " + tong);
		}

	}

}
