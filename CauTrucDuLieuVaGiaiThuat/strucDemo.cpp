#include<stdio.h>
#include<string>

//#1
typedef struct HocSinh
{
    char hoTen[50];
    char soThich[50];
    char khuVuc;
    float diemTrungBinh;
}HS;

//#2
// struct HocSinh
// {
//     char hoTen[50];
//     char soThich[50];
//     char khuVuc;
//     float diemTrungBinh;
// };
// typedef struct HocSinh HS;


int main()
{
    HS h;
    printf("Nhap ho ten: ");
    gets(h.hoTen);
    printf("Nhap so thich: ");
    gets(h.soThich);
    printf("Nhap khu vuc: ");
    scanf("%d", &h.khuVuc);
    printf("Nhap diem trung binh: ");
    scanf("%f", &h.diemTrungBinh);

    printf("\nHo ten: %s", h.hoTen);
    printf("\nSo thich: %s", h.soThich);
    printf("\nKhu vuc: %d", h.khuVuc);
    printf("\nDiem trung binh: %.2f", h.diemTrungBinh);
    return 0;
}