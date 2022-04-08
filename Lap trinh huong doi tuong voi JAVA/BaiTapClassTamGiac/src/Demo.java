
public class Demo {

	public static void main(String[] args) {
		
		TamGiac a = new TamGiac();
        System.out.println("Chu vi: " + a.tinhCV());
        System.out.println("Dien tich: " + a.tinhDT());
        a.xuatLoaiTamGiac();
        
        TamGiac c = new TamGiac(10, 2, 1);
        c.xuatLoaiTamGiac();

        TamGiac b = new TamGiac(4, 4, 4);
        b.xuatLoaiTamGiac();

        MangTamGiac ds = new MangTamGiac();
        ds.nhapMangTamGiac();
        ds.xuatMangTamGiac();
        System.out.println("Trung binh chu vi mang tam giac da nhap: " + ds.tbChuVi());
        System.out.println("Gia tri dien tich lon nhat la: " + ds.gtDienTichMax());

	}

}
