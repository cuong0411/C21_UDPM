#include <stdio.h>

//Bài 5 slide 21
int main()
{
	int diemToan, diemLy, diemHoa;
	float diemTrungBinh;
	printf("Nhap diem toan, ly, hoa:\n");
	scanf("%d, %d, %d", &diemToan, &diemLy, &diemHoa);
	diemTrungBinh = float(diemToan + diemLy + diemHoa) / 3;
	printf("Diem trung binh la %.2f\n", diemTrungBinh);
	
	if (diemTrungBinh < 5)
		printf("Xep loai YEU");
	else if (diemTrungBinh>=5&&diemTrungBinh<7)
		printf("Xep loai TRUNG BINH");
	else if (diemTrungBinh>=7&&diemTrungBinh<8)
		printf("Xep loai KHA");
	else
		printf("Xep loai GIOI");
	
	return 0;

}
