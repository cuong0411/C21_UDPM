#include <stdio.h>
#include <stdlib.h>
#include <string.h>


typedef struct SinhVien
{
	int mssv;
	char hoTen[20];
	char gioiTinh[20];
	char diaChi[20];
	float dtb;
}
SV;

typedef struct Node
{
	SV sv;
	struct Node *next;
}
node;
typedef struct LIST
{
	node *head;
	node *tail;
}
list;

void nhap1SV(SV &sv);
void xuat1SV(SV sv);
node *taoNode(SV sv);
void taoList(list &l);
void themCuoi(list &l, node *new_element);
void nhapDS(list &l);
void xuatDS(list l);
int soLuongSVNam(list l);
void lietKeSV(list l);
void interchangeSortDTB(list l);
void hoanViSV(SV &sv1, SV &sv2);
void interchangeSortMSSV(list l);
void xoaCuoi(list &l);
void xoaDau(list &l);

int main()
{
	list l;
	nhapDS(l);
	xuatDS(l);
	
	// liet ke sv co dtb >= 5
//	lietKeSV(l);
	
//	printf("\nDS SV tang dan theo dtb\n");
//	interchangeSortDTB(l);
//	xuatDS(l);
	
//	printf("\nDS SV tang dan theo mssv\n");
//	interchangeSortMSSV(l);
//	xuatDS(l);
	
//	// 7
//	printf("\nSo luong sv nam: %d", soLuongSVNam(l));

	printf("\n");
	// xoaDau(l);
	xoaCuoi(l);
	xuatDS(l);

	return 0;
}
void nhap1SV(SV &sv)
{
	printf("Nhap mssv: ");
	scanf("%d", &sv.mssv);
	fflush(stdin);
	printf("Nhap ho ten: ");
	gets(sv.hoTen);
	printf("Nhap gioi tinh: ");
	gets(sv.gioiTinh);
	printf("Nhap dia chi: ");
	gets(sv.diaChi);
	printf("Nhap diem tb: ");
	scanf("%f", &sv.dtb);
}
void xuat1SV(SV sv)
{
	printf("%-5d | %-10s | %-10s | %-10s | %-5.2f", sv.mssv, sv.hoTen, sv.gioiTinh, sv.diaChi, sv.dtb);
}
node *taoNode(SV sv)
{
	node *n = (node *)malloc(sizeof(node));
	if (n == NULL)
	{
		printf("khong cap phat duoc vung nho");
		exit(0);
	}
	n->sv = sv;
	n->next = NULL;
	return n;
}
void taoList(list &l)
{
	l.head = NULL;
	l.tail = NULL;
}
void themCuoi(list &l, node *new_element)
{
	if (l.head == NULL)
	{
		l.head = new_element;
		l.tail = l.head;
	}
	else
	{
		l.tail->next = new_element;
		l.tail = new_element;
	}
}
void nhapDS(list &l)
{
	taoList(l);
	node *n;
	SV sv;
	int sl;
	printf("Nhap so luong sv: ");
	scanf("%d", &sl);
	for (int i = 0; i < sl; i++)
	{
		nhap1SV(sv);
		n = taoNode(sv);
		themCuoi(l, n);
	}
	
}
void xuatDS(list l)
{
	for (node *n = l.head; n != NULL; n = n->next)
	{
		xuat1SV(n->sv);
		printf("\n");
	}
}
int soLuongSVNam(list l)
{
	int sl = 0;
	for (node *n = l.head; n != NULL; n = n->next)
	{
		if (strcmp(n->sv.gioiTinh, "nam") == 0)
		{
			sl++;
		}
	}
	return sl;
}
//void xoaSV(list &l, int mssv)
//{
//	for (node *n = l.head; n != NULL; n = n->next)
//	{
//		if (n->sv.mssv == mssv)
//		{
//			if (n == l.head)
//			{
//				l.head = n->next;
//			}
//			
//		}
//	}
//}
void lietKeSV(list l)
{
	for (node *n = l.head; n != NULL; n = n->next)
	{
		if (n->sv.dtb >= 5)
		{
			xuat1SV(n->sv);
			printf("\n");
		}
	}
}
void hoanViSV(SV &sv1, SV &sv2)
{
	SV temp;
	temp = sv1;
	sv1 = sv2;
	sv2 = temp;
	
}
void interchangeSortDTB(list l)
{
	for (node *i = l.head; i != NULL; i = i->next)
	{
		for (node *j = i->next; j != NULL;j = j->next)
		{
			if (i->sv.dtb > j->sv.dtb)
			{
				hoanViSV(i->sv, j->sv);
			}
		}
	}
}
void interchangeSortMSSV(list l)
{
	for (node *i = l.head; i != NULL; i = i->next)
	{
		for (node *j = i->next; j != NULL;j = j->next)
		{
			if (i->sv.mssv > j->sv.mssv)
			{
				hoanViSV(i->sv, j->sv);
			}
		}
	}
}
void xoaDau(list &l)
{
	node *n = (node *)malloc(sizeof(node));
	if (n == NULL)
	{
		exit(0);
	}
	n = l.head;
	l.head = l.head->next;
	free(n);
}
void xoaCuoi(list &l)
{
	node *n = (node *)malloc(sizeof(node));
	if (n == NULL)
	{
		exit(0);
	}
	n = l.tail;
	
	node *j;
	node *i;
	for (i = l.head, j ; i != NULL; j = i, i = i->next)
	{
		if (i == l.tail)
		{
			j->next = NULL;
			l.tail = j;
		}
	}
	free(n);
}
