/* NGUYEN TUAN CUONG
bai tap so 4
1. cau truc sinh vien
    ma so (so nguyen)
    ho ten (30 ky tu)
    chuc vu (1-giam doc, 2-pho giam doc, 3-nhan vien, 4-bao ve)
    luong (so thuc)
2. nhap va xuat mang nhan vien co n phan tu
3. tinh trung binh luong
4. cho biet so nhan vien theo tung chuc vu
5. tim nhan vien co luong cao nhat
*/

#include<stdio.h>
#include<string.h>
#define MAX 100

struct NhanVien
{
    int maSo;
    char hoTen[30];
    char chucVu;
    double luong;
};
typedef struct NhanVien NV;

void nhap1NV(NV &nv);
void xuat1NV(NV nv);
void nhapMangNV(NV mang[], int &soNhanVien);
void xuatMangNV(NV mang[], int soNhanVien);
double tinhTBLuong(NV mang[], int soNhanVien);
void xuatNVTheoChucVu(NV mang[], int soNhanVien);
NV timNVLuongCaoNhat(NV mang[], int soNhanVien);
int timNVLuongCaoNhat2(NV mang[], int soNhanVien);

int main()
{
    NV mangNV[MAX];
    int soNhanVien;
    nhapMangNV(mangNV, soNhanVien);
    xuatMangNV(mangNV, soNhanVien);
    printf("\nLuong trung binh cua cac nhan vien la: %.2lf", tinhTBLuong(mangNV, soNhanVien));
    xuatNVTheoChucVu(mangNV, soNhanVien);
    //NV nv = timNVLuongCaoNhat(mangNV, soNhanVien);
    int i = timNVLuongCaoNhat2(mangNV, soNhanVien);
    
    //printf("\nNhan vien co luong cao nhat la: %.2lf", nv.luong);
    xuat1NV(mangNV[i]);
    
    

    return 0;
}
void nhap1NV(NV &nv)
{
    printf("Nhap ma so: ");
    scanf("%d", &nv.maSo);
    fflush(stdin);
    printf("Nhap ho ten: ");
    gets(nv.hoTen);
    do{
        printf("Nhap chuc vu (1-giam doc, 2-pho giam doc, 3-nhan vien, 4-bao ve): ");
        scanf("%d", &nv.chucVu);
    } while(nv.chucVu != 1 && nv.chucVu != 2 &&
            nv.chucVu != 3 && nv.chucVu != 4 );
    printf("Nhap luong: ");
    scanf("%lf", &nv.luong);
}
void xuat1NV(NV nv)
{
	char s[30];
    printf("%-5d|%-15s|", nv.maSo, nv.hoTen);
    if(nv.chucVu == 1)
        strcpy(s,"giam doc");
    else if(nv.chucVu == 2)
        strcpy(s, "pho giam doc");
    else if(nv.chucVu == 3)
        strcpy(s, "nhan vien");
    else
        strcpy(s, "bao ve");
    printf("%-15s|", s);
    printf("%2.lf", nv.luong);

}
void nhapMangNV(NV mang[], int &soNhanVien)
{
    do{
        printf("Nhap so nhan vien: ");
        scanf("%d", &soNhanVien);
    } while(soNhanVien <= 0);
    for(int i = 0; i < soNhanVien; i++)
    {
        nhap1NV(mang[i]);
        printf("\n");
    }
}
void xuatMangNV(NV mang[], int soNhanVien)
{
    for(int i = 0; i < soNhanVien; i++)
    {
        xuat1NV(mang[i]);
        printf("\n");
    }
}
double tinhTBLuong(NV mang[], int soNhanVien)
{
    double tong = 0.0;
    for(int i = 0; i < soNhanVien; i++)
    {
        tong += mang[i].luong;
    }
    return tong/soNhanVien;
}
void xuatNVTheoChucVu(NV mang[], int soNhanVien)
{
    int cv1 = 0, cv2 = 0, cv3 = 0, cv4 = 0;
    for(int i = 0; i < soNhanVien; i++)
    {
        if(mang[i].chucVu == 1)
            cv1++;
        else if(mang[i].chucVu == 2)
            cv2++;
        else if(mang[i].chucVu == 3)
            cv3++;
        else
            cv4++;
    }
    printf("\nGiam doc - %d", cv1);
    printf("\nPho giam doc - %d", cv2);
    printf("\nNhan vien - %d", cv3);
    printf("\nBao ve - %d", cv4);
}
NV timNVLuongCaoNhat(NV mang[], int soNhanVien)
{
    int index = 0;
    for(int i = 1; i < soNhanVien; i++)
    {
        if(mang[index].luong < mang[i].luong)
            index = i;
    }
    return mang[index];
}

int timNVLuongCaoNhat2(NV mang[], int soNhanVien)
{
    int index = 0;
    for(int i = 1; i < soNhanVien; i++)
    {
        if(mang[index].luong < mang[i].luong)
            index = i;
    }
    return index;
}
