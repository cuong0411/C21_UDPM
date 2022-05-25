#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct SACH
{
	//
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
	node *n = (node *)malloc(sizeof(node));
	if (n == NULL)
	(
		printf("Khong the cap phat vung nho");
		exit(0);
	)
	n->data = s;
	n->next = NULL;
}
void taoList(list &l)
{
	l.head = NULL;
	l.tail = NULL;
}
void themCuoi(list &l, sach s)
{
	node *n = taoNode(s);

	if (l.head == NULL)
	{
		l.head = n;
		l.tail = l.head;
	}
	else
	{
		l.tail->next = n;
		l.tail = n;
	}
}
void nhap1Sach(sach s)
{
	//
}
void xuat1Sach(sach s)
{
	//
}
void nhapList(list &l)
{
	taoList(l);
    int soLuong;
    do
    {
        printf("Nhap so luong : ");
        scanf("%d", &soLuong);
    } while (soLuong <= 0);

    for (int i = 0; i < soLuong; i++)
    {
        // sach s;
        // nhap1Sach(s);
        node *n = taoNode(s);
        themCuoi(l, n);
    }
}
void xuatList(list l)
{
	for (node *n = l.head; n != NULL; n = n->next)
    {
        // xuat1Sach(n->data);
        printf("\n");
    }
}
void showMenu()
{
	printf("\t ============MENU================================\n");
        printf("\t |1. nhap danh sach cuon sach                   |\n");
        printf("\t |2. xuat danh sach cuon sanh                   |\n");
        printf("\t |3. sap xep mang tang dan theo ma sach         |\n");
        printf("\t |4. tim phan tu co ten sach bang x             |\n");
        printf("\t |5. xua lai ten sach theo ma da nhap           |\n");
        printf("\t |6. tim sach co tri gia nho nhat               |\n");
        printf("\t |7. them 1 cuon sach x vao trong ds o vi tri k |\n");
        printf("\t |8. Thoat                                      |\n");
        printf("\t ================================================\n");
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
