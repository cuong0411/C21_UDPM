/* NGUYEN TUAN CUONG
1. khai bao cau truc hoc sinh gom cac thong tin
    ho ten
    so thich
    khu vuc: 1- thanh pho, 2 - tinh
    diem trung binh
2. nhap va xuat 1 hoc sinh
*/

#include<stdio.h>
#include<string.h>

struct HocSinh
{
    char hoTen[50];
    char soThich[50];
    char khuVuc;
    float diemTrungBinh;
};
typedef struct HocSinh HS;

int main()
{
    HS hocSinh1;
    printf("Nhap ho ten hoc sinh: ");
    gets(hocSinh1.hoTen);
    printf("Nhap so thich hoc sinh: ");
    gets(hocSinh1.soThich);
    printf("Nhap khu vuc hoc sinh: ");
    scanf("%d", &hocSinh1.khuVuc);
    printf("Nhap diem trung binh hoc sinh: ");
    scanf("%f", &hocSinh1.diemTrungBinh);

    printf("\nHo ten: %s", hocSinh1.hoTen);
    printf("\nSo thich: %s", hocSinh1.soThich);
    printf("\nKhu vuc: %d", hocSinh1.khuVuc);
    printf("\nDiem trung binh: %.2f", hocSinh1.diemTrungBinh);

    return 0;
}
