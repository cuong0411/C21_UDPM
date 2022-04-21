#include <stdio.h>

int main()
{
	FILE *f;
	f = fopen("E:\\C21UDPM\\CauTrucDuLieuVaGiaiThuat\\LamViecVoiFile\\data.txt", "rt");
	if (f == NULL)
	{
		printf("Khong mo duoc file");
		return 0;
	}
	int x;
	fscanf(f, "%d", &x);
	fclose(f);
	
	x = x * 10;
	f = fopen("E:\\C21UDPM\\CauTrucDuLieuVaGiaiThuat\\LamViecVoiFile\\data.txt", "at");
	fprintf(f, "\nket qua cua x la: %d", x);
	fclose(f);
	
	return 0;
}
