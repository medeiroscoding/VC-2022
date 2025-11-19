namespace Teclado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void inserirLetra(object sender, EventArgs e)
        {
            txtVisor.Text += ((Button)sender).Text;
        }
    }
}