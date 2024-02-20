// 14/09/2023
// Afonso Figueiredo
// ArrayComoArgumento.

#include <time.h>
#include <iostream>
using namespace std;

struct Registo
{
    string nome;
    int idade = 0;
};

int GeraValor(int limite_inferior, int limite_superior)
{
    // implica a utilização de    #include<time.h>
    int n;

    n = limite_inferior + rand() % (limite_superior + 1 - limite_inferior);
    return n;
}

void PreencherArray(Registo Registos[])
{
    Registos[0].nome = "Ana";
    Registos[1].nome = "Rui";
    Registos[2].nome = "Abel";

    Registos[0].idade = GeraValor(18, 99);
    Registos[1].idade = GeraValor(18, 99);
    Registos[2].idade = GeraValor(18, 99);
}

void ListarArray(Registo Registos[])
{
    cout << "\t REGISTOS\n";
    for (int i = 0; i <= 2; i++)
    {
        cout << Registos[i].nome << " / " << Registos[i].idade << "\n";
    }
}

void InformarTamanhoStruct()
{
    cout << "Tamanho Tipo Struct: " << sizeof(Registo);
}


int main()
{
    srand(time (NULL) );
    Registo Registos[3];

    PreencherArray(Registos);
    ListarArray(Registos);
    InformarTamanhoStruct();
}