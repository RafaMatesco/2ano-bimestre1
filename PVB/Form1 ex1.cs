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
            label1.Text = "múltiplos de 4 até 200";
            int cont = 1;
            do
            {
                if (cont % 4 == 0)
                {
                    textBox1.AppendText(cont + Environment.NewLine);
                }
                cont++;
            } while (cont <= 200);
        }
    }
}