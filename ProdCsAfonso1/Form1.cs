using cAgudo;

namespace ProdCsAfonso1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public DataBaseAccess bd = new DataBaseAccess();
        public string sc;
        public string sql;

        private void Form1_Load(object sender, EventArgs e)
        {
            sc = bd.ConnectionString();
            sql = "SELECT * FROM Produtos";
            dgvProdutos.DataSource = bd.BuscarDados(sc, sql);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Rastreador rs = new Rastreador();
            int qtdProdutos = rs.getQtdProdutos(dgvProdutos);
            lstRespostas.Items.Add("Qtd Produtos: " + qtdProdutos.ToString());

            int qtdCelulasVazias = rs.getQtdCelulasVazias(dgvProdutos);
            lstRespostas.Items.Add("Qtd Celulas Vazias: " + qtdCelulasVazias.ToString());

            string clienteMaisCaro = rs.getCatForn(dgvProdutos);
            lstRespostas.Items.Add("Produto Mais Caro e: " + clienteMaisCaro);

        }


    }
}
