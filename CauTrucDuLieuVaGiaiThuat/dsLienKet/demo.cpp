#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct NSX
{
	char ma[6];
	char ten[20];
	char loaisp;
	float von;
} nsx;
typedef struct NODE
{
	nsx data;
	struct NODE *next;
} node;
typedef struct LIST
{
	node *head;
	node *tail;
} list;

node *taoNode(nsx s)
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
void themCuoi(list &l, nsx s)
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
void nhap1NSX(nsx &s)
{
	fflush(stdin);
    printf("Nhap ma nsx: ");
    gets(s.ma);
    printf("Nhap ten: ");
    gets(s.ten);
    do
    {
    	fflush(stdin);
    	printf("Nhap loai sp: b - banh, k - keo, s - sua: ");
    	scanf("%c", &s.loaisp);
	} while (s.loaisp != 'b' && s.loaisp != 'k' && s.loaisp != 'c');
    printf("Nhap von: ");
    scanf("%f", &s.von);
}
void xuat1NSX(nsx s)
{
	printf("%-6s | %-20s |", s.ma, s.ten);
	char loaisp[6];
	if (s.loaisp == 'b')
	{
		strcpy(loaisp, "banh");
	}
	else if (s.loaisp == 'k')
	{
		strcpy(loaisp, "keo");
	}
	else
	{
		strcpy(loaisp, "sua");
	}
	printf(" %-6s |", loaisp);
	
	printf(" %-5.2f", s.von);
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
        nsx s;
        nhap1NSX(s);
        themCuoi(l, s);
    }
}
void xuatList(list l)
{
	for (node *n = l.head; n != NULL; n = n->next)
    {
        xuat1NSX(n->data);
        printf("\n");
    }
}
void showMenu()
{
	printf("\t ============MENU================================\n");
	printf("\t |0. Thoat                                      |\n");
	printf("\t |1. nhap danh sach NSX                   |\n");
	printf("\t |2. xuat danh sach NSX                   |\n");
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
