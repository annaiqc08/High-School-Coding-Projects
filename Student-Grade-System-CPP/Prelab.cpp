#include<iostream>
#include<Windows.h>
#include<cstdio>
#include<string>
#include<dos.h>
#include<math.h>
#include<conio.h>
using namespace std;

string nom[2][2],opc;
int f,c,alum,ingnot,repnot,op,a,n;
int cod[2];
double Notas[2][6],prom,sum;

void gotoxy(int x, int y){
	COORD p;
	p.X= x; p.Y=y;
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE),p);
}

void alumnos(void){
	system("cls");
	cout<<"Cuantos alumnos desea ingresar (max. 2) ==> ";
	cin>>a;
	if((a>2)&&(a<0)){
		cout<<"Numero no valido.";
		alumnos();
	}
		     //0123456789012345678901234567890123456789012345678901234567890123456789
		cout<<"Codigo    Nombre    Apellido"<<endl;
	for(f=0;f<a;++f){
		cin>>cod[f];
		for(c=0;c<2;++c){
		gotoxy((c+1)*10,f+2);cin>>nom[f][c];
		}
	}
system("pause");	
}

void ingnotas(void){
	do{
		system("cls");

	}while((opc != "N")&&(opc != "n"));
	system("pause");
}

void repnotas(void){
	do{
		system("cls");
		     //0123456789012345678901234567890123456789012345678901234567890123456789
		cout<<"Codigo    Bloque 1  Bloque 2  Bloque 3  Bloque 4  Nota Final"<<endl;
		for(f=0;f<a;++f){
			cin>>cod[f];
			for(c=0;c<5;++c){
				gotoxy((c+1)*10,f+2);
				cin>>Notas[f][c];
				sum=Notas[f][c];
			}
		}

	}while((opc != "N")&&(opc != "n"));
	system("pause");
}
int main(){
	do{
		system("cls");
		cout<<"1. Ingreso de Alumnos"<<endl;
		cout<<"2. Ingreso de Notas"<<endl;
		cout<<"3. Reporte de Notas"<<endl;
		cout<<"4. Salir"<<endl;
		cout<<"Ingrese una opcion (1,2,3,4) ==> ";
		cin>>op;

		switch(op){
		case 1:
			alumnos();
			break;
		case 2:
			ingnotas();
			break;
		case 3:
			repnotas();
			break;
		case 4:
			break;

		default:
			cout<<"Ingrese una opcion valida.";
		}

	}while(op != 4);
system("pause");
return 0;
}
