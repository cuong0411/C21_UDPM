package baiTapMang;



// Bai tap ve nha 18/03/2022

import java.util.Scanner;
import java.util.Arrays;

public class Demo2 {
    public static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {

//        Mang mang1 = new Mang();
//        mang1.input();
//        mang1.output();
//
//        System.out.println("Tong trung binh le cua mang: " + mang1.tinhTBSoLe());
//        System.out.println("Phan tu lon nhat cua mang la: " + mang1.timMax());
//        
//        mang1.sapXepTangDan();
//        mang1.output();
//
//        Mang mang2 = new Mang();
//        System.out.println("Mang 2:");
//        mang2.input();
//        mang2.output();
//        mang2.sapXepTangDan2();
//        mang2.output();
    	
    	int n = 4;
    	int[] arr = {6, 4, -10, 0, 4, 9};
    	int[] arr2;
    	arr2 = Arrays.copyOf(arr, n);
    	
    	System.out.println(Arrays.toString(arr2));
    	
    }

}

