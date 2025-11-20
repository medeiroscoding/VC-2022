namespace MeuDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSair = new Button();
            panelLogin = new Panel();
            button2 = new Button();
            btnLogin = new Button();
            textBox2 = new TextBox();
            panelTitle = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            panelLogin.SuspendLayout();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Black;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Copperplate Gothic Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.ForeColor = Color.Transparent;
            btnSair.Location = new Point(627, 5);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(25, 34);
            btnSair.TabIndex = 2;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // panelLogin
            // 
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(textBox1);
            panelLogin.Controls.Add(button2);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(textBox2);
            panelLogin.Location = new Point(137, 159);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(388, 155);
            panelLogin.TabIndex = 0;
            panelLogin.Paint += panelLogin_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(20, 20, 20);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Gray;
            button2.Location = new Point(196, 109);
            button2.Name = "button2";
            button2.Size = new Size(94, 32);
            button2.TabIndex = 3;
            button2.Text = "register";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(20, 20, 20);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Gray;
            btnLogin.Location = new Point(96, 109);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 32);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(20, 20, 20);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Bahnschrift Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(96, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 28);
            textBox2.TabIndex = 1;
            textBox2.Text = "password";
            textBox2.Click += textBox2_Click;
            // 
            // panelTitle
            // 
            panelTitle.BorderStyle = BorderStyle.FixedSingle;
            panelTitle.Controls.Add(label1);
            panelTitle.Location = new Point(137, 109);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(388, 51);
            panelTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(124, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 34);
            label1.TabIndex = 0;
            label1.Text = "login page";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(20, 20, 20);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Bahnschrift Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(96, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 28);
            textBox1.TabIndex = 4;
            textBox1.Text = "password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(654, 405);
            ControlBox = false;
            Controls.Add(btnSair);
            Controls.Add(panelTitle);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".";
            Load += Form1_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSair;
        private Panel panelLogin;
        private Button button2;
        private Button btnLogin;
        private TextBox textBox2;
        private Panel panelTitle;
        private Label label1;
        private TextBox textBox1;
    }
}
