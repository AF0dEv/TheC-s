// 01/09/2023
// Elaborado por Afonso Figueiredo
// Verificar se Nº é Par ou Impar com Funçoes

#include <iostream>
using namespace std;

bool EPar(int n)
{
	if ( (n % 2) == 0 )
	{
		return true;
	}
	else
	{
		return false;
	}
}

bool EMultiplo(int n)
{
	if ((n % 10) == 0)
	{
		return true;
	}
	else
	{
		return false;
	}
}
int main()
{
	int n;
	do
	{
		cout << "Escreva Numero\n";
		cin >> n;

	} while (n < 0 || n > 100);

		if (EPar(n) == true)
		{
			cout << "E Par\n";
		}
		else
		{
			cout << "E Impar\n";
		}

		if ( EMultiplo(n) == true) 
		{
			cout << "E Multiplo\n";
		}
		else
		{
			cout << "Nao e Multiplo\n";
		}

	
	
    
}
