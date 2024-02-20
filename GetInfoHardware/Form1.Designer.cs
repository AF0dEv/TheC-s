namespace GetInfoHardware
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
            groupBox1 = new GroupBox();
            lblCM = new Label();
            lblCS = new Label();
            lblPM = new Label();
            lblBios = new Label();
            lblBM = new Label();
            lblHDD = new Label();
            lblPid = new Label();
            CPUMkr = new Button();
            CPUSpeed = new Button();
            PhysicalMem = new Button();
            BIOSMkr = new Button();
            BoardMake = new Button();
            HDDSNo = new Button();
            ProcId = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCM);
            groupBox1.Controls.Add(lblCS);
            groupBox1.Controls.Add(lblPM);
            groupBox1.Controls.Add(lblBios);
            groupBox1.Controls.Add(lblBM);
            groupBox1.Controls.Add(lblHDD);
            groupBox1.Controls.Add(lblPid);
            groupBox1.Controls.Add(CPUMkr);
            groupBox1.Controls.Add(CPUSpeed);
            groupBox1.Controls.Add(PhysicalMem);
            groupBox1.Controls.Add(BIOSMkr);
            groupBox1.Controls.Add(BoardMake);
            groupBox1.Controls.Add(HDDSNo);
            groupBox1.Controls.Add(ProcId);
            groupBox1.Location = new Point(10, 5);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(612, 329);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hardware Information";
            // 
            // lblCM
            // 
            lblCM.AutoSize = true;
            lblCM.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCM.ForeColor = Color.DarkRed;
            lblCM.Location = new Point(188, 298);
            lblCM.Margin = new Padding(4, 0, 4, 0);
            lblCM.Name = "lblCM";
            lblCM.Size = new Size(50, 16);
            lblCM.TabIndex = 13;
            lblCM.Text = "label7";
            // 
            // lblCS
            // 
            lblCS.AutoSize = true;
            lblCS.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCS.ForeColor = Color.DarkRed;
            lblCS.Location = new Point(188, 253);
            lblCS.Margin = new Padding(4, 0, 4, 0);
            lblCS.Name = "lblCS";
            lblCS.Size = new Size(50, 16);
            lblCS.TabIndex = 12;
            lblCS.Text = "label6";
            // 
            // lblPM
            // 
            lblPM.AutoSize = true;
            lblPM.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPM.ForeColor = Color.DarkRed;
            lblPM.Location = new Point(188, 208);
            lblPM.Margin = new Padding(4, 0, 4, 0);
            lblPM.Name = "lblPM";
            lblPM.Size = new Size(50, 16);
            lblPM.TabIndex = 11;
            lblPM.Text = "label5";
            // 
            // lblBios
            // 
            lblBios.AutoSize = true;
            lblBios.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBios.ForeColor = Color.DarkRed;
            lblBios.Location = new Point(188, 163);
            lblBios.Margin = new Padding(4, 0, 4, 0);
            lblBios.Name = "lblBios";
            lblBios.Size = new Size(50, 16);
            lblBios.TabIndex = 10;
            lblBios.Text = "label4";
            // 
            // lblBM
            // 
            lblBM.AutoSize = true;
            lblBM.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBM.ForeColor = Color.DarkRed;
            lblBM.Location = new Point(188, 118);
            lblBM.Margin = new Padding(4, 0, 4, 0);
            lblBM.Name = "lblBM";
            lblBM.Size = new Size(50, 16);
            lblBM.TabIndex = 9;
            lblBM.Text = "label3";
            // 
            // lblHDD
            // 
            lblHDD.AutoSize = true;
            lblHDD.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHDD.ForeColor = Color.DarkRed;
            lblHDD.Location = new Point(188, 73);
            lblHDD.Margin = new Padding(4, 0, 4, 0);
            lblHDD.Name = "lblHDD";
            lblHDD.Size = new Size(50, 16);
            lblHDD.TabIndex = 8;
            lblHDD.Text = "label2";
            // 
            // lblPid
            // 
            lblPid.AutoSize = true;
            lblPid.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPid.ForeColor = Color.DarkRed;
            lblPid.Location = new Point(188, 28);
            lblPid.Margin = new Padding(4, 0, 4, 0);
            lblPid.Name = "lblPid";
            lblPid.Size = new Size(50, 16);
            lblPid.TabIndex = 7;
            lblPid.Text = "label1";
            // 
            // CPUMkr
            // 
            CPUMkr.Location = new Point(47, 295);
            CPUMkr.Margin = new Padding(4, 3, 4, 3);
            CPUMkr.Name = "CPUMkr";
            CPUMkr.Size = new Size(118, 27);
            CPUMkr.TabIndex = 6;
            CPUMkr.Text = "CPU Maker";
            CPUMkr.UseVisualStyleBackColor = true;
            CPUMkr.Click += CPUMkr_Click;
            // 
            // CPUSpeed
            // 
            CPUSpeed.Location = new Point(47, 253);
            CPUSpeed.Margin = new Padding(4, 3, 4, 3);
            CPUSpeed.Name = "CPUSpeed";
            CPUSpeed.Size = new Size(118, 27);
            CPUSpeed.TabIndex = 5;
            CPUSpeed.Text = "CPU Speed";
            CPUSpeed.UseVisualStyleBackColor = true;
            CPUSpeed.Click += CPUSpeed_Click;
            // 
            // PhysicalMem
            // 
            PhysicalMem.Location = new Point(47, 207);
            PhysicalMem.Margin = new Padding(4, 3, 4, 3);
            PhysicalMem.Name = "PhysicalMem";
            PhysicalMem.Size = new Size(118, 27);
            PhysicalMem.TabIndex = 4;
            PhysicalMem.Text = "Physical Memory";
            PhysicalMem.UseVisualStyleBackColor = true;
            PhysicalMem.Click += PhysicalMem_Click;
            // 
            // BIOSMkr
            // 
            BIOSMkr.Location = new Point(47, 160);
            BIOSMkr.Margin = new Padding(4, 3, 4, 3);
            BIOSMkr.Name = "BIOSMkr";
            BIOSMkr.Size = new Size(118, 27);
            BIOSMkr.TabIndex = 3;
            BIOSMkr.Text = "BIOS Maker";
            BIOSMkr.UseVisualStyleBackColor = true;
            BIOSMkr.Click += BIOSMkr_Click;
            // 
            // BoardMake
            // 
            BoardMake.Location = new Point(47, 114);
            BoardMake.Margin = new Padding(4, 3, 4, 3);
            BoardMake.Name = "BoardMake";
            BoardMake.Size = new Size(118, 27);
            BoardMake.TabIndex = 2;
            BoardMake.Text = "Board Maker";
            BoardMake.UseVisualStyleBackColor = true;
            BoardMake.Click += BoardMake_Click;
            // 
            // HDDSNo
            // 
            HDDSNo.Location = new Point(47, 68);
            HDDSNo.Margin = new Padding(4, 3, 4, 3);
            HDDSNo.Name = "HDDSNo";
            HDDSNo.Size = new Size(118, 27);
            HDDSNo.TabIndex = 1;
            HDDSNo.Text = "HDD Serail No";
            HDDSNo.UseVisualStyleBackColor = true;
            HDDSNo.Click += HDDSNo_Click;
            // 
            // ProcId
            // 
            ProcId.Location = new Point(47, 22);
            ProcId.Margin = new Padding(4, 3, 4, 3);
            ProcId.Name = "ProcId";
            ProcId.Size = new Size(118, 27);
            ProcId.TabIndex = 0;
            ProcId.Text = "Processor Id";
            ProcId.UseVisualStyleBackColor = true;
            ProcId.Click += ProcId_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 347);
            Controls.Add(groupBox1);
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HardwareInfo";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BIOSMkr;
        private System.Windows.Forms.Button BoardMake;
        private System.Windows.Forms.Button HDDSNo;
        private System.Windows.Forms.Button ProcId;
        private System.Windows.Forms.Button CPUSpeed;
        private System.Windows.Forms.Button PhysicalMem;
        private System.Windows.Forms.Label lblCM;
        private System.Windows.Forms.Label lblCS;
        private System.Windows.Forms.Label lblPM;
        private System.Windows.Forms.Label lblBios;
        private System.Windows.Forms.Label lblBM;
        private System.Windows.Forms.Label lblHDD;
        private System.Windows.Forms.Label lblPid;
        private System.Windows.Forms.Button CPUMkr;
    }
}
