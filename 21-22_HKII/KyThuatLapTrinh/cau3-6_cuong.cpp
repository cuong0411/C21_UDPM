//NGUYEN TUAN CUONG
#include<stdio.h>
#define MAX 100

void ktSoDuong(int &so);
void nhapmang(int A[], int &N);
void xuatdk(int A[], int N);
int demdk(int A[], int N, int X);
void tichdk(int A[], int N);

int main()
{
    int A[MAX];
    int N;
    
    printf("Cau3 - nhap mang so nguyen\n");
    nhapmang(A, N);

    printf("======================================\n");
    printf("Nhap lua chon cua ban:\n");
    printf("4 - Xuat phan tu khong chia het cho 3\n");
    printf("5 - Xuat phan tu lon hon X\n");
    printf("6 - Xuat tich cac phan tu cuc dai\n");
    printf("======================================\n");

    int luachon;
    scanf("%d", &luachon);
    switch (luachon)
    {
    case 4:
        printf("So phan tu khong chia het cho 3 co trong mang la:\n");
        xuatdk(A, N);
        break;
    case 5:
        int x;
        printf("\nNhap so X: ");
        scanf("%d", &x);
        int dem;
        dem = demdk(A, N, x);
        printf("Trong mang co %d phan tu lon hon %d\n", dem, x);
        break;
    case 6:
        tichdk(A, N);
        break;
    default:
        printf("Khong hop le!");
        break;
    }

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
void nhapmang(int A[], int &N)
{
    printf("Nhap so phan tu cho A: ");
    ktSoDuong(N);

    for(int i=0; i<N; i++)
    {
        printf("A[%d] = ", i);
        scanf("%d", &A[i]);
    }
}
void xuatdk(int A[], int N)
{
    int dem=0;
    for(int i=0; i<N; i++)
    {
        if(A[i]%3!=0)
        {
            printf("%d ", A[i]);
            dem=1;
        }      
    }
    if(dem==0)
        printf("Khong co phan tu thoa dieu kien!\n");
}
int demdk(int A[], int N, int X)
{
    int dem=0;
    for(int i=0; i<N; i++)
    {
        if(A[i]>X)
            dem++;
    }
    return dem;
}
void tichdk(int A[], int N)
{
    if(N<3)
        printf("Trong mang khong co phan tu cuc dai.\n");
    else
    {
        unsigned long tich=1;
        int dem=0;
        for(int i=1; i<N-1; i++)
        {
            if(A[i]>A[i-1] && A[i]>A[i+1])
            {
                tich=tich*A[i];
                dem=1;
            }       
        }
        if(dem==0)
            printf("Trong mang khong co phan tu cuc dai.\n");
        else
            printf("Tich cac phan tu cuc dai trong mang la: %lu\n", tich);
    }
    
}
