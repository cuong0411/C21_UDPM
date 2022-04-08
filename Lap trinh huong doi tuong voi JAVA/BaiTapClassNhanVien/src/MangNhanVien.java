import java.util.Scanner;

public class MangNhanVien {
    private static Scanner scanner = new Scanner(System.in);
    private NhanVien danhSachNV[];
    private int soLuongNV;

    public void nhapMangNV() {
        do {
            System.out.print("Nhap so luong NV: ");
            this.soLuongNV = scanner.nextInt();
        } while (this.soLuongNV <= 0);

        this.danhSachNV = new NhanVien[this.soLuongNV];
        for (int i = 0; i < soLuongNV; i++) {
            // this.n=new NhanVien();
            System.out.print("Nhap NV #" + (i + 1) + "\n");
            danhSachNV[i] = new NhanVien();
            danhSachNV[i].input();
        }
    }

    public void xuatMangNV() {
        for (int i = 0; i < this.soLuongNV; i++) {
            System.out.println(danhSachNV[i].toString());
        }
    }


}
