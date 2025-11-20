namespace CalcularArea
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
            panel1 = new Panel();
            lblBase = new Label();
            txtBase = new TextBox();
            lblAltura = new Label();
            lblLargura = new Label();
            txtAltura = new TextBox();
            txtLado = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            btnCalc = new Button();
            btnDel = new Button();
            button11 = new Button();
            btnVirgula = new Button();
            btn1 = new Button();
            btn2 = new Button();
            button7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            panel4 = new Panel();
            label1 = new Label();
            radioTriangl = new RadioButton();
            radioRetangulo = new RadioButton();
            radioQdrd = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            txtResultT = new TextBox();
            txtResultR = new TextBox();
            panel5 = new Panel();
            btnResetResult = new Button();
            txtPerimR = new TextBox();
            txtPerimT = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            radioPergunta2 = new RadioButton();
            txtPerimQ = new TextBox();
            txtResultQ = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            radioPergunta3 = new RadioButton();
            radioPergunta1 = new RadioButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 55, 76);
            panel1.Controls.Add(lblBase);
            panel1.Controls.Add(txtBase);
            panel1.Controls.Add(lblAltura);
            panel1.Controls.Add(lblLargura);
            panel1.Controls.Add(txtAltura);
            panel1.Controls.Add(txtLado);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(891, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 924);
            panel1.TabIndex = 0;
            // 
            // lblBase
            // 
            lblBase.AutoSize = true;
            lblBase.Font = new Font("Bahnschrift Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBase.ForeColor = SystemColors.Window;
            lblBase.Location = new Point(46, 145);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(66, 29);
            lblBase.TabIndex = 7;
            lblBase.Text = "Base";
            // 
            // txtBase
            // 
            txtBase.Enabled = false;
            txtBase.Font = new Font("Bahnschrift Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBase.ForeColor = Color.Black;
            txtBase.Location = new Point(163, 147);
            txtBase.Margin = new Padding(3, 4, 3, 4);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(140, 36);
            txtBase.TabIndex = 6;
            txtBase.TextChanged += txtBase_TextChanged;
            txtBase.Enter += corRDMBase;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Bahnschrift Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAltura.ForeColor = SystemColors.Window;
            lblAltura.Location = new Point(46, 240);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(80, 29);
            lblAltura.TabIndex = 5;
            lblAltura.Text = "Altura";
            // 
            // lblLargura
            // 
            lblLargura.AutoSize = true;
            lblLargura.Font = new Font("Bahnschrift Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLargura.ForeColor = SystemColors.Window;
            lblLargura.Location = new Point(46, 193);
            lblLargura.Name = "lblLargura";
            lblLargura.Size = new Size(66, 29);
            lblLargura.TabIndex = 4;
            lblLargura.Text = "Lado";
            // 
            // txtAltura
            // 
            txtAltura.Enabled = false;
            txtAltura.Font = new Font("Bahnschrift Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltura.ForeColor = Color.Black;
            txtAltura.Location = new Point(163, 240);
            txtAltura.Margin = new Padding(3, 4, 3, 4);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(140, 36);
            txtAltura.TabIndex = 3;
            txtAltura.Enter += corRDMAltr;
            // 
            // txtLado
            // 
            txtLado.Enabled = false;
            txtLado.Font = new Font("Bahnschrift Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLado.ForeColor = Color.Transparent;
            txtLado.Location = new Point(163, 193);
            txtLado.Margin = new Padding(3, 4, 3, 4);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(140, 36);
            txtLado.TabIndex = 2;
            txtLado.Enter += corRDMLgr;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(42, 42, 70);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(344, 133);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btnCalc);
            panel2.Controls.Add(btnDel);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(btnVirgula);
            panel2.Controls.Add(btn1);
            panel2.Controls.Add(btn2);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(btn6);
            panel2.Controls.Add(btn5);
            panel2.Controls.Add(btn4);
            panel2.Controls.Add(btn9);
            panel2.Controls.Add(btn8);
            panel2.Controls.Add(btn7);
            panel2.Location = new Point(16, 292);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 499);
            panel2.TabIndex = 0;
            // 
            // btnCalc
            // 
            btnCalc.BackColor = Color.FromArgb(55, 55, 76);
            btnCalc.FlatAppearance.BorderSize = 0;
            btnCalc.FlatStyle = FlatStyle.Flat;
            btnCalc.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalc.ForeColor = Color.WhiteSmoke;
            btnCalc.Location = new Point(11, 447);
            btnCalc.Margin = new Padding(3, 4, 3, 4);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(288, 41);
            btnCalc.TabIndex = 11;
            btnCalc.Text = "Calcular";
            btnCalc.UseVisualStyleBackColor = false;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.FromArgb(55, 55, 76);
            btnDel.FlatAppearance.BorderSize = 0;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnDel.ForeColor = Color.WhiteSmoke;
            btnDel.Location = new Point(208, 339);
            btnDel.Margin = new Padding(3, 4, 3, 4);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(91, 100);
            btnDel.TabIndex = 10;
            btnDel.Text = "Del";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(55, 55, 76);
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button11.ForeColor = Color.WhiteSmoke;
            button11.Location = new Point(110, 339);
            button11.Margin = new Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Size = new Size(91, 100);
            button11.TabIndex = 9;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = false;
            button11.Click += enviarValor;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.FromArgb(55, 55, 76);
            btnVirgula.FlatAppearance.BorderSize = 0;
            btnVirgula.FlatStyle = FlatStyle.Flat;
            btnVirgula.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnVirgula.ForeColor = Color.WhiteSmoke;
            btnVirgula.Location = new Point(11, 339);
            btnVirgula.Margin = new Padding(3, 4, 3, 4);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(91, 100);
            btnVirgula.TabIndex = 8;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += enviarValor;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(55, 55, 76);
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.ForeColor = Color.WhiteSmoke;
            btn1.Location = new Point(11, 231);
            btn1.Margin = new Padding(3, 4, 3, 4);
            btn1.Name = "btn1";
            btn1.Size = new Size(91, 100);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += enviarValor;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(55, 55, 76);
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.ForeColor = Color.WhiteSmoke;
            btn2.Location = new Point(110, 231);
            btn2.Margin = new Padding(3, 4, 3, 4);
            btn2.Name = "btn2";
            btn2.Size = new Size(91, 100);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += enviarValor;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(55, 55, 76);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.WhiteSmoke;
            button7.Location = new Point(208, 231);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(91, 100);
            button7.TabIndex = 5;
            button7.Text = "3";
            button7.UseVisualStyleBackColor = false;
            button7.Click += enviarValor;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(55, 55, 76);
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.ForeColor = Color.WhiteSmoke;
            btn6.Location = new Point(208, 123);
            btn6.Margin = new Padding(3, 4, 3, 4);
            btn6.Name = "btn6";
            btn6.Size = new Size(91, 100);
            btn6.TabIndex = 4;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += enviarValor;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(55, 55, 76);
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.ForeColor = Color.WhiteSmoke;
            btn5.Location = new Point(110, 123);
            btn5.Margin = new Padding(3, 4, 3, 4);
            btn5.Name = "btn5";
            btn5.Size = new Size(91, 100);
            btn5.TabIndex = 3;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += enviarValor;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(55, 55, 76);
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.ForeColor = Color.WhiteSmoke;
            btn4.Location = new Point(11, 123);
            btn4.Margin = new Padding(3, 4, 3, 4);
            btn4.Name = "btn4";
            btn4.Size = new Size(91, 100);
            btn4.TabIndex = 2;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += enviarValor;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(55, 55, 76);
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.ForeColor = Color.WhiteSmoke;
            btn9.Location = new Point(208, 15);
            btn9.Margin = new Padding(3, 4, 3, 4);
            btn9.Name = "btn9";
            btn9.Size = new Size(91, 100);
            btn9.TabIndex = 1;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += enviarValor;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(55, 55, 76);
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.ForeColor = Color.WhiteSmoke;
            btn8.Location = new Point(110, 15);
            btn8.Margin = new Padding(3, 4, 3, 4);
            btn8.Name = "btn8";
            btn8.Size = new Size(91, 100);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += enviarValor;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(55, 55, 76);
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.ForeColor = Color.WhiteSmoke;
            btn7.Location = new Point(11, 15);
            btn7.Margin = new Padding(3, 4, 3, 4);
            btn7.Name = "btn7";
            btn7.Size = new Size(91, 100);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += enviarValor;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(55, 55, 76);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(891, 133);
            panel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Light", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(47, 35);
            label1.Name = "label1";
            label1.Size = new Size(544, 60);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de Formas";
            // 
            // radioTriangl
            // 
            radioTriangl.AutoSize = true;
            radioTriangl.Font = new Font("Bahnschrift", 36F, FontStyle.Bold, GraphicsUnit.Point);
            radioTriangl.ForeColor = Color.Black;
            radioTriangl.Location = new Point(106, 427);
            radioTriangl.Margin = new Padding(3, 4, 3, 4);
            radioTriangl.Name = "radioTriangl";
            radioTriangl.Size = new Size(300, 76);
            radioTriangl.TabIndex = 0;
            radioTriangl.Text = "Triangulo";
            radioTriangl.UseVisualStyleBackColor = true;
            radioTriangl.CheckedChanged += radioTriangl_CheckedChanged;
            // 
            // radioRetangulo
            // 
            radioRetangulo.AutoSize = true;
            radioRetangulo.Font = new Font("Bahnschrift", 36F, FontStyle.Bold, GraphicsUnit.Point);
            radioRetangulo.ForeColor = Color.Black;
            radioRetangulo.Location = new Point(108, 632);
            radioRetangulo.Margin = new Padding(3, 4, 3, 4);
            radioRetangulo.Name = "radioRetangulo";
            radioRetangulo.Size = new Size(322, 76);
            radioRetangulo.TabIndex = 1;
            radioRetangulo.Text = "Retangulo";
            radioRetangulo.UseVisualStyleBackColor = true;
            radioRetangulo.CheckedChanged += radioRetangulo_CheckedChanged;
            // 
            // radioQdrd
            // 
            radioQdrd.AutoSize = true;
            radioQdrd.Font = new Font("Bahnschrift", 36F, FontStyle.Bold, GraphicsUnit.Point);
            radioQdrd.ForeColor = Color.Black;
            radioQdrd.Location = new Point(108, 212);
            radioQdrd.Margin = new Padding(3, 4, 3, 4);
            radioQdrd.Name = "radioQdrd";
            radioQdrd.Size = new Size(310, 76);
            radioQdrd.TabIndex = 2;
            radioQdrd.Text = "Quadrado";
            radioQdrd.UseVisualStyleBackColor = true;
            radioQdrd.CheckedChanged += radioQdrd_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 39.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(13, 422);
            label2.Name = "label2";
            label2.Size = new Size(87, 81);
            label2.TabIndex = 3;
            label2.Text = "△";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 39.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(7, 635);
            label3.Name = "label3";
            label3.Size = new Size(95, 81);
            label3.TabIndex = 4;
            label3.Text = "▯";
            // 
            // txtResultT
            // 
            txtResultT.Enabled = false;
            txtResultT.Font = new Font("Bahnschrift", 36F, FontStyle.Bold, GraphicsUnit.Point);
            txtResultT.Location = new Point(436, 427);
            txtResultT.Margin = new Padding(3, 4, 3, 4);
            txtResultT.Name = "txtResultT";
            txtResultT.ReadOnly = true;
            txtResultT.Size = new Size(155, 80);
            txtResultT.TabIndex = 7;
            txtResultT.TextAlign = HorizontalAlignment.Right;
            txtResultT.TextChanged += txtResultT_TextChanged;
            // 
            // txtResultR
            // 
            txtResultR.Enabled = false;
            txtResultR.Font = new Font("Bahnschrift", 36F, FontStyle.Bold, GraphicsUnit.Point);
            txtResultR.Location = new Point(436, 631);
            txtResultR.Margin = new Padding(3, 4, 3, 4);
            txtResultR.Name = "txtResultR";
            txtResultR.ReadOnly = true;
            txtResultR.Size = new Size(155, 80);
            txtResultR.TabIndex = 8;
            txtResultR.TextAlign = HorizontalAlignment.Right;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkGray;
            panel5.Controls.Add(btnResetResult);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 797);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(891, 127);
            panel5.TabIndex = 9;
            // 
            // btnResetResult
            // 
            btnResetResult.BackColor = Color.FromArgb(55, 55, 76);
            btnResetResult.FlatAppearance.BorderSize = 0;
            btnResetResult.FlatStyle = FlatStyle.Flat;
            btnResetResult.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetResult.ForeColor = Color.Transparent;
            btnResetResult.Location = new Point(337, 54);
            btnResetResult.Margin = new Padding(3, 4, 3, 4);
            btnResetResult.Name = "btnResetResult";
            btnResetResult.Size = new Size(243, 45);
            btnResetResult.TabIndex = 19;
            btnResetResult.Text = "Resetar Resultados";
            btnResetResult.UseVisualStyleBackColor = false;
            btnResetResult.Click += btnResetResult_Click;
            // 
            // txtPerimR
            // 
            txtPerimR.Enabled = false;
            txtPerimR.Font = new Font("Bahnschrift", 36F, FontStyle.Bold, GraphicsUnit.Point);
            txtPerimR.Location = new Point(615, 631);
            txtPerimR.Margin = new Padding(3, 4, 3, 4);
            txtPerimR.Name = "txtPerimR";
            txtPerimR.ReadOnly = true;
            txtPerimR.Size = new Size(221, 80);
            txtPerimR.TabIndex = 13;
            txtPerimR.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPerimT
            // 
            txtPerimT.Enabled = false;
            txtPerimT.Font = new Font("Bahnschrift", 36F, FontStyle.Bold, GraphicsUnit.Point);
            txtPerimT.Location = new Point(615, 426);
            txtPerimT.Margin = new Padding(3, 4, 3, 4);
            txtPerimT.Name = "txtPerimT";
            txtPerimT.ReadOnly = true;
            txtPerimT.Size = new Size(221, 80);
            txtPerimT.TabIndex = 12;
            txtPerimT.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(615, 365);
            label7.Name = "label7";
            label7.Size = new Size(235, 57);
            label7.TabIndex = 16;
            label7.Text = "Perímetro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(455, 366);
            label8.Name = "label8";
            label8.Size = new Size(125, 57);
            label8.TabIndex = 15;
            label8.Text = "Área";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(615, 570);
            label9.Name = "label9";
            label9.Size = new Size(235, 57);
            label9.TabIndex = 18;
            label9.Text = "Perímetro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(455, 570);
            label10.Name = "label10";
            label10.Size = new Size(125, 57);
            label10.TabIndex = 17;
            label10.Text = "Área";
            // 
            // radioPergunta2
            // 
            radioPergunta2.AutoSize = true;
            radioPergunta2.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radioPergunta2.Location = new Point(106, 510);
            radioPergunta2.Name = "radioPergunta2";
            radioPergunta2.Size = new Size(292, 40);
            radioPergunta2.TabIndex = 19;
            radioPergunta2.TabStop = true;
            radioPergunta2.Text = "Calcular perímetro";
            radioPergunta2.UseVisualStyleBackColor = true;
            radioPergunta2.CheckedChanged += radioPergunta2_CheckedChanged_1;
            // 
            // txtPerimQ
            // 
            txtPerimQ.Enabled = false;
            txtPerimQ.Font = new Font("Bahnschrift", 36F, FontStyle.Bold, GraphicsUnit.Point);
            txtPerimQ.Location = new Point(615, 208);
            txtPerimQ.Margin = new Padding(3, 4, 3, 4);
            txtPerimQ.Name = "txtPerimQ";
            txtPerimQ.ReadOnly = true;
            txtPerimQ.Size = new Size(221, 80);
            txtPerimQ.TabIndex = 11;
            txtPerimQ.TextAlign = HorizontalAlignment.Right;
            // 
            // txtResultQ
            // 
            txtResultQ.Enabled = false;
            txtResultQ.Font = new Font("Bahnschrift", 36F, FontStyle.Bold, GraphicsUnit.Point);
            txtResultQ.Location = new Point(436, 208);
            txtResultQ.Margin = new Padding(3, 4, 3, 4);
            txtResultQ.Name = "txtResultQ";
            txtResultQ.ReadOnly = true;
            txtResultQ.Size = new Size(155, 80);
            txtResultQ.TabIndex = 6;
            txtResultQ.TextAlign = HorizontalAlignment.Right;
            txtResultQ.TextChanged += txtResultQ_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(615, 147);
            label4.Name = "label4";
            label4.Size = new Size(235, 57);
            label4.TabIndex = 21;
            label4.Text = "Perímetro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(455, 147);
            label5.Name = "label5";
            label5.Size = new Size(125, 57);
            label5.TabIndex = 20;
            label5.Text = "Área";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 39.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(13, 205);
            label6.Name = "label6";
            label6.Size = new Size(87, 81);
            label6.TabIndex = 22;
            label6.Text = "☐";
            // 
            // radioPergunta3
            // 
            radioPergunta3.AutoSize = true;
            radioPergunta3.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radioPergunta3.Location = new Point(108, 715);
            radioPergunta3.Name = "radioPergunta3";
            radioPergunta3.Size = new Size(292, 40);
            radioPergunta3.TabIndex = 23;
            radioPergunta3.TabStop = true;
            radioPergunta3.Text = "Calcular perímetro";
            radioPergunta3.UseVisualStyleBackColor = true;
            radioPergunta3.CheckedChanged += radioPergunta3_CheckedChanged;
            // 
            // radioPergunta1
            // 
            radioPergunta1.AutoSize = true;
            radioPergunta1.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radioPergunta1.Location = new Point(108, 295);
            radioPergunta1.Name = "radioPergunta1";
            radioPergunta1.Size = new Size(292, 40);
            radioPergunta1.TabIndex = 24;
            radioPergunta1.TabStop = true;
            radioPergunta1.Text = "Calcular perímetro";
            radioPergunta1.UseVisualStyleBackColor = true;
            radioPergunta1.CheckedChanged += radioPergunta1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1235, 924);
            Controls.Add(radioPergunta1);
            Controls.Add(radioPergunta3);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtResultQ);
            Controls.Add(radioQdrd);
            Controls.Add(txtPerimQ);
            Controls.Add(radioPergunta2);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtPerimR);
            Controls.Add(txtPerimT);
            Controls.Add(panel5);
            Controls.Add(txtResultR);
            Controls.Add(txtResultT);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel4);
            Controls.Add(radioTriangl);
            Controls.Add(radioRetangulo);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Calculadora";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnCalc;
        private Button btnDel;
        private Button button11;
        private Button btnVirgula;
        private Button btn1;
        private Button btn2;
        private Button button7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Panel panel4;
        private Label lblAltura;
        private Label lblLargura;
        private TextBox txtAltura;
        private TextBox txtLado;
        private Label label1;
        private RadioButton radioTriangl;
        private RadioButton radioRetangulo;
        private RadioButton radioQdrd;
        private Label lblBase;
        private TextBox txtBase;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private TextBox txtResultT;
        private TextBox txtResultR;
        private Panel panel5;
        private TextBox txtPerimR;
        private TextBox txtPerimT;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnResetResult;
        private RadioButton radioPergunta2;
        private TextBox txtPerimQ;
        private TextBox txtResultQ;
        private Label label4;
        private Label label5;
        private Label label6;
        private RadioButton radioPergunta3;
        private RadioButton radioPergunta1;
    }
}