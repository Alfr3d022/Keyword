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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnLogar1 = new Button();
            label1 = new Label();
            epLogin = new ErrorProvider(components);
            label2 = new Label();
            txtRegistrar = new Label();
            ((System.ComponentModel.ISupportInitialize)epLogin).BeginInit();
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
            // btnLogar1
            // 
            btnLogar1.BackColor = Color.FromArgb(20, 10, 137);
            btnLogar1.BackgroundImage = Properties.Resources.blue;
            btnLogar1.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogar1.FlatStyle = FlatStyle.Popup;
            btnLogar1.ForeColor = Color.White;
            btnLogar1.Location = new Point(428, 283);
            btnLogar1.Margin = new Padding(0);
            btnLogar1.Name = "btnLogar1";
            btnLogar1.Size = new Size(75, 23);
            btnLogar1.TabIndex = 3;
            btnLogar1.Text = "Login";
            btnLogar1.UseVisualStyleBackColor = false;
            btnLogar1.Click += btnLogar1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(296, 190);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "Login";
            // 
            // epLogin
            // 
            epLogin.BlinkRate = 400;
            epLogin.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 7.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(296, 322);
            label2.Name = "label2";
            label2.Size = new Size(183, 26);
            label2.TabIndex = 5;
            label2.Text = "Ainda não possui um cadastro?\r\nClique em \r\n";
            // 
            // txtRegistrar
            // 
            txtRegistrar.AutoSize = true;
            txtRegistrar.BackColor = Color.Transparent;
            txtRegistrar.Cursor = Cursors.Hand;
            txtRegistrar.Font = new Font("Microsoft Sans Serif", 7.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtRegistrar.ForeColor = Color.DodgerBlue;
            txtRegistrar.Location = new Point(358, 335);
            txtRegistrar.Name = "txtRegistrar";
            txtRegistrar.Size = new Size(53, 13);
            txtRegistrar.TabIndex = 6;
            txtRegistrar.Text = "registrar";
            txtRegistrar.Click += txtRegistrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRegistrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogar1);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)epLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnLogar1;
        private Label label1;
        private ErrorProvider epLogin;
        private Label txtRegistrar;
        private Label label2;
    }
}