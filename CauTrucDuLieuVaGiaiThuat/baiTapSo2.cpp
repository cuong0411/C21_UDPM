/*
nhap va xuat thong tin 1 hoc sinh nhu sau:
    ho ten
    so thich
    khu vuc: 1- thanh pho, 2 - tinh
    diem trung binh

    1. nhap va xuat 1 hoc sinh
    2. tao thong tin cho hoc sinh thu 2 bang cach sao chep
    thong tin cua hoc sinh 1 cho hoc sinh 2
*/

#include<stdio.h>
#include<string.h>

int main()
{
    char hoTen[50];
    char soThich[50];
    char khuVuc; //chi co gia tri 1, 2 nen dung char
    float diemTrungBinh;

    printf("Nhap ho ten: ");
    gets(hoTen);
    printf("Nhap so thich: ");
    gets(soThich);
    printf("Nhap khu vuc (1-thanh pho, 2-tinh): ");
    scanf("%d", &khuVuc); //dinh dang %d de in so
    printf("Nhap diem trung binh: ");
    scanf("%f", &diemTrungBinh);

    printf("\nHo ten: %s", hoTen);
    printf("\nSo thich: %s", soThich);
    printf("\nKhu vuc: %d", khuVuc);
    printf("\nDiem trung binh: %.2f", diemTrungBinh);

    char hoTen2[50];
    char soThich2[50];
    char khuVuc2; //chi co gia tri 1, 2 nen dung char
    float diemTrungBinh2;

    strcpy(hoTen2, hoTen);
    strcpy(soThich2, soThich);
    khuVuc2 = khuVuc;
    diemTrungBinh2 = diemTrungBinh;
    printf("\n\nHo ten: %s", hoTen2);
    printf("\nSo thich: %s", soThich2);
    printf("\nKhu vuc: %d", khuVuc2);
    printf("\nDiem trung binh: %.2f", diemTrungBinh2);

    return 0;
}