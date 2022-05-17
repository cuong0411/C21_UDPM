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


int main()
{
	SV sv;
	nhap1SV(sv);
	xuat1SV(sv);
	
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
	scanf("%f", &sv.diaChi);
}
void xuat1SV(SV sv)
{
	printf("%d | %s | %s | %s | %f", sv.mssv, sv.hoTen, sv.gioiTinh, sv.diaChi, sv.dtb);
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
