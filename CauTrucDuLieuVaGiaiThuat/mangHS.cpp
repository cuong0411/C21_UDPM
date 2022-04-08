#include<stdio.h>
#include<string.h>
#define MAX 100

struct HocSinh
{
    char hoTen[MAX];
    char soThich[MAX];
    // char khuVuc;
    // float diemTrungBinh;
};
typedef struct HocSinh HS;

void nhap1HS(HS &s);
void xuat1HS(HocSinh s);
void nhapLopHoc(HS lopHoc[], int &soHocSinh);
void xuatLopHoc(HS lopHoc[], int soHocSinh);
int linearSearch(int a[], int n, int num);
int viTriHocSinhCuoiCung(HS lopHoc[], int soHocSinh, char ten[]);
void timHocSinhCuoiCung(HS lopHoc[], int soHocSinh, char ten[]);
void hsCungSoThich(HS lopHoc[], int soHocSinh, char soThich[]);

int main()
{
    HS lopHoc[MAX];
    int soHocSinh;
    nhapLopHoc(lopHoc, soHocSinh);
    xuatLopHoc(lopHoc, soHocSinh);

    // 1.Tim hs cuoi cung co ten x (x la ten nhap tu ban phim)
    char x[MAX];
    printf("Nhap ten hs can tim: ");
    gets(x);
    timHocSinhCuoiCung(lopHoc, soHocSinh, x);

    // 2.Tim cac hs co cung so thich voi y (y la so thich nhap tu ban phim)
    char y[MAX];
    printf("\nNhap so thich can tim: ");
    gets(y);
    hsCungSoThich(lopHoc, soHocSinh, y);

    return 0;
}
void nhap1HS(HS &s)
{
    fflush(stdin);
    printf("Nhap ho ten hoc sinh: ");
    gets(s.hoTen);
    printf("Nhap so thich hoc sinh: ");
    gets(s.soThich);
    // printf("Nhap khu vuc hoc sinh: ");
    // scanf("%d", &s.khuVuc);
    // printf("Nhap diem trung binh hoc sinh: ");
    // scanf("%f", &s.diemTrungBinh);
}
void xuat1HS(HocSinh s)
{
    printf("%-15s|%-15s|\n", s.hoTen, s.soThich);
    // if(s.khuVuc == 1)
    //     printf("Thanh pho |");
    // else
    //     printf("Tinh      |");
    // printf("%5.1f", s.diemTrungBinh);

}
void nhapLopHoc(HS lopHoc[], int &soHocSinh)
{
    do{
        printf("Nhap so hoc sinh: ");
        scanf("%d", &soHocSinh);
    } while(soHocSinh <= 0);
    for(int i = 0; i < soHocSinh; i++)
    {
        nhap1HS(lopHoc[i]);
        printf("\n");
    }
}
void xuatLopHoc(HS lopHoc[], int soHocSinh)
{
    for(int i = 0; i < soHocSinh; i++)
    {
        xuat1HS(lopHoc[i]);
        printf("\n");
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
int viTriHocSinhCuoiCung(HS lopHoc[], int soHocSinh, char ten[])
{
    for (int i = soHocSinh - 1; i >= 0; i--)
    {
        if (strcmp(lopHoc[i].hoTen, ten) == 0)
        {
            return i;
        }
    }
    return -1;
    
}
void timHocSinhCuoiCung(HS lopHoc[], int soHocSinh, char ten[])
{
    int vt = viTriHocSinhCuoiCung(lopHoc, soHocSinh, ten);
    if (vt != -1)
    {
        printf("\nHoc sinh cuoi cung co ten can tim o vi tri %d: \n", vt);
        xuat1HS(lopHoc[vt]);
    }
    else
    {
        printf("\nKhong ton tan hoc sinh");
    }
}
void hsCungSoThich(HS lopHoc[], int soHocSinh, char soThich[])
{
    int count = 0;
    for (int i = 0; i < soHocSinh; i++)
    {
        if (strcmp(lopHoc[i].soThich, soThich) == 0)
        {
            count = 1;
            xuat1HS(lopHoc[i]);
        }
    }
    if (count == 0)
    {
        printf("\nKhong ton tai hs");
    }
}