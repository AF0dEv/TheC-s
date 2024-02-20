// Ficheiros
// 12-10-2023
// Elaborado por Afonso Figueiredo

#include <iostream>
#include <string>		// stoi (), getline
#include <conio.h>		// _getch ()
#include <locale>		// para usar carateres nacionais
#include <iomanip>		// para a formatação do output 
#include <Windows.h>	// para o temporizador ou marca_passo
#include <algorithm>	// para usar a transform string function
#include <fstream>		// para trabalhar com file
#include <vector>		// uso de vetores
using namespace std;

struct registo
{
	string nome;
	int idade;
};



// ########## PEQUENAS FUNÇÕES COMPLEMENTARES ##########
void intermitencia(int t)
{
	cout << "."; Sleep(t); cout << "."; Sleep(t);
	cout << "."; Sleep(t); cout << "."; Sleep(t);
	cout << "."; Sleep(t); cout << "."; Sleep(t);
	cout << "."; Sleep(t);
}
void beep_erro(char op)
{
	if (op != 27)
	{
		cout << "Opcao incorreta!";
		Beep(440, 1000); //frequência, tempo
		Sleep(500); //tempo
	}
}

// Retirar Nome e Idade de String

string getNome(string nome)
// Se existir '#' , devolve a parte do nome; senão, devolve vazio
// ex. de string que chega: "Ana#18"
{
	int p = nome.find("#"); // em que posição aparece o separador '#'?
	if (p < 0) // não encontrou o separador '#'
	{
		return "";
	}
	else
	{
		return nome.substr(0, p); // do inicio até antes do '#'
	}
}

int getIdade(string nome)
{
	int p = nome.find("#"); // em que posição aparece o separador '#'
	if (p < 0) // não encontrou separador '#'
	{
		return -1;
	}
	else
	{
		return stoi(nome.substr(p + 1));
	}
}

// Concatenar Nome com Idade separado por '#'

string Concatenar(string nome, int idade)
{
	string registo;
	return  nome + "#" + to_string(idade);
}


// Função Procurar Nome Ficheiro

string fProcurarNomeFicheiro(string nome)
{
	string s;
	ifstream fpl("Lista.txt");
	bool existeNome;
	string soNome;
	string nomeIntroduzido = nome;

	existeNome = false;


	while (getline(fpl, s))
	{
		soNome = getNome(s);
		if (soNome == nomeIntroduzido)
		{
			existeNome = true;
			return s;
		}
	}
	if (existeNome == false)
	{
		return "Nao existe";
	}
	fpl.close();
}

// ##################################################### FUNÇÕES DOS 'cases' DO PROGRAMA
void desenha_menu()
{
	system("cls");
	cout << "  \nExercício prático - algoritmos diversos, com text file, funcões, matriz, ...\n\n" << endl;
	cout << "  L - (L)istar ficheiro Lista         D - (D)eletar conteudo ficheiro\n";
	cout << "  Z - Iniciali(Z)ar com 16 nomes\n";
	cout << "  N - Escrever (N)o início do fich.   A - (A)crescentar nome no fim \n";
	cout << "  S - (S)ubstituir nome no ficheiro   P - (P)rocurar nome no ficheiro\n";
	cout << "  C - (C)ontar nomes no ficheiro      1 - (1) Contar ocorrência de certo nome\n" << endl;
	cout << "  Z - Iniciar Lista com Registos      2 - (2) Apagar Ficheiro\n" << endl;
	cout << "  3 - Escrever Inicio Sem Apagar Nada\n" << endl;
	cout << "  J - a(J)uda\n\n\n" << endl;

	cout << "  4 - (4) Indicar a Idade de Certa Pessoa             5 - (5) \n" << endl;

	cout << "  7 - (7) Ler Idade, Separar 2 Ficheiros\n" << endl;
	cout << "  8 - (8) Listar Array\n";
	cout << "  9 - (9) Encontrar Nome e Elimina - lo, Encontrar Idades Iguais e eliminar, Listar e Contar Registos\n" << endl;



	cout << "  ESC - sair\n\n\n";
}
void fCasoAAjuda()
{
	int i;
	for (i = 7; i >= 1; i--)
	{
		system("cls");
		cout << "\n\n\n\n\n\n\t" << "ah!... faça mas é os algoritmos!";
		cout << "\n\n\n\n\t";
		cout << "  " << i << "...";
		Sleep(600);
	}
}

