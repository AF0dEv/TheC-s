using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPauta
{
    public class Aluno
    {
        
        //public Aluno[] alunosArray = Aluno.GetAlunos();
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Freguesia { get; set; }
        public int Ano { get; set; }
        public string Sexo { get; set; }

        public static Aluno[] GetAlunos()
        {
            return new Aluno[]
            {
          new Aluno { Numero =1,  Nome = "Joao Martins", Freguesia = "Real",    Ano = 1996,  Sexo="M" },
          new Aluno { Numero =2,  Nome ="Maria Cunha", Freguesia="Maximinos", Ano = 1993,  Sexo="F"},
          new Aluno { Numero =3,  Nome ="Zé Maria", Freguesia="Lomar", Ano = 1998,  Sexo="M"},
          new Aluno { Numero =4,  Nome ="Maria Albertina", Freguesia="Maximinos", Ano = 1991,  Sexo="F"},
          new Aluno { Numero =5,  Nome ="Joaquina Felisberta", Freguesia="Real", Ano = 1983,  Sexo="F"},
          new Aluno { Numero =6,  Nome ="José Quim Alberto", Freguesia="Sao Vitor", Ano = 1989,  Sexo="M"},
          new Aluno { Numero =7,  Nome ="Joaquim Ferreira", Freguesia="Ferreiros", Ano = 1978,  Sexo="M"},
          new Aluno { Numero =8,  Nome ="Ana Rita Cunha", Freguesia="Amares", Ano = 2001,  Sexo="F"},
          new Aluno { Numero =9,  Nome ="Ana Maria", Freguesia="Lomar", Ano = 2003,  Sexo="F"},
          new Aluno { Numero =10, Nome ="Joao Silva", Freguesia="Maximinos", Ano = 1993,  Sexo="M"},
          new Aluno { Numero =11, Nome ="Mariana Feliz", Freguesia="Amares", Ano = 1996,  Sexo="F"},
          new Aluno { Numero =12, Nome ="André Maria", Freguesia="Real", Ano = 1982,  Sexo="M"},
          new Aluno { Numero =13, Nome ="André André", Freguesia="Vila Verde", Ano = 1991,  Sexo="M"},
          new Aluno { Numero =14, Nome ="Joao Cunha e Silva", Freguesia="Vila Verde", Ano = 1981,  Sexo="M"},
          new Aluno { Numero =15, Nome ="Joaquina Maria", Freguesia="Real", Ano = 1991,  Sexo="F"},
          new Aluno { Numero =16, Nome ="Carlota Sá", Freguesia="Amares", Ano = 1999,  Sexo="F"},
          new Aluno { Numero =17, Nome ="Carlos Silva", Freguesia="Ferreiros", Ano = 2003,  Sexo="M"},
          new Aluno { Numero =18, Nome ="Filipe Sá", Freguesia="Lomar", Ano = 1973,  Sexo="M"},
          new Aluno { Numero =19, Nome ="Joana André", Freguesia="Maximinos", Ano = 1996,  Sexo="F"},
          new Aluno { Numero =20, Nome ="Bruna Cunha", Freguesia="Real", Ano = 1998,  Sexo="F"}
            };
        }

       
    }
}
