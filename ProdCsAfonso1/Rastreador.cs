using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdCsAfonso1
{
    internal class Rastreador
    {
        //DataGridView dgv = new DataGridView();
        

        public Rastreador() { }

        // Saber Quantidade Produtos
        public int getQtdProdutos(DataGridView dgv)
        {
            return dgv.Rows.Count - 1;
        }
        // Saber Celulas Vazias
        public int getQtdCelulasVazias(DataGridView dgv)
        {
            int counter = 0;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                for (int j = 0; j < dgv.Rows.Count - 1; j++)
                {
                    if (dgv.Rows[j].Cells.ToString() == "")
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
        // ter o mais caro
        public string getCatForn(DataGridView dgv)
        {
            string? clienteMaisCaro = null;
            decimal valorMaisCaro = 0;
            valorMaisCaro = Convert.ToDecimal(dgv.Rows[1].Cells[4].Value);
            for (int i = 2; i < dgv.Rows.Count; i++)
            {
                
                if (valorMaisCaro < Convert.ToDecimal(dgv.Rows[i].Cells[4].Value))
                {
                    valorMaisCaro = Convert.ToDecimal(dgv.Rows[i].Cells[4].Value);
                    clienteMaisCaro = dgv.Rows[i].Cells[1].Value.ToString();
                }
            }

            return clienteMaisCaro;

        }
    }
}
