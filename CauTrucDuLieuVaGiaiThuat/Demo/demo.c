#include<stdio.h>

void xuat(char ch[])
{
    printf("\nIn xuat function\n");
    printf("\nSizeof with ch: %lld", sizeof(ch));
    printf("\nCharacter array is: %s", ch);
}
int main()
{
    char ch[] = "Ana Pham win 2 TI";
    //xuat(ch);
    if(&ch == ch)
        printf("Bang nhau\n");
    else
        printf("Khong bang nhau\n");
    printf("\n%p", &ch);
    printf("\n%p", ch);
    
    return 0;
}
