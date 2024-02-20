// Joao Sousa
// 2023-10-12
// Ficheiros nome e idades v3
// Producao 3

#include <iostream>
#include <string>		// stoi (), getline
#include <conio.h>		// _getch ()
#include <locale>		// para usar carateres nacionais
#include <iomanip>		// para a formatação do output 
#include <Windows.h>	// para o temporizador ou marca_passo
#include <algorithm>	// para usar a transform string function
#include <fstream>		// para trabalhar com file
#include <vector>		// para trabalhar com vectors
using namespace std;


//###################################################################
// Parte 2 do exercicio
// Foi adicionado as idades na lista de nomes
// O # (cardinal) separa o nome da idade
//###################################################################


//###################################################################
// Funcoes auxiliares
//###################################################################
int getIdade(string s)
// Funcao get idade de uma linha
// Se existir # devolve a idade , se nao devolve -1 "erro"
{
	int p = s.find("#"); // devolve a posicao do char "#"" na stringa
	if (p < 0)
		// retoma -1 se nao encontrou
		return -1;
	else
		// se encontrou convert para int e devolve
		return stoi(s.substr(p + 1));
}

string getNome(string s)
// Funcao get nome de uma linha
// Se existir #, devolve a parte do nome; se nao, devolve vazio
{
	int p = s.find("#"); // Em que posicao aparece o p
	if (p < 0)
		return ""; // return string vazia se nao en controu
	else
		return s.substr(0, p); // Do inico ate antes de #
}

string concatenar(string nome, int idade)
// Funcao que vai concatenar o nome e a idade
{
	return  nome + "#" + to_string(idade) + "\n";
}

int encontrarPosNome(string nome)
// Funcao que retoma a posicao (linha) onde se encontra o nome
// Se o nome nao existe retoma -1;
{
	// Acesso ao ficheiro em modo de leitura
	ifstream fpl("lista.txt");
	string s;
	int posicao = 1; // comeca na linha 1

	// Loop para percorrer o ficheiro
	if (!fpl) // Verifica de existe
	{
		cout << "Ficheiro vazio ou inexistente!";
	}
	else {
		// ciclo para ler linha a linha
		while (getline(fpl, s))
		{
			if (getNome(s) == nome) // se a substring for igual ao nome
			{
				return posicao; // retoma a posicao da linha
			}
			posicao++;
		}
		fpl.close();
	}
	return -1; // se nao en controu nehum nome retoma -1
}

void removeLinha(int numero)
// Funcao para remover linha numero x
{
	fstream fpl("lista.txt");
	string s;
	int posicao = 1; // comeca na linha 1

	// Ficheiro temporario1
	fstream fplT1("nomesT1.txt", ofstream::out);

	// Ficheiro temporario2
	fstream fplT2("nomesT2.txt", ofstream::out);

	// Separa em dois ficheiros
	while (getline(fpl, s)) // ciclo para ler linha a linha
	{
		if (posicao < numero) // todas as linhas antes da posicao
		{
			fplT1 << s << endl;
		}
		if (posicao > numero) // todas as linhas depois da posicao
		{
			fplT2 << s << endl;
		}
		posicao++;
	}

	// fplT1.clear();
	// fplT1.seekg(0, fstream::beg);
	// fplT2.clear();
	// fplT2.seekg(0, fstream::beg);

	// fechar ficheiros
	fplT1.close();
	fplT2.close();

	// Ficheiro temporario1 mode leitura
	ifstream fplT1l("nomesT1.txt");

	// Ficheiro temporario2 modo leitura
	ifstream fplT2l("nomesT2.txt");

	// Ficheiro final que junta os dois ficheiros temporarios
	fstream fplFinal("nomesFinal.txt", ofstream::out);

	// utiliza o buffer para direcionar para o ficheiro final
	if (numero == 1)
	{
		// se for a na primeira linha so junta o ficheiro temporario fplT2l
		fplFinal << fplT2l.rdbuf();
	}
	else
	{
		// junta o ficheiros temporarios fplT1l e fplT2l
		fplFinal << fplT1l.rdbuf() << fplT2l.rdbuf();
	}

	// fechar ficheiros
	fpl.close();
	fplFinal.close();
	fplT1l.close();
	fplT2l.close();

	// renomear 
	remove("lista.txt");
	rename("nomesFinal.txt", "lista.txt");
	// remove ficheiros temporarios
	remove("nomesT1.txt");
	remove("nomesT2.txt");

}


