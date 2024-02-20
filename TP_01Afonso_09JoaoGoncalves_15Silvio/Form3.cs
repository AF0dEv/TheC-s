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
    public partial class Form3 : Form
    {
        Funcionario funcionario = new Funcionario();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnInserirFuncionario_Click(object sender, EventArgs e)
        {
            funcionario.InserirFuncionario(txtFuncionario.Text, dgvFuncionario);
            funcionario.preencherDgvFuncionario(dgvFuncionario);
        }

        private void btnRemoverFuncionario_Click(object sender, EventArgs e)
        {
            funcionario.RemoverFuncionario(dgvFuncionario.CurrentRow.Cells[0].Value.ToString(), dgvFuncionario);
            funcionario.preencherDgvFuncionario(dgvFuncionario);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            funcionario.preencherDgvFuncionario(dgvFuncionario);
        }
    }
}
