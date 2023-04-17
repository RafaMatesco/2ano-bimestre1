namespace exercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Programa para caluclar o fatorial de um número(n)";
            int n = int.Parse(textBox1.Text);
            int cont = n;
            textBox1.AppendText(Environment.NewLine + Environment.NewLine);

            while (cont > 1)
            { 
                textBox1.AppendText(n + " X ");
                cont--;
                textBox1.AppendText(cont + " = ");
                n = n * cont;
                textBox1.AppendText(n + Environment.NewLine);
                textBox1.AppendText(Environment.NewLine);
            }

        }
    }
}