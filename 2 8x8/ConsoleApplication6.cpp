#include "stdafx.h"
#include <iostream>
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <Windows.h>
#include "8X8win1251.h"
#include "8X16win1251.h"
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	int m = 1029;
	int n = 0;
	for (int i = 0; i < 32; i++)
	{
		
		for (int j = 0; j < 64; j++){
			if (j<32)
				printf("%c", (m & (1 << (128 - j))) > 0 ? '#' : ' ');
			else
				printf("%c", (~m & (1 << (128 + j))) > 0 ? '#' : ' ');
		}
		m=m/2+m*2;
		printf("\n");
	}
	system("pause");
	return 0;
}