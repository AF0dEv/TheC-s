// 27/07/2023
//Elaborado por Afonso Figueiredo
//Programa Funções e Matrizes

#include <conio.h>				// para input getchar()
#include <locale>				// para usar carateres nacionais
#include <iomanip>				// para a formatação do output 
#include <iostream>
#include <string>				// para converter string para int (stoi)

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
	fichas[3][1] = "Porto";
	fichas[4][1] = "Lomar";
	fichas[5][1] = "Cividade";
	fichas[6][1] = "Porto";
	fichas[7][1] = "Maximinos";
	fichas[8][1] = "Ferreiros";
	fichas[9][1] = "Porto";
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
	fichas[3][2] = "M"; fichas[3][3] = "2020";
	fichas[4][2] = "M"; fichas[4][3] = "1980";
	fichas[5][2] = "M"; fichas[5][3] = "1980";
	fichas[6][2] = "M"; fichas[6][3] = "2015";
	fichas[7][2] = "F"; fichas[7][3] = "1977";
	fichas[8][2] = "F"; fichas[8][3] = "1977";
	fichas[9][2] = "M"; fichas[9][3] = "2010";
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

void ListarMenu()
{
	cout << "Op 1: Inicializar Matriz.\n";
	cout << "Op 2: Listar Matriz.\n";
	cout << "Op 3: Inserir Nova Ficha em Matriz.\n";
	cout << "Op 4: Quem e o Mais Velho da Lista ? (2023)\n";
	cout << "Op 5: Quantas Raparigas ha na Lista ?\n";
	cout << "Op 6: Quantos Rapazes ha em Maximinos ?\n";
	cout << "Op 7: Ler Ano -> Aparece Repetido ?\n";
	cout << "Op 8: Ha Anos Repetidos ?\n";
	cout << "Op 9: Listar Apenas Raparigas.\n";
	cout << "Op A: Quantas Pessoas Acima de uma Idade?\n";
	cout << "Op F: Copiar Rapazes Para Array e Listar Array.\n";
	cout << "Op G: Contar Rapazes Em Matriz\n";
	cout << "Op X: Quantos Menores de idade com X sexo e X freguesia?\n";
	cout << "Op Y: Listar Nomes da Freguesia X com mais elementos.\n";
	cout << "Op Z: Se existe 2 Nomes em Simultaneo na Lista e se estão Seguidos.\n";
	cout << "ESC: Sair do Programa.\n\n";
} 

void InserirNovaFicha()
{
	int pos;
	string NOME;
	string LOCAL;
	string SEXO;
	string ANO;

	cout << "Indicar Posicao Nova Ficha: ";
	cin >> pos;
	cout << "Indique Novo Nome\n";
	cin >> NOME;
	cout << "Indique Novo Local\n";
	cin >> LOCAL;
	cout << "Indique Novo Sexo\n";
	cin >> SEXO;
	cout << "Indique Novo Ano\n";
	cin >> ANO;

	fichas[pos][0] = NOME;
	fichas[pos][1] = LOCAL;
	fichas[pos][2] = SEXO;
	fichas[pos][3] = ANO;
}

void QuemMaisVelho()
{
	int MaisVelhoPos = 0;
	int MaisVelho = stoi(fichas[0][3]);
	for (int i = 0; i <= 19; i++)
	{
		if (stoi(fichas[i][3]) < MaisVelho)
		{
			MaisVelho = stoi(fichas[i][3]);
			MaisVelhoPos = i;
		}
	}
	cout << "O mais velho da lista e: " << fichas[MaisVelhoPos][0] << "\n\n";
}

void QuantasRaparigas()
{
	int ContadorRaparigas = 0;
	for (int i = 0; i <= 19; i++)
	{
		if (fichas[i][2] == "F")
		{
			ContadorRaparigas++;
		}
	}
	cout << "Existe " << ContadorRaparigas << " Raparigas\n\n";
}

