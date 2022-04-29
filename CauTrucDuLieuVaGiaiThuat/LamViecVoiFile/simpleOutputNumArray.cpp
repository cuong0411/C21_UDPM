/*
* doc mang so nguyen tu 1 file txt
*/

#include <stdio.h>
#define MAX 30

void readFile(int a[], int &n, FILE *f);
void outputArray(int a[], int n);

int main()
{
	int a[MAX];
	int n;
	FILE *f;
	f = fopen("array_data.txt", "rt");
	if (f == NULL)
	{
		printf("Cant't open the file.");
		return 0;
	}
	readFile(a, n, f);
	fclose(f);
	outputArray(a, n);

	

	return 0;
}
void readFile(int a[], int &n, FILE *f)
{
	fscanf(f, "%d", &n);
	for (int i = 0; i < n; i++)
	{
		fscanf(f, "%d", &a[i]);
	}
}
void outputArray(int a[], int n)
{
	for (int i = 0; i < n; i++)
	{
		printf("%5d", a[i]);
	}
}
void writeArrayToFile(int a[], int n, FILE *f)
{
	fprintf(f, "\n");
	for (int i = 0; i < n; i++)
	{
		fprintf(f, "%5d", a[i]);
	}
}