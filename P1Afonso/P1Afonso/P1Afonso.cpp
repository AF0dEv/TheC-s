// 21/09/2023
// Afonso Figueiredo
// Produção 1

#include <iomanip> // formatação output
#include <iostream> 
#include <conio.h> // para input getchar()
#include <locale> // para usar carateres nacionais
using namespace std;

// Tipificar Contentor

struct viagens
{
	int Nviagem;
	string MarcaCarro;
	int Nkms;
};

// Inicialização Fichas

viagens fichas[10];

// Inicializar Contentor

void InicializarContentor()
{
	fichas[0] = { 1, "Seat", 158000 };
	fichas[1] = { 2, "Nissan", 13000 };
	fichas[2] = { 3, "BMW", 13000 };
	fichas[3] = { 4, "Mercedes", 170000 };
	fichas[4] = { 5, "Seat", 220000 };
	fichas[5] = { 6, "BMW", 67000 };
	fichas[6] = { 7, "Seat", 350 };
	fichas[7] = { 8, "Nissan", 3500 };
	fichas[8] = { 9, "Mercedes", 98000 };
	fichas[9] = { 10, "Seat", 143000 };
}

// Listar Contentor

void ListarContentor()
{
	for (int i = 0; i <= 9; i++)
	{
		cout << left << setw(12) << setfill(' ') << fichas[i].Nviagem <<
			left << setw(9) << setfill(' ') << fichas[i].MarcaCarro <<
			left << setw(9) << setfill(' ') << fichas[i].Nkms <<" \n";
		cout << "--------------------------------" << endl;
	}
	cout << endl;
}

// Somar KMS

void SomarKms()
{
	int totalkms = 0;
	for (int i = 0; i <= 9; i++)
	{
		totalkms = totalkms + fichas[i].Nkms;
	}
	cout << "\tO Número Total de Kms é: " << totalkms << "\n";
	cout << endl;
}

// Saber a Viagem Maior

void ViagemMaior()
{
	int ViagemMaior = fichas[0].Nkms;
	int posM = 0;

	for (int i = 0; i <= 9; i++)
	{
		if (fichas[i].Nkms > ViagemMaior)
		{
			ViagemMaior = fichas[i].Nkms;
			posM = i;
		}
	}

	cout << "\tA Viagem Maior é:\t" << fichas[posM].Nviagem << "\t/\t" << fichas[posM].MarcaCarro << "\t/\t" << ViagemMaior << "\n";
	cout << endl;
}

void TrocarFichas()
{
	viagens fichatemporaria;
	int pos1 = 0;
	int pos2 = 0;

	cout << "\tQual a 1 Posição a Trocar?\n";
	cin >> pos1;
	cout << "\n\tQual a 2 Posição a Trocar?\n";
	cin >> pos2;

	fichatemporaria = fichas[pos1];
	fichas[pos1].MarcaCarro = fichas[pos2].MarcaCarro;
	fichas[pos1].Nkms = fichas[pos2].Nkms;
	fichas[pos1].Nviagem = fichas[pos2].Nviagem;
	fichas[pos2].MarcaCarro = fichatemporaria.MarcaCarro;
	fichas[pos2].Nkms = fichatemporaria.Nkms;
	fichas[pos2].Nviagem = fichatemporaria.Nviagem;

	ListarContentor();
}

int main()
{
	setlocale(LC_ALL, "Portuguese");

	char op;

	do
	{
		// MENU

		cout << "-------------------------------------------------OPCOES--------------------------------------------------------------\n";
		cout << "(1)\tIniciar Lista.\n";
		cout << "(2)\tListar Contentor.\n";
		cout << "(3)\tSomar os Kms.\n";
		cout << "(4)\tEncontrar o Número Viagem Maior.\n";
		cout << "(5)\tTrocar Ficha.\n";
		cout << "ESC\tAcabar Programa.\n";
		op = _getch();

		switch (op)
		{
			// --------------------------------------------------------------------------------------------------------------------- 1:
		case '1':
			// Inicializar Contentor

			InicializarContentor();
			
			break;
			// --------------------------------------------------------------------------------------------------------------------- 2:
		case '2':
			
			// Listar Contentor

			ListarContentor();

			break;
			// --------------------------------------------------------------------------------------------------------------------- 3:
		case '3':
			
			// Somar KMS

			ListarContentor();
			SomarKms();
			
			break;
			// --------------------------------------------------------------------------------------------------------------------- 4:
		case '4':
			
			// Saber a Viagem Maior

			ListarContentor();
			ViagemMaior();
			
			break;
			// --------------------------------------------------------------------------------------------------------------------- 5:
			
		case '5':

			//Trocar Fichas
			
			ListarContentor();
			TrocarFichas();

			break;
			// --------------------------------------------------------------------------------------------------------------------- ESC:SAIR
		case 27:

			// Acabar Programa

			cout << "\n fim do programa...\n";
			
			break;
			// --------------------------------------------------------------------------------------------------------------------- DEFAULT
		default:
			
			// Inputs Inválidos

			cout << "\7"; //beep do sistema
			
			break;
		}
	} while (op != 27);
}

