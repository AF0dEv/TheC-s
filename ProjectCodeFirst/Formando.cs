using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCodeFirst
{
    internal class Formando
    {
        public Formando()
        {
            
        }
        private int id;
        private string nome;
        private string freguesia;

        public int Id 
        {  
            get { return this.id; } 
            set { this.id = value;} 
        }

        public string? Nome 
        { 
            get { return this.nome; } 
            set { this.nome = value; } 
        }

        public string? Freguesia
        {
            get { return this.freguesia;}
            set { this.freguesia = value; }
        }
    }
}
