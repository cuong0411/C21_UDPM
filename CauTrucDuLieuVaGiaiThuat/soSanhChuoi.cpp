#include<stdio.h>
#include<string.h>

int main() {

    char s1[31];
    char s2[50];
    printf("Chuoi 1: ");
    gets(s1);
    printf("Chuoi 2: ");
    gets(s2);
    printf("Hai chuoi da nhap la: %s va %s\n", s1, s2);
    int kq = strcmp(s1, s2);
    if(kq > 0)
        printf("s1 lon hon s2");
    else if(kq == 0)
        printf("s1 = s2");
    else
        printf("s1 nho hon s2");

    char s3[30];
    strcpy(s3, s1);
    printf("\nChuoi s3 sau khi duoc copy tu s1 la %s", s3);

    return 0;
}