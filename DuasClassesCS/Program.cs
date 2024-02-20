using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuasClassesCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ESTANCIAR VARIÁVEIS
            Calculo obj = new Calculo();
            int x, y, resultadoSoma, resultadoMultiplicar;

            // LER NUMEROS
            Console.WriteLine("Insira o 1º Número a Calcular: ");
            x = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("\nInsira o 2º Número a Calcular: ");
            y = Convert.ToInt16(Console.ReadLine());
            
            // CHAMAR CLASSE E CALCULAR NUMEROS
            resultadoSoma = obj.somar(x, y);
            resultadoMultiplicar = obj.multiplicar(x, y);
            
            // APRESENTAR RESULTADO
            Console.WriteLine("\nA soma é: " + resultadoSoma);
            Console.WriteLine("\nA multiplicação é: " + resultadoMultiplicar + "\n");
        }
    }
}
