#include<stdio.h>
#include<string.h>

int main()
{
    char hoTen[31];
    printf("Yeu cau nhap ho ten: ");
    gets(hoTen);
    
    char diaChi[31];
    printf("Nhap dia chi: ");
    gets(diaChi);

    printf("Ho ten la: %s\n", hoTen);
    printf("Dia chi da nhap: %s\n", diaChi);

    strcat(hoTen, diaChi);
    printf("Chuoi hoTen sau khi thay doi: %s\n", hoTen);

    char ch = 'c';
    char *s = strchr(hoTen, ch); //con tro
    if(s!=NULL)
        printf("%c co trong chuoi %s", ch, hoTen);
    else
        printf("Khong co");
    
    return 0;
}
