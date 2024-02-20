// Introduçao Ficheiros
// 12/10/2023
// Elaborado por Afonso Figueiredo

#include <iostream>
#include <fstream>
#include <string>

#define _CRT_SECURE_NO_WARNINGS

using namespace std;

int main()
{
	// Cria Ficheiro e Escreve nele
	{
		ofstream fpw("Lista.txt");
		fpw << "Ana Carvalho\n";
		fpw << "Rui\n";
		fpw.close();
	}
	// Ler o Ficheiro
	
	string s;
	ifstream fpr("Lista.txt");
	getline(fpr, s);
	cout << s;
	getline(fpr, s);
	cout << s;
}