#include<stdio.h>
#include<string.h>
#define MAX 100

struct HocSinh
{
    char hoTen[MAX];
    char soThich[MAX];
    char khuVuc;
    float diemTrungBinh;
};
typedef struct HocSinh HS;

void nhap1HS(HS &s);
void xuat1HS(HocSinh s);
void nhapLopHoc(HS lopHoc[], int &soHocSinh);
void xuatLopHoc(HS lopHoc[], int soHocSinh);
float tinhDTB(HS lopHoc[], int soHocSinh);
void xuatHSTheoKV(HS lopHoc[], int soHocSinh);
void sxHS(HS mang[], int n);
void hoanViHS(HS &a, HS &b);
void selectSortSoThich(HS mang[], int n);
void selectSortHoTen(HS mang[], int n);
void interchangeSortHoTen(HS a[], int n);
void bubbleSortHoTen(HS a[], int n);
void insertionSortDiemTB(HS a[], int n);
void insertionSortHoTen(HS a[], int n);

int main()
{
    HS lopHoc[MAX];
    int soHocSinh;
    nhapLopHoc(lopHoc, soHocSinh);
    xuatLopHoc(lopHoc, soHocSinh);
    //printf("\nDiem trung binh cua ca lop = %.2f", tinhDTB(lopHoc, soHocSinh));
    //xuatHSTheoKV(lopHoc, soHocSinh);
    
    /*
    printf("\nLop hoc sau khi duoc sap xep theo diem trung binh\n");
    sxHS(lopHoc, soHocSinh);
    xuatLopHoc(lopHoc, soHocSinh);

    printf("\nLop hoc sau khi duoc sap xep theo ten\n");
    selectSortHoTen(lopHoc, soHocSinh);
    xuatLopHoc(lopHoc, soHocSinh);

    printf("\nLop hoc sau khi duoc sap xep theo so thich\n");
    selectSortSoThich(lopHoc, soHocSinh);
    xuatLopHoc(lopHoc, soHocSinh);
    */
    
    printf("\nSap xep theo ho ten\n");
    //interchangeSortHoTen(lopHoc, soHocSinh);
    //bubbleSortHoTen(lopHoc, soHocSinh);

    //insertionSortDiemTB(lopHoc, soHocSinh);
    insertionSortHoTen(lopHoc, soHocSinh);
    xuatLopHoc(lopHoc, soHocSinh);
    

    return 0;
}
void nhap1HS(HS &s)
{
    fflush(stdin);
    printf("Nhap ho ten hoc sinh: ");
    gets(s.hoTen);
    printf("Nhap so thich hoc sinh: ");
    gets(s.soThich);
    printf("Nhap khu vuc hoc sinh: ");
    scanf("%d", &s.khuVuc);
    printf("Nhap diem trung binh hoc sinh: ");
    scanf("%f", &s.diemTrungBinh);
}
void xuat1HS(HocSinh s)
{
    printf("%-15s|%-15s|", s.hoTen, s.soThich);
    if(s.khuVuc == 1)
        printf("Thanh pho |");
    else
        printf("Tinh      |");
    printf("%5.1f", s.diemTrungBinh);

}
void nhapLopHoc(HS lopHoc[], int &soHocSinh)
{
    do{
        printf("Nhap so hoc sinh: ");
        scanf("%d", &soHocSinh);
    } while(soHocSinh <= 0);
    for(int i = 0; i < soHocSinh; i++)
    {
        nhap1HS(lopHoc[i]);
        printf("\n");
    }
}
void xuatLopHoc(HS lopHoc[], int soHocSinh)
{
    for(int i = 0; i < soHocSinh; i++)
    {
        xuat1HS(lopHoc[i]);
        printf("\n");
    }
}
float tinhDTB(HS lopHoc[], int soHocSinh)
{
    float tong = 0.0;
    for(int i = 0; i < soHocSinh; i++)
    {
        tong += lopHoc[i].diemTrungBinh;
    }
    return tong/soHocSinh;
}
void xuatHSTheoKV(HS lopHoc[], int soHocSinh)
{
    unsigned int kv1, kv2 = 0;
    for(int i = 0; i < soHocSinh; i++)
	{
        if(lopHoc[i].khuVuc == 1)
            kv1++;
        else
            kv2++;
    }
    printf("\nSo hoc sinh o khu vuc 1 la %d", kv1);
    printf("\nSo hoc sinh o khu vuc 2 la %d", kv2);
}
void hoanViHS(HS &a, HS &b)
{
	HS temp;
	temp = a;
	a = b;
	b = temp;
}
void sxHS(HS mang[], int n)
{
	int minIndex = 0;
	for (int i = 0; i < n - 1; i++)
	{
		int minIndex = i;
		for (int j = i + 1; j < n; j++)
		{
			if (mang[minIndex].diemTrungBinh > mang[j].diemTrungBinh)
			{
				minIndex = j;
			}
		}
		hoanViHS(mang[minIndex], mang[i]);	
	}
}
void selectSortHoTen(HS mang[], int n)
{
    //int minIndex = 0;
	for (int i = 0; i < n - 1; i++)
	{
		int minIndex = i;
		for (int j = i + 1; j < n; j++)
		{
            if (strcmp(mang[minIndex].hoTen, mang[j].hoTen) > 0)
			{
				minIndex = j;
			}
		}
		hoanViHS(mang[minIndex], mang[i]);	
	}
}
void selectSortSoThich(HS mang[], int n)
{
    //int minIndex = 0;
	for (int i = 0; i < n - 1; i++)
	{
		int minIndex = i;
		for (int j = i + 1; j < n; j++)
		{
            if (strcmp(mang[minIndex].soThich, mang[j].soThich) > 0)
			{
				minIndex = j;
			}
		}
		hoanViHS(mang[minIndex], mang[i]);	
	}
}
void interchangeSortHoTen(HS a[], int n)
{
	for (int i = 0; i < n - 1; i++)
	{
		for (int j = i + 1; j < n; j++)
		{
			if (strcmp(a[i].hoTen, a[j].hoTen) > 0)
			{
				hoanViHS(a[i], a[j]);
			}
		}
	}
}
void bubbleSortHoTen(HS a[], int n)
{
	for (int i = 0; i < n -1; i++)
	{
		for (int j = n - 1; j > i; j--)
		{
			if (strcmp(a[j].hoTen, a[j-1].hoTen) < 0)
			{
				hoanViHS(a[j], a[j-1]);
			}
		}
	}
}
void insertionSortDiemTB(HS a[], int n)
{
	for (int i = 1; i < n; i++)
	{
		int pos = i - 1;
		HS x = a[i];
		while (a[pos].diemTrungBinh < x.diemTrungBinh && pos >= 0)
		{
			a[pos+1] = a[pos];
			pos--;
		}
		a[pos+1] = x;
	}
}
void insertionSortHoTen(HS a[], int n)
{
	for (int i = 1; i < n; i++)
	{
		int pos = i - 1;
		HS x = a[i];
		while (strcmp(a[pos].hoTen, x.hoTen) > 0 && pos >= 0)
		{
			a[pos+1] = a[pos];
			pos--;
		}
		a[pos+1] = x;
	}
}
