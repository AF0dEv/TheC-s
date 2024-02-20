// 26/07/2023
// Elaborado por Afonso Figueiredo
// Introdução a Matrizes

#include <iostream>
using namespace std;

int main()
{
    // Iniciar a Matriz
    int M[3][3] = { 1, 2, 33,
                    0, 0, 6,
                    7, 0 , 44 };
    M[2][2] = 777;

    for (size_t i = 0; i <=2 ; i++)
    {
        for (size_t j = 0; j <=2 ; j++)
        {
            cout << M[i][j] << "\n";
        }
    }
}