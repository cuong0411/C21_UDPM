//NGUYEN TUAN CUONG
#include<stdio.h>

int main()
{
    char s;
    printf("Nhap s: ");
    scanf("%c", &s);

    int a;
    printf("Nhap so nguyen a: ");
    scanf("%d", &a);

    int b;
    printf("Nhap so nguyen b: ");
    scanf("%d", &b);

    if(s=='n')
        printf("Dien tich hcn co canh a=%d va canh b=%d la: %d.\n", a, b, a*b);
    else
        printf("Ban nhap chua chinh xac.");

    return 0;
}