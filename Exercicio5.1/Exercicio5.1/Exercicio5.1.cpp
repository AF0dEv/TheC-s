// 2023-07-11
// Elaborado por Afonso Figueiredo
// Programa Noçao Maior c/ Ciclo

#include <iostream>
using namespace std;

int main()
{
	int n, maior;

    cout << "Introduza um Numero\n";

    cin >> n;

	maior = n;

	for (int i = 1; i < 10; i++)
	 {
		cout << "Introduza um Numero\n";
		cin >> n;
			 if (n > maior)
			 {
				 maior = n;
			 }
	 }
	cout << maior;
}