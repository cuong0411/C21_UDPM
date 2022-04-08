public class SinhVien extends ConNguoi {
    private String masv;
    private String nganhHoc;
    private float dtb;

    public SinhVien() {
        super();
        masv = "1234";
        nganhHoc = "cntt";
        dtb = 9.0f;
    }

    public void output() {
        super.output();
        System.out.print(this.masv + " | " + this.nganhHoc + " | " + this.dtb + "\n");
    }

}
