#include <stdio.h>
#define MAX 30

void hoanVi(int &a, int &b);
void selectSort(int mang[], int n);
void xuatMang(int mang[], int n);
void nhapMang(int mang[], int &n);
void sapxep_chen(int mang[], int n);
void interchangeSort(int a[], int n);
void bubbleSort(int a[], int n);
void insertionSort(int a[], int n);

int main()
{
	int mang[MAX];
	int n;
	nhapMang(mang, n);
	xuatMang(mang, n);
	
	printf("\nMang sau khi sap xep\n");
	//selectSort(mang, n);
	//sapxep_chen(mang, n);
	
	//interchangeSort(mang, n);
	//bubbleSort(mang, n);
	insertionSort(mang, n);
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
void insertionSort(int a[], int n)
{
	for (int i = 1; i < n; i++)
	{
		int pos = i - 1;
		int x = a[i];
		while (a[pos] > x && pos >= 0)
		{
			a[pos+1] = a[pos];
			pos--;
		}
		a[pos+1] = x;
	}
}
void interchangeSort(int a[], int n)
{
	for (int i = 0; i < n - 1; i++)
	{
		for (int j = i + 1; j < n; j++)
		{
			if (a[i] > a[j])
			{
				hoanVi(a[i], a[j]);
			}
		}
	}
}
void bubbleSort(int a[], int n)
{
	for (int i = 0; i < n -1; i++)
	{
		for (int j = n - 1; j > i; j--)
		{
			if (a[j] < a[j-1])
			{
				hoanVi(a[j], a[j-1]);
			}
		}
	}
}