// Inicializar Lista com Registos

void fCasoZInicializaFicheiroCom16()
{
	/*ATENÇÃO:
	colar aqui os 20 nomes fornecidos na
	pasta das descargas*/
	system("cls");
	ofstream fpd("Lista.txt");

	fpd << "Ana Rita Cunha#32" << "\n";
	fpd << "Bela Costa Silva#65" << "\n";
	fpd << "Carlos Alberto Costa#98" << "\n";
	fpd << "Carlos Serafim Ferreira#78" << "\n";
	fpd << "Daniel Bastos Gomes#14" << "\n";
	fpd << "Diogo Silva Ferraz#45" << "\n";
	fpd << "Elvira Gomes Pendes#54" << "\n";
	fpd << "Fernanda Maria Silva#89" << "\n";
	fpd << "Fernando Gomes Barros#5" << "\n";
	fpd << "Gilherme Alexandre Barros#38" << "\n";
	fpd << "Hilda Fonseca Silva#60" << "\n";
	fpd << "Jose Manuel Carvalho#46" << "\n";
	fpd << "Jose Alberto Gomes#54" << "\n";
	fpd << "Maria Silvéria Bastos#74" << "\n";
	fpd << "Anabela Bastos Torres#68" << "\n";
	fpd << "Teodoro Armando Matos#12" << "\n";

	fpd.close();


	cout << "Inicializado!"; intermitencia(100);
}

// Listar Lista

void fCasoLListarNomes()
{
	system("cls");
	string s;
	ifstream fpl("Lista.txt");
	cout << "\n";

	if (!fpl) //if (!getline(fpl, s))
	{
		cout << "Ficheiro vazio ou inexistente!";
		intermitencia(100);
	}
	else {
		while (getline(fpl, s))
		{
			cout << s << endl;
		}
		fpl.close();
	}
	intermitencia(300);
}

// Contar Nomes no Ficheiro

void fCasoCContarRegistos()
{
	system("cls");
	int contador;
	string s;
	ifstream fpl("Lista.txt");

	contador = 0;
	cout << "\n";

	if (!fpl) //if (!getline(fpl, s))
	{
		cout << "Ficheiro vazio ou inexistente!\n";
		intermitencia(100);
	}
	else {
		while (getline(fpl, s))
		{
			contador++;
		}
		fpl.close();
	}
	cout << "A lista tem " << contador << " registos.\n" << endl;
	intermitencia(300);
}

// Acrescentar Nome no Fim de Lista

void fCasoAAcrescentarNoFim()
{
	system("cls");
	string nome;
	int idade;
	string registo;
	char op;
	ofstream fpd("Lista.txt", ofstream::app); // modo apendice - Escrever no fim

	cout << "Quer Registar Apenas Nome?\n" << endl;
	cout << "\tS/N ?\n" << endl;
	cin >> op;
	if (op == 's' || op =='S')
		// Caso 1 - Se Quiser Registar Apenas Nome
	{
		system("cls");
		cout << "Escreva um Nome\n" << endl;
		cin >> nome;
		fpd << nome << "\n";
		fpd.close();
		cout << "\nAdicionado no fim! \n";
		intermitencia(100);
	}
	else if (op == 'n' || op == 'N')
		// Caso 2 - Se quiser Registar Nome e Idade	
	{
		system("cls");
		cout << "Escreva o Nome a Registar.\n";
		cin >> nome;
		cout << "\nEscreva a Idade a Registar.\n";
		cin >> idade;
		registo = Concatenar(nome, idade);
		fpd << registo << "\n";
		fpd.close();
		intermitencia(150);
	}
	else
	{
		system("cls");
		cout << "Opcao Invalida\n";
		intermitencia(100);
	}
}

// Escrever nome no Inicio

