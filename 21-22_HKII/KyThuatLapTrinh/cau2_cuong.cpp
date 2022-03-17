//NGUYEN TUAN CUONG
#include<stdio.h>
#include<math.h>
void ktSoN(int &n);
int main()
{
    int n;
    printf("Nhap n(n>1): ");
    ktSoN(n);
    unsigned long tong=0;
    for(int i=0; i<=n; i++)
        tong+=pow((2*i+1), 2);
    printf("Tong S1 la: %lu", tong);
    return 0;
}
void ktSoN(int &n)
{
    do{
        scanf("%d", &n);
        if(n<=1)
            printf("Nhap lai: ");
    }while(n<=1);
}
