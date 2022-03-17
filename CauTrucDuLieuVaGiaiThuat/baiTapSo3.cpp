#include<stdio.h>
#include<string.h>
#define MAX 100

struct HocSinh
{
    char hoTen[MAX];
    char soThich[MAX];
    char khuVuc;
    float diemTrungBinh;
};
typedef struct HocSinh HS;

void nhap1HS(HS &s);
void xuat1HS(HocSinh s);
void nhapLopHoc(HS lopHoc[], int &soHocSinh);
void xuatLopHoc(HS lopHoc[], int soHocSinh);
float tinhDTB(HS lopHoc[], int soHocSinh);
void xuatHSTheoKV(HS lopHoc[], int soHocSinh);

int main()
{
    HS lopHoc[MAX];
    int soHocSinh;
    nhapLopHoc(lopHoc, &soHocSinh);
    xuatLopHoc(lopHoc, soHocSinh);
    printf("\nDiem trung binh cua ca lop = %.2f", tinhDTB(lopHoc, soHocSinh));
    xuatHSTheoKV(lopHoc, soHocSinh);
    printf("\n%d", soHocSinh);

    return 0;
}
void nhap1HS(HS &s)
{
    fflush(stdin);
    printf("Nhap ho ten hoc sinh: ");
    gets(s.hoTen);
    printf("Nhap so thich hoc sinh: ");
    gets(s.soThich);
    printf("Nhap khu vuc hoc sinh: ");
    scanf("%d", &s.khuVuc);
    printf("Nhap diem trung binh hoc sinh: ");
    scanf("%f", &s.diemTrungBinh);
}
void xuat1HS(HocSinh s)
{
    printf("%-15s|%-15s|", s.hoTen, s.soThich);
    if(s.khuVuc == 1)
        printf("Thanh pho |");
    else
        printf("Tinh      |");
    printf("%5.1f", s.diemTrungBinh);

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
float tinhDTB(HS lopHoc[], int soHocSinh)
{
    float tong = 0.0;
    for(int i = 0; i < soHocSinh; i++)
    {
        tong += lopHoc[i].diemTrungBinh;
    }
    return tong/soHocSinh;
}
void xuatHSTheoKV(HS lopHoc[], int soHocSinh)
{
    unsigned int kv1, kv2 = 0;
    for(int i = 0; i < soHocSinh; i++)
	{
        if(lopHoc[i].khuVuc == 1)
            kv1++;
        else
            kv2++;
    }
    printf("\nSo hoc sinh o khu vuc 1 la %d", kv1);
    printf("\nSo hoc sinh o khu vuc 2 la %d", kv2);
}
