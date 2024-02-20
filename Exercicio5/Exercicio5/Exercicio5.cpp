// 2023-07-11
// Elaborado por Afonso Figueiredo
// Programa Noção Maior

#include <iostream>
using namespace std;

int main()
{
 int maior, n1, n2, n3;
    cout << "Introduza um Numero\n";
        cin >> n1;
     maior = n1;
    cout << "Introduza um Numero\n";
        cin >> n2;
        if (n2 > maior)
        {
            maior = n2;
        }
    cout << "Introduza um Numero\n";
        cin >> n3;
        if (n3 > maior)
        {
            maior = n3;
        }
    cout << "O numero maior e: " << maior;
}