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
            label1.Text = "Verificar se o valor � primo";
            int n = int.Parse(textBox1.Text);
            int cont = 1;

            while (cont <= n)
            {
                if ((cont != 1) && (cont != n))
                {
                    if (n % cont == 0)
                    {
                        textBox1.AppendText(Environment.NewLine + "N�mero n�o � primo.");
                        break;
                    }
                    else
                    {
                        textBox1.AppendText(Environment.NewLine + "Numero � primo.");
                        break;
                    }
                }
                cont++;
            }


        }
    }
}