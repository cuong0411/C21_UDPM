package baiTapHocSinh;
import java.util.Scanner;

public class Demo1 {
    private static Scanner scanner = new Scanner(System.in);

	public static void main(String[] args) {
		
		HocSinh hs1 = new HocSinh(1, "Ana Pham", 6.8);
        HocSinh hs2 = new HocSinh(2, "Topson", 7);
        
        soSanhHS(hs1, hs2);
        
        hs1.rank();
        hs1.output();
             
        //nhap thong tin hoc 1 hoc sinh
        HocSinh hs3 = new HocSinh();
        hs3.input();
        hs3.output();
        hs3.rank();
        //doi ten cua hoc sinh
        System.out.print("Nhap ho ten moi cho hoc sinh: ");
        hs3.setHoTen(scanner.nextLine());
        hs3.output();
        
//      //so sanh diem trung binh cua 2 hoc sinh
//      if(hs1.getDiemTrungBinh() > hs2.getDiemTrungBinh()) {
//          System.out.println(hs1.getHoTen() + " co diem trung binh lon hon");
//      } else if(hs1.getDiemTrungBinh() == hs2.getDiemTrungBinh()) {
//          System.out.println("2 hoc sinh co diem trung binh bang nhau");
//      } else {
//          System.out.println(hs2.getHoTen() + " co diem trung binh lon hon");
//      }
//        
	}
	
	public static void soSanhHS(HocSinh hs1, HocSinh hs2) {
		if(hs1.getDiemTrungBinh() > hs2.getDiemTrungBinh()) {
          System.out.println(hs1.getHoTen() + " co diem trung binh lon hon");
      } else if(hs1.getDiemTrungBinh() == hs2.getDiemTrungBinh()) {
          System.out.println("2 hoc sinh co diem trung binh bang nhau");
      } else {
          System.out.println(hs2.getHoTen() + " co diem trung binh lon hon");
      }
	}

}
