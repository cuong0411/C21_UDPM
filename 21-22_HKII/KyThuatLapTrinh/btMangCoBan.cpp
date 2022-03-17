#include<stdio.h>
#define MAX 50

void nhapMang(int mang[], int &soPhanTu);
void xuatMang(int mang[], int soPhanTu);
void xuatPhanTuLe(int mang[], int soPhanTu);
void xuatPtLonHon(int mang[], int soPhanTu);
void xuatBoiSo5(int mang[], int soPhanTu);
int ktSoNguyenTo(int x);
void xuatSoNguyenTo(int mang[], int soPhanTu);
void xuatPtViTriLe(int mang[], int soPhanTu);
int main()
{
    int mang[MAX];
    int soPhanTu;
    nhapMang(mang, soPhanTu);
    xuatMang(mang, soPhanTu);
    //void xuatPhanTuLe( mang, soPhanTu)
    //xuatPtLonHon(mang, soPhanTu);
    //xuatBoiSo5(mang, soPhanTu);
    //xuatSoNguyenTo(mang, soPhanTu);
    xuatPtViTriLe(mang, soPhanTu);
    return 0;
}
void nhapMang(int mang[], int &soPhanTu)
{
    do{
        printf("Nhap so phan tu cua mang: ");
        scanf("%d", &soPhanTu);
    }while(soPhanTu<=0);
    for(int i=0; i<soPhanTu; i++)
    {
        printf("a[%d] = ", i);
        scanf("%d", &mang[i]);
    }
}
void xuatMang(int mang[], int soPhanTu)
{
    printf("Phan tu da nhap cho mang la:\n");
    printf("{"); //khong can thiet
    for(int i=0; i<soPhanTu; i++)
    {
        printf("%d, ", mang[i]);
    }
    printf("\b\b}\n\n"); //khong can thiet
}
//in ra man hinh nhung phan tu co gia tri le
void xuatPhanTuLe(int mang[], int soPhanTu)
{
	int dem=0;
	for(int i=0;i<soPhanTu;i++)
	{
		if(mang[i]%2!=0)
		{
			printf("%5d", mang[i]);
			dem=1;
		}
	}
	if(dem==0)
		printf("Khong co!\n");
}

//in ra cac phan tu co gia tri lon hon x co trong mang
void xuatPtLonHon(int mang[], int soPhanTu/*, int x*/)
{
    int dem=0;
    int x; // x chi ton tai trong ham xuatPtLonHon
    printf("Nhap x de xuat cac phan tu lon hon co trong mang: ");
    scanf("%d", &x);
    printf("So phan tu trong mang lon hon %d la\n", x);
    for(int i=0; i<soPhanTu; i++)
        if(mang[i]>x)
        {
            printf("%d\t", mang[i]);
            dem = 1;
        }
    if(dem==0)
        printf("Khong co!\n");
}
//xuat cac phan tu la boi so cua 5 trong mang
void xuatBoiSo5(int mang[], int soPhanTu)
{
    int dem=0;
    printf("So phan tu trong mang la boi so cua 5 la\n");
    for(int i=0; i<soPhanTu; i++)
        if(mang[i]%5==0)
        {
            printf("%d\t", mang[i]);
            dem = 1;
        }
    if(dem==0)
        printf("Khong co!\n");
}
//xuat cac phan tu la so nguyen to trong mang
int ktSoNguyenTo(int x)
{
    if(x<2)
        return 0;
    else
    {
        for(int i=2; i<x; i++)
            if(x%i==0)
                return 0;
    }
    return 1;
}
void xuatSoNguyenTo(int mang[], int soPhanTu)
{
    int dem=0;
    printf("Cac phan tu la so nguyen to trong mang la:\n");
    for(int i=0; i<soPhanTu; i++)
    {
        if(ktSoNguyenTo(mang[i])==1)
        {
            dem=1;
            printf("%d\t", mang[i]);
        }
    }
    if(dem==0)
        printf("Khong co!\n");
}
//xuat cac phan tu tai cac vi tri le trong mang
void xuatPtViTriLe(int mang[], int soPhanTu)
{
    int dem=0;
    printf("Cac phan tu tai vi tri le trong mang la:\n");
    for(int i=0; i<soPhanTu; i++)
        if(i%2!=0)
        {
            printf("a[%d]=%d\n", i, mang[i]);
            dem=1;
        }
    if(dem==0)
        printf("Khong co!");
}
