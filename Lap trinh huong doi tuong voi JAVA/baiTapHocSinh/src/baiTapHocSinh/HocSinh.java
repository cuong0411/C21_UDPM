package baiTapHocSinh;
import java.util.Scanner;

public class HocSinh {
    private static Scanner scanner = new Scanner(System.in);
    private int maSo;
    private String hoTen;
    private double diemTrungBinh;

    //constructor rong
    public HocSinh() {
    	
    }
    //constructor
    public HocSinh(int maSo, String hoTen, double diemTrungBinh) {
        this.maSo = maSo;
        this.hoTen = hoTen;
        this.diemTrungBinh = diemTrungBinh;
    }
    //contructor copy
    public HocSinh(HocSinh hs) {
        this.maSo = hs.maSo;
        this.hoTen = hs.hoTen;
        this.diemTrungBinh = hs.diemTrungBinh;
    }
    public void input() {
    	System.out.print("Nhap ma so hoc sinh: ");
    	this.maSo = scanner.nextInt();
    	scanner.nextLine();
    	System.out.print("Nhap ho ten hoc sinh: ");
    	this.hoTen = scanner.nextLine();
    	System.out.print("Nhap diem trung binh cho hoc sinh: ");
    	this.diemTrungBinh = scanner.nextDouble();
    	scanner.nextLine();
    }
    public void output() {
        System.out.println("Ma so hoc sinh: " + this.maSo);
        System.out.println("Ho ten hoc sinh: " + this.hoTen);
        System.out.println("Diem trung binh hoc sinh: " + this.diemTrungBinh);
    }
    public void rank() {
        if(this.diemTrungBinh >= 8.5)
            System.out.println("Xep loai GIOI");
        else if(this.diemTrungBinh >= 6.5)
            System.out.println("Xep loai KHA");
        else if(this.diemTrungBinh >= 5)
            System.out.println("Xep loai TRUNG BINH");
        else
            System.out.println("Xep loai YEU");
    }
    //getter, setter
    public int getMaSo() {
        return maSo;
    }
    public void setMaSo(int maSo) {
        this.maSo = maSo;
    }
    public String getHoTen() {
        return hoTen;
    }
    public void setHoTen(String hoTen) {
        this.hoTen = hoTen;
    }
    public double getDiemTrungBinh() {
        return diemTrungBinh;
    }
    public void setDiemTrungBinh(double diemTrungBinh) {
        this.diemTrungBinh = diemTrungBinh;
    }
}
