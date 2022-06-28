import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Scanner;

public class Demo {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		DanhSachHD ds = new DanhSachHD();

		int chose;
		System.out.println("Nhap lua chon cua ban");
		do {
			System.out.println(
					"0 - thoat, 1 - nhap ds, 2 - xuat ds, 3 - cap nhat ngay lap, 4 - xoa hoa don, 5 - tinh trung binh");
			chose = sc.nextInt();
			sc.nextLine();
			switch (chose) {
			case 0:
				break;
			case 1:
				System.out.println("Nhap ds");
				ds.nhapDS();
				break;
			case 2:
				System.out.println("Xuat ds");
				ds.xuatDS();
				break;
			case 3:
				System.out.print("Nhap ma hd de chinh sua: ");
				String maHD = sc.nextLine();
				String ngayLap;
				do {
					System.out.print("Nhap ngay chinh sua ");
					ngayLap = sc.nextLine();
				} while (checkDate(ngayLap) != 1);

				ds.CapNhatNgay(maHD, ngayLap);
				break;
			case 4:
				System.out.print("Nhap ma hd de xoa: ");
				String maHD2 = sc.nextLine();
				ds.xoaHD(maHD2);
				break;
			case 5:
				System.out.println("Tinh trung binh thanh tien theo loai hoa don");
				ds.TinhTBThanhTien();
				break;
			default:
				System.out.println("Khong hop le");
				break;
			}
		} while (chose != 0);

		// cau 2a, b
		/*
		 * ds.nhapDS(); ds.xuatDS();
		 */

		// cau 2c
		/*
		 * System.out.print("Nhap ma hd de chinh sua: "); String maHD = sc.nextLine();
		 * String ngayLap; do { System.out.print("Nhap ngay chinh sua "); ngayLap =
		 * sc.nextLine(); } while (checkDate(ngayLap) != 1);
		 * 
		 * ds.CapNhatNgay(maHD, ngayLap); ds.xuatDS();
		 */

		// cau 2d
		/*
		 * System.out.print("Nhap ma hd de xoa: "); String maHD = sc.nextLine();
		 * ds.xoaHD(maHD); ds.xuatDS();
		 */

		// cau 2e
		/*
		 * System.out.println("Tinh trung binh thanh tien theo loai hoa don");
		 * ds.TinhTBThanhTien();
		 */

	}

	public static int checkDate(String date) {
		Boolean flag = true;

		SimpleDateFormat ngay = new SimpleDateFormat("dd/mm/yyyy");
		ngay.setLenient(false);
		try {
			ngay.parse(date);
		} catch (ParseException e) {
			System.out.println("Nhap sai ngay");
			flag = false;
		}
		return (flag == true) ? 1 : 0;

	}

}
