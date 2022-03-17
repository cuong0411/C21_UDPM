#include<stdio.h>
#define MAX 100

void ktSoDuong(int &so);
void nhapMang(int mang[], int &soPhanTu);
void xuatMang(int mang[], int soPhanTu);

int main()
{
    int mang[MAX];
    int soPhanTu;
    
    nhapMang(mang, soPhanTu);
    xuatMang(mang, soPhanTu);

    return 0;
}
void ktSoDuong(int &so)
{
    do{
        scanf("%d", &so);
        if(so<=0)
            printf("Nhap lai:");
    }while(so<=0);
}
void nhapMang(int mang[], int &soPhanTu)
{
    printf("Nhap so phan tu cho mang: ");
    ktSoDuong(soPhanTu);

    for(int i=0; i<soPhanTu; i++)
    {
        printf("mang[%d] = ", i);
        scanf("%d", &mang[i]);
    }
}
void xuatMang(int mang[], int soPhanTu)
{
    printf("{");
    for(int i=0; i<soPhanTu; i++)
        printf("%d, ", mang[i]);
    printf("\b\b}\n");
}
