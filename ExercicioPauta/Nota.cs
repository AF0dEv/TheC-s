using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPauta
{
    public class Nota
    {
        int min;
        int max;
         public int criarNotas(int min, int max)
         {
            Random rnd = new Random();
            int nota = 0;
            nota = rnd.Next(min, max);
            return nota;
         }

    }

}