void adicionaLinha(int numero, string nome, int idade)
// Funcao para adicionar linha na posicao n
{
	fstream fpl("lista.txt");
	string s;
	int posicao = 1; // comeca na linha 1

	// Ficheiro temporario1
	fstream fplT1("nomesT1.txt", ofstream::out);

	// Ficheiro temporario2
	fstream fplT2("nomesT2.txt", ofstream::out);

	// Separa as linhas em dois ficheiros
	while (getline(fpl, s)) // ciclo para ler linha a linha
	{
		// todas as linhas antes da posicao n vao para o ficeiro temporario fplT1
		if (posicao < numero)
		{
			fplT1 << s << endl;

		}
		// todas as linhas antes da posicao n vao para o ficeiro temporario fplT2
		else
		{
			fplT2 << s << endl;
		}
		posicao++;
	}

	// fechar ficheiros temporarios
	fplT1.close();
	fplT2.close();

	// Ficheiro temporario1 mode leitura
	ifstream fplT1l("nomesT1.txt");

	// Ficheiro temporario2 modo leitura
	ifstream fplT2l("nomesT2.txt");

	// Ficheiro final que junta os dois ficheiros temporarios
	fstream fplFinal("nomesFinal.txt", ofstream::out);

	// utiliza o buffer para direcionar para o ficheiro final
	if (numero == 1)
	{
		// se for a na primeira linha so junta o ficheiro temporario fplT2l
		fplFinal << concatenar(nome, idade) << fplT2l.rdbuf();
	}
	else
	{
		// junta o ficheiros temporarios fplT1l e fplT2l
		fplFinal << fplT1l.rdbuf() << concatenar(nome, idade) << fplT2l.rdbuf();
	}

	// fecha os ficehiros temporarios
	fpl.close();
	fplFinal.close();
	fplT1l.close();
	fplT2l.close();

	// remover e renomear
	remove("lista.txt");
	rename("nomesFinal.txt", "lista.txt");

	// remmover ficheiros temporarios
	remove("nomesT1.txt");
	remove("nomesT2.txt");

}

void adicionaNomeIdade(string nome, int idade)
// Funcao para adicionar nome no final do ficheiro
{

	fstream fpl("lista.txt", ostream::app);
	// chama a funcao concatenar nome e idade separados pelo #
	fpl << concatenar(nome, idade);
	fpl.close();

}

string mostrarLinha(int numero)
// funcao mostar linha numero x
{

	ifstream fpl("lista.txt");
	string s;
	int linha = 1;
	while (getline(fpl, s)) // ciclo para ler linha a linha
	{
		if (linha == numero) // se encontrou a linha imprime
		{
			return s;
		}
		linha++;
	}
	return ""; // se nao encontrou retoma string vazia
}

void trocaNome(string nome, string nomeNovo)
// Funcao para trocar nome
{

	// Linha do nome
	int p = encontrarPosNome(nome);
	if (p < 1)
	{
		cout << "O nome nao foi encontrado\n";
	}
	else
	{
		// guarda a idade numa variavel
		int idade = getIdade(mostrarLinha(p));


		// adiciona a nova linha com o novo nome
		adicionaLinha(p, nomeNovo, idade);

		// remove a linha atual
		removeLinha(p + 1);
	}

}

int contarLinhas()
// Funcao para contar o numero de linhas no ficheiro
{
	// Acesso ao ficheiro em modo de leitura
	ifstream fpl("lista.txt");
	int linhas = 0;
	string s;

	// Loop para percorrer o ficheiro
	if (!fpl) // Verifica de existe
	{
		// retorno e -1 para ficheiro vazio ou inexistente;
		return -1;
	}
	else {
		// Loop para ler linha por linha
		while (getline(fpl, s))
		{
			linhas++;
		}
		fpl.close();
	}
	return linhas;
}
//###################################################################
// Fim das funcoes auxiliares
//###################################################################


// ##################################################### PEQUENAS FUNÇÕES COMPLEMENTARES
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
		//Beep(440, 1000); //frequência, tempo
		Sleep(500); //tempo
	}
}

