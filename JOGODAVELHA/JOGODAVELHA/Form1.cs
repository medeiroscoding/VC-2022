namespace JOGODAVELHA
{
    public partial class Form1 : Form
    {
        bool vezDoX; // true = X, false = O
        int empates = 0;
        int vitoriasJogador1;
        int vitoriasJogador2;
        public Form1()
        {
            InitializeComponent();
        }
        private void LimparBotoes()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
        private void AtivarJogo()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void DesativarJogo()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        private void enviarValor(object sender, EventArgs e)
        {

        }
        private void btnSair_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
            "Deseja fechar o jogo?",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Fechando aplicativo...",
                    "Saída",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnReiniciar_Click_1(object sender, EventArgs e)
        {
            LimparBotoes();
            AtivarJogo();
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Digite o nome dos dois jogadores!",
                                "Aviso", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
                return;
            }
            if (!radioBtnX.Checked && !radioBtnO.Checked)
            {
                MessageBox.Show("Escolha quem começa: X ou O!",
                                "Aviso", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
                return;
            }

            if (btnIniciar.Enabled = true)
            {
                DesativarBIniciar();
            }

            AtivarJogo();
            LimparBotoes();
            EnviarNome();

            vezDoX = radioBtnX.Checked;

            MessageBox.Show("Jogo iniciado! Boa sorte!");
        }

        private void btnJogo(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // se já tiver X ou O, não faz nada
            if (btn.Text != "")
                return;

            // marca X ou O
            btn.Text = vezDoX ? "X" : "O";

            // troca a vez
            vezDoX = !vezDoX;

            // verifica se alguém venceu
            VerificarVencedor();
        }
        private void VerificarVencedor()
        {
            string vencedor = "";
            bool deuEmpate = false;
            string a1 = button1.Text, a2 = button2.Text, a3 = button3.Text;
            string b1 = button4.Text, b2 = button5.Text, b3 = button6.Text;
            string c1 = button7.Text, c2 = button8.Text, c3 = button9.Text;

            // parte pra verificar as linha
            if (a1 == a2 && a2 == a3 && a1 != "") FimDeJogo(a1);
            else if (b1 == b2 && b2 == b3 && b1 != "") FimDeJogo(b1);
            else if (c1 == c2 && c2 == c3 && c1 != "") FimDeJogo(c1);

            // parte pra verificar coluna
            else if (a1 == b1 && b1 == c1 && a1 != "") FimDeJogo(a1);
            else if (a2 == b2 && b2 == c2 && a2 != "") FimDeJogo(a2);
            else if (a3 == b3 && b3 == c3 && a3 != "") FimDeJogo(a3);

            // parte pra verificar diagonal
            else if (a1 == b2 && b2 == c3 && a1 != "") FimDeJogo(a1);
            else if (a3 == b2 && b2 == c1 && a3 != "") FimDeJogo(a3);

            // parte pra verificar os empates
            else if (a1 != "" && a2 != "" && a3 != "" &&
                     b1 != "" && b2 != "" && b3 != "" &&
                     c1 != "" && c2 != "" && c3 != "")
            {
                empates++;
                lblEmpate.Text = empates.ToString();
                MessageBox.Show("Empate!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }

            if (vencedor == "X")
            {
                vitoriasJogador1++;
                MessageBox.Show(textBox1.Text + " venceu!");
            }
            else if (vencedor == "O")
            {
                vitoriasJogador2++;
                MessageBox.Show(textBox2.Text + " venceu!");
            }
            else if (deuEmpate)
            {
                empates++;
                MessageBox.Show("Empate!");
            }

            AtualizarPlacar();
        }
        private void FimDeJogo(string vencedor)
        {
            MessageBox.Show($"Jogador {vencedor} venceu!");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            DesativarJogo();
        }

        public void EnviarNome()
        {
            lblJogador1.Text = textBox1.Text;
            label2.Text = textBox2.Text;
        }

        private void AtualizarPlacar()
        {
            lblJogador1.Text = textBox1.Text + ": " + vitoriasJogador1.ToString();
            label2.Text = textBox2.Text + ": " + vitoriasJogador2.ToString();
        }
        private void DesativarBIniciar()
        {
            btnIniciar.Enabled = false;
        }

        private void panelBotBox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}