void RapazesMaximinos()
{
	int contadorRapazesMaximinos = 0;
	for (int i = 0; i <= 19; i++)
	{
		if ( (fichas[i][1] == "Maximinos") && (fichas[i][2] == "M") )
		{
			contadorRapazesMaximinos++;
		}
	}
	cout << "Existe " << contadorRapazesMaximinos << " Rapazes em Maximinos\n\n";
}

void LerAnoRepetido()
{
	string ANOaVerificar;
	bool HaRepetido = false;
	int ContadorAnoRepetido = 0;

	cout << "Digite ano a Verificar: ";
	cin >> ANOaVerificar;
	for (int i = 0; i <= 19; i++)
	{
		if (ANOaVerificar == fichas[i][3])
		{
			ContadorAnoRepetido++;
		}
	}
	if (ContadorAnoRepetido > 1)
	{
		HaRepetido = true;
	}
	if (HaRepetido == true)
	{
		cout << "Este ano tem Repetidos\n\n";
	}
	else
	{
		cout << "Este ano nao tem Repetidos\n\n";
	}
}

void AnoRepetido()
{
	bool HaAnoRepetido = false;
	for (int i = 0; i <= 19; i++)
	{
		for (int j = 0; j <= 19; j++)
		{
			if (fichas[i][3] == fichas [j][3])
			{
				HaAnoRepetido = true;
			}
		}
	}
	if (HaAnoRepetido == true)
	{
		cout << "Ha Anos Repetidos na Tabela\n\n";
	}
	else
	{
		cout << "Nao ha Anos Repetidos na Tabela\n\n";
	}
}

void ListarRaparigas()
{
	for (int i = 0; i <= 19; i++)
	{
		if (fichas[i][2] == "F")
		{
			cout << fichas[i][0] << "\n";
		}
	}
	cout << "\n";
}

void QuantasPessoasMaiorX()
{
	int Anos;
	int contador = 0;
	int idade = 2023 - stoi(fichas[0][3]);

	cout << "Que idade deseja contar ?\n";
	cin >> Anos;
	for (int i = 0; i <= 19; i++)
	{
		if (Anos < 2023 - stoi(fichas[i][3]) )
		{
			contador++;
		}
	}
	cout << "A idade " << Anos << " tem " << contador << " idades maiores.\n\n";
}

void CopiarListarArray()
{
	string Rapazes[20];

	for (int i = 0; i <= 19; i++) // Preencher Array com *
	{
		Rapazes[i] = "*";
	}
	for (int i = 0; i <= 19; i++) // Encontrar Rapazes e Substituir na Array
	{
		if ( (fichas[i][2]) == "M")
		{
			Rapazes[i] = fichas[i][0];
		}
	}
	for (int i = 0; i <= 19; i++) // Listar Rapazes
	{
		if (Rapazes[i] != "*")
		{
			cout << Rapazes[i] << " ";
		}
	}
	cout << "\n\n";
}

int ContarRapazes()
{
	int ContadorRapazes = 0;
	for (int i = 0; i <= 19; i++)
	{
		if (fichas[i][2] == "M")
		{
			ContadorRapazes++;
		}
	}
	return ContadorRapazes;
}

void FreguesiaMaisElementos()
{
	int contadorf1 = 0;
	int contadorf2 = 0;
	string freguesia1;
	string freguesia2;

	cout << "Insira a 1ª Freguesia: ";
	cin >> freguesia1;
	cout << "\nInsira a 2ª Freguesia: ";
	cin >> freguesia2;
	cout << "\n";

	for (int i = 0; i <= 19; i++) // Saber quem tem mais elementos
	{
		if (freguesia1 == fichas[i][1])
		{
			contadorf1++;
		}
		if (freguesia2 == fichas[i][1])
		{
			contadorf2++;
		}
	}
	for (int i = 0; i <= 19; i++) // Listar os nomes da freguesia com mais elementos
	{
		if (contadorf1 > contadorf2 && freguesia1 == fichas [i][1])
		{
			cout << fichas[i][0] << " ";
		}
		if (contadorf2 > contadorf1 && freguesia2 == fichas[i][1])
		{
			cout << fichas[i][0] << " ";
		}
	}
	cout << "\n\n";
}

