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
#define MAX 100
int main()
{
    

	char hoTen[30];
	char soThich[50];
	char khuVuc;
	float diemTB;
	
	printf("SoThich: ");
	gets(soThich);
	printf("\nSo thich la: %s", soThich);
	
	printf("nhap HoTen: ");
	gets(hoTen);

	fflush(stdin);
	printf("KhuVuc(1=thanh pho, 2=tinh): ");
	scanf("%c", &khuVuc);
	
	printf("DiemTB: ");
	scanf("%f", &diemTB);

	//fflush(stdin);
	printf("\nSo thich la: %s", soThich);
	printf("\nHo ten la: %s", hoTen);
	printf("\nKhu vuc la: %c", khuVuc);
	printf("\nDiem trung binh la: %f", diemTB);
	
    return 0;
	
}