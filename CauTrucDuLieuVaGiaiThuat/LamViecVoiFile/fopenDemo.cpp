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
	printf("gia tri cua x la: %d", x);
	fclose(f);
	return 0;
}
