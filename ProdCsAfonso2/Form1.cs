using cAgudo;
using System.Data;

namespace ProdCsAfonso2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DataBaseAccess bd = new DataBaseAccess();

        private void Form1_Load(object sender, EventArgs e)
        {
            // comecar com todos produtos na dgv de cima
            string sc = bd.ConnectionString();
            string sql = "SELECT * FROM Produtos";
            dgv1.DataSource = bd.BuscarDados(sc, sql);
        }
        // ter os produtos between
        public DataTable getProdBetween(string limInferior, string limSuperior)
        {
            DataTable dt = new DataTable();
            decimal dLimInferior = 0;
            decimal dLimSuperior = 0;
            bool result1 = false;
            bool result2 = false;
            result1 = decimal.TryParse(limInferior, out dLimInferior);
            result2 = decimal.TryParse(limSuperior, out dLimSuperior);

            if (result1 && result2)
            {
                string sc = bd.ConnectionString();
                // query formatada
                string sql = "SELECT NomeDoProduto, Fornecedores.NomeDaEmpresa, Categorias.NomeDaCategoria, PreçoUnitário FROM Produtos, Fornecedores, Categorias" +
                    " WHERE Fornecedores.CódigoDoFornecedor = Produtos.CódigoDoFornecedor AND Categorias.CódigoDaCategoria = Produtos.CódigoDaCategoria AND PreçoUnitário BETWEEN " + dLimInferior.ToString() + " AND " + dLimSuperior.ToString() + ";";
                MessageBox.Show(sql);
                dt = bd.BuscarDados(sc, sql);
                
            }
            else
            {
                // so pode ser ou inteiro ou separado por virgula
                MessageBox.Show("Insira Dados Validos");
            }
            return dt;
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            string limInferior = txtLimInf.Text;
            string limSuperior = txtLimSup.Text;
            dgv2.DataSource = getProdBetween(limInferior, limSuperior);
        }
    }
}
