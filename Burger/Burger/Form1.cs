namespace Burger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void checkBoxHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHamburger.Checked == true)
            {
                numericHamburger.Enabled = true;
                txtTotalHamburger.Enabled = true;
            }
            else
            {
                numericHamburger.Enabled = false;
                txtTotalHamburger.Enabled = false;
                numericHamburger.Value = 0;
                txtTotalHamburger.Text = "0,00";
            }
        }

        private void checkBoxPicles_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPicles.Checked == true)
            {
                numericPicles.Enabled = true;
                txtTotalPicles.Enabled = true;
            }
            else
            {
                numericPicles.Enabled = false;
                txtTotalPicles.Enabled = false;
                numericPicles.Value = 0;
                txtTotalPicles.Text = "0,00";
            }
        }

        private void checkBoxNuggets_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNuggets.Checked == true)
            {
                numericNuggets.Enabled = true;
                txtTotalNuggets.Enabled = true;
            }
            else
            {
                numericNuggets.Enabled = false;
                txtTotalNuggets.Enabled = false;
                numericNuggets.Value = 0;
                txtTotalNuggets.Text = "0,00";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                numericCheedar.Enabled = true;
                txtTotalCheedar.Enabled = true;
            }
            else
            {
                numericCheedar.Enabled = false;
                txtTotalCheedar.Enabled = false;
                numericCheedar.Value = 0;
                txtTotalCheedar.Text = "0,00";
            }
        }

        private void checkBoxPresunto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPresunto.Checked == true)
            {
                numericPresunto.Enabled = true;
                txtTotalPresunto.Enabled = true;
            }
            else
            {
                numericPresunto.Enabled = false;
                txtTotalPresunto.Enabled = false;
                numericPresunto.Value = 0;
                txtTotalPresunto.Text = "0,00";
            }
        }

        private void checkBoxBacon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBacon.Checked == true)
            {
                numericBacon.Enabled = true;
                txtTotalBacon.Enabled = true;
            }
            else
            {
                numericBacon.Enabled = false;
                txtTotalBacon.Enabled = false;
                numericBacon.Value = 0;
                txtTotalBacon.Text = "0,00";
            }
        }

        private void checkBoxFrango_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFrango.Checked == true)
            {
                numericFrango.Enabled = true;
                txtTotalFrango.Enabled = true;
            }
            else
            {
                numericFrango.Enabled = false;
                txtTotalFrango.Enabled = false;
                numericFrango.Value = 0;
                txtTotalFrango.Text = "0,00";
            }
        }

        private void checkBoxCebola_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCebola.Checked == true)
            {
                numericCebola.Enabled = true;
                txtTotalCebola.Enabled = true;
            }
            else
            {
                numericCebola.Enabled = false;
                txtTotalCebola.Enabled = false;
                numericCebola.Value = 0;
                txtTotalCebola.Text = "0,00";
            }
        }

        private void checkBoxAlface_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAlface.Checked == true)
            {
                numericAlface.Enabled = true;
                txtTotalAlface.Enabled = true;
            }
            else
            {
                numericAlface.Enabled = false;
                txtTotalAlface.Enabled = false;
                numericAlface.Value = 0;
                txtTotalAlface.Text = "0,00";
            }
        }

        private void checkBoxTomate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTomate.Checked == true)
            {
                numericTomate.Enabled = true;
                txtTotalTomate.Enabled = true;
            }
            else
            {
                numericTomate.Enabled = false;
                txtTotalTomate.Enabled = false;
                numericTomate.Value = 0;
                txtTotalTomate.Text = "0,00";
            }
        }

        private void txtTotalHamburger_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericHamburger_ValueChanged(object sender, EventArgs e)
        {
            decimal precoUnidade = 2.00m;
            decimal quantidade = numericHamburger.Value;
            decimal total = precoUnidade * quantidade;
        
            txtTotalHamburger.Text = total.ToString("F2");
            if (checkBoxHamburger.Checked && numericHamburger.Value > 0)
            {
                listBoxPedidos.Items.Add("Hamburger - Quantidade: " + numericHamburger.Value);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void numericPicles_ValueChanged(object sender, EventArgs e)
        {
            decimal precoUnidade = 0.75m;
            decimal quantidade = numericPicles.Value;
            decimal total = precoUnidade * quantidade;

            txtTotalPicles.Text = total.ToString("F2");
            if (checkBoxPicles.Checked && numericPicles.Value > 0)
            {
                listBoxPedidos.Items.Add("Picles - Quantidade: " + numericPicles.Value);
            }
        }

        private void numericNuggets_ValueChanged(object sender, EventArgs e)
        {
            decimal precoUnidade = 2.50m;
            decimal quantidade = numericNuggets.Value;
            decimal total = precoUnidade * quantidade;

            txtTotalNuggets.Text = total.ToString("F2");
            if (checkBoxNuggets.Checked && numericNuggets.Value > 0)
            {
                listBoxPedidos.Items.Add("Nuggets - Quantidade: " + numericNuggets.Value);
            }
        }

        private void numericCheedar_ValueChanged(object sender, EventArgs e)
        {
            decimal precoUnidade = 2.00m;
            decimal quantidade = numericCheedar.Value;
            decimal total = precoUnidade * quantidade;

            txtTotalCheedar.Text = total.ToString("F2");
            if (checkBox3.Checked && numericCheedar.Value > 0)
            {
                listBoxPedidos.Items.Add("Cheedar - Quantidade: " + numericCheedar.Value);
            }
        }

        private void numericPresunto_ValueChanged(object sender, EventArgs e)
        {
            decimal precoUnidade = 1.50m;
            decimal quantidade = numericPresunto.Value;
            decimal total = precoUnidade * quantidade;

            txtTotalPresunto.Text = total.ToString("F2");
            if (checkBoxPresunto.Checked && numericPresunto.Value > 0)
            {
                listBoxPedidos.Items.Add("Presunto - Quantidade: " + numericPresunto.Value);
            }
        }

        private void numericBacon_ValueChanged(object sender, EventArgs e)
        {
            decimal precoUnidade = 2.00m;
            decimal quantidade = numericBacon.Value;
            decimal total = precoUnidade * quantidade;

            txtTotalBacon.Text = total.ToString("F2");
            if (checkBoxBacon.Checked && numericBacon.Value > 0)
            {
                listBoxPedidos.Items.Add("Bacon - Quantidade: " + numericBacon.Value);
            }
        }

        private void numericFrango_ValueChanged(object sender, EventArgs e)
        {
            decimal precoUnidade = 1.50m;
            decimal quantidade = numericFrango.Value;
            decimal total = precoUnidade * quantidade;

            txtTotalFrango.Text = total.ToString("F2");
            if (checkBoxFrango.Checked && numericFrango.Value > 0)
            {
                listBoxPedidos.Items.Add("Frango - Quantidade: " + numericFrango.Value);
            }
        }

        private void numericCebola_ValueChanged(object sender, EventArgs e)
        {
            decimal precoUnidade = 0.50m;
            decimal quantidade = numericHamburger.Value;
            decimal total = precoUnidade * quantidade;

            txtTotalCebola.Text = total.ToString("F2");
            if (checkBoxCebola.Checked && numericCebola.Value > 0)
            {
                listBoxPedidos.Items.Add("Cebola - Quantidade: " + numericCebola.Value);
            }
        }

        private void numericAlface_ValueChanged(object sender, EventArgs e)
        {
            decimal precoUnidade = 0.75m;
            decimal quantidade = numericAlface.Value;
            decimal total = precoUnidade * quantidade;

            txtTotalAlface.Text = total.ToString("F2");
            if (checkBoxAlface.Checked && numericAlface.Value > 0)
            {
                listBoxPedidos.Items.Add("Alface - Quantidade: " + numericAlface.Value);
            }
        }

        private void numericTomate_ValueChanged(object sender, EventArgs e)
        {
            decimal precoUnidade = 0.50m;
            decimal quantidade = numericTomate.Value;
            decimal total = precoUnidade * quantidade;

            txtTotalTomate.Text = total.ToString("F2");
            if (checkBoxTomate.Checked && numericTomate.Value > 0)
            {
                listBoxPedidos.Items.Add("Tomate - Quantidade: " + numericTomate.Value);
            }
        }

        private void ValorTotal()
        {
            decimal total = 0;

            // Lista de TextBoxes com valores
            TextBox[] totais = { txtTotalHamburger, txtTotalFrango, txtTotalPicles };

            foreach (TextBox txt in totais)
            {
                if (!string.IsNullOrEmpty(txt.Text))
                    total += decimal.Parse(txt.Text);
            }

            textBoxTotal.Text = total.ToString("F2");
        }
    }
}