#include<stdio.h>
#include<string.h>
#define MAX 50;

struct HocSinh
{
    char hoTen[50];
    char soThich[50];
    int khuVuc;
    float diemTrungBinh;
};
typedef struct HocSinh HS;

void nhapMangLopHoc(HS lopHoc[], int soHocSinh);
void xuatMangLopHoc(HS lopHoc[], int soHocSinh);
float tinhDiemTrungBinh(HS lopHoc[], int soHocSinh);
void demSoHocSinhTheoKhuVuc(HS lopHoc[], int soHocSinh);
int main()
{
    HS lopHoc[50];
    int soHocSinh = 0;
    printf("Nhap so hoc sinh trong lop hoc: ");
    scanf("%d", &soHocSinh);
    nhapMangLopHoc(lopHoc, soHocSinh);
    xuatMangLopHoc(lopHoc, soHocSinh);
    printf("Diem trung binh cua lop la %.2f", tinhDiemTrungBinh(lopHoc, soHocSinh));
    demSoHocSinhTheoKhuVuc(lopHoc, soHocSinh);

    return 0;
}
void nhapMangLopHoc(HS lopHoc[], int soHocSinh)
{
    for(int i = 0; i < soHocSinh; i++)
    {
        fflush(stdin);
        printf("Hay nhap thong tin cho hoc sinh thu %d\n", i+1);
        printf("Nhap ho ten : ");
        gets(lopHoc[i].hoTen);
        printf("Nhap so thich: ");
        gets(lopHoc[i].soThich);
        printf("Nhap khu vuc: ");
        scanf("%d", &lopHoc[i].khuVuc);
        printf("Nhap diem trung binh: ");
        scanf("%f", &lopHoc[i].diemTrungBinh);
        fflush(stdin);
    }
}
void xuatMangLopHoc(HS lopHoc[], int soHocSinh)
{
    for(int i = 0; i < soHocSinh; i++)
    {
        printf("\n%s\n%s\n%d\n%.2f\n", lopHoc[i].hoTen, lopHoc[i].soThich, lopHoc[i].khuVuc, lopHoc[i].diemTrungBinh);
    }
}

float tinhDiemTrungBinh(HS lopHoc[], int soHocSinh) {
    float tong = 0;
    for(int i = 0; i < soHocSinh; i++) {
        tong += lopHoc[i].diemTrungBinh;
    }
    return (float) tong/soHocSinh;
}
void demSoHocSinhTheoKhuVuc(HS lopHoc[], int soHocSinh) {
    unsigned int kv1, kv2 = 0;
    for(int i = 0; i < soHocSinh; i++) {
        if(lopHoc[i].khuVuc == 1)
            kv1 += 1;
        else
            kv2 += 1;
    }
    printf("\nSo hoc sinh o khu vuc 1 la %d", kv1);
    printf("\nSo hoc sinh o khu vuc 2 la %d", kv2);
}