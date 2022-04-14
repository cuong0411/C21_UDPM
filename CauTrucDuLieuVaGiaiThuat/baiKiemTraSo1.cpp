// Nguyen Tuan Cuong
// 01007393

#include <stdio.h>
#include <string.h>
#define MAX 30

struct NhanVien
{
	char manv[5];
	char hotennv[20];
	int luongcb;
	float heso;
};

void nhap1NV(NhanVien &nv);
void xuat1NV(NhanVien nv);
void nhapMangNV(NhanVien a[], int &n);
void xuatMangNV(NhanVien a[], int n);
void hoanViNV(NhanVien &a, NhanVien &b);
void sxManv(NhanVien a[], int n);
void timHoTen(NhanVien a[], int n, char x[]);
float timMaxLuong(NhanVien a[], int n);
void nvMaxLuong(NhanVien a[], int n);

int timMaNV(NhanVien a[], int n, char x[]);
void xoaNV(NhanVien a[], int n, char x[]);

int main()
{
	NhanVien a[MAX];
	int n;
	nhapMangNV(a, n);
	xuatMangNV(a, n);
	
	char x[MAX];
	printf("\nNhap manv can xoa: ");
	fflush(stdin);
	gets(x);
	xoaNV(a, n, x);
	
	/* cau 4
	printf("\nCac nhan vien co luong cao nhat\n");
	nvMaxLuong(a, n);
	*/
	
	/* cau 2
	printf("\nsx tang dan theo manv\n");
	sxManv(a, n);
	xuatMangNV(a, n);
	*/
	
	/* cau 3
	char x[MAX];
	printf("\nNhap ho ten can tim: ");
	fflush(stdin);
	gets(x);
	timHoTen(a, n, x);
	*/
	
	
	return 0;
}
void nhap1NV(NhanVien &nv)
{
	fflush(stdin);
	printf("Nhap manv: ");
	gets(nv.manv);
	printf("Nhap hotennv: ");
	gets(nv.hotennv);
	printf("Nhap luongcb: ");
	scanf("%d", &nv.luongcb);
	printf("Nhap he so: ");
	scanf("%f", &nv.heso);
}
void xuat1NV(NhanVien nv)
{
	printf("%-10s | %-10s | %-10d | %-5.2f", nv.manv, nv.hotennv, nv.luongcb, nv.heso);
}

void nhapMangNV(NhanVien a[], int &n)
{
	do
	{
		printf("Nhap so nhan vien: ");
		scanf("%d", &n);
	}
	while (n <= 0);
	for (int i = 0; i < n; i++)
	{
		nhap1NV(a[i]);
		printf("\n");
	}
}
void xuatMangNV(NhanVien a[], int n)
{
	for (int i = 0; i < n; i++)
	{
		xuat1NV(a[i]);
		printf("\n");
	}
}
void hoanViNV(NhanVien &a, NhanVien &b)
{
	NhanVien c;
	c = a;
	a = b;
	b = c;
}

void sxManv(NhanVien a[], int n)
{
	for (int i = 0; i < n - 1; i++)
	{
		int vtMin = i;
		for (int j = i; j < n; j++)
		{
			if (strcmp(a[vtMin].manv, a[j].manv) > 0)
			{
				vtMin = j;
			}
		}
		hoanViNV(a[vtMin], a[i]);
	}
}
void timHoTen(NhanVien a[], int n, char x[])
{
	int flag = 0;
	for (int i = 0; i < n; i++)
	{
		if (strcmp(a[i].hotennv, x) == 0)
		{
			flag = 1;
			xuat1NV(a[i]);
			printf("\n");
		}
	}
	if (flag == 0)
	{
		printf("\nTim khong thay");
	}	
}
float timMaxLuong(NhanVien a[], int n)
{
	int max = 0;
	float luongMax = a[max].heso * a[max].luongcb;
	for (int i = 1; i < n; i++)
	{
		float luong = a[i].heso * a[i].luongcb;
		if (luongMax < luong)
		{
			luongMax = luong;
		}
	}
	return luongMax;
}
void nvMaxLuong(NhanVien a[], int n)
{
	float max = timMaxLuong(a, n);
	for (int i = 0; i < n; i++)
	{
		float luong = a[i].heso * a[i].luongcb;
		if (luong == max)
		{
			xuat1NV(a[i]);
			printf("\n");
		}
	}
}
int timMaNV(NhanVien a[], int n, char x[])
{
	
	for (int i = 0; i < n; i++)
	{
		if (strcmp(a[i].manv, x) == 0)
		{
			return i;
		}
	}	
}
void xoaNV(NhanVien a[], int n, char x[])
{
	int vt = timMaNV(a, n, x);
	for (int i = vt; i < n - 1; i++)
	{
		a[i + 1] = a[i];
	}
	xuatMangNV(a, n - 1);
}
