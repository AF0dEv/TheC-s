// 27/7/2023
// Elaborado por Afonso Figueiredo
// Produção 2

#include <iostream>
using namespace std;

int main()
{
    int anoNascimento[10] = { 2011, 2010, 2013, 2012, 1999, 2002, 1996, 2014, 2014, 2015 };
    string freguesias[10] = { "Maximinos", "S.Vitor", "S.Vitor", "Aveleda", "S.Lazaro", "Areal", "Aveleda", "Maximinos", "Enguardas", "Maximinos" };
    string nomes[10] = { "Ana", "Rui", "Maria", "Sara", "Breno", "Joao", "Luis", "Ze", "Alex", "Mara" };
    char sexos[10] = { 'f', 'm', 'f', 'f', 'm', 'm', 'm', 'm', 'm', 'f' };
    int posicao = 0;

    char op;
    do
    {
        cout << "Insira Opcao!" << "\n" << "Opcao T ou t: Terminar Programa" << "\n"  << "Opcao L ou l: Listar Tudo" << "\n" << "Opcao 1: Contar os Rapazes" << "\n" << "Opcao 2: Quantas Raparigas sao de Maximinianos ?" << "\n" << "Opcao 3: Ha mais Rapazes ou Raparigas ?" << "\n" << "Opcao 4: Contar os Rapazes Maximianos entre 2000 e 2010" << "\n" << "Opcao 5: Ha Freguesias Repetidas ?" << "\n" << "Opcao 6: Qual a Freguesia com Mais Raparigas ?" << "\n" << "Opcao 7: Qual das 2 Freguesias tem mais rapazes ?" << "\n" << "Opcao 8: Listar Rapazes e Raparigas" << "\n" << "Opcao X: Nomes e Anos entre 2010 e 2015" << "\n" << "Opcao Y: Ano Nascimento Par ou Impar" << "\n" << "Opcao Z:" << "\n";
        cin >> op;

        if ( (op == 'T') || (op == 't') ) // Terminar Programa
        {
            op = '0';
        }

        if ( (op == 'L') || (op == 'l') ) // Listar Tudo
        {
            for (int i = 0; i <= 9; i++)
            {
                cout << nomes[i] << " " << anoNascimento[i] << " " << freguesias[i] << " " << sexos[i] << " " << "\n";
                cout << "-----------------------------------------------------------------------------------------------" << "\n";
            }
        }
        if (op == '1') // Contar os Rapazes
        {
            int contadorMachos = 0;
            cout << "Escolheu Opcao 1!" << "\n";
            for (int i = 0; i <= 9; i++)
            {
                if (sexos[i] == 'm')
                {
                    contadorMachos++;
                }
            }
            cout << contadorMachos << "\n";
            cout << "-----------------------------------------------------------------------------------------------" << "\n";
        }
        if (op == '2') // Quantas Raparigas sao de Maximinianos ?
        {
            int contadorFemeasMaximinos = 0;
            cout << "Escolheu Opcao 2!" << "\n";
            for (int i = 0; i <= 9; i++)
            {
                if ((freguesias[i] == "Maximinos") && (sexos[i] == 'f'))
                {
                    contadorFemeasMaximinos++;
                }
            }
            cout << contadorFemeasMaximinos << "\n";
            cout << "-----------------------------------------------------------------------------------------------" << "\n";
        }
        if (op == '3') // Ha mais Rapazes ou Raparigas ?
        {
            cout << "Escolheu Opcao 3!" << "\n";
            int contadorMachos = 0;
            for (int i = 0; i <= 9; i++)
            {
                if (sexos[i] == 'm')
                {
                    contadorMachos++;
                }
            }
            if (contadorMachos > 5)
            {
                cout << "Ha mais rapazes!" << "\n";
            }
            else
            {
                cout << "Ha mais raparigas!" << "\n";
            }
        }
        if (op == '4') // Contar os Rapazes Maximianos entre 2000 e 2010
        {
            int contadorMachosMaximinosEntre2000e2010 = 0;
            cout << "Escolheu Opcao 4!" << "\n";
            for (int i = 0; i <= 9; i++)
            {
                if ((freguesias[i] == "Maximinos") && (sexos[i] == 'm') && (anoNascimento[i] >= 2000) && (anoNascimento[i] <= 2010))
                {
                    contadorMachosMaximinosEntre2000e2010++;
                }
            }
            cout << contadorMachosMaximinosEntre2000e2010 << "\n";
        }
        if (op == '5') // Ha Freguesias Repetidas ?
        {
            bool haRepetidos = false;

            cout << "Escolheu Opcao 5" << "\n";

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0 + 1; j <= 9; j++)
                {
                    if (freguesias[i] == freguesias[j])
                    {
                        haRepetidos = true;
                    }
                }
            }
            cout << haRepetidos << "\n";
        }
        if (op == '7') // Qual das 2 Freguesias tem mais rapazes ?
        {
            string freguesia1;
            string freguesia2;
            int contadorMachos1 = 0;
            int contadorMachos2 = 0;

            cout << "Digite a 1 Freguesia" << "\n";
            cin >> freguesia1;
            cout << "Digite a 2 Freguesia" << "\n";
            cin >> freguesia2;


            for (int i = 0; i <= 9; i++)
            {
                if (freguesia1 == freguesias[i] && sexos[i] == 'm')
                {
                    contadorMachos1++;
                }
                if (freguesia2 == freguesias[i] && sexos[i] == 'm')
                {
                    contadorMachos2++;
                }
            }
            if (contadorMachos1 > contadorMachos2)
            {
                cout << "A Freguesia com Mais Rapazes e " << freguesia1 << "\n";
            }
            else
            {
                cout << "A Freguesia com Mais Rapazes e " << freguesia2 << "\n";
            }
        }
        if (op == '8') // Listar Rapazes e Raparigas
        {
            for (int i = 0; i <= 9; i++)
            {
                if (sexos[i] == 'm')
                {
                    cout << nomes[i] << " ";
                }
            }
            cout << "\n";
            for (int i = 0; i <= 9; i++)
            {
                if (sexos[i] == 'f')
                {
                    cout << nomes[i] << " ";
                }
            }
        }
        cout << "\n";

        //------------------------------------------------------------------------------------------------------------------------
        //27/07/2023
        //Elaborado por Afonso Figueiredo
        // Produção 2

        //Nomes e Anos entre 2010 e 2015

        if ( (op == 'x') || (op == 'X') )
        {
            for (int i = 2010; i <= 2015; i++)
            { 
                for (int j  = 0; j <= 9; j++)
                {
                    if ( (anoNascimento[j] >= i) && (anoNascimento[j] <= i) )
                    {
                        cout << i << ": " << nomes[j] << "\n";
                    }
                }
            }
        }


        // Ano Nascimento Par ou Impar

        string nome;

        if ( ( op == 'y') || (op == 'Y') )
        {
            cout << "Escreva o Nome \n";
            cin >> nome;

            for (int i = 0; i <= 9; i++)
            {
                if (nome == nomes[i])
                {
                    if (anoNascimento[i] % 2 == 0)
                    {
                        cout << "PAR \n";
                    }
                    else
                    {
                        cout << "IMPAR \n";
                    }
                }
                else
                {
                    cout << "Nome nao Encontrado \n";
                }
            }
        }
    } while (op != '0');
}

