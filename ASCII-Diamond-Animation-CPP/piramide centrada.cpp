//Programa que realize una piramide con * en el centro
#include<iostream>
#include<cstdio>
#include<Windows.h>

using namespace std;

void gotoxy(int x,int y)
{
	COORD punto;
	punto.X=x; punto.Y=y;
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE),punto);
}

int main()
{
	int cols,filas,cols2,filas2,contador,filas3,filas4,cols3,cols4,contador2;
	for(filas=1;filas<=6;++filas)//primer triangulo
	{
		for(cols=1;cols<=filas;++cols)
		{
			SetConsoleTextAttribute (GetStdHandle (STD_OUTPUT_HANDLE),23);
 			//system("color 0e");
			gotoxy(cols+35,filas);
			cout <<"*" <<endl;
			Sleep(100);
		}
	}
	contador=6;
	for(filas2=7;filas2<=11;++filas2)//segundo triangulo
	{
		contador=contador-1;
		for(cols2=1;cols2<=contador;++cols2)
		{
			//system("color 0a");
			SetConsoleTextAttribute (GetStdHandle (STD_OUTPUT_HANDLE),11);
			gotoxy(cols2+35,filas2);
			cout <<"*" <<endl;
			Sleep(100);
		}
	}
	for(filas3=1;filas3<=5;++filas3)//tercer triangulo
	{
		for(cols3=5;cols3>=filas3;--cols3)
		{
			SetConsoleTextAttribute (GetStdHandle (STD_OUTPUT_HANDLE),15);
			gotoxy(cols3+30,filas3+5);
			cout <<"*" <<endl;
			Sleep(100);
		}
	}
	contador2=1;//recuerda que al usar -- en columnas va desde (5) hasta (1) y luego si le aumento va a llegar hasta (2) por lo cual disminuyen los asteriscos
	for(filas4=5;filas4>=1;--filas4)//cuarto triangulo
	{
		contador2=contador2+1;
		for(cols4=5;cols4>=contador2;--cols4)
		{
			SetConsoleTextAttribute (GetStdHandle (STD_OUTPUT_HANDLE),19);
			gotoxy(cols4+30,filas4);
			cout <<"*" <<endl;
			Sleep(100);
		}
	}
	gotoxy(21,15);
	system("PAUSE");
	return 0;
}
