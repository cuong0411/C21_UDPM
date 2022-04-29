/*
* doc so luong va danh sach mat hang tu file dsmh.txt
* xuat ds ra man hinh
*/
#include <stdio.h>
#include <string.h>

#define MAX 30
struct HangHoa
{
	char maHang[5];
	char tenHang[20];
	float gia;
};

void doc1MHFile(HangHoa &a, FILE *f);
void xuat1MH(HangHoa a);
void docDSMH(HangHoa a[], int &n, FILE *f);
void xuatDSMH(HangHoa a[], int n);
void ghi1MH(HangHoa a, FILE *f);
void ghiDSMH(HangHoa a[], int n, FILE *f);

float tinhTongGia(HangHoa a[], int n);
void xuatTheoGia(HangHoa a[], int n);
int slHangHoa(HangHoa a[], int n);
void timTheoMaHang(HangHoa a[], int n, char maHang[5]);
void hoanViMH(HangHoa &a, HangHoa &b);
void selectSortMH(HangHoa a[], int n);
float maxGia(HangHoa a[], int n);
void ghiDSMH_maxGia(HangHoa a[], int n, FILE *f);

int main()
{
	FILE *f;
	f = fopen("dsmh.txt", "rt");
	if (f == NULL)
	{
		printf("khong doc duoc file.");
		return 0;
	}

	// int b;
	// fscanf(f, "%d", &b);
	// printf("%d\n", b);
	// HangHoa a;
	// doc1MHFile(a, f);
	// xuat1MH(a);

	HangHoa a[MAX];
	int n;
	docDSMH(a, n, f);
	xuatDSMH(a, n);
	fclose(f);

	// f = fopen("test.txt", "wt");
	// if (f == NULL)
	// {
	// 	printf("khong doc duoc file.");
	// }
	// ghiDSMH(a, n, f);

	// 3. tinh tong gia cac hang hoa
	float tong = tinhTongGia(a, n);
	printf("\nTong gia cac hang hoa la: %.2f", tong);

	// 4. xuat cac hang hoa co gia lon hon 20000 va nho hon 50000
	xuatTheoGia(a, n);

	// 5. dem so luong hang hoa co gia nho hon 30000
	int soLuong = slHangHoa(a, n);
	printf("\nSo luong hang hoa nho hon 30000 la: %d", soLuong);

	// 6.tim theo ma hang, in cac thong tin con lai. Khong thay thi in thong bao: "khong tim thay"
	char maHang[5];
	printf("\nNhap ma hang can tim: ");
	gets(maHang);
	timTheoMaHang(a, n, maHang);

	// 7.sap xep dsmh theo ma
	selectSortMH(a, n);
	xuatDSMH(a, n);

	// 8.tao file dongiamax.txt, luu dsmh co gia max
	f = fopen("dongiamax.txt", "wt");
	if (f == NULL)
	{
		printf("khong doc duoc file.");
		return 0;
	}
	ghiDSMH_maxGia(a, n, f);
	fclose(f);


	return 0;
}
void doc1MHFile(HangHoa &a, FILE *f)
{
	char newline[2];
	fgets(newline, 2, f);
	newline[strcspn(newline, "\n")] = 0;
	// fgets(a.maHang, 4, f);
	// fgets(a.tenHang, 19, f);
	// fscanf(f, "%f", &a.gia);

	fscanf(f, "%s", &a.maHang);
	fscanf(f, "%s", &a.tenHang);
	fscanf(f, "%f", &a.gia);
}
void xuat1MH(HangHoa a)
{
	printf("|%-5s|%-20s|%-6.1f\n", a.maHang, a.tenHang, a.gia);
}
void docDSMH(HangHoa a[], int &n, FILE *f)
{
	fscanf(f, "%d", &n);
	for (int i = 0; i < n; i++)
	{
		doc1MHFile(a[i], f);
	}
}
void xuatDSMH(HangHoa a[], int n)
{
	for (int i = 0; i < n; i++)
	{
		xuat1MH(a[i]);
	}
}
void ghi1MH(HangHoa a, FILE *f)
{
	fprintf(f, "%-5s", a.maHang);
	fprintf(f, "%-20s", a.tenHang);
	fprintf(f, "%-6f", a.gia);
}
void ghiDSMH(HangHoa a[], int n, FILE *f)
{
	for (int i = 0; i < n; i++)
	{
		ghi1MH(a[i], f);
		fprintf(f, "\n");
	}
}
float tinhTongGia(HangHoa a[], int n)
{
	float tong = 0;
	for (int i = 0; i < n; i++)
	{
		tong += a[i].gia;
	}
	return tong;
}
void xuatTheoGia(HangHoa a[], int n)
{
	// gia lon hon 20000 va nho hon 50000
	for (int i = 0; i < n; i++)
	{
		if (a[i].gia > 20000 && a[i].gia < 50000)
		{
			xuat1MH(a[i]);
			printf("\n");
		}
	}	
}
int slHangHoa(HangHoa a[], int n)
{
	// so luong hang hoa nho hon 30000
	int count = 0;
	for (int i = 0; i < n; i++)
	{
		if (a[i].gia < 30000)
		{
			count++;
		}
	}
	return count;
}
void timTheoMaHang(HangHoa a[], int n, char maHang[5])
{
	int flag = 0;
	for (int i = 0; i < n; i++)
	{
		if (strcmp(a[i].maHang, maHang) == 0)
		{
			printf("\nTen hang hoa: %s", a[i].tenHang);
			printf("\nGia hang hoa: %.2f", a[i].gia);
			flag = 1;
		}
	}
	if (flag == 0)
	{
		printf("\nKhong tim thay.");
	}
}
void hoanViMH(HangHoa &a, HangHoa &b)
{
	HangHoa temp;
	temp = a;
	a = b;
	b = temp;
}
void selectSortMH(HangHoa a[], int n)
{
	for (int i = 1; i < n - 1; i++)
	{
		int min = i;
		for (int j = i + 1; j < n; j++)
		{
			if(strcmp(a[min].maHang, a[j].maHang) > 0)
			{
				min = j;
			}
		}
		hoanViMH(a[min], a[i]);
	}
}
float maxGia(HangHoa a[], int n)
{
	float max = a[0].gia;
	for (int i = 1; i < n; i++)
	{
		if (a[i].gia > max)
		{
			max = a[i].gia;
		}
	}
	return max;
}
void ghiDSMH_maxGia(HangHoa a[], int n, FILE *f)
{
	float max = maxGia(a, n);
	for (int i = 0; i < n; i++)
	{
		if (a[i].gia == max)
		{
			ghi1MH(a[i], f);
			fprintf(f, "\n");
		}
	}
}