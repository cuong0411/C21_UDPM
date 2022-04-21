#include <stdio.h>

int main()
{
	FILE *f;
	f = fopen("E:\\C21UDPM\\CauTrucDuLieuVaGiaiThuat\\LamViecVoiFile\\data.txt", "rt");
	char x;
	if (f == NULL)
	{
		printf("Khong mo duoc file");
		return 0;
	}
	
	x = getc(f);
	printf("gia tri cua x la: %c", x);
	fclose(f);
	return 0;
}
