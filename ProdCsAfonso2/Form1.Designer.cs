namespace ProdCsAfonso2
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
            dgv1 = new DataGridView();
            dgv2 = new DataGridView();
            txtLimInf = new TextBox();
            txtLimSup = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BTN1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            SuspendLayout();
            // 
            // dgv1
            // 
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToDeleteRows = false;
            dgv1.AllowUserToResizeColumns = false;
            dgv1.AllowUserToResizeRows = false;
            dgv1.Location = new Point(270, 12);
            dgv1.Name = "dgv1";
            dgv1.Size = new Size(507, 172);
            dgv1.TabIndex = 0;
            // 
            // dgv2
            // 
            dgv2.AllowUserToAddRows = false;
            dgv2.AllowUserToDeleteRows = false;
            dgv2.AllowUserToResizeColumns = false;
            dgv2.AllowUserToResizeRows = false;
            dgv2.Location = new Point(270, 266);
            dgv2.Name = "dgv2";
            dgv2.Size = new Size(507, 172);
            dgv2.TabIndex = 1;
            // 
            // txtLimInf
            // 
            txtLimInf.Location = new Point(12, 43);
            txtLimInf.Name = "txtLimInf";
            txtLimInf.Size = new Size(100, 23);
            txtLimInf.TabIndex = 2;
            // 
            // txtLimSup
            // 
            txtLimSup.Location = new Point(164, 43);
            txtLimSup.Name = "txtLimSup";
            txtLimSup.Size = new Size(100, 23);
            txtLimSup.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 4;
            label1.Text = "LIMITE INFERIOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 12);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 5;
            label2.Text = "LIMITE SUPERIOR";
            // 
            // BTN1
            // 
            BTN1.Location = new Point(63, 214);
            BTN1.Name = "BTN1";
            BTN1.Size = new Size(75, 23);
            BTN1.TabIndex = 6;
            BTN1.Text = "button1";
            BTN1.UseVisualStyleBackColor = true;
            BTN1.Click += BTN1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLimSup);
            Controls.Add(txtLimInf);
            Controls.Add(dgv2);
            Controls.Add(dgv1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv1;
        private DataGridView dgv2;
        private TextBox txtLimInf;
        private TextBox txtLimSup;
        private Label label1;
        private Label label2;
        private Button BTN1;
    }
}
