using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShrekCS
{
    public partial class Form1 : Form
    {
        private string avenca;
        private int anoNascimento;
        private double total;
        private double descontoEscalao;
        private double descontoSocio;
        private int agravamento = 12;
        private double descontoDistrito;
        private double descontoAno;
        private double descontoConcelho;

        public Form1()
        {
            InitializeComponent();
        }

        void calcular()
        {
            anoNascimento = Convert.ToInt16(txtAnoNascimento.Text);
            avenca = txtValorBase.Text;
            total = Convert.ToInt16(avenca);

            try
            {
                if (txtValorBase.Text != "")
                {
                    if (anoNascimento >= 2000)
                    {
                        descontoAno = Convert.ToInt16(avenca) * 0.1;
                        total = total - descontoAno;
                        txtTotal.Text = total.ToString();
                    }
                    else
                    {
                        txtTotal.Text = total.ToString();
                    }


                    if (chkDescontoEscalao.Checked)
                    {
                        descontoEscalao = Convert.ToInt32(avenca) * 0.1;
                        total = total - descontoEscalao;
                        txtTotal.Text = total.ToString();
                    }
                    else
                    {
                        txtTotal.Text = total.ToString();
                    }

                    if (chkDescontoSocio.Checked)
                    {
                        descontoSocio = Convert.ToInt32(avenca) * 0.1;
                        total = total - descontoSocio;
                        txtTotal.Text = Convert.ToString(total);
                    }
                    else
                    {
                        txtTotal.Text = total.ToString();
                    }

                    if (chkAgravamento.Checked)
                    {
                        total = total + agravamento;
                        txtTotal.Text = total.ToString();
                    }
                    else
                    {
                        txtTotal.Text = total.ToString();
                    }

                    if (rbtSim.Checked)
                    {
                        descontoDistrito = Convert.ToInt16(avenca) * 0.01;
                        total = total - descontoDistrito;
                        txtTotal.Text = total.ToString();
                    }
                    else
                    {
                        txtTotal.Text = total.ToString();
                    }

                    if (cbxConcelhos.Text == "Amares")
                    {
                        descontoConcelho = Convert.ToInt16(avenca) * 0.2;
                        total = total - descontoConcelho;
                        txtTotal.Text = total.ToString();
                    }
                    else
                    {
                        txtTotal.Text = total.ToString();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        private void txtValorBase_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtValorBase.Text == "")
                {
                    txtTotal.Text = "0";
                }
                else
                {
                    avenca = txtValorBase.Text;
                    txtTotal.Text = avenca;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            
        }

        private void txtAnoNascimento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtValorBase.Text != "")
                {
                    calcular();
                }
                else
                {
                    MessageBox.Show("Insira Valor Base Valido");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            
        }

        private void chkDescontoEscalao_CheckedChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void chkDescontoSocio_CheckedChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void chkAgravamento_CheckedChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void rbtSim_CheckedChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void cbxConcelhos_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcular();
        }
    }
}
