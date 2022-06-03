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
    printf("Nhap ma nsx (nhap 'thoat' de dung viec nhap): ");
    gets(s.ma);
    if (strcmp(s.ma, "thoat") == 0)
    {
    	printf("\nBan da thoat\n");
	}
	else
	{
		printf("Nhap ten nsx: ");
	    gets(s.ten);
	    do
	    {
	    	fflush(stdin);
	    	printf("Nhap loai sp: b - banh, k - keo, s - sua: ");
	    	scanf("%c", &s.loaisp);
		} while (s.loaisp != 'b' && s.loaisp != 'k' && s.loaisp != 's');
	    printf("Nhap von: ");
	    scanf("%f", &s.von);
	}
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
	printf(" %-6s | %-5.2f", loaisp, s.von);
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
void hoanViNSX(nsx &s1, nsx &s2)
{
    nsx temp;
    temp = s1;
    s1 = s2;
    s2 = temp;
}
void interchangeSortLoaisp(list &l)
{
    for (node *x = l.head; x != NULL; x = x->next)
    {
        for (node *y = x->next; y != NULL; y = y->next)
        {
            if (y->data.loaisp < x->data.loaisp)
            {
                hoanViNSX(y->data, x->data);
            }
        }
    }
}
void timMaNSX(list l, char ma[])
{
	int flag = 0;
	for (node *n = l.head; n != NULL; n = n->next)
	{
		if (strcmp(n->data.ma, ma) == 0)
		{
			flag = 1;
			xuat1NSX(n->data);
			printf("\n");
		}
	}
	if (flag == 0)
	{
		printf("\nTim khong thay\n");
	}
}
void suaVon(list &l, char ten[], float von)
{
	int flag = 0;
	for (node *n = l.head; n != NULL; n = n->next)
	{
		if (strcmp(n->data.ten, ten) == 0)
		{
			flag = 1;
			n->data.von = von;
		}
	}
	if (flag == 0)
	{
		printf("\nTim khong thay\n");
	}
}
float maxVon(list l)
{
	float max = l.head->data.von;
	for (node *n = l.head->next; n != NULL; n = n->next)
	{
		if (n->data.von > max)
		{
			max = n->data.von;
		}
	}
	return max;
}
void xuatMaxVon(list l)
{
	float max = maxVon(l);
	for (node *n = l.head; n != NULL; n = n->next)
	{
		if (n->data.von == max)
		{
			xuat1NSX(n->data);
			printf("\n");
		}
	}
}
void showMenu()
{
	printf("\t\t ===================MENU=========================\n");
	printf("\t\t |0. Thoat                                      |\n");
	printf("\t\t |1. nhap danh sach NSX                         |\n");
	printf("\t\t |2. xuat danh sach NSX                         |\n");
	printf("\t\t |3. sap xep danh sach giam gan theo loaisp     |\n");
	printf("\t\t |4. tim phan tu theo ma nhap vao               |\n");
	printf("\t\t |5. sua von theo ten duoc nhap                 |\n");
	printf("\t\t |6. thong tin nsx co von lon nhat              |\n");
	printf("\t\t ================================================\n");
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
				printf("\nThoat chuong trinh\n");
				break;
			case 1:
				nhapList(l);
				break;
			case 2:
				printf("\nXuat danh sach NSX\n");
				xuatList(l);
				break;
			case 3:
				interchangeSortLoaisp(l);
				break;
			case 4:
				char ma[6];
				printf("Nhap ma de tim: ");
				fflush(stdin);
				gets(ma);
				timMaNSX(l, ma);
				break;
			case 5:
				fflush(stdin);
				char ten[20];
				printf("\nNhap ten de tim trong ds: ");
				gets(ten);
				float von;
				printf("\nNhap so von de chinh sua: ");
				scanf("%f", &von);
				suaVon(l, ten, von);
				break;
			case 6:
				xuatMaxVon(l);
				break;
			default:
				printf("\nGia tri nhap khong hop le\n");
				break;
		}
		
	} while (choice != 0);
	
	return 0;
}
