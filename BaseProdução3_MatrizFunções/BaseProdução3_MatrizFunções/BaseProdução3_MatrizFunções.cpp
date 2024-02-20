// 27/07/2023
//Elaborado por Afonso Figueiredo
//Programa Funções e Matrizes

#include <conio.h>				// para input getchar()
#include <locale>				// para usar carateres nacionais
#include <iomanip>				// para a formatação do output 
#include <iostream>
using namespace std;
string fichas[20][20];

// ===================================== lista a matriz ==========================================================
// apresenta ecrã com listagem formatada
void listaMatriz()
{
	int i;
	//system("cls");
	cout << "\n\n" << endl;
	cout << "   Nº   NOME                             LOCAL          SEXO     ANO\n";
	cout << "  ------------------------------------------------------------------\n";
	for (i = 0; i <= 19; i++) //atenção: de 1 a 20 ou de 0 a 19?
	{


		cout

			<< right << setw(4) << setfill(' ') << i << ":   "
			<< left << setw(30) << setfill('.') << fichas[i][0] << "   "
			<< left << setw(15) << setfill(' ') << fichas[i][1]
			<< "  " << fichas[i][2]
			<< "     " << fichas[i][3]
			<< endl;
	}
	cout << "  ------------------------------------------------------------------\n";
	cout << " \n\n\t\t\t\t\t\t       qq. tecla ...";
	//_getch();
}


//ATENÇÃO:
//As bibliotecas seguintes terão que ser referidas no source file.cpp



// inicializa com 20 nomes e 20 freguesias, ...
void inicializa_matriz()
{
	fichas[0][0] = "Zacarias";
	fichas[1][0] = "Ana";
	fichas[2][0] = "Bela";
	fichas[3][0] = "Carlos";
	fichas[4][0] = "Carlota";
	fichas[5][0] = "Daniel";
	fichas[6][0] = "Diogo";
	fichas[7][0] = "Elvira";
	fichas[8][0] = "Fernanda";
	fichas[9][0] = "Fernando";
	fichas[10][0] = "Gilherme";
	fichas[11][0] = "Hilda";
	fichas[12][0] = "Josildo";
	fichas[13][0] = "Josecas";
	fichas[14][0] = "Maria";
	fichas[15][0] = "Anabela";
	fichas[16][0] = "Otaviano";
	fichas[17][0] = "Rui";
	fichas[18][0] = "Silvério";
	fichas[19][0] = "Teodoro";

	fichas[0][1] = "Lindoso";
	fichas[1][1] = "Maximinos";
	fichas[2][1] = "Gualtar";
	fichas[3][1] = "Lomar";
	fichas[4][1] = "Lomar";
	fichas[5][1] = "Cividade";
	fichas[6][1] = "Lamaceiros";
	fichas[7][1] = "Maximinos";
	fichas[8][1] = "Ferreiros";
	fichas[9][1] = "Maximinos";
	fichas[10][1] = "Cividade";
	fichas[11][1] = "Cabreira";
	fichas[12][1] = "Cividade";
	fichas[13][1] = "Gualtar";
	fichas[14][1] = "Cividade";
	fichas[15][1] = "Gualtar";
	fichas[16][1] = "Maximinos";
	fichas[17][1] = "Maximinos";
	fichas[18][1] = "Maximinos";
	fichas[19][1] = "Gualtar";

	fichas[0][2] = "M"; fichas[0][3] = "1986";
	fichas[1][2] = "F"; fichas[1][3] = "1980";
	fichas[2][2] = "F"; fichas[2][3] = "1982";
	fichas[3][2] = "M"; fichas[3][3] = "1981";
	fichas[4][2] = "M"; fichas[4][3] = "1980";
	fichas[5][2] = "M"; fichas[5][3] = "1980";
	fichas[6][2] = "M"; fichas[6][3] = "1980";
	fichas[7][2] = "F"; fichas[7][3] = "1977";
	fichas[8][2] = "F"; fichas[8][3] = "1977";
	fichas[9][2] = "M"; fichas[9][3] = "1983";
	fichas[10][2] = "M"; fichas[10][3] = "1989";
	fichas[11][2] = "F"; fichas[11][3] = "1980";
	fichas[12][2] = "M"; fichas[12][3] = "1981";
	fichas[13][2] = "M"; fichas[13][3] = "1982";
	fichas[14][2] = "F"; fichas[14][3] = "1975";
	fichas[15][2] = "F"; fichas[15][3] = "1980";
	fichas[16][2] = "M"; fichas[16][3] = "1988";
	fichas[17][2] = "M"; fichas[17][3] = "1987";
	fichas[18][2] = "M"; fichas[18][3] = "1980";
	fichas[19][2] = "M"; fichas[19][3] = "1985";

}

int main()
{
	inicializa_matriz();
	listaMatriz();
   cout << "Hello World!\n";
}