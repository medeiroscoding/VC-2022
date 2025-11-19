namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn01 = new Button();
            btn02 = new Button();
            btn03 = new Button();
            btn04 = new Button();
            btn05 = new Button();
            btn06 = new Button();
            btn07 = new Button();
            btn08 = new Button();
            btn09 = new Button();
            btnMenos = new Button();
            btnVezes = new Button();
            btnSoma = new Button();
            btnDividir = new Button();
            btnIgual = new Button();
            btnApagar = new Button();
            btnDeletar = new Button();
            btn00 = new Button();
            btnVirgula = new Button();
            txtVisor = new TextBox();
            panelInitial = new Panel();
            panel1 = new Panel();
            lblOperacao = new Label();
            panelInitial.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn01
            // 
            btn01.Anchor = AnchorStyles.None;
            btn01.ForeColor = SystemColors.ActiveCaptionText;
            btn01.Location = new Point(62, 263);
            btn01.Name = "btn01";
            btn01.Size = new Size(75, 45);
            btn01.TabIndex = 0;
            btn01.Text = "1";
            btn01.UseVisualStyleBackColor = true;
            btn01.Click += inserirNumero;
            // 
            // btn02
            // 
            btn02.Anchor = AnchorStyles.None;
            btn02.ForeColor = SystemColors.ActiveCaptionText;
            btn02.Location = new Point(143, 263);
            btn02.Name = "btn02";
            btn02.Size = new Size(75, 45);
            btn02.TabIndex = 1;
            btn02.Text = "2";
            btn02.UseVisualStyleBackColor = true;
            btn02.Click += inserirNumero;
            // 
            // btn03
            // 
            btn03.Anchor = AnchorStyles.None;
            btn03.ForeColor = SystemColors.ActiveCaptionText;
            btn03.Location = new Point(224, 263);
            btn03.Name = "btn03";
            btn03.Size = new Size(75, 45);
            btn03.TabIndex = 2;
            btn03.Text = "3";
            btn03.UseVisualStyleBackColor = true;
            btn03.Click += inserirNumero;
            // 
            // btn04
            // 
            btn04.Anchor = AnchorStyles.None;
            btn04.ForeColor = SystemColors.ActiveCaptionText;
            btn04.Location = new Point(62, 311);
            btn04.Name = "btn04";
            btn04.Size = new Size(75, 45);
            btn04.TabIndex = 3;
            btn04.Text = "4";
            btn04.UseVisualStyleBackColor = true;
            btn04.Click += inserirNumero;
            // 
            // btn05
            // 
            btn05.Anchor = AnchorStyles.None;
            btn05.ForeColor = SystemColors.ActiveCaptionText;
            btn05.Location = new Point(143, 311);
            btn05.Name = "btn05";
            btn05.Size = new Size(75, 45);
            btn05.TabIndex = 4;
            btn05.Text = "5";
            btn05.UseVisualStyleBackColor = true;
            btn05.Click += inserirNumero;
            // 
            // btn06
            // 
            btn06.Anchor = AnchorStyles.None;
            btn06.ForeColor = SystemColors.ActiveCaptionText;
            btn06.Location = new Point(224, 311);
            btn06.Name = "btn06";
            btn06.Size = new Size(75, 45);
            btn06.TabIndex = 5;
            btn06.Text = "6";
            btn06.UseVisualStyleBackColor = true;
            btn06.Click += inserirNumero;
            // 
            // btn07
            // 
            btn07.Anchor = AnchorStyles.None;
            btn07.ForeColor = SystemColors.ActiveCaptionText;
            btn07.Location = new Point(62, 360);
            btn07.Name = "btn07";
            btn07.Size = new Size(75, 45);
            btn07.TabIndex = 6;
            btn07.Text = "7";
            btn07.UseVisualStyleBackColor = true;
            btn07.Click += inserirNumero;
            // 
            // btn08
            // 
            btn08.Anchor = AnchorStyles.None;
            btn08.ForeColor = SystemColors.ActiveCaptionText;
            btn08.Location = new Point(143, 360);
            btn08.Name = "btn08";
            btn08.Size = new Size(75, 45);
            btn08.TabIndex = 7;
            btn08.Text = "8";
            btn08.UseVisualStyleBackColor = true;
            btn08.Click += inserirNumero;
            // 
            // btn09
            // 
            btn09.Anchor = AnchorStyles.None;
            btn09.ForeColor = SystemColors.ActiveCaptionText;
            btn09.Location = new Point(224, 360);
            btn09.Name = "btn09";
            btn09.Size = new Size(75, 45);
            btn09.TabIndex = 8;
            btn09.Text = "9";
            btn09.UseVisualStyleBackColor = true;
            btn09.Click += inserirNumero;
            // 
            // btnMenos
            // 
            btnMenos.Anchor = AnchorStyles.None;
            btnMenos.ForeColor = SystemColors.ActiveCaptionText;
            btnMenos.Location = new Point(305, 360);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(75, 45);
            btnMenos.TabIndex = 9;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            btnMenos.Click += btnMenos_Click;
            // 
            // btnVezes
            // 
            btnVezes.Anchor = AnchorStyles.None;
            btnVezes.ForeColor = SystemColors.ActiveCaptionText;
            btnVezes.Location = new Point(305, 263);
            btnVezes.Name = "btnVezes";
            btnVezes.Size = new Size(75, 45);
            btnVezes.TabIndex = 10;
            btnVezes.Text = "x";
            btnVezes.UseVisualStyleBackColor = true;
            btnVezes.Click += btnVezes_Click;
            // 
            // btnSoma
            // 
            btnSoma.Anchor = AnchorStyles.None;
            btnSoma.ForeColor = SystemColors.ActiveCaptionText;
            btnSoma.Location = new Point(305, 311);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(75, 45);
            btnSoma.TabIndex = 11;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += button12_Click;
            // 
            // btnDividir
            // 
            btnDividir.Anchor = AnchorStyles.None;
            btnDividir.ForeColor = SystemColors.ActiveCaptionText;
            btnDividir.Location = new Point(305, 212);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 45);
            btnDividir.TabIndex = 12;
            btnDividir.Text = "÷";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnIgual
            // 
            btnIgual.Anchor = AnchorStyles.None;
            btnIgual.BackColor = Color.DodgerBlue;
            btnIgual.FlatStyle = FlatStyle.Flat;
            btnIgual.ForeColor = SystemColors.ActiveCaptionText;
            btnIgual.Location = new Point(182, 411);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(198, 45);
            btnIgual.TabIndex = 13;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnApagar
            // 
            btnApagar.Anchor = AnchorStyles.None;
            btnApagar.ForeColor = SystemColors.ActiveCaptionText;
            btnApagar.Location = new Point(143, 212);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(75, 45);
            btnApagar.TabIndex = 14;
            btnApagar.Text = "⌫";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Anchor = AnchorStyles.None;
            btnDeletar.ForeColor = SystemColors.ActiveCaptionText;
            btnDeletar.Location = new Point(66, 212);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(71, 45);
            btnDeletar.TabIndex = 17;
            btnDeletar.Text = "C";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btn00
            // 
            btn00.Anchor = AnchorStyles.None;
            btn00.ForeColor = SystemColors.ActiveCaptionText;
            btn00.Location = new Point(97, 384);
            btn00.Name = "btn00";
            btn00.Size = new Size(114, 45);
            btn00.TabIndex = 19;
            btn00.Text = "0";
            btn00.UseVisualStyleBackColor = true;
            btn00.Click += inserirNumero;
            // 
            // btnVirgula
            // 
            btnVirgula.Anchor = AnchorStyles.None;
            btnVirgula.ForeColor = SystemColors.ActiveCaptionText;
            btnVirgula.Location = new Point(224, 212);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(75, 45);
            btnVirgula.TabIndex = 20;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += inserirNumero;
            // 
            // txtVisor
            // 
            txtVisor.Anchor = AnchorStyles.None;
            txtVisor.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtVisor.Location = new Point(66, 66);
            txtVisor.Multiline = true;
            txtVisor.Name = "txtVisor";
            txtVisor.Size = new Size(314, 82);
            txtVisor.TabIndex = 24;
            txtVisor.Text = "0";
            txtVisor.TextAlign = HorizontalAlignment.Right;
            txtVisor.TextChanged += txtVisor_TextChanged;
            // 
            // panelInitial
            // 
            panelInitial.AutoSize = true;
            panelInitial.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelInitial.BackColor = Color.Transparent;
            panelInitial.Controls.Add(btn00);
            panelInitial.Controls.Add(panel1);
            panelInitial.Dock = DockStyle.Fill;
            panelInitial.Location = new Point(0, 0);
            panelInitial.Name = "panelInitial";
            panelInitial.Size = new Size(628, 450);
            panelInitial.TabIndex = 25;
            panelInitial.Paint += panelInitial_Paint;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(lblOperacao);
            panel1.Controls.Add(btnVirgula);
            panel1.Controls.Add(btn04);
            panel1.Controls.Add(btn03);
            panel1.Controls.Add(btnIgual);
            panel1.Controls.Add(btn09);
            panel1.Controls.Add(btn08);
            panel1.Controls.Add(btn07);
            panel1.Controls.Add(btn02);
            panel1.Controls.Add(btn05);
            panel1.Controls.Add(btn01);
            panel1.Controls.Add(txtVisor);
            panel1.Controls.Add(btn06);
            panel1.Controls.Add(btnApagar);
            panel1.Controls.Add(btnDeletar);
            panel1.Controls.Add(btnDividir);
            panel1.Controls.Add(btnVezes);
            panel1.Controls.Add(btnMenos);
            panel1.Controls.Add(btnSoma);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(35, -27);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 488);
            panel1.TabIndex = 25;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.BackColor = Color.Transparent;
            lblOperacao.Location = new Point(80, 96);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 15);
            lblOperacao.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 450);
            Controls.Add(panelInitial);
            Name = "Form1";
            Text = "Form1";
            panelInitial.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn01;
        private Button btn02;
        private Button btn03;
        private Button btn04;
        private Button btn05;
        private Button btn06;
        private Button btn07;
        private Button btn08;
        private Button btn09;
        private Button btnMenos;
        private Button btnVezes;
        private Button btnSoma;
        private Button btnDividir;
        private Button btnIgual;
        private Button btnApagar;
        private Button btnDeletar;
        private Button btn00;
        private Button btnVirgula;
        private TextBox txtVisor;
        private Panel panelInitial;
        private Panel panel1;
        private Label lblOperacao;
    }
}