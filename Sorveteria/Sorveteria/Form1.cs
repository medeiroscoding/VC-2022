namespace Sorveteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void foreverToggle1_CheckedChanged(object sender)
        {
            if (foreverToggle1.Checked)
            {
                panelTitulo.BackColor = Color.FromArgb((36), (36), (36));
                btn1000.BackColor = Color.FromArgb((36), (36), (36));
                btn700.BackColor = Color.FromArgb((36), (36), (36));
                btn500.BackColor = Color.FromArgb((36), (36), (36));
                btn300.BackColor = Color.FromArgb((36), (36), (36));
                this.BackColor = Color.DarkGray;
                lblAcai.ForeColor = Color.White;
            }
            else
            {
                panelTitulo.BackColor = Color.DarkSlateBlue;
                btn1000.BackColor = Color.DarkSlateBlue;
                btn700.BackColor = Color.DarkSlateBlue;
                btn500.BackColor = Color.DarkSlateBlue;
                btn300.BackColor = Color.DarkSlateBlue;
                this.BackColor = Color.White;
                lblAcai.ForeColor = Color.DarkSlateBlue;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}