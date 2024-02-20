using System.Data;

namespace testeClassesTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listagem lista = new Listagem();
            lista.PreencherDgvCategoria(dgvCategoria);

            Categoria cat = new Categoria();
            for (int i = 7; i <=13; i++)
            {
            cat.RemoverCategoria(Convert.ToString(i));

            }
        }
    }
}
