#include<iostream>
#include<Windows.h>
#include<dos.h>
#include<math.h>
#include<string>
#include<cstdio>
#include<conio.h>
using namespace std;

void gotoxy(int x, int y){
	COORD p;
	p.X=x; p.Y=y;
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE),p);
}

string alum[10][2],op,nivel,nmes,pag,banco;
int f,c,fil,col,opc,cantalum,datalum[10][4],cod,cantnot,codnot,grad,niv,codalum,comp,recibcod,mes,formpag,coleg,otros,subtot,gradniv,no;
double notas[10][8],inscrip,consalum,ingnot,consnotgrad,consnotalum,notfin,mayor,menor,recib,recarg,totpag;
bool encontrado=false;

void inscripalum(void){
	system("cls");
	cout<<"Cuantos alumnos desea ingresar? ==> ";
	cin>>cantalum;
	if((cantalum<1) || (cantalum>11)){
		cout<<"Valor ingresado no valido."<<endl;
		system("pause");
		inscripalum();
	}else{
		//cout<<"                                                                                    ";
		cout<<"Los niveles son: 1-Preprimaria; 2-Primaria; 3-Basico; 4-Diversificado"<<endl;
		cout<<endl;
	     //012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789
	cout<<"Nombre    Apellido  Codigo    Grado     Nivel     Ciclo Escolar"<<endl;
	for(f=0;f<cantalum;++f){
		for(c=0;c<2;++c){
			gotoxy(c*10,f+4);
			cin>>alum[f][c];
		}//fin for c
		for(col=0;col<4;++col){
			gotoxy(10*(col+2),f+4);
			cin>>datalum[f][col];
			if(f>0){
				for(fil=0;fil<f;++fil){
					if(datalum[fil][0]==datalum[f][0]){
					cout<<"Codigo ingresado no valido o repetido.";
					system("pause");
					inscripalum();
					}
				}//fin for fil
			}//fin if cod repetido
		}//fin for col
	}//fin for f
	}//fin if cantalum
	system("pause");
}//fin void inscipalum

void consalumnos(void){
	do{
	system("cls");
	gotoxy(30,0);cout<<"BILINGUE EL PRADO"<<endl;
	gotoxy(30,1);cout<<"28 Calle 7-58 Zona 11"<<endl;
	gotoxy(30,2);cout<<"PBX: 22044464"<<endl;
	gotoxy(30,4);cout<<"CONSULTA DE ALUMNOS"<<endl;
	cout<<"Codigo del alumno a buscar: ";
	cin>>cod;
	for(f=0;f<cantalum;++f){
		if(cod==datalum[f][0]){
			encontrado=true;
			for(col=0;col<=79;++col){
				cout<<"-";
			}//fin for col
			gotoxy(30,6);cout<<"Ciclo: "<<datalum[f][3]<<endl;
			gotoxy(10,8);cout<<"Grado: "<<datalum[f][1]<<endl;
			gotoxy(10,10);cout<<"Codigo: "<<datalum[f][0]<<endl;
			if(datalum[f][2]==1){
				nivel="Preprimaria";
			}else{
				if(datalum[f][2]==2){
					nivel="Primaria";
					}else{
						if(datalum[f][2]==3){
						nivel="Basico";
						}else{
							nivel="Diversificado";
					}
				}
			}//fin if nivel
			gotoxy(40,8);cout<<"Nivel: "<<datalum[f][2]<<" "<<nivel<<endl;
			gotoxy(40,10);cout<<"Alumno(a): "<<alum[f][0]<<" "<<alum[f][1]<<endl;
		}else{//fin if consulta codigo
		encontrado==false;
		}
	}//fin for f
	
		
		if(encontrado==false){

		cout<<"Codigo ingresado no valido.";
			system("pause");
			consalumnos();
									
				
		}//fin if consulta codigo
	for(col=0;col<=79;++col){
				cout<<"-";
			}//fin for col
			
	gotoxy(25,12);cout<<"Desea realizar otra consulta? (s/n) ==> ";
	cin>>op;
	}while((op != "N")&&(op != "n"));
	system("pause");
}//fin void consalumnos

