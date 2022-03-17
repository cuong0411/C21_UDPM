/* NGUYEN TUAN CUONG
nhap vao 2 chuoi s1, s2 va cho biet:
    1. chieu dai cua tung chuoi
    2. chuyen chuoi da nhap sang chuoi in hoa
    3. so sanh s1 va s2 (theo ma ASCII)
    4. noi s2 vao s1
    5. chep gia tri cua s2 vao cho chuoi s
*/

#include<stdio.h>
#include<string.h>

int main()
{
    char s1[50];
    char s2[50];

    printf("Nhap chuoi s1: ");
    gets(s1);
    printf("Nhap chuoi s2: ");
    gets(s2);
    printf("Chuoi s1 da nhap la: %s", s1);
    printf("\nChuoi s2 da nhap la: %s", s2);

    printf("\n\nCau1");
    printf("\nChieu dai chuoi s1 la: %d", strlen(s1));
    printf("\nChieu dai chuoi s2 la: %d", strlen(s2));

    printf("\n\nCau2");
    strupr(s1);
    strupr(s2);
    printf("\nChuoi s1 da nhap la: %s", s1);
    printf("\nChuoi s2 da nhap la: %s", s2);

    printf("\n\nCau 3\n");
    int kq = strcmp(s1, s2);
    if(kq > 0)
        printf("s1 lon hon s2");
    else if(kq == 0)
        printf("s1 bang s2");
    else
        printf("s1 nho hon s2");
    
    printf("\n\nCau4");
    strcat(s1, s2);
    printf("\nChuoi s1 sau khi duoc noi them s2: %s", s1);

    printf("\n\nCau5");
    char s[50];
    strcpy(s, s2);
    printf("\nChuoi s sau khi duoc copy tu chuoi s2: %s", s);

    return 0;
}
