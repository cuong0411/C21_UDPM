#include <stdio.h>

int main()
{
	FILE *f;
	f = fopen("E:\\C21UDPM\\CauTrucDuLieuVaGiaiThuat\\LamViecVoiFile\\data.txt", "at");
	if (f == NULL)
	{
		printf("Khong mo duoc file");
		return 0;
	}
	fputs("\ntest fputs", f);
	fclose(f);
	
	return 0;
}
