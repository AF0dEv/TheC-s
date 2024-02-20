namespace ExperimentClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassA classA = new ClassA();
            
        }
    }

    public class ClassA : ClassB
    {
        public int CAM1()
        {
            return 0;
        }

        public int CAM2()
        {
            return 0;
        }

        public int CBM2() 
        {
            return 0;
        }
    }
}
