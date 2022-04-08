#include <stdio.h>
#define MAX 50

void nhapMang(int mang[], int &n);
void xuatMang(int mang[], int n);
int linearSearch(int a[], int n, int num);

int main()
{
	int a[MAX];
	int n;
	nhapMang(a, n);
	xuatMang(a, n);
	
	int num;
	printf("\nNhap num: ");
	scanf("%d", &num);
	
	int vt = linearSearch(a, n, num);
	if (vt == -1)
	{
		printf("\n%d khong co trong mang", num);
	}
	else
	{
		printf("\nVi tri %d la %d", num, vt);
	}
	
	return 0;
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
int linearSearch(int a[], int n, int num)
{
	for (int i = 0; i < n; i++)
	{
		if (a[i] == num)
		{
			return i;
		}
	}
	return -1;
}
