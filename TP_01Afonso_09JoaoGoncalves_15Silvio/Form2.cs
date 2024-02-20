using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_01Afonso_09JoaoGoncalves_15Silvio
{
    public partial class Form2 : Form
    {
        Categoria categoria = new Categoria();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnInserirCategoria_Click(object sender, EventArgs e)
        {
            categoria.InserirCategoria(txtCategoria.Text, dgvCategoria);
            categoria.preencherDgvCategoria(dgvCategoria);
        }

        private void btnRemoverCategoria_Click(object sender, EventArgs e)
        {
            string id = dgvCategoria.CurrentRow.Cells[0].Value.ToString();
            categoria.RemoverCategoria(id, dgvCategoria);
            categoria.preencherDgvCategoria(dgvCategoria);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            categoria.preencherDgvCategoria(dgvCategoria);
        }
    }
}
