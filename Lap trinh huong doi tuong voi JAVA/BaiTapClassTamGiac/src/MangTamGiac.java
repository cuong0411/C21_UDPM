import java.util.Scanner;

public class MangTamGiac extends TamGiac {
    
    private TamGiac mang[];
    private int soLuongTamGiac;

    public void nhapMangTamGiac() {
        Scanner input = new Scanner(System.in);
        do {
            System.out.print("Nhap so luong tam giac: ");
            this.soLuongTamGiac = input.nextInt();
        } while (this.soLuongTamGiac <= 0);

        this.mang = new TamGiac[this.soLuongTamGiac];
        for (int i = 0; i < soLuongTamGiac; i++) {
            System.out.println("Tam giac #" + i);
            mang[i] = new TamGiac();
            mang[i].nhapTamGiac();
        }
    }

    public void xuatMangTamGiac() {
        for (int i = 0; i < this.soLuongTamGiac; i++) {
            System.out.print("Tam giac #" + i + ": ");
            mang[i].xuatTamGiac();
        }
    }

    public double tbChuVi() {
        double tong = 0;
        for (int i = 0; i < this.soLuongTamGiac; i++) {
            tong += this.mang[i].tinhCV();
        }
        return tong / this.soLuongTamGiac;
    }

    public double gtDienTichMax() {
        int vtMax;
        double max = this.mang[0].tinhDT();
        for (int i = 0; i < this.soLuongTamGiac; i++) {
            if (this.mang[i].tinhDT() > max) {
                vtMax = i;
            }
        }
        return max;
    }
}
