#include <stdio.h>
#include <math.h>
/*
Bài 4 slide 15
kiem tra so nguyen duong n
co phai la so chinh phuong hay khong
*/

int main()
{
	int n;
	printf("Nhap so nguyen duong n:\n");
	scanf("%d", &n);
	if (sqrt(n) == int(sqrt(n)))
	{
		printf("%d la so chinh phuong", n);
	}
	else
	{
		printf("%d khong phai so chinh phuong", n);
	}
	return 0;
}
