using System.Drawing.Drawing2D;

namespace MeuDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Opacity = 0.95;
        }
        private void opacityPanels()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBox1 == null)
            {
                MessageBox.Show("");
            }
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {
            int raio = 20;

            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            var r = panelLogin.ClientRectangle;
            var path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(0, r.Height - raio, raio, raio, 180, 90);
            path.AddLine(raio, r.Height, r.Width, r.Height);
            path.AddLine(r.Width, r.Height, r.Width, 0);
            path.AddLine(r.Width, 0, 0, 0);
            path.AddLine(0, 0, 0, r.Height - raio);

            path.CloseFigure();

            g.DrawPath(Pens.Black, path);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled)
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Enabled)
            {
                textBox2.Text = string.Empty;
            }
        }
    }
}
