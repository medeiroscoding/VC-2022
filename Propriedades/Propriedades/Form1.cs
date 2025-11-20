namespace Propriedades
{
    public partial class Form1 : Form
    {
        Random rgb = new Random();
        Form form1 = new Form();
        public Form1()
        {
            InitializeComponent();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 2;  // velocidade da mudança
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int r = rgb.Next(0, 256);
            int g = rgb.Next(0, 256);
            int b = rgb.Next(0, 256);

            // muda o fundo do Form atual
            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
