/*
viet chuong trinh quan ly ho so nhan vien trong 1 cong ty,
thong tin nhan vien gom:
    ho ten
    phai
    ngay sinh
    dia chi
    luong co ban
    bao hiem xa hoi
    thuong
    phat
    luong thuc linh
luong thuc linh = luong co ban + thuong - bao hiem xa hoi - phat
viet chuong trinh thuc hien nhung cong viec sau:
    a. nhap mang nhan vien
    b. xuat mang nhan vien
    c. tinh trung binh so tien phat cua mot nhan vien
    d. in danh sach cac nhan vien nu
*/

#include<stdio.h>
#include<string.h>
#define MAX 50

struct NhanVien
{
    char hoTen[30];
    char phai[4];
    char ngaySinh[15];
    char diaChi[20];
    float luongCB;
    float BHXH;
    float thuong;
    float phat;
    float luongThucLinh;
};
typedef struct NhanVien NV;

void nhap1NV(NV &nv);
void xuat1NV(NV nv);
void nhapMangNV(NV mangNV[], int &soNV);
void xuatMangNV(NV mangNV[], int soNV);
void inDSNu(NV mangNV[], int soNV);

int main()
{
    NV nv[MAX];
    int soNV;
    nhapMangNV(nv, soNV);
    xuatMangNV(nv, soNV);

    inDSNu(nv, soNV);

    return 0;
}
void nhap1NV(NV &nv)
{
    fflush(stdin);
    printf("\nNhap ho ten nhan vien: ");
    gets(nv.hoTen);

    do{
    printf("Nhap phai nhan vien: ");
    gets(nv.phai);
    } while (strcmp(nv.phai, "nu") != 0 && strcmp(nv.phai, "nam") != 0);
    
    printf("Nhap ngay sinh nhan vien: ");
    gets(nv.ngaySinh);
    printf("Nhap dia chi nhan vien: ");
    gets(nv.diaChi);
    fflush(stdin);

    printf("Nhap luong co ban nhan vien: ");
    scanf("%f", &nv.luongCB);
    printf("Nhap BHXH nhan vien: ");
    scanf("%f", &nv.BHXH);
    printf("Nhap tien thuong nhan vien: ");
    scanf("%f", &nv.thuong);
    printf("Nhap tien phat cua nhan vien: ");
    scanf("%f", &nv.phat);

    nv.luongThucLinh = nv.luongCB + nv.thuong - nv.BHXH - nv.phat;
}
void xuat1NV(NV nv)
{
    printf("\n%-20s|%-5s|%-10s|%-15s|%-10.2f|%-10.2f|%-10.2f|%-10.2f|%-10.2f",
            nv.hoTen, nv.phai, nv.ngaySinh, nv.diaChi, nv.luongCB, nv.BHXH, nv.thuong, nv.phat, nv.luongThucLinh);
}
void nhapMangNV(NV mangNV[], int &soNV)
{
    do{
        printf("Nhap so nhan vien: ");
        scanf("%d", &soNV);
    } while (soNV <= 0);
    for (int i=0; i<soNV; i++)
    {
        nhap1NV(mangNV[i]);
    }
}
void xuatMangNV(NV mangNV[], int soNV)
{
    for (int i = 0; i < soNV; i++)
    {
        xuat1NV(mangNV[i]);
    }
}
void inDSNu(NV mangNV[], int soNV)
{
    printf("\nDanh sach nhan vien nu:");
    for (int i = 0; i < soNV; i++)
    {
        if (strcmp(mangNV[i].phai, "nu") == 0)
        {
            xuat1NV(mangNV[i]);
        }
    }
}