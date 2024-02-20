using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_01Afonso_09JoaoGoncalves_15Silvio
{
    public partial class Form4 : Form
    {
        Cliente cliente = new Cliente();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cliente.preencherClientes(dgvCliente);
        }

        private void btnInserirCliente_Click(object sender, EventArgs e)
        {
            cliente.inserirCliente(txtCliente.Text, dgvCliente);
            cliente.preencherClientes(dgvCliente);
        }

        private void btnRemoverCliente_Click(object sender, EventArgs e)
        {
            cliente.removerCliente(dgvCliente.CurrentRow.Cells[0].Value.ToString(), dgvCliente);
            cliente.preencherClientes(dgvCliente);
        }
    }
}
