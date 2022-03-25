#include <stdio.h>
#define MAX 30

void hoanVi(int &a, int &b);
void selectSort(int mang[], int n);
void xuatMang(int mang[], int n);
void nhapMang(int mang[], int &n);


int main()
{
	int mang[MAX];
	int n;
	nhapMang(mang, n);
	xuatMang(mang, n);
	
	printf("Mang sau khi sap xep\n");
	selectSort(mang, n);
	xuatMang(mang, n);
	return 0;
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
void xuatMang(int mang[], int n)
{
	for (int i = 0; i < n; i++)
	{
		printf("%d ", mang[i]);
	}
}
void nhapMang(int mang[], int &n)
{
	do
	{
		printf("Nhap n = ");
		scanf("%d", &n);
	} while (n <= 0);
	for (int i = 0; i < n; i++)
	{
		printf("phan tu thu a[%d] = ", i);
		scanf("%d", &mang[i]);
	}
}
