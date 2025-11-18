namespace CalcularIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void IMCeStatus()
        {
            double valordaAltura = double.Parse(txtAltura.Text);
            double valordoPeso = double.Parse(txtPeso.Text);

            double calculoTotal = valordoPeso / Math.Pow(valordaAltura, 2);

            txtIMC.Text = calculoTotal.ToString("N2");

            if (calculoTotal < 18.5)
            {
                lblSituação2.Text = "Abaixo do peso normal";
            }
            else if (calculoTotal > 18.5 && calculoTotal < 24.9)
            {
                lblSituação2.Text = "Execesso de peso";
            }
            else if (calculoTotal > 25.0 && calculoTotal < 29.9)
            {
                lblSituação2.Text = "Obesidade classe I";
            }
            else if (calculoTotal > 35.0 && calculoTotal < 29.9)
            {
                lblSituação2.Text = "Obesidade classe II";
            }
            else if (calculoTotal == 100)
            {
                lblSituação2.Text = "ok";
            }
        }
        private void FecharPrograma()
        {
            if (btnSair.Enabled == true)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja sair?",
                    "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Asterisk
                    );
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
        private void LimparTudo()
        {
            txtAltura.ResetText();
            txtIMC.ResetText();
            txtPeso.ResetText();
        }
        private void PintarAltura()
        {
            txtAltura.BackColor = Color.AliceBlue;
            txtPeso.BackColor = Color.White;
        }
        private void EnviarValor(object sender)
        {
            if (txtAltura.BackColor == Color.AliceBlue)
            {
                txtAltura.Text += ((Button)sender).Text;
            }
            if (txtPeso.BackColor == Color.AliceBlue)
            {
                txtPeso.Text += ((Button)sender).Text;
            }
        }
        private void PintarPeso()
        {
            txtAltura.BackColor = Color.White;
            txtPeso.BackColor = Color.AliceBlue;
        }

        private void focoPeso(object sender, EventArgs e)
        {
            PintarPeso();
        }

        private void focoAltura(object sender, EventArgs e)
        {
            PintarAltura();
        }

        private void btnSair_click(object sender, EventArgs e)
        {
            FecharPrograma();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            LimparTudo();
        }

        private void enviarValor(object sender, EventArgs e)
        {
            EnviarValor(sender);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            IMCeStatus();
        }
    }
}