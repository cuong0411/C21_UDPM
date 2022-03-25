public class App {
	
    public static void main(String[] args) {
    	
        Coodinate a = new Coodinate(-3f, 2f);
        a.output();

        Coodinate b = new Coodinate(4f, 2f);
        b.output();

        Coodinate c = Coodinate.tinhTong(a, b);
        c.output();
        
        Coodinate d = b.tinhTong(a);
        d.output();
        
        Coodinate e = a.diemDoiXung();
        e.output();
        
        
        System.out.println();
        Coodinate x1 = new Coodinate(1, 2);
        Coodinate x2 = new Coodinate(3, 4);
        double doDai = x1.tinhDoDai(x2);
        System.out.println("Do dai = " + doDai);
        System.out.printf("Do dai = %.2f", doDai);
    }
}
