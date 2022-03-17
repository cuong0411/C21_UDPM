import java.util.Scanner;

public class PhanSo
{
	//cac thuoc tinh
	private int tuSo;
	private int mauSo;
	//cac phuong thuc
	public void nhapPS()
	{
		//@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in); 
		System.out.print("nhap tu so: ");
		this.tuSo=input.nextInt();
		System.out.print("nhap mau so: ");
		this.mauSo=input.nextInt();
		
	}
	public void xuatPS()
	{
	  System.out.print("phan so ban da nhap la: "+tuSo+"/"+mauSo+"\n");
	}
	public int UCLN(int x,int y)
	{
		while (x != y)
		{
	        if (x > y)
	        {
	            x -= y;//x=x-y
	        }
	        else
	        {
	            y -= x;//y=y-x
	        }
	    }
		return x;
	}
	public void RutgonPS()
	{
		int a = UCLN(this.tuSo, this.mauSo);
		while(a!=1)
		{
			this.tuSo/=a;
			this.mauSo/=a;
			a = UCLN(this.tuSo, this.mauSo);
		}
		System.out.print("phan so sau khi rut gon la: " + this.tuSo+"/" + this.mauSo + "\n");
	}
	public void congPS(PhanSo ps2)
	{
		this.tuSo = this.tuSo * ps2.mauSo + ps2.tuSo * this.mauSo;
		this.mauSo = this.mauSo * ps2.mauSo;
		RutgonPS();
		System.out.print("tong hai phan so la: "+this.tuSo+"/"+this.mauSo+"\n");
	}
	public void truPS(PhanSo ps2)
	{
		int ts=this.tuSo * ps2.mauSo - ps2.tuSo * this.mauSo;
		int ms=this.mauSo * ps2.mauSo;
		ts/=UCLN(ts, ms);
		ms/=UCLN(ts, ms);
		System.out.print("hieu hai phan so la: "+ts+"/"+ms+"\n");
	}
	public void nhanPS(PhanSo ps2)
	{
		int ts=(this.tuSo * ps2.tuSo);
		int ms=(this.mauSo*ps2.mauSo);
		ts/=UCLN(ts, ms);
		ms/=UCLN(ts, ms);
		System.out.print("tich hai phan so la: "+ts+"/"+ms+"\n");
	}
	public void chiaPS(PhanSo ps2)
	{
		int ts=(this.tuSo * ps2.mauSo);
		int ms=(this.mauSo*ps2.tuSo);
		ts/=UCLN(ts, ms);
		ms/=UCLN(ts, ms);
		System.out.print("thuong hai phan so la: "+ts+"/"+ms+"\n");
	}
}