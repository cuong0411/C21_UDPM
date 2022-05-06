#include <stdio.h>
#include <stdlib.h>

// cau truc cua 1 node
typedef struct tagNode
{
	int info;
	struct tagNode *pNext;
}
NODE;

// danh sach
typedef struct list
{
	NODE *pHead;
	NODE *pTail;
}LIST;

void khoiTao(LIST &l);
NODE *taoNode(int x);
void themDau(LIST &l, NODE *new_ele);
void themCuoi(LIST &l, NODE *new_ele);
void nhapDS(LIST &l);
void xuatDS(LIST l);
void xuatChan(LIST l);
int demNode(LIST l);
NODE *timMax(LIST l);
int laSoNT(int x);
int demSoNT(LIST l);

int main()
{
	LIST list;
	nhapDS(list);
	xuatDS(list);
	
	/*
	// them cuoi
	NODE *new_ele = taoNode(-100);
	themCuoi(list, new_ele);
	xuatDS(list);
	*/
	
	// liet ke cac phan tu chan
	printf("\n");
	xuatChan(list);
	
	int count = demNode(list);
	printf("\nSo luong node: %d", count);
	
	// tim phan tu co gia tri lon nhat
	NODE *max = timMax(list);
	printf("\nPhan tu co gia tri lon nhat: %d", max->info);
	
	// dem so nguyen to
	int soNT = demSoNT(list);
	printf("\nSo luong so nguyen to: %d", soNT);
	
	return 0;
}
void khoiTao(LIST &l)
{
	l.pHead = NULL;
	l.pTail = NULL;
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
	
	p->info =  x;
	p->pNext = NULL;
	return p;
}
void themDau(LIST &l, NODE *new_ele)
{
	if (l.pHead == NULL) // xau rong
	{
		l.pHead = new_ele;
		l.pTail = l.pHead;
	}
	else // ds da co node
	{
		new_ele->pNext = l.pHead;
		l.pHead = new_ele;
	}
}
void themCuoi(LIST &l, NODE *new_ele)
{
	// xau rong
	if (l.pHead == NULL)
	{
		l.pHead = new_ele;
		l.pTail = l.pHead;
	}
	else
	{
		l.pTail->pNext = new_ele;
		l.pTail = new_ele;
	}
}
void nhapDS(LIST &l)
{
	int x;
	NODE *p;
	khoiTao(l);
	do
	{
		printf("Nhap gia tri cho node - neu nhap 0 thi dung: ");
		scanf("%d", &x);
		if (x == 0)
		{
			break;
		}
		p = taoNode(x);
		themDau(l, p);
	}
	while (1);
}
void xuatDS(LIST l)
{
	NODE *p = l.pHead;
	while (p != NULL)
	{
		printf("%5d", p->info);
		p = p->pNext;
	}
}
void xuatChan(LIST l)
{
	NODE *p = l.pHead;
	int flag = 0;
	while (p)
	{
		if (p->info % 2 == 0)
		{
			printf("%d ", p->info);
			flag = 1;
		}
		p = p->pNext;
	}
	if (flag == 0)
	{
		printf("khong co phan tu la so chan");
	}
}
int demNode(LIST l)
{
	int length = 0;
	for (NODE *d = l.pHead; d!= NULL; d = d->pNext)
	{
		length++;
	}
	return length;
}
NODE *timMax(LIST l)
{
	NODE *pmax = l.pHead;
	for (NODE *p = l.pHead->pNext; p != NULL; p = p->pNext)
	{
		if (p->info > pmax->info)
		{
			pmax = p;
		}
	}
	return pmax;
}
int laSoNT(int x)
{
	if (x <= 1)
	{
		return -1;
	}
	if (x == 2)
	{
		return 1;
	}
	for (int i = 2; i < x; i++)
	{
		if (x % i == 0)
		{
			return -1;
		}
	}
	return 1;
}
int demSoNT(LIST l)
{
	int count = 0;
	for (NODE *p = l.pHead; p != NULL; p = p->pNext)
	{
		if (laSoNT(p->info) == 1)
		{
			count++;
		}
	}
	return count;
}
