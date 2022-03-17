#include<stdio.h>
#include<stdlib.h>

int stringLength(const char string[]);
int main()
{
    const char word[] = "Topson";
    const char word2[] = "nguyen tuan cuong";
    printf("%d  %d", stringLength(word), stringLength(word2));
    return 0;
}
int stringLength(const char string[])
{
    int count = 0;
    while (string[count] != '\0')
        count++;
    return count;
}