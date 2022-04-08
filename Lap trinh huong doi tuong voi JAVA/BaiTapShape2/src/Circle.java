
public class Circle extends Shape {
	private double radius;

	public Circle() {
		super();
		this.radius = 1.0;
	}

	public Circle(double radius) {
		super();
		this.radius = radius;
	}

	public Circle(double radius, String color, boolean filled) {
		super(color, filled);
		this.radius = radius;
	}

	public double getRadius() {
		return this.radius;
	}

	public void setRadius(double radius) {
		this.radius = radius;
	}

	public double getArea() {
		return this.radius * this.radius * Math.PI;
	}

	public double getPerimeter() {
		return 2 * this.radius * Math.PI;
	}

	public String toString() {
		return super.toString() + " radius = " + this.radius;
	}

	public void input() {
		super.input();
		System.out.print("Nhap radius: ");
		this.setRadius(scanner.nextDouble());
		scanner.nextLine();
	}

}
