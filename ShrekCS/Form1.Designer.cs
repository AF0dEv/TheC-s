namespace ShrekCS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtValorBase = new System.Windows.Forms.TextBox();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.chkDescontoEscalao = new System.Windows.Forms.CheckBox();
            this.chkAgravamento = new System.Windows.Forms.CheckBox();
            this.chkDescontoSocio = new System.Windows.Forms.CheckBox();
            this.rbtSim = new System.Windows.Forms.RadioButton();
            this.rbtNao = new System.Windows.Forms.RadioButton();
            this.cbxConcelhos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁLCULO DO VALOR DA AVENÇA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONCELHO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RESIDE NO DISTRITO ?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "VALOR BASE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ANO DE NASCIMENTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "NOME";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(183, 67);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(443, 356);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // txtValorBase
            // 
            this.txtValorBase.Location = new System.Drawing.Point(183, 93);
            this.txtValorBase.Name = "txtValorBase";
            this.txtValorBase.Size = new System.Drawing.Size(100, 20);
            this.txtValorBase.TabIndex = 9;
            this.txtValorBase.TextChanged += new System.EventHandler(this.txtValorBase_TextChanged);
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(183, 119);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtAnoNascimento.TabIndex = 10;
            this.txtAnoNascimento.TextChanged += new System.EventHandler(this.txtAnoNascimento_TextChanged);
            // 
            // chkDescontoEscalao
            // 
            this.chkDescontoEscalao.AutoSize = true;
            this.chkDescontoEscalao.Location = new System.Drawing.Point(183, 174);
            this.chkDescontoEscalao.Name = "chkDescontoEscalao";
            this.chkDescontoEscalao.Size = new System.Drawing.Size(163, 17);
            this.chkDescontoEscalao.TabIndex = 11;
            this.chkDescontoEscalao.Text = "Desconto de Escalão? (10%)";
            this.chkDescontoEscalao.UseVisualStyleBackColor = true;
            this.chkDescontoEscalao.CheckedChanged += new System.EventHandler(this.chkDescontoEscalao_CheckedChanged);
            // 
            // chkAgravamento
            // 
            this.chkAgravamento.AutoSize = true;
            this.chkAgravamento.Location = new System.Drawing.Point(183, 220);
            this.chkAgravamento.Name = "chkAgravamento";
            this.chkAgravamento.Size = new System.Drawing.Size(170, 17);
            this.chkAgravamento.TabIndex = 12;
            this.chkAgravamento.Text = "Tem Agravamento? (12 Euros)";
            this.chkAgravamento.UseVisualStyleBackColor = true;
            this.chkAgravamento.CheckedChanged += new System.EventHandler(this.chkAgravamento_CheckedChanged);
            // 
            // chkDescontoSocio
            // 
            this.chkDescontoSocio.AutoSize = true;
            this.chkDescontoSocio.Location = new System.Drawing.Point(183, 197);
            this.chkDescontoSocio.Name = "chkDescontoSocio";
            this.chkDescontoSocio.Size = new System.Drawing.Size(146, 17);
            this.chkDescontoSocio.TabIndex = 13;
            this.chkDescontoSocio.Text = "Desconto de Sócio? (5%)";
            this.chkDescontoSocio.UseVisualStyleBackColor = true;
            this.chkDescontoSocio.CheckedChanged += new System.EventHandler(this.chkDescontoSocio_CheckedChanged);
            // 
            // rbtSim
            // 
            this.rbtSim.AutoSize = true;
            this.rbtSim.Location = new System.Drawing.Point(183, 295);
            this.rbtSim.Name = "rbtSim";
            this.rbtSim.Size = new System.Drawing.Size(42, 17);
            this.rbtSim.TabIndex = 14;
            this.rbtSim.TabStop = true;
            this.rbtSim.Text = "Sim";
            this.rbtSim.UseVisualStyleBackColor = true;
            this.rbtSim.CheckedChanged += new System.EventHandler(this.rbtSim_CheckedChanged);
            // 
            // rbtNao
            // 
            this.rbtNao.AutoSize = true;
            this.rbtNao.Checked = true;
            this.rbtNao.Location = new System.Drawing.Point(238, 295);
            this.rbtNao.Name = "rbtNao";
            this.rbtNao.Size = new System.Drawing.Size(45, 17);
            this.rbtNao.TabIndex = 15;
            this.rbtNao.TabStop = true;
            this.rbtNao.Text = "Não";
            this.rbtNao.UseVisualStyleBackColor = true;
            // 
            // cbxConcelhos
            // 
            this.cbxConcelhos.FormattingEnabled = true;
            this.cbxConcelhos.Items.AddRange(new object[] {
            "Braga",
            "Amares",
            "Guimarães"});
            this.cbxConcelhos.Location = new System.Drawing.Point(443, 294);
            this.cbxConcelhos.Name = "cbxConcelhos";
            this.cbxConcelhos.Size = new System.Drawing.Size(121, 21);
            this.cbxConcelhos.TabIndex = 16;
            this.cbxConcelhos.SelectedIndexChanged += new System.EventHandler(this.cbxConcelhos_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "TOTAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 412);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxConcelhos);
            this.Controls.Add(this.rbtNao);
            this.Controls.Add(this.rbtSim);
            this.Controls.Add(this.chkDescontoSocio);
            this.Controls.Add(this.chkAgravamento);
            this.Controls.Add(this.chkDescontoEscalao);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.txtValorBase);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtValorBase;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.CheckBox chkDescontoEscalao;
        private System.Windows.Forms.CheckBox chkAgravamento;
        private System.Windows.Forms.CheckBox chkDescontoSocio;
        private System.Windows.Forms.RadioButton rbtSim;
        private System.Windows.Forms.RadioButton rbtNao;
        private System.Windows.Forms.ComboBox cbxConcelhos;
        private System.Windows.Forms.Label label7;
    }
}

