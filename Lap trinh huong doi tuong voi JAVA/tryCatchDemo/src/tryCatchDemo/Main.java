package tryCatchDemo;

import java.util.Scanner;
import java.util.InputMismatchException;

public class Main {
    public static void main(String[] args) {
        
        int x, y;

        //defines 1.0 / 0.0 as Infinity and -1.0 / 0.0 as -Infinity and 0.0 / 0.0 as NaN.
        int kq;
        Scanner input = new Scanner(System.in);
        try {
            System.out.print("Nhap gia tri cho x = ");
            x = input.nextInt();
            System.out.print("Nhap gia tri cho y = ");
            y = input.nextInt();
            System.out.println("Gia tri cua x = " + x);
            kq = x / y;
            System.out.println("Gia tri cua kq = " + kq);
        } catch (InputMismatchException ex) {
            System.out.println("Nhap lieu bi loi: " + ex);
        } catch (ArithmeticException chiaZero) {
            System.out.println("Loi phep chia cho 0");
        } finally {
            System.out.println("Chuong trinh da chay xong");
        }
        input.close();
    }
}