import java.util.Scanner;

public class Shape {
	protected static Scanner scanner = new Scanner(System.in);
	protected String color;
	protected boolean filled;

	public Shape() {
		this.color = "white";
		this.filled = true;
	}

	public Shape(String color, boolean filled) {
		this.color = color;
		this.filled = filled;
	}

	public String getColor() {
		return this.color;
	}

	public void setColor(String color) {
		this.color = color;
	}

	public boolean isFilled() {
		return this.filled;
	}

	public void setFilled(boolean filled) {
		this.filled = filled;
	}

	public String toString() {
		return "Is filled? " + this.isFilled() + ", color = " + this.color;
	}

	public void input() {
		System.out.print("Nhap color: ");
		this.setColor(scanner.nextLine());
		System.out.print("Is filled?: ");
		this.setFilled(scanner.nextBoolean());
		scanner.nextLine();

	}

}
