// 12/09/2023
// Afonso Figueiredo
// Introdução Struct

#include <iostream>
using namespace std;

struct ficha
{   // Declara novo tipo de Dados

    string nome;    // declarar cada membro...
    string freguesia;
    int ano;
    char sexo;
    string morada;
};

int main()
{
    ficha F[20];    // Declara F do tipo ficha

    // ficha F = { "Ana", "Braga", 2000, 'F', "Rua das Flores" };

    F[15].nome = { "Ana" };
    F[15].morada = { "Lomar" };
 
    cout << F[15].nome << "\n";
    cout << F[15].morada << "\n";
    cout << F[16].nome << "\n";
    cout << F; // Imprime endereço de memoria onde esta guardado o Array F
    /*cout << F[15];*/
}