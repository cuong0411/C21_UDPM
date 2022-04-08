import java.util.Scanner;

public class TamGiac {

    private int canhThuNhat;
    private int canhThuHai;
    private int canhThuBa;

    public TamGiac() {
        this.canhThuNhat = 3;
        this.canhThuHai = 4;
        this.canhThuBa = 5;
    }

    public TamGiac(int canhThuNhat, int canhThuHai, int canhThuBa) {
        this.canhThuNhat = canhThuNhat;
        this.canhThuHai = canhThuHai;
        this.canhThuBa = canhThuBa;
    }

    public double tinhDT() {
        double p = this.tinhCV() / 2;
        return Math.sqrt(p * (p - canhThuNhat) * (p - canhThuHai) * (p - canhThuBa));
    }

    public long tinhCV() {
        return canhThuNhat + canhThuHai + canhThuBa;
    }

    private boolean LaTamGiac() {
        return canhThuNhat + canhThuHai > canhThuBa &&
                canhThuHai + canhThuBa > canhThuNhat &&
                canhThuBa + canhThuNhat > canhThuHai;
    }

    private boolean LaTamGiacDeu() {
        return canhThuNhat == canhThuHai && canhThuNhat == canhThuBa && canhThuHai == canhThuBa;
    }

    private boolean LaTamGiacVuong() {
        return canhThuNhat * canhThuNhat == canhThuHai * canhThuHai + canhThuBa * canhThuBa ||
                canhThuHai * canhThuHai == canhThuNhat * canhThuNhat + canhThuBa * canhThuBa ||
                canhThuBa * canhThuBa == canhThuNhat * canhThuNhat + canhThuHai * canhThuHai;
    }

    private boolean LaTamGiacCan() {
        return canhThuNhat == canhThuHai || canhThuNhat == canhThuBa || canhThuHai == canhThuBa;
    }

    private String loaiTamGiac() {
        String thongBao = "Day la tam giac thuong";
        if (LaTamGiac() == false) {
            thongBao = "Khong tao thanh tam giac";
            return thongBao;
        }
        if (LaTamGiacDeu() == true) {
            thongBao = "Day la tam giac deu";
            return thongBao;
        }
        if (LaTamGiacDeu() == true && LaTamGiacVuong() == true) {
            thongBao = "Day la tam giac vuong can";
            return thongBao;
        }
        if (LaTamGiacCan() == true) {
            thongBao = "Day la tam giac can";
            return thongBao;
        }
        if (LaTamGiacVuong() == true) {
            thongBao = "Day la tam giac vuong";
            return thongBao;
        }
        return thongBao;
    }

    public void xuatLoaiTamGiac() {
        System.out.println(this.loaiTamGiac());
    }

    public void nhapTamGiac() {
        Scanner input = new Scanner(System.in);
        System.out.print("Canh #1: ");
        this.canhThuNhat = input.nextInt();
        System.out.print("Canh #2: ");
        this.canhThuHai = input.nextInt();
        System.out.print("Canh #3: ");
        this.canhThuBa = input.nextInt();
    }

    public void xuatTamGiac() {
        System.out.println("canh #1= " + this.canhThuNhat + ", canh #2= " + this.canhThuHai + ", canh #3= " +this.canhThuBa);
    }

}
