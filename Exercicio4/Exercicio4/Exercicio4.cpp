// 2023-07-11
// Elaborado por Afonso Figueiredo
// Programa Noçao de Contador

#include <iostream>
using namespace std;
int main()
{
   int contador, n1, n2, n3;
   contador = 0;
    cout << "Introduza um Numero\n";
        cin >> n1;
    cout << "Introduza Outro Numero\n";
        cin >> n2;
    cout << "Introduza o ultimo Numero\n";
        cin >> n3;
        if (n1 > 0)
            {
            contador = contador + 1;
            }
        if (n2 > 0)
            {
            contador = contador + 1;
            }
        if (n3 > 0)
            {
            contador = contador + 1;
            }
    cout << contador;
}


