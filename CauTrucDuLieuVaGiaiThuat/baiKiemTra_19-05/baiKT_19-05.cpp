/*
NGUYEN TUAN CUONG
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct Sach
{
    char masach[4];
    char tensach[15];
    int namxuatban;
    float trigia;
}
sach;

typedef struct Node
{
    sach data;
    struct Node *next;
}
node;

typedef struct LIST
{
    node *head;
    node *tail;
}
list;

void nhap1Sach(sach &s);
void xuat1Sach(sach s);
void khoiTaoList(list &l);
node *taoNode(sach s);
void themCuoi(list &l, node *new_element);
void nhapDS(list &l);
void xuatDS(list l);
void hoanViSach(sach &s1, sach &s2);
void interchangeMaSach(list &l);
void timTenSach(list l, char tensach[15]);
void suaTenSach(list &l, char masach[4]);
float minTriGia(list l);
void sachCoTriGiaMin(list l);
void themSach(list l, sach s, int k);

int main()
{
    // // cau 1, 2
    list l;
    // nhapDS(l);
    // xuatDS(l);
    int choice;
    do
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
        printf("Ban chon: ");
        scanf("%d", &choice);
        switch (choice)
        {
            case 1:
                nhapDS(l);
                break;
            case 2:
                xuatDS(l); 
                break;
            case 3:
                printf("\nSap xep ds\n");
                interchangeMaSach(l);
                break;
            case 4:
                printf("\nNhap ten sach can tim: ");
                char tensach[15];
                fflush(stdin);
                gets(tensach);
                timTenSach(l, tensach);
                break;
            case 5:
                printf("Nhap ma sach can tim: ");
                char masach[4];
                fflush(stdin);
                gets(masach);
                suaTenSach(l, masach);
                break;
            case 6:
                printf("\nSach co tri gia nho nhat\n");
                sachCoTriGiaMin(l);
                break;
            case 7:
                sach s;
                nhap1Sach(s);
                int k;
                printf("Nhap vi tri k (bat dau tu 0): ");
                scanf("%d", &k);
                themSach(l, s, k);
                break;
            case 8:
                break;
            default:
                printf("khong hop le");
                break;
        }
    } while (choice != 8);

    return 0;
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
void khoiTaoList(list &l)
{
    l.head = NULL;
    l.tail = NULL;
}
node *taoNode(sach s)
{
    node *n = (node *)malloc(sizeof(node));
    if (n == NULL)
    {
        printf("Khong the khoi tao vung nho");
        exit(0);
    }

    n->data = s;
    n->next = NULL;

    return n;
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
    khoiTaoList(l);
    int soLuong;
    do
    {
        printf("Nhap so luong sach: ");
        scanf("%d", &soLuong);
    } while (soLuong <= 0);

    for (int i = 0; i < soLuong; i++)
    {
        sach s;
        nhap1Sach(s);
        node *n;
        n = taoNode(s);
        themCuoi(l, n);
    }
}
void xuatDS(list l)
{
    for (node *n = l.head; n != NULL; n = n->next)
    {
        xuat1Sach(n->data);
        printf("\n");
    }
}
void hoanViSach(sach &s1, sach &s2)
{
    sach temp;
    temp = s1;
    s1 = s2;
    s2 = temp;
}
void interchangeMaSach(list &l)
{
    for (node *x = l.head; x != NULL; x = x->next)
    {
        for (node *y = x->next; y != NULL; y = y->next)
        {
            if (strcmp(y->data.masach, x->data.masach) < 0)
            {
                hoanViSach(y->data, x->data);
            }
        }
    }
}
void timTenSach(list l, char tensach[15])
{
    int index = 0;
    int flag = 0;
    for (node *n = l.head; n != NULL; n = n->next)
    {
        if (strcmp(n->data.tensach, tensach) == 0)
        {
            flag = 1;
            printf("Da tim thay %s tai vi tri %d", tensach, index);
            break;
        }
        index++;
    }
    if (flag == 0)
    {
        printf("Tim khong thay");
    }
}
void suaTenSach(list &l, char masach[4])
{
    int flag = 0;
    for (node *n = l.head; n != NULL; n = n->next)
    {
        if (strcmp(n->data.masach, masach) == 0)
        {
            flag = 1;
            printf("Nhap ten sach de chinh sua: ");
            char tensach[15];
            fflush(stdin);
            gets(tensach);
            strcpy(n->data.tensach, tensach);
            break;
        }
    }
    if (flag == 0)
    {
        printf("Khong tim thay ma sach");
    }
}
float minTriGia(list l)
{
    float min = l.head->data.trigia;

    for (node *n = l.head->next; n != NULL; n = n->next)
    {
        if (n->data.trigia < min)
        {
            min = n->data.trigia;
        }
    }
    return min;
}
void sachCoTriGiaMin(list l)
{
    float min = minTriGia(l);
    for (node *n = l.head; n != NULL; n = n->next)
    {
        if (n->data.trigia == min)
        {
            xuat1Sach(n->data);
            printf("\n");
        }
    }
}
void themSach(list l, sach s, int k)
{
    int index = 0;
    node *a = taoNode(s);
    int flag = 0;

    node *n;
    for (n = l.head; n != NULL; n = n->next)
    {
        if (index == k - 1)
        {
            flag = 1;
            a->next = n->next;
            n->next = a;
            break;
        }
        index++;
    }

    if (flag == 0)
    {
        printf("k khong hop le");
    }
}