namespace Arinza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            label2.Text = "Hallo! " + name;
        }
    }
}
