namespace Keyword
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnLogar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(296, 208);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(207, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.AccessibleDescription = "";
            txtSenha.Location = new Point(296, 254);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(207, 23);
            txtSenha.TabIndex = 2;
            txtSenha.Tag = "";
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnLogar
            // 
            btnLogar.BackColor = Color.FromArgb(20, 10, 137);
            btnLogar.BackgroundImage = Properties.Resources.blue;
            btnLogar.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogar.FlatStyle = FlatStyle.Popup;
            btnLogar.ForeColor = Color.White;
            btnLogar.Location = new Point(428, 283);
            btnLogar.Margin = new Padding(0);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(75, 23);
            btnLogar.TabIndex = 3;
            btnLogar.Text = "Login";
            btnLogar.UseVisualStyleBackColor = false;
            btnLogar.Click += btnLogar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(296, 190);
            label1.Name = "label1";
            label1.Size = new Size(43, 16);
            label1.TabIndex = 4;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(296, 235);
            label2.Name = "label2";
            label2.Size = new Size(48, 16);
            label2.TabIndex = 5;
            label2.Text = "Senha";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnLogar;
        private Label label1;
        private Label label2;
    }
}