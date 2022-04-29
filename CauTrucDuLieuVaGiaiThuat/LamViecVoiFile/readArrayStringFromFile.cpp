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