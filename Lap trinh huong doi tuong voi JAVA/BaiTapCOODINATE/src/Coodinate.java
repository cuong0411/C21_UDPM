public class Coodinate {

    // fields
    private float hoanhDo;
    private float tungDo;

    // constructors
    public Coodinate() {
        this.hoanhDo = 0;
        this.tungDo = 0;
    }
    public Coodinate(float hoanhDo, float tungDo) {
        this.hoanhDo = hoanhDo;
        this.tungDo = tungDo;
    }

    // getter, setter
    public float getHoanhDo() {
        return hoanhDo;
    }
    public void setHoanhDo(Float hoanhDo) {
        this.hoanhDo = hoanhDo;
    }
    public float getTungDo() {
        return tungDo;
    }
    public void setTungDo(Float tungDo) {
        this.tungDo = tungDo;
    }

    // methods
    public void output() {
        System.out.println("(" + this.getHoanhDo() + ", " + this.tungDo + ")");
    }
    public Coodinate tinhTong(Coodinate toaDo) {
        Coodinate toaDoMoi = new Coodinate();
        toaDoMoi.hoanhDo = this.hoanhDo + toaDo.hoanhDo;
        toaDoMoi.tungDo = this.tungDo + toaDo.tungDo;
        return toaDoMoi;
    }
    public Coodinate diemDoiXung() {
    	Coodinate toaDoMoi = new Coodinate(-this.hoanhDo, -this.tungDo);
    	return toaDoMoi;
    }
    public double tinhDoDai(Coodinate toaDo) {
    	double doDai = Math.sqrt(Math.pow(this.hoanhDo - toaDo.hoanhDo, 2) + Math.pow(this.tungDo - toaDo.tungDo, 2));
    	return doDai;
    }
    
    
    
    
    
    
    // demo
    public static Coodinate tinhTong(Coodinate toaDo1, Coodinate toaDo2) {
        Coodinate toaDo = new Coodinate();
        toaDo.setHoanhDo(toaDo1.getHoanhDo() + toaDo2.getHoanhDo());
        toaDo.setTungDo(toaDo1.getTungDo() + toaDo2.getTungDo());
        return toaDo;
    }
    
}
