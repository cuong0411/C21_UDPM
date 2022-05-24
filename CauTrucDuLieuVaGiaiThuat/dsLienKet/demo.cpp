#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct SACH
{
	
}
sach;
typedef struct NODE
{
	sach data;
	struct NODE *next;
}
node;
typedef struct LIST
{
	node *head;
	node *tail;
}
list;

node *taoNode(sach s)
{
	
}
void taoList(list &l)
{
	l.head = NULL;
	l.tail = NULL;
}
void themCuoi(list &l, sach s)
{
	
}
void nhap1Sach(sach s)
{
	
}
void xuat1Sach(sach s)
{
	
}
void nhapList(list &l)
{
	
}
void xuatList(list l)
{
	
}
void showMenu()
{
	
}
int main()
{
	list l;
	int choice;
	do
	{
		printf("Nhap lua chon cua ban: ");
		scanf("%d", &choice);
		showMenu();
		switch (choice)
		{
			case 0:
				break;
			case 1:
				//
				break;
			case 2:
				//
				break;
			default:
				//
				break;
		}
		
	} while (choice != 0);
	
	return 0;
}
