namespace TP_01Afonso_09JoaoGoncalves_15Silvio
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
            this.cbxFuncionario = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.numMinuto = new System.Windows.Forms.NumericUpDown();
            this.btnInserirProcesso = new System.Windows.Forms.Button();
            this.btnRemoverProcesso = new System.Windows.Forms.Button();
            this.dgvProcesso = new System.Windows.Forms.DataGridView();
            this.cbxListarFuncionario = new System.Windows.Forms.ComboBox();
            this.cbxListarMesF = new System.Windows.Forms.ComboBox();
            this.btnListarFuncionario = new System.Windows.Forms.Button();
            this.cbxListarCliente = new System.Windows.Forms.ComboBox();
            this.cbxListarMesC = new System.Windows.Forms.ComboBox();
            this.btnListarCliente = new System.Windows.Forms.Button();
            this.btnGerirFuncionario = new System.Windows.Forms.Button();
            this.btnGerirCliente = new System.Windows.Forms.Button();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblMesF = new System.Windows.Forms.Label();
            this.lblMesC = new System.Windows.Forms.Label();
            this.gbxListarPorF = new System.Windows.Forms.GroupBox();
            this.gbxListarCliente = new System.Windows.Forms.GroupBox();
            this.btnGerirCategoria = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnListAll = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotalM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMinuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesso)).BeginInit();
            this.gbxListarPorF.SuspendLayout();
            this.gbxListarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxFuncionario
            // 
            this.cbxFuncionario.FormattingEnabled = true;
            this.cbxFuncionario.Location = new System.Drawing.Point(50, 61);
            this.cbxFuncionario.Name = "cbxFuncionario";
            this.cbxFuncionario.Size = new System.Drawing.Size(261, 39);
            this.cbxFuncionario.TabIndex = 0;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(328, 62);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(261, 39);
            this.cbxCategoria.TabIndex = 1;
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(611, 61);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(261, 39);
            this.cbxCliente.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(893, 62);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(362, 38);
            this.txtDescricao.TabIndex = 3;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(1283, 62);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 38);
            this.dtpData.TabIndex = 4;
            // 
            // numMinuto
            // 
            this.numMinuto.Location = new System.Drawing.Point(1508, 62);
            this.numMinuto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMinuto.Name = "numMinuto";
            this.numMinuto.Size = new System.Drawing.Size(108, 38);
            this.numMinuto.TabIndex = 5;
            // 
            // btnInserirProcesso
            // 
            this.btnInserirProcesso.Location = new System.Drawing.Point(1665, 42);
            this.btnInserirProcesso.Name = "btnInserirProcesso";
            this.btnInserirProcesso.Size = new System.Drawing.Size(152, 58);
            this.btnInserirProcesso.TabIndex = 6;
            this.btnInserirProcesso.Text = "Inserir";
            this.btnInserirProcesso.UseVisualStyleBackColor = true;
            this.btnInserirProcesso.Click += new System.EventHandler(this.btnInserirProcesso_Click);
            // 
            // btnRemoverProcesso
            // 
            this.btnRemoverProcesso.Location = new System.Drawing.Point(1361, 694);
            this.btnRemoverProcesso.Name = "btnRemoverProcesso";
            this.btnRemoverProcesso.Size = new System.Drawing.Size(456, 58);
            this.btnRemoverProcesso.TabIndex = 7;
            this.btnRemoverProcesso.Text = "Remover registo selecionado";
            this.btnRemoverProcesso.UseVisualStyleBackColor = true;
            this.btnRemoverProcesso.Click += new System.EventHandler(this.btnRemoverProcesso_Click);
            // 
            // dgvProcesso
            // 
            this.dgvProcesso.AllowUserToAddRows = false;
            this.dgvProcesso.AllowUserToDeleteRows = false;
            this.dgvProcesso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcesso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesso.Location = new System.Drawing.Point(50, 130);
            this.dgvProcesso.Name = "dgvProcesso";
            this.dgvProcesso.RowHeadersWidth = 102;
            this.dgvProcesso.RowTemplate.Height = 40;
            this.dgvProcesso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcesso.Size = new System.Drawing.Size(1767, 461);
            this.dgvProcesso.TabIndex = 8;
            // 
            // cbxListarFuncionario
            // 
            this.cbxListarFuncionario.FormattingEnabled = true;
            this.cbxListarFuncionario.Location = new System.Drawing.Point(28, 70);
            this.cbxListarFuncionario.Name = "cbxListarFuncionario";
            this.cbxListarFuncionario.Size = new System.Drawing.Size(285, 39);
            this.cbxListarFuncionario.TabIndex = 9;
            // 
            // cbxListarMesF
            // 
            this.cbxListarMesF.FormattingEnabled = true;
            this.cbxListarMesF.Location = new System.Drawing.Point(28, 215);
            this.cbxListarMesF.Name = "cbxListarMesF";
            this.cbxListarMesF.Size = new System.Drawing.Size(285, 39);
            this.cbxListarMesF.TabIndex = 10;
            // 
            // btnListarFuncionario
            // 
            this.btnListarFuncionario.Location = new System.Drawing.Point(28, 296);
            this.btnListarFuncionario.Name = "btnListarFuncionario";
            this.btnListarFuncionario.Size = new System.Drawing.Size(285, 58);
            this.btnListarFuncionario.TabIndex = 11;
            this.btnListarFuncionario.Text = "Listar funcionário";
            this.btnListarFuncionario.UseVisualStyleBackColor = true;
            this.btnListarFuncionario.Click += new System.EventHandler(this.btnListarFuncionario_Click);
            // 
            // cbxListarCliente
            // 
            this.cbxListarCliente.FormattingEnabled = true;
            this.cbxListarCliente.Location = new System.Drawing.Point(34, 70);
            this.cbxListarCliente.Name = "cbxListarCliente";
            this.cbxListarCliente.Size = new System.Drawing.Size(282, 39);
            this.cbxListarCliente.TabIndex = 12;
            // 
            // cbxListarMesC
            // 
            this.cbxListarMesC.FormattingEnabled = true;
            this.cbxListarMesC.Location = new System.Drawing.Point(34, 215);
            this.cbxListarMesC.Name = "cbxListarMesC";
            this.cbxListarMesC.Size = new System.Drawing.Size(282, 39);
            this.cbxListarMesC.TabIndex = 13;
            // 
            // btnListarCliente
            // 
            this.btnListarCliente.Location = new System.Drawing.Point(34, 296);
            this.btnListarCliente.Name = "btnListarCliente";
            this.btnListarCliente.Size = new System.Drawing.Size(285, 58);
            this.btnListarCliente.TabIndex = 14;
            this.btnListarCliente.Text = "Listar Cliente";
            this.btnListarCliente.UseVisualStyleBackColor = true;
            this.btnListarCliente.Click += new System.EventHandler(this.btnListarCliente_Click);
            // 
            // btnGerirFuncionario
            // 
            this.btnGerirFuncionario.Location = new System.Drawing.Point(868, 794);
            this.btnGerirFuncionario.Name = "btnGerirFuncionario";
            this.btnGerirFuncionario.Size = new System.Drawing.Size(293, 161);
            this.btnGerirFuncionario.TabIndex = 15;
            this.btnGerirFuncionario.Text = "Gestão de funcionários";
            this.btnGerirFuncionario.UseVisualStyleBackColor = true;
            this.btnGerirFuncionario.Click += new System.EventHandler(this.btnGerirFuncionario_Click);
            // 
            // btnGerirCliente
            // 
            this.btnGerirCliente.Location = new System.Drawing.Point(1524, 794);
            this.btnGerirCliente.Name = "btnGerirCliente";
            this.btnGerirCliente.Size = new System.Drawing.Size(293, 161);
            this.btnGerirCliente.TabIndex = 16;
            this.btnGerirCliente.Text = "Gestão de clientes";
            this.btnGerirCliente.UseVisualStyleBackColor = true;
            this.btnGerirCliente.Click += new System.EventHandler(this.btnGerirCliente_Click);
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(44, 23);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(164, 32);
            this.lblFuncionario.TabIndex = 17;
            this.lblFuncionario.Text = "Funcionário";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(322, 23);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(138, 32);
            this.lblCategoria.TabIndex = 18;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(605, 23);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(104, 32);
            this.lblCliente.TabIndex = 19;
            this.lblCliente.Text = "Cliente";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(887, 23);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(140, 32);
            this.lblDescricao.TabIndex = 20;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(1277, 23);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(74, 32);
            this.lblData.TabIndex = 21;
            this.lblData.Text = "Data";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(1502, 23);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(114, 32);
            this.lblMinutos.TabIndex = 22;
            this.lblMinutos.Text = "Minutos";
            // 
            // lblMesF
            // 
            this.lblMesF.AutoSize = true;
            this.lblMesF.Location = new System.Drawing.Point(37, 170);
            this.lblMesF.Name = "lblMesF";
            this.lblMesF.Size = new System.Drawing.Size(67, 32);
            this.lblMesF.TabIndex = 24;
            this.lblMesF.Text = "Mês";
            // 
            // lblMesC
            // 
            this.lblMesC.AutoSize = true;
            this.lblMesC.Location = new System.Drawing.Point(51, 170);
            this.lblMesC.Name = "lblMesC";
            this.lblMesC.Size = new System.Drawing.Size(67, 32);
            this.lblMesC.TabIndex = 26;
            this.lblMesC.Text = "Mês";
            // 
            // gbxListarPorF
            // 
            this.gbxListarPorF.Controls.Add(this.cbxListarFuncionario);
            this.gbxListarPorF.Controls.Add(this.lblMesF);
            this.gbxListarPorF.Controls.Add(this.cbxListarMesF);
            this.gbxListarPorF.Controls.Add(this.btnListarFuncionario);
            this.gbxListarPorF.Location = new System.Drawing.Point(50, 624);
            this.gbxListarPorF.Name = "gbxListarPorF";
            this.gbxListarPorF.Size = new System.Drawing.Size(350, 394);
            this.gbxListarPorF.TabIndex = 27;
            this.gbxListarPorF.TabStop = false;
            this.gbxListarPorF.Text = "Listar Por Funcionário";
            // 
            // gbxListarCliente
            // 
            this.gbxListarCliente.Controls.Add(this.cbxListarCliente);
            this.gbxListarCliente.Controls.Add(this.cbxListarMesC);
            this.gbxListarCliente.Controls.Add(this.lblMesC);
            this.gbxListarCliente.Controls.Add(this.btnListarCliente);
            this.gbxListarCliente.Location = new System.Drawing.Point(443, 624);
            this.gbxListarCliente.Name = "gbxListarCliente";
            this.gbxListarCliente.Size = new System.Drawing.Size(350, 394);
            this.gbxListarCliente.TabIndex = 28;
            this.gbxListarCliente.TabStop = false;
            this.gbxListarCliente.Text = "Listar por Cliente";
            // 
            // btnGerirCategoria
            // 
            this.btnGerirCategoria.Location = new System.Drawing.Point(1199, 794);
            this.btnGerirCategoria.Name = "btnGerirCategoria";
            this.btnGerirCategoria.Size = new System.Drawing.Size(293, 161);
            this.btnGerirCategoria.TabIndex = 29;
            this.btnGerirCategoria.Text = "Gestão de categorias";
            this.btnGerirCategoria.UseVisualStyleBackColor = true;
            this.btnGerirCategoria.Click += new System.EventHandler(this.btnGerirCategoria_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(878, 624);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 32);
            this.lblTotal.TabIndex = 30;
            // 
            // btnListAll
            // 
            this.btnListAll.Location = new System.Drawing.Point(941, 694);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(297, 58);
            this.btnListAll.TabIndex = 31;
            this.btnListAll.Text = "Listar Tudo";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(1665, 597);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(152, 38);
            this.txtTotal.TabIndex = 32;
            this.txtTotal.Visible = false;
            // 
            // lblTotalM
            // 
            this.lblTotalM.AutoSize = true;
            this.lblTotalM.Location = new System.Drawing.Point(1543, 603);
            this.lblTotalM.Name = "lblTotalM";
            this.lblTotalM.Size = new System.Drawing.Size(78, 32);
            this.lblTotalM.TabIndex = 33;
            this.lblTotalM.Text = "Total";
            this.lblTotalM.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1968, 1047);
            this.Controls.Add(this.lblTotalM);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnGerirCategoria);
            this.Controls.Add(this.gbxListarCliente);
            this.Controls.Add(this.gbxListarPorF);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.btnGerirCliente);
            this.Controls.Add(this.btnGerirFuncionario);
            this.Controls.Add(this.dgvProcesso);
            this.Controls.Add(this.btnRemoverProcesso);
            this.Controls.Add(this.btnInserirProcesso);
            this.Controls.Add(this.numMinuto);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxFuncionario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMinuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesso)).EndInit();
            this.gbxListarPorF.ResumeLayout(false);
            this.gbxListarPorF.PerformLayout();
            this.gbxListarCliente.ResumeLayout(false);
            this.gbxListarCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFuncionario;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.NumericUpDown numMinuto;
        private System.Windows.Forms.Button btnInserirProcesso;
        private System.Windows.Forms.Button btnRemoverProcesso;
        private System.Windows.Forms.DataGridView dgvProcesso;
        private System.Windows.Forms.ComboBox cbxListarFuncionario;
        private System.Windows.Forms.ComboBox cbxListarMesF;
        private System.Windows.Forms.Button btnListarFuncionario;
        private System.Windows.Forms.ComboBox cbxListarCliente;
        private System.Windows.Forms.ComboBox cbxListarMesC;
        private System.Windows.Forms.Button btnListarCliente;
        private System.Windows.Forms.Button btnGerirFuncionario;
        private System.Windows.Forms.Button btnGerirCliente;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblMesF;
        private System.Windows.Forms.Label lblMesC;
        private System.Windows.Forms.GroupBox gbxListarPorF;
        private System.Windows.Forms.GroupBox gbxListarCliente;
        private System.Windows.Forms.Button btnGerirCategoria;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotalM;
    }
}