// ##################################################### FUNÇÕES DOS 'cases' DO PROGRAMA
void desenha_menu()
{
	system("cls");
	cout << "  \nExercício prático - algoritmos diversos, com text file, funcões, matriz, ...\n\n" << endl;
	cout << "  L - (L)istar ficheiro               D - (D)eletar ficheiro\n";
	cout << "  Z - Iniciali(Z)ar com 16 nomes\n";
	cout << "  N - Escrever (N)o início do fich.   A - (A)crescentar nome no fim \n";
	cout << "  S - (S)ubstituir nome no ficheiro   P - (P)rocurar nome no ficheiro\n";
	cout << "  C - (C)ontar nomes no ficheiro      1 - (1) Contar ocorrência de certo nome\n";
	cout << "  I - (I)nserir nome na linha (X)     R - Apaga(r) nome na linha (x)\n";
	cout << "  V - Ver idade (X)\n" << endl;

	cout << "  J - a(J)uda\n" << endl;

	cout << "  ESC - sair\n\n\n";
}
void fCasoJAjuda()
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
void fCasoZInicializaFicheiroCom16()
{
	//ATENÇÃO:
	//colar aqui os 20 nomes fornecidos na 
	//pasta das descargas

	ofstream fpd("lista.txt", ofstream::app);

	fpd << "Ana Rita Cunha#25" << "\n";
	fpd << "Bela Costa Silva#27" << "\n";
	fpd << "Carlos Alberto Costa#18" << "\n";
	fpd << "Carlos Serafim Ferreira#32" << "\n";
	fpd << "Daniel Bastos Gomes#38" << "\n";
	fpd << "Diogo Silva Ferraz#37" << "\n";
	fpd << "Elvira Gomes Pendes#23" << "\n";
	fpd << "Fernanda Maria Silva#42" << "\n";
	fpd << "Fernando Gomes Barros#47" << "\n";
	fpd << "Gilherme Alexandre Barros#29" << "\n";
	fpd << "Hilda Fonseca Silva#33" << "\n";
	fpd << "José Manuel Carvalho#47" << "\n";
	fpd << "José Alberto Gomes#39" << "\n";
	fpd << "Maria Silvéria Bastos#25" << "\n";
	fpd << "Anabela Bastos Torres#19" << "\n";
	fpd << "Teodoro Armando Matos#40" << "\n";

	fpd.close();

	cout << "Inicializado!"; intermitencia(100);
}
void fCasoLListarNomes()
{
	system("cls");
	string s;
	ifstream fpl("lista.txt");
	cout << "\n";

	if (!fpl) //if (!getline(fpl, s))
	{
		cout << "Ficheiro vazio ou inexistente!";
	}
	else {
		while (getline(fpl, s))
		{
			cout << "Nome: " << getNome(s) << " | Idade: " << getIdade(s) << endl;
		}
		fpl.close();
	}
	intermitencia(400);
}
void fCasoCContarNomes()
{

	system("cls");
	string s;
	ifstream fpl("lista.txt");

	int contador = 0;

	while (getline(fpl, s))
	{
		contador++;
	}

	cout << "Total de nomes: " << contador << "\n";
	//char op = _getch();
	intermitencia(400);

}
void fCasoAAcrescentaNoFim()
{

	system("cls");
	string s;
	string nome;
	string idade;

	cout << "Escreva nome no fim.\n";
	getline(cin, nome);

	cout << "Insira a idade.\n";
	getline(cin, idade);

	// funcao auxiliar para adicionar nova linha
	adicionaNomeIdade(nome, stoi(idade));

}
void fCasoPProcuraNome()
{

	system("cls");
	string s;
	string nome;
	fstream fpl("lista.txt");
	bool encontrou = false;


	cout << "Escreva o nome.\n";
	getline(cin, nome);

	while (getline(fpl, s)) // ciclo ler linhas
	{
		size_t found = s.find(nome); // se encontrou o nome
		// se nao encontrar a substring, retorna string::npos que e o valor mais alto possivel para size_t
		// https://cplusplus.com/reference/string/string/npos/
		if (found != string::npos)
		{
			encontrou = true;
			cout << s << endl;
		}
	}

	if (!encontrou)
	{
		cout << "Nome nao encontrado.\n";
	}

	//char op = _getch();
	intermitencia(400);

}
void fCasoDApagarFicheiro() {

	remove("lista.txt");
	cout << "Ficheiro lista.txt apagado!\n";
	intermitencia(100);

}
void fCasoNEscreveNomeInicioFicheiro()
{
	system("cls");
	string s;
	string nome;
	string idade; // o getline so aceita strings
	string fileString;

	cout << "Escreva o nome.\n";
	getline(cin, nome);

	cout << "Insira a idade.\n";
	getline(cin, idade);

	// funcao que adiciona nome e idade na posicao numero (x)
	// parametros numeroLinha, nome, idade
	adicionaLinha(1, nome, stoi(idade));
	intermitencia(100);

}
void fCaso1ContarOcorrenciaNomes()
{
	system("cls");
	string s;
	string nome;
	int contador = 0;

	cout << "Escreva o nome.\n";
	getline(cin, nome);

	fstream fpl("lista.txt");
	while (getline(fpl, s))
	{
		if (nome == getNome(s)) // getNome retorna a substing
		{
			contador++;
		}
	}

	if (contador > 0)
	{
		cout << "Ocorrencias do nome " << nome << " : " << contador << endl;
	}
	else
	{
		cout << "Sem ocorrencias para o nome: " << nome << " \n";
	}
	intermitencia(100);
}
void fCasoSSubstituirNomeFicheiro()
{
	system("cls");
	string s;
	string nome;
	string nomeSub;

	cout << "Escreva o nome a ser substituido.\n";
	getline(cin, nomeSub);

	cout << "Escreva o novo nome.\n";
	getline(cin, nome);

	// funcao auxiliar que troca os nomes mas mantem a idade
	trocaNome(nomeSub, nome);

	intermitencia(100);
}

