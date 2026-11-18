#include<iostream>
#include<Windows.h>
#include<cstdio>
#include<dos.h>
#include<string>
#include<math.h>
#include<conio.h>
using namespace std;
int f,c,cont,op,n,a,cant;
string nom,nomprod[5],continuar,clie[5][4];
double ing,cons,ingre,consul,fact,ganancia,ganan,prods[5][4],nit[5],totven,subtot,desc,subtotclie,iva,tot;
void gotoxy(int x, int y){
	COORD p;
	p.X=x; p.Y=y;
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE),p);
}
void ingresoprod(void){
	system("cls");
	cout<<"Cuantos productos desea ingresar? (max. 5) ==> ";
	cin>>n;
	if((n<0) && (n>6)){
		cout<<"Valor ingresado no valido."<<endl;
		system("pause");
		ingresoprod();
	}else{
	//123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890
	cout<<"Nombre producto          codprod    costo        precioventa    cant"<<endl;
	for(f=0;f<n;++f){
		cin>>nomprod[f];
		for(c=0;c<4;++c){
			gotoxy((c+5)*(c+5),f+2);
			cin>>prods[f][c];
				if(f>0){
					for(cont=0;cont<f;++cont){
						if(prods[cont][0]==prods[f][0]){
						cout<<"Valor ingresado no valido. ";
						ingresoprod();
						}
					}
				}
			}
		ganancia=prods[f][2]-prods[f][1];
		ganan=ganancia*prods[f][3];
		}		
	}
	system("pause");
}
void consprod(void){
	system("cls");
	do{
	gotoxy(35,0); cout<<"INFOPRADO";
	gotoxy(30,1); cout<<"28 Calle 7-58 Zona 11";
	gotoxy(33,2); cout<<"Tel. 24423411";
	gotoxy(30,4); cout<<"CONSULTA DE PRODUCTOS"<<endl;
	cout<<"Ingrese el codigo a buscar: ";
	cin>>a;
	for(f=0;f<=n;++f){
		if(prods[f][0]==a){
			cout<<"Codigo del producto: "<<prods[f][0]<<endl;
			cout<<"Nombre del producto: "<<nomprod[f]<<endl;
			cout<<"Precio costo: "<<prods[f][1]<<endl;
			cout<<"Precio venta: "<<prods[f][2]<<endl;
			cout<<"Ganancia por unidad: "<<ganancia<<endl;
			cout<<"Cantidad en existencia: "<<prods[f][3]<<endl;			
			cout<<"Ganacia total estimada: "<<ganan<<endl;
			f=n+1;
			system("pause");
		}else{
			cout<<"Codigo no registrado.";
			system("pause");
			consprod();
		}
	}
	cout<<"¿Desea realizar otra consulta? (s/n)==> ";
	cin>>continuar;
	consprod();
	}while((continuar != "n") && (continuar != "N"));
	system("pause");
}
void ingresoclie(void){
	system("cls");
	cout<<"Cuantos clientes desea ingresar? (max. 5) ==>";
	cin>>n;
	if(n>=6){
		cout<<"Valor ingresado no valido."<<endl;
		system("pause");
		ingresoclie();
	}
	//123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890
	cout<<"NIT     nombre     dept.     tel.     tipo cliente(A/B)";
	for(f=0;f<n;++f){
		cin>>nit[f];
		for(c=0;c<4;++c){
			cin>>clie[f][c];
				if(f>0){
					for(cont=0;cont<f;++cont){
						if(clie[cont][0]==clie[f][0]){
						cout<<"Valor ingresado no valido o duplicado. ";
						ingresoclie();
						}
					}
				}
				if((clie[f][3] !="A") && (clie[f][3] !="a") && (clie[f][3] !="B") && (clie[f][3] !="b")){
					cout<<"Dato ingresado no valido. ";
					ingresoclie();
				}
		}
	}

	system("pause");
}
void consulclie(void){
	system("cls");
	do{
	gotoxy(35,0); cout<<"INFOPRADO";
	gotoxy(30,1); cout<<"28 Calle 7-58 Zona 11";
	gotoxy(33,2); cout<<"Tel. 24423411";
	gotoxy(30,4); cout<<"CONSULTA DE PRODUCTOS"<<endl;
	cout<<"Ingrese el nit a buscar: ";
	cin>>a;
	for(f=0;f<=n;++f){
		if(prods[f][0]==a){
			cout<<"NIT: "<<nit[f]<<endl;
			cout<<"Nombre del cliente: "<<clie[f][0]<<endl;
			cout<<"Direccion: "<<clie[f][1]<<endl;
			cout<<"El cliente esta ubicado en la categoria: "<<clie[f][3]<<endl;
			cout<<"Telefono: "<<clie[f][2]<<endl;
			f=n+1;
			system("pause");
		}else{
			cout<<"Codigo no registrado.";
			system("pause");
			consulclie();
		}
	}
	cout<<"¿Desea realizar otra consulta? (s/n)==> ";
	cin>>continuar;
	consulclie();
	}while((continuar != "n") && (continuar != "N"));
	system("pause");
}
void facturar(void){
	system("cls");
	do{
	gotoxy(35,0); cout<<"INFOPRADO";
	gotoxy(30,1); cout<<"28 Calle 7-58 Zona 11";
	gotoxy(33,2); cout<<"Tel. 24423411";
	for(f=0;f<=79;++f){
		cout<<"-";
	}
	a=0;
	cout<<"NIT: "<<endl;
	cout<<"Nombre del cliente: "<<endl;
	cout<<"Direccion: "<<endl;
	cout<<"Telefono: "<<endl;
	cout<<"El cliente esta ubicado en la categoria: "<<endl;
	cin>>a;
	for(f=0;f<=n;++f){
		if(nit[f]==a){
			cout<<clie[f][0];
			cout<<clie[f][1];
			cout<<clie[f][2];
			cout<<clie[f][3];
			f=n+1;
			if((clie[f][3] !="A")  & (clie[f][3] !="a")){
				desc=0.06;
			}else{
				desc=0.02;
			}
		}else{
			cout<<"NIT no registrado.";
			system("pause");
			facturar();
		}
	}
	for(f=0;f<=79;++f){
		cout<<"-";
	}
	a=0;
	cout<<"Cod. Producto     Nom. Prod    Cant     Precio     Total Venta "<<endl;
	cin>>a;
	for(f=0;f<=n;++f){
		if(prods[f][0]==a){
			cout<<prods[f][0];
			cin>>cant;
			if(cant>prods[f][3]){
				cout<<"Cantidad mayor a la existente.";
				system("pause");
				facturar();
			}
		}else{
			cout<<"Codigo no registrado.";
			system("pause");
			facturar();
		}
		prods[f][3]=prods[f][3]-cant;
			cout<<prods[f][2];
			totven=prods[f][2]*cant;
			f=n+1;
			subtot=subtot+totven;

			
	}
	desc=desc*subtot;
	subtotclie=subtot-desc;
	iva=subtotclie*0.12;
	tot=subtotclie+iva;
	cout<<"Subtotal: "<<subtot<<endl;
	cout<<"Descuento: "<<desc<<endl;
	cout<<"Subtotal Cliente: "<<subtotclie<<endl;
	cout<<"IVA "<<iva<<endl;
	cout<<"Total a pagar: "<<tot<<endl;
	cout<<"¿Desea realizar otra consulta? (s/n)==> ";
	cin>>continuar;
	facturar();
	}while((continuar != "n") && (continuar != "N"));
	system("pause");
}
int main(){
	do{
		system("cls");
		gotoxy(5,5);cout<<"1. Ingreso de productos.";
		gotoxy(5,6);cout<<"2. Consulta de productos.";
		gotoxy(5,7);cout<<"3. Ingreso de clientes.";
		gotoxy(5,8);cout<<"4. Consulta de clientes.";
		gotoxy(5,9);cout<<"5. Facturacion.";
		gotoxy(5,10);cout<<"6. Salir.";
		gotoxy(5,11);cout<<"Ingrese una opcion (1,2,3,4,5,6) ==> ";
		cin>>op;
		switch(op){
		case 1:
			ingresoprod();
			break;
		case 2:
			consprod();
			break;
		case 3:
			ingresoclie();
			break;
		case 4:
			consulclie();
			break;
		case 5:
			facturar();
			break;
		case 6:
			break;
		default:
			cout<<"Ingrese una opcion valida.";
		}
	}while(op !=6);
	system("pause");
	return 0;
}