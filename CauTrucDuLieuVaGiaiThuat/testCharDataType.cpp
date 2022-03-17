#include<stdio.h>
#include<string.h>

int main()
{
    char diemSo;
    printf("Nhap diem so: ");
    scanf("%d", &diemSo);
    printf("\nDiem so ban da nhap la %d", diemSo);

    fflush(stdin);
    char kyTu;
    printf("\nNhap ky tu: ");
    scanf("%c", &kyTu);
    printf("\nKy tu da nhap la %d", kyTu);

    return 0;
}