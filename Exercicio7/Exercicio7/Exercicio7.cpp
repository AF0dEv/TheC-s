// 2023-07-12
// Elaborado por Afonso Figueiredo
// Programa Noção de Array com Ciclos

#include <iostream>
using namespace std;

int main()
{
    int numeros[3];
	for ( int i = 0; i <= 2; i++)
	{
		cin >> numeros[i];
	}

// Calcular a Soma dos valores da Array

	int resultado;
	resultado = numeros[0] + numeros[1] + numeros[2];
	cout << resultado << "\n";

// Calcular a Média dos valores do Array

	int media;
	media = resultado / 3;
	cout << media << "\n";

// Contar os Positivos nos valores da Array
}
