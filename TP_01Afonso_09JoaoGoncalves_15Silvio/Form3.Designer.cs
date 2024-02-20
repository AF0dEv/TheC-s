namespace TP_01Afonso_09JoaoGoncalves_15Silvio
{
    partial class Form3
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
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.btnInserirFuncionario = new System.Windows.Forms.Button();
            this.btnRemoverFuncionario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Location = new System.Drawing.Point(45, 37);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.RowHeadersWidth = 102;
            this.dgvFuncionario.RowTemplate.Height = 40;
            this.dgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionario.Size = new System.Drawing.Size(1485, 678);
            this.dgvFuncionario.TabIndex = 0;
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(45, 827);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(445, 38);
            this.txtFuncionario.TabIndex = 1;
            // 
            // btnInserirFuncionario
            // 
            this.btnInserirFuncionario.Location = new System.Drawing.Point(550, 813);
            this.btnInserirFuncionario.Name = "btnInserirFuncionario";
            this.btnInserirFuncionario.Size = new System.Drawing.Size(323, 65);
            this.btnInserirFuncionario.TabIndex = 2;
            this.btnInserirFuncionario.Text = "Inserir Funcionário";
            this.btnInserirFuncionario.UseVisualStyleBackColor = true;
            this.btnInserirFuncionario.Click += new System.EventHandler(this.btnInserirFuncionario_Click);
            // 
            // btnRemoverFuncionario
            // 
            this.btnRemoverFuncionario.Location = new System.Drawing.Point(1052, 743);
            this.btnRemoverFuncionario.Name = "btnRemoverFuncionario";
            this.btnRemoverFuncionario.Size = new System.Drawing.Size(478, 65);
            this.btnRemoverFuncionario.TabIndex = 3;
            this.btnRemoverFuncionario.Text = "Remover funcionário selecionado";
            this.btnRemoverFuncionario.UseVisualStyleBackColor = true;
            this.btnRemoverFuncionario.Click += new System.EventHandler(this.btnRemoverFuncionario_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1568, 912);
            this.Controls.Add(this.btnRemoverFuncionario);
            this.Controls.Add(this.btnInserirFuncionario);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.dgvFuncionario);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Button btnInserirFuncionario;
        private System.Windows.Forms.Button btnRemoverFuncionario;
    }
}