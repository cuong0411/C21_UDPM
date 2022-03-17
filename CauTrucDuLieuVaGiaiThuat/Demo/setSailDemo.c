#include<stdio.h>

void go_south_east(int *lat, int *lon)
{
    *lat = *lat - 1;
    *lon = *lon + 1;
}

void nhapSo(int *so);
int main()
{
    int latitude = 32;
    int longtitude = -64;
    go_south_east(&latitude, &longtitude);
    printf("Avast! Now at: [%i, %i]\n", latitude, longtitude);

    int so = 10;
    nhapSo(&so);
    printf("\nBien so sau khi di vao ham = %d", so);
    return 0;
}
void nhapSo(int *so)
{
    printf("Nhap so: ");
    scanf("%d", so);
}