void fCasoNAdicionarNomeInicioFicheiro()
{
	string nome;
	int idade;
	string registo;
	char op;
	ofstream fpd("Lista.txt", ofstream::out); // modo overwrite - Escrever por Cima, Apaga anterior

	system("cls");
	cout << "Quer Registar Apenas Nome?\n" << endl;
	cout << "\tS/N ?\n" << endl;
	cin >> op;
	if (op == 's' || op == 'S')
		// Caso 1 - Se Quiser Registar Apenas Nome
	{
		system("cls");
		cout << "Escreva um Nome\n" << endl;
		cin >> nome;
		fpd << nome << "\n";
		fpd.close();
		cout << "Adicionado no Inicio! \n";
		intermitencia(100);
	}
	else if (op == 'n' || op == 'N')
		// Caso 2 - Se quiser Registar Nome e Idade	
	{
		system("cls");
		cout << "Escreva o Nome a Registar.\n";
		cin >> nome;
		cout << "\nEscreva a Idade a Registar.\n";
		cin >> idade;
		registo = Concatenar(nome, idade);
		fpd << registo << "\n";
		fpd.close();
		intermitencia(150);
	}
	else
	{
		system("cls");
		cout << "Opcao Invalida\n";
		intermitencia(100);
	}
}

// Apagar Conteúdo Ficheiro

void fCasoDDeletarTudo()
{
	system("cls");
	ofstream file("Lista.txt", ios::out | ios::trunc); // ios::trunc, o Compilador faz Overload ao Ficheiro, ou seja apagá-lo e criar outro novo.
	cout << "Conteudo Ficheiro Apagado\n" << endl;
	intermitencia(150);
}

// Procurar Nome

void fCasoPProcurarNomeNoFicheiro()
{
	system("cls");
	string nome;

	cout << "Escreva Nome a Procurar\n" << endl;
	getline(cin, nome);
	string s = fProcurarNomeFicheiro(nome);

	if (s == "Nao existe") //if (!getline(fpl, s))
	{
		cout << "\nNome nao Existe!\n" << endl;
	}
	else
	{
		cout << "\nO Nome Existe.\n" << endl;
	}
	intermitencia(300);
}

// Contar Ocorrência de Nome

void fCaso1ContarOcorrênciaDeCertoNome()
{
	system("cls");
	int contador;
	string s;
	string nome;
	ifstream fpl("Lista.txt");
	string SoNome;

	contador = 0;
	cout << "\n";

	if (!fpl) //if (!getline(fpl, s))
	{
		cout << "Ficheiro vazio ou inexistente!";
	}
	else {
		cout << "Escreva Nome a Procurar.\n";
		getline(cin, nome);
		while (getline(fpl, s))
		{
			SoNome = getNome(s);
			if (SoNome == nome)
			{
				contador++;
			}
		}
		fpl.close();
	}
	cout << "\nA lista tem " << contador << " registos com nome igual.\n" << endl;
	intermitencia(300);
}

// Procurar e Substituir Nome

void fCasoSSubstituirNomeNoFicheiro()
{
	system("cls");
	string s;
	string Nome;
	string NomeATrocar;
	ifstream fpl("Lista.txt");
	ofstream fpw("Listatemp.txt");
	string capturaidade;
	string nomeConcatenado;
	string existe;
	int idade;

	cout << "Escreva o Nome a Encontrar.\n" << endl;
	getline(cin, Nome);

	cout << "\nEscreva o Novo Nome.\n" << endl;
	getline(cin, NomeATrocar);
	cout << "\nEscreva a Nova Idade\n" << endl;
	getline(cin,capturaidade);
	idade = stoi(capturaidade);
	nomeConcatenado = Concatenar(NomeATrocar, idade); // Juntar o Novo Nome com Idade

	existe = fProcurarNomeFicheiro(Nome);

	if (existe == "Nao existe") // se o nome nao existir
	{
		cout << "Nome nao Existe.\n" << endl;
	}
	else // se o nome existir
	{
		while (getline(fpl, s))
		{
			if (s != existe) // comparar nomes
			{
				fpw << s << "\n"; // escrever nomes diferentes
			}
			else
			{
				fpw << nomeConcatenado << "\n"; // substituir novo nome;
			}
		}
	}
	fpl.close();
	fpw.close();
	remove("Lista.txt");
	rename("Listatemp.txt", "Lista.txt");
	intermitencia(150);
}

