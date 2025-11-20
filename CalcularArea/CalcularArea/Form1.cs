using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace CalcularArea
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        private void CalcularPerimQuadrado()
        {
            if (!double.TryParse(txtLado.Text, out double Lado))
            {
                MessageBox.Show("Digite um valor válido para o lado.");
                return;
            }
            double perimetro = Lado * 4;
            txtPerimQ.Text = perimetro.ToString("N2");
        }
        private void CalculoAreaQuadrado()
        {
            if (!double.TryParse(txtLado.Text, out double Lado))
            {
                MessageBox.Show("Digite um valor válido para o lado.");
                return;
            }

            double area = Lado * Lado;
            txtResultQ.Text = area.ToString("N2");
        }
        private void CalcularPerimTriangulo()
        {
            if (!double.TryParse(txtLado.Text, out double Lado))
            {
                MessageBox.Show("Digite um valor válido para o lado.");
                return;
            }
            if (radioPergunta2.Checked == true)
            {
                AtivarTxtLado();
            }
            double perimetro = Lado + Lado + Lado;
            txtPerimT.Text = perimetro.ToString("N2");
        }
        private void CalculoAreaTriangulo()
        {
            if (!double.TryParse(txtBase.Text, out double Base))
            {
                MessageBox.Show("Digite um valor válido para a base.");
                return;
            }
            if (!double.TryParse(txtAltura.Text, out double Altura))
            {
                MessageBox.Show("Digite um valor válido para a altura.");
                return;
            }

            double areaTriangulo = (Base * Altura) / 2;
            txtResultT.Text = areaTriangulo.ToString("N2");
        }
        private void CalculoPerimRetangulo()
        {
            if (!double.TryParse(txtBase.Text, out double Base))
            {
                MessageBox.Show("Digite um valor válido para a base.");
                return;
            }
            if (!double.TryParse(txtAltura.Text, out double Altura))
            {
                MessageBox.Show("Digite um valor válido para a altura.");
                return;
            }
            if (radioPergunta3.Checked == true)
            {
                AtivarTxtBase();
                AtivarTxtAltura();
            }

            double perimRetangulo = (Base + Altura) * 2;
            txtPerimR.Text = perimRetangulo.ToString("N2");
        }
        private void CalculoAreaRetangulo()
        {
            if (!double.TryParse(txtBase.Text, out double Base))
            {
                MessageBox.Show("Digite um valor válido para a base.");
                return;
            }
            if (!double.TryParse(txtAltura.Text, out double Altura))
            {
                MessageBox.Show("Digite um valor válido para a altura.");
                return;
            }

            double areaRetangulo = Base * Altura;
            txtResultR.Text = areaRetangulo.ToString("N2");
        }
        private void EnviarValor(object sender)
        {
            if (txtBase.BackColor == Color.Coral)
            {
                txtBase.Text += ((Button)sender).Text;
            }
            if (txtLado.BackColor == Color.Coral)
            {
                txtLado.Text += ((Button)sender).Text;
            }
            if (txtAltura.BackColor == Color.Coral)
            {
                txtAltura.Text += ((Button)sender).Text;
            }
        }
        private void AtivarTxtAltura()
        {
            txtBase.Enabled = true;
        }
        private void AtivarTxtBase()
        {
            txtAltura.Enabled = true;
        }
        private void AtivarTxtLado()
        {
            txtLado.Enabled = true;
        }

        /*private void AtivarTudo() Não usado!!
        {
            radioQdrd.Enabled = true;
            radioRetangulo.Enabled = true;
            radioTriangl.Enabled = true;
            radioPergunta1.Enabled = true;
            radioPergunta2.Enabled = true;
            radioPergunta3.Enabled = true;
        }
        private void DesativarTudo()
        {
            radioQdrd.Enabled = false;
            radioRetangulo.Enabled = false;
            radioTriangl.Enabled = false;
            radioPergunta1.Enabled = false;
            radioPergunta2.Enabled = false;
            radioPergunta3.Enabled = false;
        }
        */

        private void CoresBase(object sender, EventArgs e)
        {
            Color cor = Color.Coral;
            txtBase.BackColor = cor;
            txtAltura.BackColor = Color.White;
            txtLado.BackColor = Color.White;
        }
        private void CoresAltura(object sender, EventArgs e)
        {
            Color cor = Color.Coral;
            txtAltura.BackColor = cor;
            txtBase.BackColor = Color.White;
            txtLado.BackColor = Color.White;
        }
        private void CoresLado(object sender, EventArgs e)
        {
            Color cor = Color.Coral;
            txtAltura.BackColor = Color.White;
            txtBase.BackColor = Color.White;
            txtLado.BackColor = cor;
        }
        private void corRDMBase(object sender, EventArgs e)
        {
            CoresBase(sender, e);
        }

        private void corRDMLgr(object sender, EventArgs e)
        {
            CoresLado(sender, e);
        }

        private void corRDMAltr(object sender, EventArgs e)
        {
            CoresAltura(sender, e);
        }

        private void radioQdrd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioQdrd.Enabled == true)
            {
                AtivarTxtLado();
                txtAltura.Enabled = false;
                txtBase.Enabled = false;
            }
            if (radioTriangl.Enabled == true)
            {
                txtAltura.BackColor = Color.White;
                txtBase.BackColor = Color.White;
                txtLado.BackColor = Color.White;
            }
            if (radioRetangulo.Enabled == true)
            {
                txtAltura.BackColor = Color.White;
                txtBase.BackColor = Color.White;
                txtLado.BackColor = Color.White;
            }
        }

        private void radioTriangl_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTriangl.Enabled == true)
            {
                AtivarTxtBase();
                AtivarTxtAltura();
                txtLado.Enabled = false;
            }
            if (radioQdrd.Enabled == true)
            {
                txtAltura.BackColor = Color.White;
                txtBase.BackColor = Color.White;
                txtLado.BackColor = Color.White;
            }
            if (radioRetangulo.Enabled == true)
            {
                txtAltura.BackColor = Color.White;
                txtBase.BackColor = Color.White;
                txtLado.BackColor = Color.White;
            }
        }

        private void radioRetangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRetangulo.Enabled == true)
            {
                AtivarTxtBase();
                AtivarTxtAltura();
                txtLado.Enabled = false;
            }
            if (radioQdrd.Enabled == true)
            {
                txtAltura.BackColor = Color.White;
                txtBase.BackColor = Color.White;
                txtLado.BackColor = Color.White;
            }
            if (radioTriangl.Enabled == true)
            {
                txtAltura.BackColor = Color.White;
                txtBase.BackColor = Color.White;
                txtLado.BackColor = Color.White;
            }
        }

        private void enviarValor(object sender, EventArgs e)
        {
            EnviarValor(sender);
        }

        private void txtResultT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Quadrado: Perimetro e area.
            if (radioQdrd.Checked == true)
            {
                if (btnCalc.Enabled)
                {
                    CalculoAreaQuadrado();
                }
            }
            if (radioPergunta1.Checked == true)
            {
                CalcularPerimQuadrado();
            }

            // Retangulo: Perimetro e area.
            if (radioRetangulo.Checked == true)
            {
                if (btnCalc.Enabled)
                {
                    CalculoAreaRetangulo();
                }
            }
            if (radioPergunta3.Checked == true)
            {
                CalculoPerimRetangulo();
            }

            // Triangulo: Perimetro e area.
            if (radioTriangl.Checked == true)
            {
                if (btnCalc.Enabled)
                {
                    CalculoAreaTriangulo();
                }
            }
            if (radioPergunta2.Checked == true)
            {
                CalcularPerimTriangulo();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (btnDel.Enabled)
            {
                if (txtBase.BackColor == Color.Coral)
                {
                    txtBase.ResetText();
                }
                if (txtLado.BackColor == Color.Coral)
                {
                    txtLado.ResetText();
                }
                if (txtAltura.BackColor == Color.Coral)
                {
                    txtAltura.ResetText();
                }
            }
        }

        private void btnResetResult_Click(object sender, EventArgs e)
        {
            if (btnResetResult.Enabled)
            {
                txtResultQ.ResetText();
                txtResultR.ResetText();
                txtResultT.ResetText();
                txtPerimQ.ResetText();
                txtPerimR.ResetText();
                txtPerimT.ResetText();

            }
        }

        private void txtResultQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioPergunta1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPergunta1.Enabled == true)
            {
                AtivarTxtLado();
                txtAltura.Enabled = false;
                txtBase.Enabled = false;
            }
            if (radioTriangl.Enabled == true)
            {
                txtAltura.BackColor = Color.White;
                txtBase.BackColor = Color.White;
                txtLado.BackColor = Color.White;
            }
            if (radioRetangulo.Enabled == true)
            {
                txtAltura.BackColor = Color.White;
                txtBase.BackColor = Color.White;
                txtLado.BackColor = Color.White;
            }
        }

        private void radioPergunta3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPergunta2.Enabled == true)
            {
                AtivarTxtBase();
                AtivarTxtAltura();
                txtLado.Enabled = false;
            }
            if (radioTriangl.Enabled == true)
            {
                txtAltura.BackColor = Color.White;
                txtBase.BackColor = Color.White;
                txtLado.BackColor = Color.White;
            }
            if (radioRetangulo.Enabled == true)
            {
                txtAltura.BackColor = Color.White;
                txtBase.BackColor = Color.White;
                txtLado.BackColor = Color.White;
            }
        }

        private void radioPergunta2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPergunta2.Enabled == true)
            {
                AtivarTxtLado();
                txtAltura.Enabled = false;
                txtBase.Enabled = false;
            }
            if (radioTriangl.Enabled == true)
            {
                txtAltura.BackColor = Color.White;
                txtBase.BackColor = Color.White;
                txtLado.BackColor = Color.White;
            }
            if (radioRetangulo.Enabled == true)
            {
                txtAltura.BackColor = Color.White;
                txtBase.BackColor = Color.White;
                txtLado.BackColor = Color.White;
            }
        }

        private void radioPergunta2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioPergunta2.Enabled == true)
            {
                AtivarTxtLado();
                txtAltura.Enabled = false;
                txtBase.Enabled = false;
            }
            if (radioTriangl.Enabled == true)
            {
                txtAltura.BackColor = Color.White;
                txtBase.BackColor = Color.White;
                txtLado.BackColor = Color.White;
            }
            if (radioRetangulo.Enabled == true)
            {
                txtAltura.BackColor = Color.White;
                txtBase.BackColor = Color.White;
                txtLado.BackColor = Color.White;
            }
        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {

        }
    }
}