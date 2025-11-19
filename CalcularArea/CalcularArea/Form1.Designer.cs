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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBase = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblLargura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioTriangl = new System.Windows.Forms.RadioButton();
            this.radioRetangulo = new System.Windows.Forms.RadioButton();
            this.radioQdrd = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultQ = new System.Windows.Forms.TextBox();
            this.txtResultT = new System.Windows.Forms.TextBox();
            this.txtResultR = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnResetResult = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPerimR = new System.Windows.Forms.TextBox();
            this.txtPerimT = new System.Windows.Forms.TextBox();
            this.txtPerimQ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.lblBase);
            this.panel1.Controls.Add(this.txtBase);
            this.panel1.Controls.Add(this.lblAltura);
            this.panel1.Controls.Add(this.lblLargura);
            this.panel1.Controls.Add(this.txtAltura);
            this.panel1.Controls.Add(this.txtLado);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(499, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 605);
            this.panel1.TabIndex = 0;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBase.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBase.Location = new System.Drawing.Point(40, 109);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(52, 23);
            this.lblBase.TabIndex = 7;
            this.lblBase.Text = "Base";
            // 
            // txtBase
            // 
            this.txtBase.Enabled = false;
            this.txtBase.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBase.ForeColor = System.Drawing.Color.Black;
            this.txtBase.Location = new System.Drawing.Point(143, 110);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(123, 30);
            this.txtBase.TabIndex = 6;
            this.txtBase.Enter += new System.EventHandler(this.corRDMBase);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAltura.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAltura.Location = new System.Drawing.Point(40, 180);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(63, 23);
            this.lblAltura.TabIndex = 5;
            this.lblAltura.Text = "Altura";
            // 
            // lblLargura
            // 
            this.lblLargura.AutoSize = true;
            this.lblLargura.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLargura.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLargura.Location = new System.Drawing.Point(40, 145);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(51, 23);
            this.lblLargura.TabIndex = 4;
            this.lblLargura.Text = "Lado";
            // 
            // txtAltura
            // 
            this.txtAltura.Enabled = false;
            this.txtAltura.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAltura.ForeColor = System.Drawing.Color.Black;
            this.txtAltura.Location = new System.Drawing.Point(143, 180);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(123, 30);
            this.txtAltura.TabIndex = 3;
            this.txtAltura.Enter += new System.EventHandler(this.corRDMAltr);
            // 
            // txtLado
            // 
            this.txtLado.Enabled = false;
            this.txtLado.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLado.ForeColor = System.Drawing.Color.Transparent;
            this.txtLado.Location = new System.Drawing.Point(143, 145);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(123, 30);
            this.txtLado.TabIndex = 2;
            this.txtLado.Enter += new System.EventHandler(this.corRDMLgr);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 100);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(19, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ativar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnCalc);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.btnVirgula);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.btn6);
            this.panel2.Controls.Add(this.btn5);
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Controls.Add(this.btn9);
            this.panel2.Controls.Add(this.btn8);
            this.panel2.Controls.Add(this.btn7);
            this.panel2.Location = new System.Drawing.Point(14, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 374);
            this.panel2.TabIndex = 0;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalc.Location = new System.Drawing.Point(10, 335);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(252, 31);
            this.btnCalc.TabIndex = 11;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDel.Location = new System.Drawing.Point(182, 254);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(80, 75);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button11.Location = new System.Drawing.Point(96, 254);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 75);
            this.button11.TabIndex = 9;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.enviarValor);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.btnVirgula.FlatAppearance.BorderSize = 0;
            this.btnVirgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVirgula.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVirgula.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVirgula.Location = new System.Drawing.Point(10, 254);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(80, 75);
            this.btnVirgula.TabIndex = 8;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.enviarValor);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn1.Location = new System.Drawing.Point(10, 173);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 75);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.enviarValor);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn2.Location = new System.Drawing.Point(96, 173);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 75);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.enviarValor);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Location = new System.Drawing.Point(182, 173);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 75);
            this.button7.TabIndex = 5;
            this.button7.Text = "3";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.enviarValor);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn6.Location = new System.Drawing.Point(182, 92);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 75);
            this.btn6.TabIndex = 4;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.enviarValor);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn5.Location = new System.Drawing.Point(96, 92);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 75);
            this.btn5.TabIndex = 3;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.enviarValor);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn4.Location = new System.Drawing.Point(10, 92);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 75);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.enviarValor);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn9.Location = new System.Drawing.Point(182, 11);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(80, 75);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.enviarValor);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn8.Location = new System.Drawing.Point(96, 11);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 75);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.enviarValor);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn7.Location = new System.Drawing.Point(10, 11);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 75);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.enviarValor);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(499, 100);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de Formas";
            // 
            // radioTriangl
            // 
            this.radioTriangl.AutoSize = true;
            this.radioTriangl.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioTriangl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.radioTriangl.Location = new System.Drawing.Point(71, 265);
            this.radioTriangl.Name = "radioTriangl";
            this.radioTriangl.Size = new System.Drawing.Size(182, 46);
            this.radioTriangl.TabIndex = 0;
            this.radioTriangl.Text = "Triangulo";
            this.radioTriangl.UseVisualStyleBackColor = true;
            this.radioTriangl.CheckedChanged += new System.EventHandler(this.radioTriangl_CheckedChanged);
            // 
            // radioRetangulo
            // 
            this.radioRetangulo.AutoSize = true;
            this.radioRetangulo.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioRetangulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.radioRetangulo.Location = new System.Drawing.Point(70, 394);
            this.radioRetangulo.Name = "radioRetangulo";
            this.radioRetangulo.Size = new System.Drawing.Size(194, 46);
            this.radioRetangulo.TabIndex = 1;
            this.radioRetangulo.Text = "Retangulo";
            this.radioRetangulo.UseVisualStyleBackColor = true;
            this.radioRetangulo.CheckedChanged += new System.EventHandler(this.radioRetangulo_CheckedChanged);
            // 
            // radioQdrd
            // 
            this.radioQdrd.AutoSize = true;
            this.radioQdrd.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioQdrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.radioQdrd.Location = new System.Drawing.Point(66, 148);
            this.radioQdrd.Name = "radioQdrd";
            this.radioQdrd.Size = new System.Drawing.Size(188, 46);
            this.radioQdrd.TabIndex = 2;
            this.radioQdrd.Text = "Quadrado";
            this.radioQdrd.UseVisualStyleBackColor = true;
            this.radioQdrd.CheckedChanged += new System.EventHandler(this.radioQdrd_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(1, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 64);
            this.label2.TabIndex = 3;
            this.label2.Text = "△";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(-3, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 64);
            this.label3.TabIndex = 4;
            this.label3.Text = "▯";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(-1, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 64);
            this.label4.TabIndex = 5;
            this.label4.Text = "□";
            // 
            // txtResultQ
            // 
            this.txtResultQ.Enabled = false;
            this.txtResultQ.Font = new System.Drawing.Font("Bahnschrift Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultQ.Location = new System.Drawing.Point(256, 146);
            this.txtResultQ.Name = "txtResultQ";
            this.txtResultQ.ReadOnly = true;
            this.txtResultQ.Size = new System.Drawing.Size(100, 50);
            this.txtResultQ.TabIndex = 6;
            // 
            // txtResultT
            // 
            this.txtResultT.Enabled = false;
            this.txtResultT.Font = new System.Drawing.Font("Bahnschrift Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultT.Location = new System.Drawing.Point(256, 263);
            this.txtResultT.Name = "txtResultT";
            this.txtResultT.ReadOnly = true;
            this.txtResultT.Size = new System.Drawing.Size(100, 50);
            this.txtResultT.TabIndex = 7;
            this.txtResultT.TextChanged += new System.EventHandler(this.txtResultT_TextChanged);
            // 
            // txtResultR
            // 
            this.txtResultR.Enabled = false;
            this.txtResultR.Font = new System.Drawing.Font("Bahnschrift Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultR.Location = new System.Drawing.Point(255, 392);
            this.txtResultR.Name = "txtResultR";
            this.txtResultR.ReadOnly = true;
            this.txtResultR.Size = new System.Drawing.Size(100, 50);
            this.txtResultR.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.btnResetResult);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 510);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(499, 95);
            this.panel5.TabIndex = 9;
            // 
            // btnResetResult
            // 
            this.btnResetResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.btnResetResult.FlatAppearance.BorderSize = 0;
            this.btnResetResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetResult.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetResult.ForeColor = System.Drawing.Color.Transparent;
            this.btnResetResult.Location = new System.Drawing.Point(143, 32);
            this.btnResetResult.Name = "btnResetResult";
            this.btnResetResult.Size = new System.Drawing.Size(213, 34);
            this.btnResetResult.TabIndex = 19;
            this.btnResetResult.Text = "Resetar";
            this.btnResetResult.UseVisualStyleBackColor = false;
            this.btnResetResult.Click += new System.EventHandler(this.btnResetResult_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(278, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Área";
            // 
            // txtPerimR
            // 
            this.txtPerimR.Enabled = false;
            this.txtPerimR.Font = new System.Drawing.Font("Bahnschrift Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPerimR.Location = new System.Drawing.Point(380, 392);
            this.txtPerimR.Name = "txtPerimR";
            this.txtPerimR.ReadOnly = true;
            this.txtPerimR.Size = new System.Drawing.Size(100, 50);
            this.txtPerimR.TabIndex = 13;
            // 
            // txtPerimT
            // 
            this.txtPerimT.Enabled = false;
            this.txtPerimT.Font = new System.Drawing.Font("Bahnschrift Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPerimT.Location = new System.Drawing.Point(381, 263);
            this.txtPerimT.Name = "txtPerimT";
            this.txtPerimT.ReadOnly = true;
            this.txtPerimT.Size = new System.Drawing.Size(100, 50);
            this.txtPerimT.TabIndex = 12;
            // 
            // txtPerimQ
            // 
            this.txtPerimQ.Enabled = false;
            this.txtPerimQ.Font = new System.Drawing.Font("Bahnschrift Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPerimQ.Location = new System.Drawing.Point(381, 146);
            this.txtPerimQ.Name = "txtPerimQ";
            this.txtPerimQ.ReadOnly = true;
            this.txtPerimQ.Size = new System.Drawing.Size(100, 50);
            this.txtPerimQ.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(381, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Perímetro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(381, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Perímetro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(278, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Área";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(380, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Perímetro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(277, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Área";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPerimR);
            this.Controls.Add(this.txtPerimT);
            this.Controls.Add(this.txtPerimQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtResultR);
            this.Controls.Add(this.txtResultT);
            this.Controls.Add(this.txtResultQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioQdrd);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.radioTriangl);
            this.Controls.Add(this.radioRetangulo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label label4;
        private TextBox txtResultQ;
        private TextBox txtResultT;
        private TextBox txtResultR;
        private Panel panel5;
        private Button button1;
        private Label label5;
        private TextBox txtPerimR;
        private TextBox txtPerimT;
        private TextBox txtPerimQ;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnResetResult;
    }
}