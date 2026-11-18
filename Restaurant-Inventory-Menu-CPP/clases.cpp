#include<iostream>
#include<cstdio>
#include<string>
#include<Windows.h>
#include<dos.h>
#include<math.h>
#include<conio.h>


using namespace std;

double materiaprima[4][3],opciones[6][6],codmbuscar,inversionmateria,pgrandes,pmedianas,ppequenas;
string nombreprod[4],nombreopcion[6], continua;
int fila,columna,cont,cantprima,cantopcion,f,c,encontrado;

void gotoxy(int x, int y){
	COORD p;
	p.X=x; p.Y=y;
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE),p);
}


void llenarmateria(void){

	system("cls");

	gotoxy(5,1);
	cout<<"CUANTOS PRODUCTOS DESEA INGRESAR (MAXIMO 4)...  ";
	cin>>cantprima;

	system("cls");

	if ((cantprima>0) && (cantprima < 5)){
		

		gotoxy(3,1);cout<<"NOMBRE PROD      CODPROD       CANT. ONZAS       PRECIO COSTO Q.";
		
		for(fila=0;fila<cantprima;++fila){
			gotoxy(1,fila+2); cin>>nombreprod[fila];
				for(columna=0;columna<3;++columna){
					gotoxy((columna*18)+20,fila+2); cin>>materiaprima[fila][columna];

					if (fila>0){
						
						for(cont=0;cont<fila;++cont){
							if (materiaprima[cont][0]==materiaprima[fila][0]){
								gotoxy(1,20);cout<<"Error, dato duplicado, ingrese dato diferente"<<endl;
								system("pause");
								gotoxy(0,20);cout<<"                                              ";
								gotoxy(0,21);cout<<"                                              ";
								cont = fila + 1;
								fila = fila - 1;
								columna=4;
								gotoxy(1,fila+3);cout<<"                                          ";
							}else{
							}//Fin del IF para prevenir repetidos
						}//fin del For para prevenir repetidos
					}//fin del IF para iniciar b�squeda de repetidos

					}//fin FOR columna ingreso matriz
		
				}//fin FOR fila ingreso matriz
		}else{
			cout<<"ERROR LA CANTIDAD INGRESADA NO ES CORRECTA..."<<endl;

	}//fin del IF determinar cantidad correcta de ingreso

	gotoxy(5,18);system("pause");

}//Fin VOID llenar Materia Prima


void llenaropciones(void){
system("cls");

	gotoxy(5,1);
	cout<<"CUANTOS OPCIONES DESEA INGRESAR (MAXIMO 6)...  ";
	cin>>cantopcion;

	system("cls");

	if ((cantopcion>0) && (cantopcion < 7)){
		

		gotoxy(3,1);cout<<"NOMBRE OPC    CODOPC   CODINGPR   CANTINGPR  CANTSALSA  CANTQUESO   PRECIO Q.";
		
		for(fila=0;fila<cantopcion;++fila){
			gotoxy(1,fila+2); cin>>nombreopcion[fila];
				for(columna=0;columna<6;++columna){
					gotoxy((columna*10)+18,fila+2); cin>>opciones[fila][columna];

					if (fila>0){
						
						for(cont=0;cont<fila;++cont){
							if (opciones[cont][0]==opciones[fila][0]){
								gotoxy(1,20);cout<<"Error, dato duplicado, ingrese dato diferente"<<endl;
								system("pause");
								gotoxy(0,20);cout<<"                                              ";
								gotoxy(0,21);cout<<"                                              ";
								cont = fila + 1;
								fila = fila - 1;
								columna=6;
								gotoxy(1,fila+3);cout<<"                                          ";
							}else{
							}//Fin del IF para prevenir repetidos
						}//fin del For para prevenir repetidos
					}//fin del IF para iniciar b�squeda de repetidos

					}//fin FOR columna ingreso matriz
		
				}//fin FOR fila ingreso matriz
		}else{
			cout<<"ERROR LA CANTIDAD INGRESADA NO ES CORRECTA..."<<endl;

	}//fin del IF determinar cantidad correcta de ingreso

	system("pause");
}


void consultamateria(void){
	
	do{

	system("cls"),
	gotoxy(1,5);cout<<"Ingrese codigo de materia prima a consultar --->";
	cin>>codmbuscar;

		for(c=20;c<55;++c){
				gotoxy(20,17);cout<<"Tratando de localizar codigo...";
				gotoxy(c,18);cout<<"=";
				Sleep(25);
			}
			gotoxy(20,17);cout<<"                                    ";
			gotoxy(20,18);cout<<"                                                   ";
		for(fila=0;fila<cantprima;++fila){

			if(materiaprima[fila][0]==codmbuscar){

				system("cls");
				for(c=3;c<55;++c){
					gotoxy(c,3);cout<<"=";
					gotoxy(c,12);cout<<"=";Sleep(5);
				}
					for(f=4;f<12;++f){
						gotoxy(3,f);cout<<"=";
						gotoxy(54,f);cout<<"=";Sleep(5);
					}
						gotoxy(35,5);cout<<"CODIGO... ---> "<<materiaprima[fila][0];
						gotoxy(5,6);cout<<"PRODUCTO. ---> "<<nombreprod[fila];
						gotoxy(5,7);cout<<"EXISTENCIA---> "<<materiaprima[fila][1];
						gotoxy(35,7);cout<<"COSTO ONZA---> "<<materiaprima[fila][2];
						inversionmateria=(materiaprima[fila][1]*materiaprima[fila][2]);
						gotoxy(5,8);cout<<"TOTAL INVERTIDO EN "<<materiaprima[fila][1]<<" ONZ. DE "<<nombreprod[fila]<<" ...---> Q. "<<inversionmateria;



						encontrado=1;
						fila=cantprima+1;
			}else{
			encontrado=0;
			}//fin IF busqueda

					
	}//fin de FOR fila para b�squeda

	if(encontrado==0){
				gotoxy(5,10);cout<<"REGISTRO NO ALMACENADO O INGRESADO...";
			}else{
			}//fin IF no encontrado

		gotoxy(5,20);cout<<"Desea realizar otra consulta? s/n... ---> ";
		cin>>continua;

	}while((continua != "n") && (continua != "N"));

}//fin de VOID consultamateria

int main()
{
	int opcion;
	
	
	do
		{
			system("cls");

			for(c=20;c<55;++c){
				gotoxy(c,3);cout<<"=";
				gotoxy(c,12);cout<<"=";Sleep(30);
			}
			for(f=4;f<12;++f){
				gotoxy(20,f);cout<<"=";
				gotoxy(54,f);cout<<"=";Sleep(30);
			}

			gotoxy(25,5);cout<<"1.  Ingreso Materia Prima"<<endl;
			gotoxy(25,6);cout<<"2.  Ingreso Opciones"<<endl;
			gotoxy(25,7);cout<<"3.  Consulta Materia Prima"<<endl;
			gotoxy(25,8);cout<<"4.  Salir"<<endl;
			gotoxy(25,9);cout<<"Ingrese una opcion (1,2,3,4)---> ";
			cin>>opcion;

			switch(opcion){
				case 1:
					llenarmateria();
					break;

				case 2:
					llenaropciones();
					break;

				case 3:
					consultamateria();
					break;

				case 4:
					break;

			default:
			cout<<"Ingrese una opci�n v�lida"<<endl;
		}
	}while(opcion != 4);


	

	gotoxy(5,18);system("pause");
	return 0;
}