void ingnotas(void){
	system("cls");
	encontrado=false;
	cout<<"Cuantas notas desea realizar? ==> ";
	cin>>cantnot;
	if((cantnot>cantalum)||(cantnot<1)){
		cout<<"Valor ingresado no valido."<<endl;
		system("pause");
		ingnotas();
	}else{
		     //0123456789012345678901234567890123456789012345678901234567890123456789012345678
		cout<<"Codigo    Grado     Nivel     Nota 1    Nota 2    Nota 3    Nota 4    NotaFinal"<<endl;
		for(f=0;f<cantnot;++f){
			cin>>comp;

			if(f>0){
					for(col=0;col<f;++col){
						if(notas[col][0]==notas[f][0]){
							cout<<"Codigo ingresado duplicado."<<endl;
							system("pause");
							ingnotas();
							}//fin if cod duplicado
						}//fin for col	
					}//fin if vercod

				for(c=0;c<cantalum;++c){
				if(datalum[c][0]==comp){
					notas[f][0]=comp;
					encontrado=true;
					gotoxy(10,f+2);cout<<datalum[c][1];
					gotoxy(20,f+2);cout<<datalum[c][2];
					gotoxy(30,f+2);cin>>notas[f][3];
					gotoxy(40,f+2);cin>>notas[f][4];
					gotoxy(50,f+2);cin>>notas[f][5];
					gotoxy(60,f+2);cin>>notas[f][6];
					notfin=(notas[f][3]+notas[f][4]+notas[f][5]+notas[f][6])/4;
					notas[f][7]=notfin;
					gotoxy(70,f+2);cout<<notas[f][7]<<endl;
					
				}else{//fin if encontrar cod
					encontrado==false;
				}//fin else
			}//fin for c 
		}//fin for f
	}//fin if cantnot
	if(encontrado==false){
		cout<<"Codigo no ingresado."<<endl;
		system("pause");
		ingnotas();
	}
	system("pause");
}//fin void ingnotas

void consnotgradnivel(void){
	do{
	system("cls");
	gotoxy(30,0);cout<<"BILINGUE EL PRADO"<<endl;
	gotoxy(30,1);cout<<"28 Calle 7-58 Zona 11"<<endl;
	gotoxy(30,2);cout<<"PBX: 22044464"<<endl;
	gotoxy(20,4);cout<<"CONSULTA DE NOTAS POR GRADO"<<endl;
	gotoxy(15,6);cout<<"Grado: ";cin>>grad;
	gotoxy(50,6);cout<<"Nivel: ";cin>>niv;

	for(f=0;f<cantalum;++f){
		if((grad==datalum[f][1])&&(niv==datalum[f][2])){
			if(datalum[f][2]==1){
				nivel="Preprimaria";
			}else{
				if(datalum[f][2]==2){
					nivel="Primaria";
					}else{
						if(datalum[f][2]==3){
						nivel="Basico";
						}else{
							nivel="Diversificado";
					}//fin else
				}//fin else
			}//fin if nivel
			gotoxy(58,6);cout<<nivel<<endl;
			for(col=0;col<=79;++col){
				cout<<"-";
			}//fin for col
			     //0123456789012345678901234567890123456789012345678901234567890123456789012345678
			cout<<"Codigo    Nota 1    Nota 2    Nota 3    Nota 4    Promedio  Resultado"<<endl;
			for(col=0;col<=79;++col){
				cout<<"-";
			}//fin for col
			cout<<endl;
			gotoxy(0,f+10);cout<<notas[f][0];
			gotoxy(10,f+10);cout<<notas[f][3];
			gotoxy(20,f+10);cout<<notas[f][4];
			gotoxy(30,f+10);cout<<notas[f][5];
			gotoxy(40,f+10);cout<<notas[f][6];
			gotoxy(50,f+10);cout<<notas[f][7];
			if(notas[f][7]>=70){
			gotoxy(60,f+10);cout<<"Aprobado"<<endl;
			}else{
				gotoxy(60,f+10);cout<<"Reprobado"<<endl;
			}//fin if rep aprob
		}else{//fin if encontrar cod//fin if grad niv
			encontrado==false;
		}//fin else
		if(encontrado==false){
					cout<<"Codigo no ingresado."<<endl;
					system("pause");
					ingnotas();
		}//fin if encontrado
	}//fin for f

	cout<<"Desea realizar otra consulta? (s/n) ==> ";
	cin>>op;
	}while((op !="N")&&(op !="n"));
	system("pause");
}//fin void consnotgradnivel

