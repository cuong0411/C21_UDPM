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
        toaDoMoi.setHoanhDo(this.getHoanhDo() + toaDo.getHoanhDo());
        toaDoMoi.setTungDo(this.getTungDo() + toaDo.getTungDo());
        return toaDoMoi;
    }
    public static Coodinate tinhTong(Coodinate toaDo1, Coodinate toaDo2) {
        Coodinate toaDo = new Coodinate();
        toaDo.setHoanhDo(toaDo1.getHoanhDo() + toaDo2.getHoanhDo());
        toaDo.setTungDo(toaDo1.getTungDo() + toaDo2.getTungDo());
        return toaDo;
    }
    
}
