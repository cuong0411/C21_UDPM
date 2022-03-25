public class App {
	
    public static void main(String[] args) {
    	
        Coodinate a = new Coodinate(3f, 2f);
        a.output();

        Coodinate b = new Coodinate(4.5f, 9.8f);
        b.output();

        Coodinate c = Coodinate.tinhTong(a, b);
        c.output();
        
        Coodinate d = b.tinhTong(a);
        d.output();
    }
}
