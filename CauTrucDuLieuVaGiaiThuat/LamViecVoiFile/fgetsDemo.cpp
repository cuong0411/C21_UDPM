#include <stdio.h>

int main()
{
	FILE *f;
	f = fopen("E:\\C21UDPM\\CauTrucDuLieuVaGiaiThuat\\LamViecVoiFile\\data.txt", "rt");
	char x[50];
	if (f == NULL)
	{
		printf("Khong mo duoc file");
		return 0;
	}
	
	fgets(x, 49, f);
	printf("gia tri cua x la: %s", x);
	fclose(f);
	return 0;
}
