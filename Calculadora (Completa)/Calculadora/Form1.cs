namespace Calculadora
{
    public partial class Form1 : Form
    {
        string operacaoselecionada;
        decimal valor;
        decimal resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void panelInitial_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn05_Click(object sender, EventArgs e)
        {
        }

        private void btn02_Click(object sender, EventArgs e)
        {
        }

        private void btn04_Click(object sender, EventArgs e)
        {
        }

        private void btn06_Click(object sender, EventArgs e)
        {
        }

        private void btn07_Click(object sender, EventArgs e)
        {
        }

        private void btn08_Click(object sender, EventArgs e)
        {
        }

        private void btn09_Click(object sender, EventArgs e)
        {
        }

        private void btn00_Click(object sender, EventArgs e)
        {
        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button13_Click(object sender, EventArgs e)
        {
        }

        private void button19_Click(object sender, EventArgs e)
        {
        }

        private void button21_Click(object sender, EventArgs e)
        {
        }

        private void button23_Click(object sender, EventArgs e)
        {
        }

        private void button24_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void inserirNumero(object sender, EventArgs e)
        {
            txtVisor.Text += ((Button)sender).Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operacaoselecionada = "Adicao";
            valor += decimal.Parse(txtVisor.Text);
            txtVisor.Text = "";
            lblOperacao.Text = "+";

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {


                switch (operacaoselecionada)
                {

                    case "Adicao":
                        resultado = valor + decimal.Parse(txtVisor.Text);
                        break;


                    case "Menos":
                        resultado = valor - decimal.Parse(txtVisor.Text);
                        break;

                    case "Vezes":
                        resultado = valor * decimal.Parse(txtVisor.Text);
                        break;

                    case "Dividir":
                        resultado = valor / decimal.Parse(txtVisor.Text);
                        break;
                }
                txtVisor.Text = resultado.ToString();
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVisor.Text = "";
            }

            lblOperacao.Text = "";
            }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operacaoselecionada = "Menos";
            valor += decimal.Parse(txtVisor.Text);
            txtVisor.Text = "";
            lblOperacao.Text = "-";
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            operacaoselecionada = "Vezes";
            valor += decimal.Parse(txtVisor.Text);
            txtVisor.Text = "";
            lblOperacao.Text = "x";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operacaoselecionada = "Dividir";
            valor += decimal.Parse(txtVisor.Text);
            txtVisor.Text = "";
            lblOperacao.Text = "÷";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            lblOperacao.Text = "";
            resultado = 0;
            valor = 0;
        }
    }
}