void consnotalumnos(void){
	do{
		system("cls");
		gotoxy(30,0);cout<<"BILINGUE EL PRADO"<<endl;
		gotoxy(30,1);cout<<"28 Calle 7-58 Zona 11"<<endl;
		gotoxy(30,2);cout<<"PBX: 22044464"<<endl;
		gotoxy(30,4);cout<<"CONSULTA DE NOTAS POR ALUMNO"<<endl;
		for(col=0;col<=79;++col){
				cout<<"-";
			}//fin for col
		gotoxy(10,6);cout<<"Codigo del alumno: ";cin>>codalum;
		for(f=0;f<cantalum;++f){
			if(codalum==datalum[f][0]){
			gotoxy(10,8);cout<<"Nombre del alumno: "<<alum[f][0]<<" "<<alum[f][1]<<endl;
			gotoxy(10,10);cout<<"Grado: "<<datalum[f][1]<<endl;
			gotoxy(20,10);cout<<"Nivel: "<<datalum[f][2]<<endl;
			gotoxy(30,10);cout<<"Ciclo Escolar: "<<datalum[f][3]<<endl;
			for(col=0;col<=79;++col){
				cout<<"-";
			}//fin for col
			gotoxy(10,12);cout<<"Nota 1    Nota 2    Nota 3    Nota 4"<<endl;
			for(col=0;col<=79;++col){
				cout<<"-";
			}//fin for col
			gotoxy(10,14);cout<<notas[f][3];
			gotoxy(20,14);cout<<notas[f][4];
			gotoxy(30,14);cout<<notas[f][5];
			gotoxy(40,14);cout<<notas[f][6]<<endl;
			for(col=0;col<=79;++col){
				cout<<"-";
			}//fin for col
			gotoxy(10,16);cout<<"Promedio: "<<notas[f][7];
			if(notas[f][7]>=70){
			gotoxy(40,16);cout<<"Resultado: Aprobado"<<endl;
			}else{
				gotoxy(40,16);cout<<"Resultado: Reprobado"<<endl;
			}//fin aprob reprob
			mayor=0;
			menor=notas[f][3];
			if((notas[f][3]>notas[f][4])&&(notas[f][3]>notas[f][5])&&(notas[f][3]>notas[f][6])){
				mayor=notas[f][3];
				}else{
					if((notas[f][4]>notas[f][3])&&(notas[f][4]>notas[f][5])&&(notas[f][4]>notas[f][6])){
						mayor=notas[f][4];
					}else{
						if((notas[f][5]>notas[f][3])&&(notas[f][5]>notas[f][4])&&(notas[f][5]>notas[f][6])){
							mayor=notas[f][5];
						}else{
							mayor=notas[f][6];
						}//fin else
					}//fin else
				}//fin if mayor
			if((notas[f][3]<notas[f][4])&&(notas[f][3]<notas[f][5])&&(notas[f][3]<notas[f][6])){
				menor=notas[f][3];
				}else{
					if((notas[f][4]<notas[f][3])&&(notas[f][4]<notas[f][5])&&(notas[f][4]<notas[f][6])){
						menor=notas[f][4];
					}else{
						if((notas[f][5]<notas[f][3])&&(notas[f][5]<notas[f][4])&&(notas[f][5]<notas[f][6])){
							menor=notas[f][5];
						}else{
							menor=notas[f][6];
						}//fin else
					}//fin else
				}//fin if menor
			cout<<endl;
			gotoxy(10,17);cout<<"Nota menor: "<<menor<<endl;
			gotoxy(40,17);cout<<"Nota mayor: "<<mayor<<endl;
			}//fin if codalum
		}//fin for f
	for(col=0;col<=79;++col){
				cout<<"-";
			}//fin for col
	gotoxy(30,19);cout<<"Desea realizar otra consulta? (s/n) ==> ";
	cin>>op;
	}while((op !="N")&&(op !="n"));
	system("pause");
}//fin void consnotalumnos