// Apagar Ficheiro

void fCaso2ApagarFicheiro()
{
	system("cls");
	int r = remove("Lista.txt");
	if (r == 0)
	{
		cout << "Ficheiro Removido.\n" << endl;
		intermitencia(150);
	}
	else
	{
		cout << "Ficheiro Inexistente.\n" << endl;
		intermitencia(150);
	}

}

// Escrever Inicio Ficheiro Sem Apagar Registos

void fCaso3EscreverInicioManterRegisto()
{
	system("cls");
	string nome;
	string s;
	ifstream fpl("Lista.txt");
	ofstream fpw("Listatemp.txt");
	int idade;
	string nomeconcatenado;

	cout << "Escreva o Nome a Adicionar\n" << endl;
	getline(cin, nome);
	cout << "Escreva a idade.\n" << endl;
	cin >> idade;
	nomeconcatenado = Concatenar(nome, idade);

	fpw << nomeconcatenado << "\n";
	while (getline(fpl, s))
	{
		fpw << s << "\n";
	}
	fpl.close();
	fpw.close();
	remove("Lista.txt");
	rename("Listatemp.txt", "Lista.txt");
	cout << "Nome Adicionado.\n" << endl;
	intermitencia(150);
}

// Separar Nome de Idade

void fCaso4IndicarIdade()
{
	int idade;
	string nome;
	system("cls");
	cout << "Indique o Nome.\n";
	getline(cin, nome);


	string s = fProcurarNomeFicheiro(nome);

	// Se não Existir Nome
	if (s == "Nao existe")
	{
		cout << "O nome Nao Existe\n";
		intermitencia(100);
	}
	else
	{ // Se existir nome
		idade = getIdade(s);
		cout << "A idade e " << idade << "\n";
		intermitencia(100);
	}

}

// Ler Idade, Enviar maiores para ficheiro e menores para outro, Listar os dois

void fCaso7LerIdadeSeparar2ficheiros()
{
	string s;
	string idadeIntroduzida;
	int idadeInt;
	int idade;

	ifstream fp ("Lista.txt");
	ifstream fpr("Lista1.txt");
	ifstream fpl("Lista2.txt");

	ofstream fpw("Lista1.txt");
	ofstream fpe("Lista2.txt");

	system("cls");
	cout << "Introduza Uma idade\n" << endl;
	getline(cin, idadeIntroduzida);
	intermitencia(50);

	idadeInt = stoi(idadeIntroduzida);
	
	while (getline(fp,s))
	{
		idade = getIdade(s);

		if (idade > idadeInt )
		{
			fpw << s << "\n";
		}
		else
		{
			fpe << s << "\n";
		}
	}

	fp.close();
	fpe.close();
	fpw.close();

	system("cls");

	cout << "\n\tLISTA 1 - MAIORES QUE IDADE INTRODUZIDA\n\n";
	if (!fpr)
	{
		cout << "\nFicheiro vazio ou Inexistente\n" << endl;
		intermitencia(100);
	}
	else
	{
		while (getline(fpr,s) )
		{
			cout << s << endl;
		}
	}
	fpr.close();

	cout << "\n\tLISTA 2 - MENORES QUE IDADE INTRODUZIDA\n\n";
	if (!fpl)
	{
		cout << "\nFicheiro vazio ou Inexistente\n" << endl;
		intermitencia(100);
	}
	else
	{
		while (getline(fpl, s))
		{
			cout << s << endl;
		}
	}
	intermitencia(500);
	fpl.close();
}

int contarLinhas()
{
	system("cls");
	int contador;
	string s;
	ifstream fpl("Lista.txt");

	contador = 0;
	cout << "\n";

	if (fpl) //if (!getline(fpl, s))
	{
		while (getline(fpl, s))
		{
			contador++;
		}
	}
	fpl.close();
	return contador;
}



// LISTAR ARRAY 

