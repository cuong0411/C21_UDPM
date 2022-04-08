
public class Rectangle extends Shape {
	private double width;
	private double length;

	public Rectangle() {
		super();
		this.width = 3;
		this.length = 4;
	}

	public Rectangle(double width, double length) {
		super();
		this.width = width;
		this.length = length;
	}

	public Rectangle(double width, double length, String color, boolean filled) {
		super(color, filled);
		this.width = width;
		this.length = length;
	}

	public double getWidth() {
		return width;
	}

	public void setWidth(double width) {
		this.width = width;
	}

	public double getLength() {
		return length;
	}

	public void setLength(double length) {
		this.length = length;
	}

	public double getArea() {
		return this.width * this.length;
	}

	public double getPerimeter() {
		return (this.width + this.length) * 2;
	}

	public String toString() {
		return super.toString() + ", width = " + this.width + ", length = " + this.length;
	}

	public void input() {
		super.input();
		System.out.print("Nhap width: ");
		this.setWidth(scanner.nextDouble());
		System.out.print("Nhap lenght: ");
		this.setLength(scanner.nextDouble());
		scanner.nextLine();
	}
}
