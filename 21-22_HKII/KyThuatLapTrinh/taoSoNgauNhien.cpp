#include<stdio.h>
#include<stdlib.h>
#include<time.h>

int main()
{
  srand((unsigned int)time(NULL));
  for(int i=0; i<=10; i++){
    int a = rand()%(9 * 2 + 1) - 9; // ngau nhien tu -9 toi 9
    printf("%d", a);
  }
  return 0;
}
