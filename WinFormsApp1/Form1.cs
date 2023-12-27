namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int n = Convert.ToInt32(textBox1.Text);
            int n1 = Convert.ToInt32(textBox2.Text);
            Soma(n, n1);
            MessageBox.Show($"Resulatado = {Soma(n,n1)}");
        }

        public static int Soma(int n, int n1)
        {
            return n + n1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
