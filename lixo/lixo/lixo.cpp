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


void arrastar(string frase,int i)
{
	string fr = frase;
	int p = i;

	while (fr[p] <= fr.length())
	{
		fr[p] = fr[p + 1];
	}
}

int existeCaracter(string frase, string caracter)
{
	string fr = frase;
	string c = caracter;
	int contador = 0;

	for (int i = 0; i <= fr.length() -1; i++)
	{
		if (c = fr[i] &&  )
		{

		}
	}
}

int main()
{
	
}