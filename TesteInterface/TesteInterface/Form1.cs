namespace TesteInterface
{
    public partial class Form1 : Form
    {
        Random randomCor = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void CoresRandom()
        {
            Color cor = Color.FromArgb(randomCor.Next(39), randomCor.Next(39), randomCor.Next(80));
            btnProdutos.BackColor = cor;
            btnInicio.BackColor = cor;
            btnContato.BackColor = cor;
            btnConfig.BackColor = cor;
            btnCadastro.BackColor = cor;
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            CoresRandom();
        }

        private void btnContato_Click(object sender, EventArgs e)
        {
            CoresRandom();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            CoresRandom();
        }



        private void btnConfig_Click(object sender, EventArgs e)
        {
            CoresRandom();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            CoresRandom();
        }
    }
}