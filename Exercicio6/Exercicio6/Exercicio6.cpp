// 2023-07-12
// Elaborado por Afonso Figueiredo
// Programa Introdução Variavel String

#include <iostream>
using namespace std;

int main()
{
    int idade1, idade2;
    string nome1, nome2;

    cout << "Pessoa 1, Introduza seu Nome\n";
    cin >> nome1;
    cout << "Pessoa 1, Introduza sua Idade\n";
    cin >> idade1;
    cout << "Pessoa 2, Introduza seu Nome\n";
    cin >> nome2;
    cout << "Pessoa 2, Introduza sua Idade\n";
    cin >> idade2;

    if (idade1 > idade2)
    {
        cout << nome1;
    }
    else
    {
        cout << nome2;
    }
}