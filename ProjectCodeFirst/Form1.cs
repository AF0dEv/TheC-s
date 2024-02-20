namespace ProjectCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscarDados_Click(object sender, EventArgs e)
        {
            AppDbContext c = new AppDbContext();
            // var colecao = c.Nomes.ToList();
            // dgvBD.DataSource = colecao;
            dgvBD.DataSource = c.Nomes.ToList();

            Formando f = new Formando();

            f = c.Nomes.FirstOrDefault();
            txtNomes.Text = f.Nome;



        }

        private void btnContarRegistos_Click(object sender, EventArgs e)
        {
            
            AppDbContext c = new AppDbContext();
            txtContaRegistos.Text = c.Nomes.Count().ToString();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Formando f = new Formando();
            f.Nome = txtNome.Text;
            f.Freguesia = txtFreguesia.Text;
            //f.Id = Convert.ToInt32(txtId.Text);

            AppDbContext c = new AppDbContext();
            c.Add(f);
            c.SaveChanges();
        }
    }
}
