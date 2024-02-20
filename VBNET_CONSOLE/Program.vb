Imports System

Module Program
    Sub Main()

        Dim i, soma As Integer
        soma = 0
        Dim N(6) As Integer 'TIPIFICAÇÃO E DIMENSIONAMENTO DO ARRAY

        For i = 1 To 5 'CICLO FOR
            N(i) = Console.ReadLine()
        Next
        i = 1
        While (i <= 5) 'CICLO WHILE  
            soma = soma + N(i)
            i = i + 1

        End While
        Console.WriteLine("Os números introduzidos foram: ")
        i = 1
        Do While i <= 5 'CILO DO WHILE
            Console.WriteLine(N(i))
            i = i + 1
        Loop

        Dim media As Double
        media = soma / 5
        Console.WriteLine("A media e igual a {0]", media)
    End Sub
End Module
