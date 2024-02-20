namespace ProjectCodeFirst
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvBD = new DataGridView();
            btnBuscarDados = new Button();
            txtNomes = new TextBox();
            btnContarRegistos = new Button();
            txtContaRegistos = new TextBox();
            label1 = new Label();
            txtNome = new TextBox();
            txtFreguesia = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnInserir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBD).BeginInit();
            SuspendLayout();
            // 
            // dgvBD
            // 
            dgvBD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBD.Location = new Point(12, 12);
            dgvBD.Name = "dgvBD";
            dgvBD.Size = new Size(439, 426);
            dgvBD.TabIndex = 0;
            // 
            // btnBuscarDados
            // 
            btnBuscarDados.Location = new Point(457, 12);
            btnBuscarDados.Name = "btnBuscarDados";
            btnBuscarDados.Size = new Size(331, 23);
            btnBuscarDados.TabIndex = 1;
            btnBuscarDados.Text = "Apresentar Dados";
            btnBuscarDados.UseVisualStyleBackColor = true;
            btnBuscarDados.Click += btnBuscarDados_Click;
            // 
            // txtNomes
            // 
            txtNomes.Location = new Point(688, 78);
            txtNomes.Name = "txtNomes";
            txtNomes.Size = new Size(100, 23);
            txtNomes.TabIndex = 2;
            // 
            // btnContarRegistos
            // 
            btnContarRegistos.Location = new Point(457, 168);
            btnContarRegistos.Name = "btnContarRegistos";
            btnContarRegistos.Size = new Size(75, 23);
            btnContarRegistos.TabIndex = 3;
            btnContarRegistos.Text = "Contar Registos";
            btnContarRegistos.UseVisualStyleBackColor = true;
            btnContarRegistos.Click += btnContarRegistos_Click;
            // 
            // txtContaRegistos
            // 
            txtContaRegistos.Location = new Point(688, 169);
            txtContaRegistos.Name = "txtContaRegistos";
            txtContaRegistos.Size = new Size(100, 23);
            txtContaRegistos.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(475, 257);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Inserir";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(476, 297);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 6;
            // 
            // txtFreguesia
            // 
            txtFreguesia.Location = new Point(611, 297);
            txtFreguesia.Name = "txtFreguesia";
            txtFreguesia.Size = new Size(100, 23);
            txtFreguesia.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.Location = new Point(475, 349);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(476, 331);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 9;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(611, 279);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 10;
            label3.Text = "Freguesia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(475, 279);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 11;
            label4.Text = "Nome";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(611, 349);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 12;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInserir);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(txtFreguesia);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(txtContaRegistos);
            Controls.Add(btnContarRegistos);
            Controls.Add(txtNomes);
            Controls.Add(btnBuscarDados);
            Controls.Add(dgvBD);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvBD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBD;
        private Button btnBuscarDados;
        private TextBox txtNomes;
        private Button btnContarRegistos;
        private TextBox txtContaRegistos;
        private Label label1;
        private TextBox txtNome;
        private TextBox txtFreguesia;
        private TextBox txtId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnInserir;
    }
}
