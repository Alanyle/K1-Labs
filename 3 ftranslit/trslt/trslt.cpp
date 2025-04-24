#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <conio.h>
#include <locale.h>
#include <stdlib.h>


int main()
{
	setlocale(0, "Rus");
	FILE *f;
	FILE *f1;
	char c;
	int n;
	f = fopen("letter.txt", "a+");
	f1 = fopen("let.txt", "wt+");
	printf("\n%c", f);
	char a[] = "abvgdeOjziyklmnoprstufhc48#.I,Eua";
	for (;;)
	{
		c = fgetc(f);
		if (feof(f)) break;
		n = (int)(c);
		if (char(c) = " ")
		{
			fputc(" ", f1);
		}
		else
		{
			n += 33;
			fputc(a[n], f1);
		}
	}
	char z = (char)(n);
	printf("\n%c, %d, %c, %c, %c, %c", c, n, z, f, a[n]);
	fclose(f);
	fclose(f1);
	system("start let.txt");
	_getch();
}
//à 1361605456 224 -32