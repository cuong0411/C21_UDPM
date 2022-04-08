
public class Test {

	public static void main(String[] args) {

		// shape
		System.out.println("Shape test");
		Shape a = new Shape();
		System.out.println(a.toString());

		Shape b = new Shape("Black", true);
		System.out.println(b.toString());

		// circle
		System.out.println("Circle test");
		Circle c = new Circle(1);
		System.out.println(c.toString());
		System.out.println(c.getArea());
		System.out.println(c.getPerimeter());

		// rectangle
		System.out.println("Rectangle test");
		Rectangle hcn1 = new Rectangle(5, 6, "Green", true);
		System.out.println("dt = " + hcn1.getArea() + ", cv = " + hcn1.getPerimeter());
		System.out.println(hcn1.toString());

		System.out.println(a.getClass());

	}

}
