#include<stdio.h>

void skip(char *msg)
{
    puts(msg+6);
}
int main()
{
    char *msg_from_amy = "Don't call me";
    skip(msg_from_amy);
    printf("\n%p", msg_from_amy);
    printf("\n%p", msg_from_amy+1);
    printf("\n%c", *(msg_from_amy+1));
    return 0;
}