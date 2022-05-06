#include <stdio.h>
#include <stdlib.h>

typedef tagNode
{
	int info;
	struct tagNode *pNext;
}
NODE;
typedef LIST
{
	NODE *pHead;
	NODE *pTail;
}
LIST;

int main()
{
	return 0;
}
NODE *taoNode(int x)
{
	NODE *p;
	p = new NODE;
	if (p == NULL)
	{
		printf("khong cap phat duoc vung nho, ket thuc");
		exit(0);
	}
	
	p->info = x;
	p->pNext = NULL;
	return p;
}
void themDau(LIST &l, NODE *new_ele)
{
	
}
