// 17/07/20232
// Elaborado por Afonso Figueiredo
// Programa Noção Arrays

#include <iostream>
using namespace std;

int main()
{
// Declaração e Inicialização da Array
    int numeros[10] = { 1, 0, -5, -8, 44, 11, 6, 18, 19, 101 };

	for ( int i = 0; i <= 9; i++)
	{
		cout << numeros[i] << " ";
	}

//----------------------------------------------------------------------------------
// Calcular a Soma de todos os elementos
	int soma = 0;

	for (int i = 0; i <= 9; i++)
	{
		soma = soma + numeros[i];
	}
	cout << "\n" << soma << "\n";

//------------------------------------------------------------------------------------
// Contar os Positivos
	int ContadorPositivos = 0;

	for (int i = 0; i <= 9; i++)
	{
		if (numeros[i] > 0)
		{
			ContadorPositivos++;
		} 
	}
	cout << ContadorPositivos << "\n";

//----------------------------------------------------------------------------------------
// Quantos Numeros entre 0 e 100

	int ContadorNumeros0a100 = 0;

		for (int i = 0; i <= 9; i++)
		{
			if ( (numeros[i] >= 0) && (numeros[i] <= 100) )
			{
				ContadorNumeros0a100++;
			}
		}
		cout << ContadorNumeros0a100 << "\n";

//--------------------------------------------------------------------------------------------
// Contar os Pares
		
		int ContadorDePares = 0;
		for (int i = 0; i <= 9; i++)
		{
			if ( (numeros[i] % 2 == 0) && numeros[i] != 0)
			{
				ContadorDePares++;

			}
		}
		cout << ContadorDePares << "\n";
//-----------------------------------------------------------------------------------------------
// Contar os Impares Negativos

		int ContadorImparNegativo = 0;
		for (int i = 0; i <= 9; i++)
		{
			if ( (numeros[i] % 2 != 0) && (numeros[i] < 0) )
			{
				ContadorImparNegativo++;
			}
		}
		cout << ContadorImparNegativo << "\n";

//----------------------------------------------------------------------------------------------
// Contar os Primos (EXTRA) --> AINDA NÃO CORRIGIDO NEM ACABADO

		int ContadorNumerosPrimos = 0;
		for (int i = 0; i <=0 ; i++)
		{
			if ( (numeros[i] % 2 != 0) && (numeros[i] % 3 != 0) && numeros[i] ) )
			{
				ContadorNumerosPrimos++;
			}

		}
		cout << ContadorNumerosPrimos << "\n";
}