void fCasoInserirLinha()
{
	string nLinha; // getline so aceita strings
	string nome;
	string idade;

	cout << "Escreva o numero da linha onde pretende inserir.\n";
	getline(cin, nLinha);

	cout << "Escreva o nome.\n";
	getline(cin, nome);

	cout << "Escreva a idade.\n";
	getline(cin, idade);

	// funcao auxiliar que adiciona linha na posicao numero (x)
	adicionaLinha(stoi(nLinha), nome, stoi(idade));

}

void fCasoApagaLinha()
{
	string nLinha; // getline so aceita strings

	cout << "Escreva o numero da linha onde pretende apagar.\n";
	getline(cin, nLinha);

	// funcao auxiliar que apagar linha na posicao numero (x)
	removeLinha(stoi(nLinha));
}

void fCasoIdade()
// inserir um nome, mostar a idade
{
	string nome;
	string s;
	bool encontrou = false;

	cout << "Escreva o nome.\n";
	getline(cin, nome);

	fstream fpl("lista.txt");

	while (getline(fpl, s))
	{
		if (nome == getNome(s)) // getNome retorna a substing
		{
			cout << getIdade(s) << endl;
			encontrou = true;
		}
	}

	if (!encontrou)
	{
		cout << "Nome nao existe!\n";
	}

	intermitencia(400);

}


// #####################################################

void fCaso7()
{

}

void fCaso8()
{

}

void fCaso9()
{

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
		case 'a': case 'A':fCasoAAcrescentaNoFim();				break;
		case 'l': case 'L':fCasoLListarNomes();					break;
		case 'n': case 'N':fCasoNEscreveNomeInicioFicheiro();	break;
		case 'z': case 'Z':fCasoZInicializaFicheiroCom16();		break;
		case 'c': case 'C':fCasoCContarNomes();					break;
		case 'd': case 'D':fCasoDApagarFicheiro();				break;
		case 's': case 'S':fCasoSSubstituirNomeFicheiro();		break;
		case 'p': case 'P':fCasoPProcuraNome();					break;
		case '1':fCaso1ContarOcorrenciaNomes();					break;
		case 'j': case'J':fCasoJAjuda();						break;
		case 'i': case'I':fCasoInserirLinha();					break;
		case 'v': case'V':fCasoIdade();     					break;
		case'7':fCaso7();			                    		break;
		case'8':fCaso8();					                    break;
		case'9':fCaso9();					                    break;
		case 'r': case'R':fCasoApagaLinha();					break;
		default: beep_erro(op);									break;
		}
	} while (op != 27);
	cout << "\tAté breve.\n\n\n"; intermitencia(50);
}