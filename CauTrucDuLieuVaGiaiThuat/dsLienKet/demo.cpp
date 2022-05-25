#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct SACH
{
	char masach[4];
    char tensach[15];
    int namxuatban;
    float trigia;
} sach;
typedef struct NODE
{
	sach data;
	struct NODE *next;
} node;
typedef struct LIST
{
	node *head;
	node *tail;
} list;

node *taoNode(sach s)
{
	node *n = (node *)malloc(sizeof(node));
	if (n == NULL)
	{
		printf("Khong the cap phat vung nho");
		exit(0);
	}
	n->data = s;
	n->next = NULL;

	return n;
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
void nhap1Sach(sach &s)
{
	fflush(stdin);
    printf("Nhap ma sach: ");
    gets(s.masach);
    printf("Nhap ten sach: ");
    gets(s.tensach);
    printf("Nhap nam xuat ban: ");
    scanf("%d", &s.namxuatban);
    printf("Nhap tri gia: ");
    scanf("%f", &s.trigia);
}
void xuat1Sach(sach s)
{
	printf("%-5s | %-15s | %-5d | %-5.2f", s.masach, s.tensach, s.namxuatban, s.trigia);
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
        sach s;
        nhap1Sach(s);
        themCuoi(l, s);
    }
}
void xuatList(list l)
{
	for (node *n = l.head; n != NULL; n = n->next)
    {
        xuat1Sach(n->data);
        printf("\n");
    }
}
void showMenu()
{
	printf("\t ============MENU================================\n");
	printf("\t |0. Thoat                                      |\n");
	printf("\t |1. nhap danh sach cuon sach                   |\n");
	printf("\t |2. xuat danh sach cuon sanh                   |\n");
	printf("\t ================================================\n");
}
int main()
{
	list l;
	int choice;
	do
	{
		showMenu();
		printf("\nNhap lua chon cua ban: ");
		scanf("%d", &choice);
		switch (choice)
		{
			case 0:
				break;
			case 1:
				nhapList(l);
				break;
			case 2:
				xuatList(l);
				break;
			default:
				printf("\nGia tri nhap khong hop le\n");
				break;
		}
		
	} while (choice != 0);
	
	return 0;
}
