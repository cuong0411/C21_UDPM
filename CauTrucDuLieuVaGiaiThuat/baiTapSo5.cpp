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
void nhapMangMH(MH mangMH[], int &soLuongMH);
void xuatMangMH(MH mangMH[], int soLuongMH);
long tinhThanhTien1MH(MH mh);
long tinhThanhTienMangMH(MH mangMH[], int soLuongMH);
long tinhSLMH(MH mangMH[], int soLuongMH);
long tinhSLMH(MH mangMH[], int soLuongMH);
int tinhMH_KhuyenMai(MH mangMH[], int soLuongMH);

int main()
{
    MH dsMatHang[MAX];
    int soLuongMH;

    nhapMangMH(dsMatHang, soLuongMH);
    xuatMangMH(dsMatHang, soLuongMH);

    long tong = tinhThanhTienMangMH(dsMatHang, soLuongMH);
    printf("\nTong thanh tien tat ca cac mat hang la: %ld", tong);

    long sl = tinhSLMH(dsMatHang, soLuongMH);
    printf("\nTong so luong tat ca cac mat hang: %ld", sl);

    int slKM = tinhMH_KhuyenMai(dsMatHang, soLuongMH);
    printf("\nSo mat hang dang co khuyen mai la: %d", slKM);

    return 0;
}
void nhap1MH(MH &mh)
{
    fflush(stdin);
    printf("Nhap ma hang: ");
    gets(mh.maHang);
    printf("Nhap ten hang: ");
    gets(mh.tenHang);
    printf("Nhap ngay nhap hang: ");
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
void nhapMangMH(MH mangMH[], int &soLuongMH)
{
    do{
        printf("Nhap so luong mat hang: ");
        scanf("%d", &soLuongMH);
        fflush(stdin);
    } while (soLuongMH <= 0);
    for (int i=0; i<soLuongMH; i++)
    {
        nhap1MH(mangMH[i]);
    }
}
void xuatMangMH(MH mangMH[], int soLuongMH)
{
    for (int i=0; i<soLuongMH; i++)
    {
        xuat1MH(mangMH[i]);
    }
}
long tinhThanhTien1MH(MH mh)
{
    return (long) mh.donGia * mh.soLuong - mh.khuyenMai;
}
long tinhThanhTienMangMH(MH mangMH[], int soLuongMH)
{
    long tong = 0;
    for (int i=0; i<soLuongMH; i++)
    {
        tong += tinhThanhTien1MH(mangMH[i]);
    }
    return tong;
}
long tinhSLMH(MH mangMH[], int soLuongMH)
{
    long tong = 0;
    for (int i=0; i<soLuongMH; i++)
    {
        tong += mangMH[i].soLuong;
    }
    return tong;
}
int tinhMH_KhuyenMai(MH mangMH[], int soLuongMH)
{
    int count = 0;
    for (int i=0; i<soLuongMH; i++)
    {
        if (mangMH[i].trangThai == 1)
        {
            count++;
        }
    }
    return count;
}