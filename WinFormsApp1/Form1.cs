namespace WinFormsApp1
{
    public class Form1 : Form
    {
        public Form1()
        {
            btnOk = new Button();
            txtOlaMundo = new TextBox();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(188, 192);
            btnOk.Click += btnOk_Click;
            // 
            // txtOlaMundo
            // 
            txtOlaMundo.Location = new Point(466, 191);
            // 
            // Form1
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(txtOlaMundo);
            Controls.Add(btnOk); ;
        }
        private Button btnOk;
        private TextBox txtOlaMundo;

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtOlaMundo.Text = "Ola Mundo!";
        }
    }
}
