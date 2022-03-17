/*
viet chuong trinh quan ly hang hoa
moi mat hang bao gom:
    ma hang
    ten hang
    ngay nhap
    so luong
    don gia
    khuyen mai
    trang thai(co khuyen mai hay khong khuyen mai)
a. nhap ds cac mat hang
b. xuat ds cac mat hang
c. tinh tong thanh tien cua tat ca cac mat hang.
    thanh tien = so luong * don gia - khuyen mai
d. tinh tong so luong cua tat ca cac mat hang
e. co bao nhieu mat hang dang khuyen mai
*/

#include<stdio.h>
#include<string.h>
#define MAX 50

struct MatHang
{
    char maHang[10];
    char tenHang[30];
    char ngayNhap[30];
    int soLuong;
    int donGia;
    int khuyenMai;
    int trangThai;
};
typedef struct MatHang MH;

void nhap1MH(MH &mh);
void xuat1MH(MH mh);

int main()
{
    MH mh1;
    nhap1MH(mh1);
    xuat1MH(mh1);

    return 0;
}
void nhap1MH(MH &mh)
{
    printf("Nhap ma hang: ");
    gets(mh.maHang);
    printf("Nhap ten hang: ");
    gets(mh.tenHang);
    printf("Nhap ngay nhap hang; ");
    gets(mh.ngayNhap);
    printf("Nhap so luong: ");
    scanf("%d", &mh.soLuong);
    printf("Nhap don gia: ");
    scanf("%d", &mh.donGia);
    printf("Nhap gia khuyen mai: ");
    scanf("%d", &mh.khuyenMai);
    do{
        printf("Nhap trang thai mat hang (1 - khuyen mai, 2 - khong khuyen mai): ");
        scanf("%d", &mh.trangThai); 
    } while (mh.trangThai != 1 && mh.trangThai != 2);
}
void xuat1MH(MH mh)
{
    printf("\n|%-5s|%-15s|%-15s|%5d|%10d|%10d|%2d",
        mh.maHang, mh.tenHang, mh.ngayNhap, mh.soLuong, mh.donGia, mh.khuyenMai, mh.trangThai);
}