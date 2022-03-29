import java.util.Scanner;

public class NhanVien {

    // fields
    private static Scanner scanner = new Scanner(System.in);
    private String maSo;
    private String hoTen;
    private double LuongCoBan;
    private float heSoLuong;

    // constructor rong
    public NhanVien() {
        this.maSo = "000";
        this.hoTen = "xxx";
        this.LuongCoBan = 1200000;
        this.heSoLuong = 1f;
    }

    // constructor co tham so
    public NhanVien(String maSo, String hoTen, double luongCoBan, float heSoLuong) {
        this.maSo = maSo;
        this.hoTen = hoTen;
        this.LuongCoBan = luongCoBan;
        this.heSoLuong = heSoLuong;
    }

    // constructor sao chep
    public NhanVien(NhanVien nv) {
        this.maSo = nv.maSo;
        this.hoTen = nv.hoTen;
        this.LuongCoBan = nv.LuongCoBan;
        this.heSoLuong = nv.heSoLuong;
    }

    // setters, getters
    public String getMaSo() {
        return maSo;
    }
    public void setMaSo(String maSo) {
        this.maSo = maSo;
    }
    public String getHoTen() {
        return hoTen;
    }
    public void setHoTen(String hoTen) {
        this.hoTen = hoTen;
    }
    public double getLuongCoBan() {
        return LuongCoBan;
    }
    public void setLuongCoBan(double luongCoBan) {
        LuongCoBan = luongCoBan;
    }
    public float getHeSoLuong() {
        return heSoLuong;
    }
    public void setHeSoLuong(float heSoLuong) {
        this.heSoLuong = heSoLuong;
    }

    // toString() method
    @Override
    public String toString() {
        return "[Ma so: " + this.maSo + ", ho ten: " + this.hoTen + ", luong: " + this.tinhLuong();
    }

    public void input() {
        
        System.out.print("Nhap ma so nhan vien: ");
        this.maSo = scanner.nextLine();
        System.out.print("Nhap ho ten nhan vien: ");
        this.hoTen = scanner.nextLine();
        System.out.print("Nhap luong co ban: ");
        this.LuongCoBan = scanner.nextLong();
        System.out.print("Nhap he so luong: ");
        this.heSoLuong = scanner.nextFloat();
        scanner.nextLine();
    }

    public double tinhLuong() {
        return this.LuongCoBan * this.heSoLuong;
    }
    
}
