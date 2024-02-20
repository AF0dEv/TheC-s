using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace TP_01Afonso_09JoaoGoncalves_15Silvio
{
    public partial class Form1 : Form
    {
        Listagem listagem = new Listagem();
        Processo processo = new Processo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //preenchimento de combobox da insercao
            listagem.PreencherComboBoxes(cbxCategoria, "Categorias", "categoriaID", "designacao");
            listagem.PreencherComboBoxes(cbxCliente, "Clientes", "clienteID", "nomeCliente");
            listagem.PreencherComboBoxes(cbxFuncionario, "Funcionarios", "funcionarioID", "nomeFuncionario");

            //preenche datagridview
            listagem.PreencherDgvProcesso(dgvProcesso);

            //preenchimento de cbx das filtragens
            listagem.PreencherComboBoxes(cbxListarFuncionario, "Funcionarios", "funcionarioID", "nomeFuncionario");
            listagem.PreencherComboBoxes(cbxListarCliente, "Clientes", "clienteID", "nomeCliente");
            listagem.listarMes(cbxListarMesF);
            listagem.listarMes(cbxListarMesC);


        }

        private void btnGerirCategoria_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnGerirFuncionario_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btnGerirCliente_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void btnInserirProcesso_Click(object sender, EventArgs e)
        {
            processo.inserirProcesso(cbxFuncionario.SelectedValue.ToString(),cbxCliente.SelectedValue.ToString(), cbxCategoria.SelectedValue.ToString(), txtDescricao.Text,dtpData.Value.ToString("yyyy-MM-dd"),((int)numMinuto.Value));
            listagem.PreencherDgvProcesso(dgvProcesso);
        }

        private void btnRemoverProcesso_Click(object sender, EventArgs e)
        {
            processo.removerProcesso(dgvProcesso.CurrentRow.Cells[0].Value.ToString());
            listagem.PreencherDgvProcesso(dgvProcesso);
        }

        private void btnListarFuncionario_Click(object sender, EventArgs e)
        {
            listagem.ListarFuncionario(cbxListarFuncionario.SelectedValue.ToString(), cbxListarMesF.SelectedValue.ToString(), dgvProcesso);
            lblTotalM.Show();
            txtTotal.Show();
            txtTotal.Text = listagem.CalculaTotalFuncionario(cbxListarFuncionario.SelectedValue.ToString(), cbxListarMesF.SelectedValue.ToString());
        }

        private void btnListarCliente_Click(object sender, EventArgs e)
        {
            listagem.ListarClientes(cbxListarCliente.SelectedValue.ToString(), cbxListarMesC.SelectedValue.ToString(), dgvProcesso);
            lblTotalM.Show();
            txtTotal.Show();
            txtTotal.Text = listagem.CalculaTotalCliente(cbxListarCliente.SelectedValue.ToString(), cbxListarMesC.SelectedValue.ToString());
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            listagem.PreencherDgvProcesso(dgvProcesso);
            lblTotalM.Hide();
            txtTotal.Text = "";
            txtTotal.Hide();
        }
    }
}
