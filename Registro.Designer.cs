namespace Keyword
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            label1 = new Label();
            btnRegistrar = new Button();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            txtLogar = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(299, 184);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 8;
            label1.Text = "Registrar";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(20, 10, 137);
            btnRegistrar.BackgroundImage = Properties.Resources.blue;
            btnRegistrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(431, 277);
            btnRegistrar.Margin = new Padding(0);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.AccessibleDescription = "";
            txtSenha.Location = new Point(299, 248);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(207, 23);
            txtSenha.TabIndex = 6;
            txtSenha.Tag = "";
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(299, 202);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(207, 23);
            txtUsuario.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 7.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(299, 321);
            label2.Name = "label2";
            label2.Size = new Size(139, 26);
            label2.TabIndex = 9;
            label2.Text = "Já possui um cadastro?\r\nClique em \r\n";
            // 
            // txtLogar
            // 
            txtLogar.AutoSize = true;
            txtLogar.BackColor = Color.Transparent;
            txtLogar.Cursor = Cursors.Hand;
            txtLogar.Font = new Font("Microsoft Sans Serif", 7.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtLogar.ForeColor = Color.DodgerBlue;
            txtLogar.Location = new Point(361, 334);
            txtLogar.Name = "txtLogar";
            txtLogar.Size = new Size(35, 13);
            txtLogar.TabIndex = 10;
            txtLogar.Text = "logar";
            txtLogar.Click += txtLogar_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLogar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegistrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            DoubleBuffered = true;
            Name = "Registro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegistrar;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label label2;
        private Label txtLogar;
    }
}