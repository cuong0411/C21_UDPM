package baiTapMang;

import java.util.Scanner;
import java.util.Arrays;

public class Mang {
    
    int soPhanTu;
    int[] mang;

    public Mang() {}
    public Mang(Mang mang) {
    	this.soPhanTu = mang.soPhanTu;
    	this.mang = mang.mang;
    }
    public Mang(int soPhanTu, int[] mang) {
    	if (soPhanTu < mang.length) {
    		System.out.println("So phan tu da nhap nho hon do dai mang");
    	} else if (soPhanTu == mang.length) {
    		this.soPhanTu = soPhanTu;
        	this.mang = mang;
    	} else {
    		
    		this.mang = Arrays.copyOf(mang, soPhanTu);
    	}
    	
    }
    public int getSoPhanTu() {
        return soPhanTu;
    }

    public void setSoPhanTu(int soPhanTu) {
        if (soPhanTu < 0) {
            this.soPhanTu = 0;
        } else {
        this.soPhanTu = soPhanTu;
        }
    }

    public int[] getMang() {
        return mang;
    }

    public void setMang(int[] mang) {
        this.mang = mang;
    }

    public void input() {
    	Scanner scanner = new Scanner(System.in);
        do {
            System.out.print("Nhap so phan tu: ");
            this.soPhanTu = scanner.nextInt();
            // scanner.nextLine();
        } while (this.soPhanTu <= 0);
        this.mang = new int[this.soPhanTu];
        for (int i = 0; i < this.soPhanTu; i++) {
            System.out.print("Nhap phan tu #" + i + "= ");
            this.mang[i] = scanner.nextInt();
            // scanner.nextLine();
        }
    }

    public void output() {
        for (int phanTu : this.mang) {
            System.out.print(phanTu + " ");
        }
        System.out.println();
    }

//    private static boolean ktSoLe(int so) {
//        if (so % 2 != 0) {
//            return true;
//        }
//        return false;
//    }

    public double tinhTBSoLe() {
        double tong = 0; //double
        int count = 0;
        for (int i = 0; i < this.mang.length; i++) {
            // if (ktSoLe(this.mang[i]) == true) { // if(this.mang[i] % 2 != 0)
            if(this.mang[i] % 2 != 0) {
                tong += this.mang[i];
                count++;
            }
        }
        if (count == 0) {
            return 0;
        }
        return tong / count;
    }

    public int timMax() {
//        if (this.mang.length == 1) {
//            return this.mang[0];
//        }
        int max = this.mang[0];
        for (int i = 1; i < this.mang.length; i++) {
            if (max < this.mang[i]) {
                max = this.mang[i];
            }
        }
        return max;
    }

    public void sapXepTangDan() {
        while (true) {
            boolean isSwap = false;
            for (int i = 0; i < this.mang.length - 1; i++) {
                if (this.mang[i] > this.mang[i + 1]) {
                    isSwap = true;
                    
                    // swap
                    int temp = this.mang[i];
                    this.mang[i] = this.mang[i + 1];
                    this.mang[i + 1] = temp;
                }
            }
            
            // mang da dung thu tu
            if (isSwap == false) {
                break;
            }
        }
    }

    public void sapXepTangDan2() {
        for (int i = 0; i < this.mang.length - 1; i++) {
            for (int j = 0; j < this.mang.length - i - 1; j++) {
                if (this.mang[j] > this.mang[j + 1]) {
                    int temp = this.mang[j];
                    this.mang[j] = this.mang[j + 1];
                    this.mang[j + 1] = temp;
                }
            }
        }
    }
    
    // select sort
    public void sapXepTangDan3() {
    	int temp, index;
    	for (int i = 0; i < this.soPhanTu - 1; i++) {
    		index = i;
    		for (int j = i + 1; j < this.soPhanTu; j++) {
    			if (this.mang[j] < mang[index]) {
    				index = j;
    			}
    		}
    		temp = mang[i];
			mang[i] = mang[index];
			mang[index] = temp;
    	}
    }
}