void fCaso8ListarArray()
{
	system("cls");
	registo array[50];
	string s;
	ifstream fp("Lista.txt");
	int linha = 1;
	int l = contarLinhas();

	while (getline(fp,s))
	{
			array[linha].nome = getNome(s);
			array[linha].idade = getIdade(s);
			linha++;
	}
	fp.close();


	for (int i = 1; i <= l; i++)
	{
		cout << array[i].nome << "\t/\t" << array[i].idade << "\n"; 
	}
	intermitencia(500);

}

// Ler Nome Apagar Se Existir APAGAR Idades Iguais Listar Contar

void fCaso9LerNomeApagarSeExistirEIdadesIguaisListarContar()
{
	system("cls");
	string s;
	string nome;
	string existeNome;
	int idadeAcomparar;
	int idadeComparacao;
	int linhas = contarLinhas();
	ifstream fpr("Lista.txt");
	ofstream fpw("ListaTemp.txt");
	bool alteracao;

	alteracao = false;
	cout << "Escreva Nome a Procurar\n";
	getline(cin, nome);
	existeNome = fProcurarNomeFicheiro(nome);
	idadeAcomparar = getIdade(existeNome);

	// Eliminar Nome
	if (existeNome == "Nao existe")
	{
		alteracao = false;
		cout << "\nO nome nao existe.\n" << endl;
		intermitencia(50);
	}
	else
	{
		alteracao = true;
		while (getline(fpr,s))
		{
			idadeComparacao = getIdade(s);
			if (s != existeNome && idadeAcomparar != idadeComparacao ) // eliminar nome igual e todos com a mesma idade
			{
				fpw << s << "\n";
			}
		}
	}
	fpr.close();
	fpw.close();
	
	if (alteracao == true) // se a alteraçao foi feita, Listar Membros e contalos
	{
		remove("Lista.txt");
		rename("ListaTemp.txt", "Lista.txt");
		ifstream fpl("Lista.txt");

		system("cls");
		while (getline(fpl, s))
		{
			cout << s << endl;
		}
		cout << "\nO Ficheiro tem " << linhas << " registos apos formatacao\n" << endl;
		intermitencia(500);
		fpl.close();
	}

}

// ##################################################### FUNÇÃO PRINCIPAL OU MAIN
int main()
{
	//locale::global(std::locale(""));
	//1252 é o codepage LATIN1 que parece funcionar para nós (Portugal)
	//1253 Greek, 1255 Hebrew, etc...
	SetConsoleOutputCP(1252);
	SetConsoleCP(1252);
	SetConsoleTitle(TEXT("	    - OPERAÇÕES COM FICHEIRO DE TEXTO E OUTRAS - "));

	char op;
	do
	{
		desenha_menu();
		op = _getch();
		switch (op)
		{
		case 'a': case 'A':fCasoAAcrescentarNoFim();		break;
		case 'l': case 'L':fCasoLListarNomes();				break;
		case 'n': case 'N':fCasoNAdicionarNomeInicioFicheiro();break;
		case 'z': case 'Z':fCasoZInicializaFicheiroCom16();	break;
		case 'c': case 'C':fCasoCContarRegistos();			break;
		case 'd': case 'D':fCasoDDeletarTudo();				break;
		case 's': case 'S':fCasoSSubstituirNomeNoFicheiro();break;
		case 'p': case'P':fCasoPProcurarNomeNoFicheiro();	break;
		case '1':fCaso1ContarOcorrênciaDeCertoNome();		break;
		case '2':fCaso2ApagarFicheiro();					break;
		case '3':fCaso3EscreverInicioManterRegisto();		break;
		case '4':fCaso4IndicarIdade();						break;
		case '7':fCaso7LerIdadeSeparar2ficheiros();			break;
		case '8':fCaso8ListarArray();						break;
		case '9':fCaso9LerNomeApagarSeExistirEIdadesIguaisListarContar();break;
		case 'j': case'J':fCasoAAjuda();					break;
		default: beep_erro(op);								break;
		}
	} while (op != 27);
	cout << "\tAté breve.\n\n\n"; intermitencia(50);
}