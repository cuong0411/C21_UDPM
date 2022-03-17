#include<stdio.h>

int main()
{
    // int x = 10;
    // int *address_of_x = &x;
    // int value_stored = *address_of_x;

    // printf("\nGia tri cua x = %d", x);
    // printf("\nDia chi cua x = %p", address_of_x);
    // printf("\nGia tri tu dia chi cua bien x = %d", value_stored);

    // *address_of_x = 20;
    // printf("\nGia tri cua x sau khi thay doi (dereference) = %d", x);
    // printf("\nGia tri cua x sau khi thay doi (dereference) = %d", *address_of_x);

    // //demo2
    // int a = 10;
    // printf("\n%d", a);
    // printf("\n%p", &a);
    // *(&a) = 20;
    // printf("\n%d", a);

    char msg[] = "HelloWorld from VSCODE";
    char *p_msg = msg;
    printf("%u bytes\n", sizeof(p_msg));
    printf("%u bytes\n", sizeof(msg));
    printf("\n%s", msg);
    printf("\nAddress = %p", msg);
    printf("\nAddress = %p", &msg[0]);

    int contestants[] = {1, 2, 3};
    int *choice = contestants;
    contestants[0] = 2;
    contestants[1] = contestants[2];
    contestants[2] = *choice;
    printf("I'm going to pick contestant number %i\n", contestants[2]);
    return 0;


    return 0;
}