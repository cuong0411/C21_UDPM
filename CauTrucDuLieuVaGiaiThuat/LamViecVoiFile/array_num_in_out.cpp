#include <stdio.h>
#define MAX 30

void docFile(int a[], int &n, FILE *f);
void xuatMang(int a[], int n);
void ghiFile(int a[], int n, FILE *f);
void ghiTongChan(int a[], int n, FILE *f);
int phanTuMax(int a[], int n);
void ghiPhanTuMax(int a[], int n, FILE *f);
void ghiSoPhanTuMax(int a[], int n, FILE *f);
int ktSoNT(int n);
void ghiSoNT(int a[], int n, FILE *f);
void selectSort(int mang[], int n);
void hoanVi(int &a, int &b);

int main()
{
	FILE *f;
	f = fopen("E:\\C21UDPM\\CauTrucDuLieuVaGiaiThuat\\LamViecVoiFile\\cau1_taptin.txt", "rt");
	if (f == NULL)
	{
		printf("Khong mo duoc file");
		return 0;
	}
	
	// doc so phan tu va mang tu file
	int a[MAX];
	int n;
	docFile(a, n, f);
	printf("So phan tu cua mang la: %d\n", n);
	xuatMang(a, n);
	fclose(f);
	
	/*
	// ghi mang so nguyen vao file, (mode append)
	f = fopen("E:\\C21UDPM\\CauTrucDuLieuVaGiaiThuat\\LamViecVoiFile\\cau1_taptin.txt", "at");
	if (f == NULL)
	{
		printf("Khong mo duoc file");
		return 0;
	}
	ghiFile(a, n, f);
	fclose(f);
	*/
	
	/*
	// tinh tong cac so chan co trong mang, ghi ket qua vao file data.txt
	f = fopen("E:\\C21UDPM\\CauTrucDuLieuVaGiaiThuat\\LamViecVoiFile\\cau1_taptin.txt", "at");
	if (f == NULL)
	{
		printf("Khong mo duoc file");
		return 0;
	}
	ghiTongChan(a, n, f);
	fclose(f);
	*/
	
	/*
	// tim phan tu lon nhat, ghi ket qua vao file data.txt
	f = fopen("E:\\C21UDPM\\CauTrucDuLieuVaGiaiThuat\\LamViecVoiFile\\cau1_taptin.txt", "at");
	if (f == NULL)
	{
		printf("Khong mo duoc file");
		return 0;
	}
	ghiPhanTuMax(a, n, f);
	fclose(f);
	*/
	
	/*
	//dem so phan tu lon nhat, ghi ket qua vao file data.txt
	f = fopen("E:\\C21UDPM\\CauTrucDuLieuVaGiaiThuat\\LamViecVoiFile\\cau1_taptin.txt", "at");
	if (f == NULL)
	{
		printf("Khong mo duoc file");
		return 0;
	}
	ghiSoPhanTuMax(a, n, f);
	fclose(f);
	*/
	
	/*
	// ghi cac so nguyen to trong mang vao file data.txt
	f = fopen("E:\\C21UDPM\\CauTrucDuLieuVaGiaiThuat\\LamViecVoiFile\\cau1_taptin.txt", "at");
	if (f == NULL)
	{
		printf("Khong mo duoc file");
		return 0;
	}
	ghiSoNT(a, n, f);
	fclose(f);
	*/
	
	
	//sap xep mang theo thu tu tang dan, luu ket qua sau sap xep vao file dataSX.txt
	f = fopen("E:\\C21UDPM\\CauTrucDuLieuVaGiaiThuat\\LamViecVoiFile\\dataSX.txt", "wt");
	if (f == NULL)
	{
		printf("Khong mo duoc file");
		return 0;
	}
	selectSort(a, n);
	ghiFile(a, n, f);
	fclose(f);
	
	return 0;
}
void docFile(int a[], int &n, FILE *f)
{
	fscanf(f, "%d", &n);
	for (int i = 0; i < n; i++)
	{
		fscanf(f, "%d", &a[i]);
	}
}
void xuatMang(int a[], int n)
{
	for (int i = 0; i < n; i++)
	{
		printf("%d ", a[i]);
	}
}
void ghiFile(int a[], int n, FILE *f)
{
	fprintf(f, "\n");
	for (int i = 0; i < n; i++)
	{
		fprintf(f, "%d ", a[i]);
	}
}
void ghiTongChan(int a[], int n, FILE *f)
{
	long tong = 0;
	int flag = 0;
	for (int i = 0; i < n; i++)
	{
		if (a[i] % 2 == 0)
		{
			tong += a[i];
			flag = 1;
		}
	}
	if (flag == 0)
	{
		printf("\nKhong co so chan trong mang");
	}
	else
	{
		fprintf(f, "\nTong cac so chan trong mang: %ld", tong);
	}
}
int phanTuMax(int a[], int n)
{
	int max = a[0];
	for (int i = 1; i < n; i++)
	{
		if (a[i] > max)
		{
			max = a[i];
		}
	}
	return max;
}
void ghiPhanTuMax(int a[], int n, FILE *f)
{
	int max = phanTuMax(a, n);
	fprintf(f, "\nPhan tu lon nhat trong mang la: %d", max);
}
void ghiSoPhanTuMax(int a[], int n, FILE *f)
{
	int max = phanTuMax(a, n);
	int count = 0;
	for (int i = 0; i < n; i++)
	{
		if (a[i] == max)
		{
			count++;
		}
	}
	fprintf(f, "\nSo phan tu lon nhat trong mang la: %d", count);
}
int ktSoNT(int n)
{
	if (n <= 1)
	{
		return -1;
	}
	if (n == 2)
	{
		return 1;
	}
	for (int i = 2; i < n; i++)
	{
		if (n % i == 0)
		{
			return -1;
		}
	}
	return 1;
}
void ghiSoNT(int a[], int n, FILE *f)
{
	int flag = 0;
	fprintf(f, "\n");
	for (int i = 0; i < n; i++)
	{
		if (ktSoNT(a[i]) == 1)
		{
			flag = 1;
			fprintf(f, "%d ", a[i]);
		}
	}
	if (flag == 0)
	{
		fprintf(f, "khong ton tai so nguyen to trong mang");
	}
}
void hoanVi(int &a, int &b)
{
	int temp;
	temp = a;
	a = b;
	b = temp;
}
void selectSort(int mang[], int n)
{
	int minIndex = 0;
	for (int i = 0; i < n - 1; i++)
	{
		int minIndex = i;
		for (int j = i + 1; j < n; j++)
		{
			if (mang[minIndex] > mang[j])
			{
				minIndex = j;
			}
		}
		hoanVi(mang[minIndex], mang[i]);	
	}
}