void QuantosMenoresXSexoFreguesia()
{
	string freguesia;
	string sexo;
	int contadorMenores = 0;
	int idade = 18;

	cout << "Insira a freguesia: ";
	cin >> freguesia;
	cout << "\nInsira o sexo: ";
	cin >> sexo;
	cout << "\n";

	for (int i = 0; i <= 19; i++) // comparar e contar os menores
	{
		if (freguesia == fichas[i][1] && sexo == fichas[i][2] && (2023 - stoi(fichas[i][3]) < idade) )
		{
			contadorMenores++;
		}
	}
	cout << "Existem " << contadorMenores << " menores do sexo " << sexo << " da freguesia " << freguesia;
	cout << "\n\n";
}

void SeExisteNomeEstaoSeguidos()
{
	bool existenome1 = false;
	bool existenome2 = false;
	bool ExisteNomes = false;
	bool EstaoSeguidos = false;
	string nome1;
	string nome2;
	int p1 = 0;
	int p2 = 0;

	cout << "Escreva o 1º Nome: ";
	cin >> nome1;
	cout << "\nEscreva o 2º Nome: ";
	cin >> nome2;
	cout << "\n";

	// Ver se existem os Nomes

	for (int i = 0; i <= 19; i++)
	{
		if (nome1 == fichas[i][0])
		{
			existenome1 = true;
			p1 = i;
		}
	}
	for (int i = 0; i <= 19; i++)
	{
		if (nome2 == fichas[i][0])
		{
			existenome2 = true;
			p2 = i;
		}
	}
	if (existenome1 == true && existenome2 == true)
	{
		ExisteNomes = true;
	}
	
	// Verificar se estao Seguidos

	if (ExisteNomes == true && (p1+1) == p2 )
	{
		EstaoSeguidos = true;
	}

	// escrever resultados

	if (ExisteNomes == true)
	{
		cout << "Sim, existem estes dois nomes simutaneamente. ";
	}
	else
	{
		cout << "Estes dois nomes não existem em simultaneo. ";
	}
	if (EstaoSeguidos == true)
	{
		cout << "Sim, estão em Posições Contíguas\n\n";
	}
	else
	{
		cout << "Não estão em Posicões Contíguas\n\n";
	}


}

int main()
{
	setlocale(LC_ALL, "Portuguese");
	ListarMenu();

	char op;
	
	do
	{
		op = _getch();
		switch (op)
		{
		case '1':
			inicializa_matriz();
			ListarMenu();
			break;
		case '2':
			listaMatriz();
			ListarMenu();
			break;
		case '3':
			InserirNovaFicha();
			ListarMenu();
			break;
		case '4':
			QuemMaisVelho();
			ListarMenu();
			break;
		case '5':
			QuantasRaparigas();
			ListarMenu();
			break;
		case '6':
			RapazesMaximinos();
			ListarMenu();
			break;
		case '7':
			LerAnoRepetido();
			ListarMenu();
			break;
		case '8':
			AnoRepetido();
			ListarMenu();
			break;
		case '9':
			ListarRaparigas();
			ListarMenu();
			break;
		case'A':
			QuantasPessoasMaiorX();
			ListarMenu();
			break;
		case'F':
			CopiarListarArray();
			ListarMenu();
			break;
		case 'G':
			ContarRapazes();
			cout << "Há " << ContarRapazes() << " Rapazes.\n\n";
			ListarMenu();
			break;
		case'Y':
			FreguesiaMaisElementos();
			ListarMenu();
			break;
		case 'X':
			QuantosMenoresXSexoFreguesia();
			ListarMenu();
			break;
		case 'Z':
			SeExisteNomeEstaoSeguidos();
			ListarMenu();
			break;
		}
	} while (op != 27 );
}