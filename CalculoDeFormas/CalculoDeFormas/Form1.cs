namespace CalculoDeFormas
{
    public partial class Form1 : Form
    {
        Random coresRDM = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void CoresBase()
        {
            Color cor = Color.FromArgb(coresRDM.Next(39), coresRDM.Next(39), coresRDM.Next(80));
            txt.BackColor = cor;
        }
        private void CoresAltura()
        {
            Color cor = Color.FromArgb(coresRDM.Next(39), coresRDM.Next(39), coresRDM.Next(80));
            txtAltura.BackColor = cor;
        }
        private void CoresLargura()
        {
            Color cor = Color.FromArgb(coresRDM.Next(39), coresRDM.Next(39), coresRDM.Next(80));
            txtLargura.BackColor = cor;
        }

        private void corRandom(object sender, EventArgs e)
        {
            CoresLargura();
        }
    }
}