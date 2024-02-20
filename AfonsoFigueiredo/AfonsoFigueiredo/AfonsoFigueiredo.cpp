// 17/07/2023
// Elaborado Por Afonso Figueiredo
// Produção 1

#include <iostream>
using namespace std;

int main()
{
 // ler 5 numeros e contar os zeros
    int n1, n2, n3, n4, n5, contador, resultado, menor, maiorMil;
    contador = 0;
    cout << "Introduza o seu Numero\n";
    cin >> n1;
    cout << "Introduza o seu Numero\n";
    cin >> n2;
    cout << "Introduza o seu Numero\n";
    cin >> n3;
    cout << "Introduza o seu Numero\n";
    cin >> n4;
    cout << "Introduza o seu Numero\n";
    cin >> n5;
    if (n1 == 0)
    {
        contador = contador + 1;
    }
    if (n2 == 0)
    {
        contador = contador + 1;
    }
    if (n3 == 0)
    {
        contador = contador + 1;
    }
    if (n4 == 0)
    {
        contador = contador + 1;
    }
    if (n5 == 0)
    {
        contador = contador + 1;
    }
    cout << "Tem " << contador << " zeros entre os 5 numeros" << "\n";

// Calcular a soma dos 5 numeros
    resultado = n1 + n2 + n3 + n4 + n5;
    cout << "A soma dos numeros e " << resultado << "\n";

// Encontrar o menor dos 5 numeros

    menor = n1;
    if (n2 < menor)
    {
        menor = n2;
    }
    if (n3 < menor)
    {
        menor = n3;
    }
    if (n4 < menor)
    {
        menor = n4;
    }
    if (n5 < menor)
    {
        menor = n5;
    }
    cout << "O numero menor e " << menor << "\n";

// Escrever se há ou não numeros Maiores que Mil

    maiorMil = 0;
    if (n1 > 1000)
    {
        maiorMil = maiorMil + 1;
    }
    if (n2 > 1000)
    {
        maiorMil = maiorMil + 1;
    }
    if (n3 > 1000)
    {
        maiorMil = maiorMil + 1;
    }
    if (n4 > 1000)
    {
        maiorMil = maiorMil + 1;
    }
    if (n5 > 1000)
    {
        maiorMil = maiorMil + 1;
    }
    if (maiorMil > 0)
    {
        cout << "Sim, ha!\n";
    }
    else
    {
        cout << "Nao, nao ha!\n";
    }

// Escrever Elaborado por...

    cout << "Elaborado por Afonso Figueiredo!";
}