void recibcolegio(void){
	do{
		system("cls");
		gotoxy(30,0);cout<<"BILINGUE EL PRADO"<<endl;
		gotoxy(30,1);cout<<"28 Calle 7-58 Zona 11"<<endl;
		gotoxy(30,2);cout<<"PBX: 22044464"<<endl;
		gotoxy(30,4);cout<<"RECIBO DE PAGO DE COLEGIATURA"<<endl;
		for(col=0;col<=79;++col){
				cout<<"-";
		}//fin for col
		gotoxy(15,6);cout<<"Codigo del alumno: ";
		cin>>recibcod;
		for(f=0;f<cantalum;++f){
			if(recibcod==datalum[f][0]){
				encontrado=true;
				gotoxy(15,8);cout<<"Nombre del alumno: "<<alum[f][0]<<" "<<alum[f][1];
				gotoxy(15,10);cout<<"Grado: "<<datalum[f][1];
				gotoxy(15,10);cout<<"Nivel: "<<datalum[f][2];
				gotoxy(15,10);cout<<"Ciclo Escolar: "<<datalum[f][3]<<endl;
				for(col=0;col<=79;++col){
				cout<<"-";
				}//fin for col
				             //0123456789012345678901234567890123456789012345678901234567890123456789012345678
				gotoxy(5,12);cout<<"Colegiatura/otras actividades correspondentes al mes: No. ";
				cin>>mes;
				if(mes==1){
					nmes="Enero    ";
				}else{
					if(mes==2){
						nmes="Febrero   ";
					}else{
						if(mes==3){
							nmes="Marzo   ";
						}else{
							if(mes==4){
								nmes="Abril   ";
							}else{
								if(mes==5){
									nmes="Mayo    ";
								}else{
									if(mes==6){
										nmes="Junio    ";
									}else{
										if(mes==7){
											nmes="Julio    ";
										}else{
											if(mes==8){
												nmes="Agosto   ";
											}else{
												if(mes==9){
													nmes="Septiembre   ";
												}else{
													if(mes==10){
														nmes="Octubre   ";
													}else{
														if(mes==11){
															nmes="Noviembre   ";
														}else{
															nmes="Diciembre   ";
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				gotoxy(59,12);cout<<nmes<<endl;
				for(col=0;col<=79;++col){
				cout<<"-";
				}//fin for col
				gradniv=datalum[f][2];
				if(gradniv==1){
					coleg=750;
					otros=75;
					subtot=coleg+otros;
				}else{
					if(gradniv==2){
						coleg=900;
						otros=85;
						subtot=coleg+otros;
					}else{
						if(gradniv==3){
							coleg=990;
							otros=90;
							subtot=coleg+otros;
						}else{
							coleg=1100;
							otros=150;
							subtot=coleg+otros;
						}
					}
				}
				gotoxy(15,14);cout<<"Forma de pago:    1. Efectivo  2. Tarjeta   3. Cheque";
				gotoxy(31,14);cin>>formpag;
				if(formpag==1){
					pag="Efectivo";
					totpag=subtot;
				}else{
					if(formpag==2){
						pag="Tarjeta";
					gotoxy(15,16);cout<<"No.t: ";cin>>no;
					gotoxy(40,16);cout<<"Banco o Empresa: ";cin>>banco;					
					recarg=subtot*0.05;
					gotoxy(55,18);cout<<"Recargo: Q. "<<recarg;
					totpag=subtot+recarg;
					}else{
						pag="Cheque";
					gotoxy(15,16);cout<<"No.: ";cin>>no;
					gotoxy(40,16);cout<<"Banco o Empresa: ";cin>>banco;
					totpag=subtot;
					}
				}
				gotoxy(31,14);cout<<"                                                  ";
				gotoxy(31,14);cout<<pag;
				cout<<endl;
				for(col=0;col<=79;++col){
				cout<<"-";
				}//fin for col
				gotoxy(5,18);cout<<"Colegiatura: Q. "<<coleg;
				gotoxy(25,18);cout<<"Otros: Q. "<<otros;				
				gotoxy(35,18);cout<<"Total: Q. "<<subtot;				
				gotoxy(30,20);cout<<"Total a pagar: Q. "<<totpag;

			}else{//fin if recibcod
				encontrado=false;
			}//fin else
		}//fin for f
		cout<<endl;
		for(col=0;col<=79;++col){
				cout<<"-";
			}//fin for col
	gotoxy(35,22);cout<<"Desea realizar otra consulta? (s/n) ==> ";
	cin>>op;
	}while((op !="N")&&(op !="n"));
	system("pause");
}
	
int main(){
	do{
		system("cls");
		gotoxy(20,6);cout<<"1. Inscripcion de Alumnos"<<endl;
		gotoxy(20,7);cout<<"2. Consulta de Alumnos"<<endl;
		gotoxy(20,8);cout<<"3. Ingreso de Notas"<<endl;
		gotoxy(20,9);cout<<"4. Consulta de Notas por Grado y Nivel"<<endl;
		gotoxy(20,10);cout<<"5. Consulta de Notas de Alumno"<<endl;
		gotoxy(20,11);cout<<"6. Recibo de Colegiatura y otros"<<endl;
		gotoxy(20,12);cout<<"7. Salir"<<endl;
		gotoxy(20,13);cout<<"Ingrese una opcion (1,2,3,4,5,6,7) ==> ";
		cin>>opc;

		switch(opc){
		case 1:
			inscripalum();
			break;
		case 2:
			consalumnos();
			break;
		case 3:
			ingnotas();
			break;
		case 4:
			consnotgradnivel();
			break;
		case 5:
			consnotalumnos();
			break;
		case 6:
			recibcolegio();
			break;
		case 7:
			break;

		default:
			cout<<"Ingrese una opcion valida."<<endl;
			
		}

	}while(opc != 7);

system("pause");
return 0;
}