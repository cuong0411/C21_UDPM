import java.util.Scanner;

public class PhanSo {
	
	//cac thuoc tinh
	private int tuSo;
	private int mauSo;
	private Scanner input = new Scanner(System.in);
	
	//contructors
	public PhanSo() {}
	
	public PhanSo(int tuSo, int mauSo) {
		this.tuSo = tuSo;
		this.mauSo = mauSo;
	}
	public PhanSo(PhanSo p) {
		this.tuSo = p.tuSo;
		this.mauSo = p.mauSo;
	}
	
	public int getTuSo() {
		return tuSo;
	}

	public void setTuSo(int tuSo) {
		this.tuSo = tuSo;
	}

	public int getMauSo() {
		return mauSo;
	}

	public void setMauSo(int mauSo) {
		this.mauSo = mauSo;
	}

	//cac phuong thuc
	public void nhapPhanSo() {
		System.out.print("Nhap tu so: ");
		this.tuSo = input.nextInt();
		do {
			System.out.print("Nhap mau so: ");
			this.mauSo = input.nextInt();
		} while (this.mauSo <= 0);
		//input.close();
	}
	//xuat phan so
	public void xuatPhanSo() {
		if(this.tuSo == 0)
			System.out.println("Phan so = 0");
		else if (this.tuSo == this.mauSo)
			System.out.println("Phan so = 	1");
		else
			System.out.println("Phan so = " + tuSo + "/" + mauSo);
	}
	//tim UCLN
	public int UCLN() {
		int ucln = 1;
		int min = (tuSo < mauSo) ? tuSo : mauSo;
		for(int i = 1; i <= min; i++) {
			if(tuSo % i == 0 && mauSo % i == 0) {
				ucln = i;
			}
		}
		return ucln;
	}
	public PhanSo rutGonPS() {
		PhanSo ps = new PhanSo();
		ps.tuSo = this.tuSo;
		ps.mauSo = this.mauSo;
		int a = UCLN();
		ps.tuSo /= a;
		ps.mauSo /= a;	
		return ps;
	}
	public PhanSo congPS(PhanSo ps2) {
		PhanSo kq = new PhanSo();
		kq.tuSo = this.tuSo * ps2.mauSo + this.mauSo * ps2.tuSo;
		kq.mauSo = this.mauSo * ps2.mauSo;
		return kq.rutGonPS();
	}
	public PhanSo truPS(PhanSo ps2) {
		PhanSo kq = new PhanSo();
		kq.tuSo = this.tuSo * ps2.mauSo - this.mauSo * ps2.tuSo;
		kq.mauSo = this.mauSo * ps2.mauSo;
		return kq.rutGonPS();
	}
	public PhanSo nhanPS(PhanSo ps2) {
		PhanSo kq = new PhanSo();
		kq.tuSo = this.tuSo * ps2.tuSo;
		kq.mauSo = this.mauSo * ps2.mauSo;
		return kq.rutGonPS();
	}
	public PhanSo chiaPS(PhanSo ps2) {
		PhanSo kq = new PhanSo();
		kq.tuSo = this.tuSo * ps2.mauSo;
		kq.mauSo = this.mauSo * ps2.tuSo;
		return kq.rutGonPS();
	}

}
