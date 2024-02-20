// 12/09/2023
// 

#include <iostream>
using namespace std;

int main()
{
    int x;
    float f;
    double d;
    char c;
    long l;
    bool b;
    string s;
    int A[4];

    // Saber tamanho em Bytes alocado na memoria

    cout << "int: " << sizeof(x) << "\n";
    cout << "float: " << sizeof(f) << "\n";
    cout << "double: " << sizeof(d) << "\n";
    cout << "char: " << sizeof(c) << "\n";
    cout << "long: " << sizeof(l) << "\n";
    cout << "bool: " << sizeof(b) << "\n";
    cout << "string: " << sizeof(s) << "\n";
    cout << "int A: " << sizeof(A) << "\n";
}


