using System.Data;
using System.Globalization;

namespace ExercicioPauta
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        // VARIAVEL LOCAL tabela TIPO DataTable()
        DataTable tabela = new DataTable();

        // ================================================ CRIAR ESTRUTURA DGV ===================================================
        private void CriarColuna() // cria o header da tabela
        {
            tabela.Columns.Add("Nº", typeof(int));
            tabela.Columns.Add("Nome", typeof(string));
            tabela.Columns.Add("Freg", typeof(string));
            tabela.Columns.Add("Ano", typeof(int));
            tabela.Columns.Add("Sex", typeof(string));

            tabela.Columns.Add("POR", typeof(int));
            tabela.Columns.Add("ING", typeof(int));
            tabela.Columns.Add("FIL", typeof(int));
            tabela.Columns.Add("MAT", typeof(int));
            tabela.Columns.Add("FÍS", typeof(int));
            tabela.Columns.Add("QUÍ", typeof(int));
            tabela.Columns.Add("GEO", typeof(int));
            tabela.Columns.Add("HIS", typeof(int));
            tabela.Columns.Add("EF", typeof(int));
            tabela.Columns.Add("CID", typeof(int));

            tabela.Columns.Add("Média", typeof(double));
            tabela.Columns.Add("Neg", typeof(int));
        }

        // ==================================== ADICIONAR ALUNO TABELA ===============================================
        private void AdicionarAluno() // em vez de parametro vai usar a class Aluno

        {
            // Estanciar Array
            Aluno[] alunos = Aluno.GetAlunos();

            // Estanciar objeto tipo Notas
            Nota notas = new Nota();

            for (int i = 0; i < alunos.Length; i++)
            {
                tabela.Rows.Add(new Object[]
                {
                    alunos[i].Numero,
                    alunos[i].Nome,
                    alunos[i].Freguesia,
                    alunos[i].Ano,
                    alunos[i].Sexo,
                    notas.criarNotas(6, 20),
                    notas.criarNotas(6, 20),
                    notas.criarNotas(6, 20),
                    notas.criarNotas(6, 20),
                    notas.criarNotas(6, 20),
                    notas.criarNotas(6, 20),
                    notas.criarNotas(6, 20),
                    notas.criarNotas(6, 20),
                    notas.criarNotas(6, 20),
                    notas.criarNotas(6, 20)


                });
            }
        }

        private double CalcularMedia(int l) // calcula media para um aluno
        {
            double sum = 0;
            double media = 0;
            for (int i = 5; i < 14; i++) // colunas
            {
                //tabela.Rows[l].Field<int>(i)
                sum += Convert.ToDouble(tabela.Rows[l][i]);
            }

            media = sum / 10;
            return media;
        }

        private void MediaNotas() // calcula media para todas as linhas
        {
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                // coluna da media no index 14
                tabela.Rows[i][15] = CalcularMedia(i);
            }
        }

        private int ContaNegativas(int l) // conta negativas
        {
            int contador = 0;
            for (int i = 5; i < 15; i++) // colunas
            {
                int valor = (int)tabela.Rows[l][i];
                if (valor < 10)
                {
                    contador++;
                }
            }

            return contador;
        }

        private void Negativas()
        {
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                // coluna das negativas no index 15
                tabela.Rows[i][16] = ContaNegativas(i);
            }
        }

        // ================================ FORM LOAD ========================================
        private void Form1_Load_1(object sender, EventArgs e)
        {


            // criar as colunas da datagridview
            CriarColuna();
            AdicionarAluno();
            dgvNotas.DataSource = tabela;
            MediaNotas();
            Negativas();
            coresNotas();

        }

         public void coresNotas()
         {
             ;
            for (int i = 0; i < dgvNotas.Rows.Count - 1; i++)
            {
                for (int j = 5; j < 15; j++)
                {
                    if (Convert.ToInt32(dgvNotas.Rows[i].Cells[j].Value) == 6)
                    {
                        dgvNotas.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                    }
                    else if (Convert.ToInt32(dgvNotas.Rows[i].Cells[j].Value) == 7)
                    {
                        dgvNotas.Rows[i].Cells[j].Style.ForeColor = Color.DarkOrange;
                    }
                    else if (Convert.ToInt32(dgvNotas.Rows[i].Cells[j].Value) == 8)
                    {
                        dgvNotas.Rows[i].Cells[j].Style.ForeColor = Color.Coral;
                    }
                    else if (Convert.ToInt32(dgvNotas.Rows[i].Cells[j].Value) == 9)
                    {
                        dgvNotas.Rows[i].Cells[j].Style.ForeColor = Color.Firebrick;
                    }
                }
                if (Convert.ToInt32(dgvNotas.Rows[i].Cells[16].Value) >= 3)
                {
                    dgvNotas.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }

    }

}
