import java.util.Scanner;

public class Demo {
    public static Scanner scanner = new Scanner(System.in);
    public static void main(String[] args) {
        
        
        NhanVien nv1 = new NhanVien("001", "Cuong", 200000, 2.3f);
        System.out.println("Thong tin nhan vien 1: " + nv1.toString());
        System.out.println("Thong tin nhan vien 1 sau khi duoc doi ten");
        nv1.setHoTen("Cuong Nguyen");
        System.out.println("Thong tin nhan vien 1: " + nv1.toString());

        NhanVien nv2 = new NhanVien();
        System.out.println("Thong tin nhan vien 2: " + nv2.toString());
        
        NhanVien nv3 = new NhanVien(nv1);
        System.out.println("Thong tin nhan vien 3: " + nv3.toString());

        // tim nhan vien co luong cao nhat trong 3 nhan vien
        // System.out.println("Nhan vien co luong cao nhat trong 3 nhan vien la:");
        // if (nv1.tinhLuong() > nv2.tinhLuong()) {
        //     if (nv1.tinhLuong() > nv3.tinhLuong()) {
        //         System.out.print(nv1.toString());
        //     } else {
        //         System.out.println(nv3.toString());
        //     }
        // } else {
        //     if (nv2.tinhLuong() > nv3.tinhLuong()) {
        //         System.out.println(nv2.toString());
        //     } else {
        //         System.out.println(nv3.toString());
        //     }
        // }
        NhanVien nvMAX = timNhanVienCoLuongMax(nv1, nv2, nv3);
        System.out.println("Nhan vien co luong cao nhat trong 3 nhan vien la: " + nvMAX.toString());
        
        // Danh sach nhan vien
        // int soNhanVien;
        // do {
        //     System.out.print("Nhap so nhan vien: ");
        //     soNhanVien = scanner.nextInt();
        // } while (soNhanVien <= 0);

        // NhanVien[] ds = new NhanVien[soNhanVien];
        // for (int i = 0; i < soNhanVien; i++) {
        //     System.out.println("Nhap nhan vien #" + (i + 1));
        //     NhanVien nv = new NhanVien();
        //     nv.input();
        //     ds[i] = nv;
        // }
        // for (int i = 0; i < soNhanVien; i++) {
        //     System.out.println("Ho ten: " + ds[i].getHoTen()
        //                         + ", luong: " + ds[i].tinhLuong());
        // }
        // so luong nhan vien trong danh sach
        // System.out.println("So luong nhan vien: " + ds.length);
        MangNhanVien danhSachNhanVien = new MangNhanVien();
        danhSachNhanVien.nhapMangNV();
        danhSachNhanVien.xuatMangNV();
    }
    public static NhanVien timNhanVienCoLuongMax(NhanVien nv1, NhanVien nv2, NhanVien nv3) {
        NhanVien nhanVienMax = new NhanVien(nv1);
        if (nv2.tinhLuong() > nhanVienMax.tinhLuong()) {
            nv2 = nhanVienMax;
        }
        if (nv3.tinhLuong() > nhanVienMax.tinhLuong()) {
            nv3 = nhanVienMax;
        }
        return nhanVienMax;
    }
}
