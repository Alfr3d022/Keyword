namespace Keyword
{
    partial class FrmCadastrarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarProdutos));
            label1 = new Label();
            txtNomeProd = new TextBox();
            txtCategoriaProd = new TextBox();
            label2 = new Label();
            txtDescProdutos = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cbUnidade = new ComboBox();
            btnSalvar = new Button();
            pbVoltarHome = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbVoltarHome).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(199, 121);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome produto";
            // 
            // txtNomeProd
            // 
            txtNomeProd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeProd.Location = new Point(199, 149);
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.Size = new Size(379, 29);
            txtNomeProd.TabIndex = 1;
            // 
            // txtCategoriaProd
            // 
            txtCategoriaProd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoriaProd.Location = new Point(199, 249);
            txtCategoriaProd.Name = "txtCategoriaProd";
            txtCategoriaProd.Size = new Size(205, 29);
            txtCategoriaProd.TabIndex = 3;
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(199, 221);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 2;
            label2.Text = "Categoria produto";
            // 
            // txtDescProdutos
            // 
            txtDescProdutos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescProdutos.Location = new Point(199, 393);
            txtDescProdutos.Multiline = true;
            txtDescProdutos.Name = "txtDescProdutos";
            txtDescProdutos.Size = new Size(638, 135);
            txtDescProdutos.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(199, 365);
            label3.Name = "label3";
            label3.Size = new Size(167, 25);
            label3.TabIndex = 4;
            label3.Text = "Descrição produto";
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(646, 121);
            label4.Name = "label4";
            label4.Size = new Size(177, 25);
            label4.TabIndex = 6;
            label4.Text = "Unidade de medida";
            // 
            // cbUnidade
            // 
            cbUnidade.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbUnidade.FormattingEnabled = true;
            cbUnidade.Items.AddRange(new object[] { "M", "KM", "CM", "MM", "IN", "FT", "YD", "MI", "KG", "G", "MG", "T", "LB", "OZ", "L", "ML", "GAL", "OZ (fluid)" });
            cbUnidade.Location = new Point(646, 149);
            cbUnidade.Name = "cbUnidade";
            cbUnidade.Size = new Size(177, 33);
            cbUnidade.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Location = new Point(804, 553);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(124, 45);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // pbVoltarHome
            // 
            pbVoltarHome.BackColor = Color.Transparent;
            pbVoltarHome.BackgroundImage = (Image)resources.GetObject("pbVoltarHome.BackgroundImage");
            pbVoltarHome.BackgroundImageLayout = ImageLayout.Stretch;
            pbVoltarHome.Image = (Image)resources.GetObject("pbVoltarHome.Image");
            pbVoltarHome.Location = new Point(0, 56);
            pbVoltarHome.Name = "pbVoltarHome";
            pbVoltarHome.Size = new Size(70, 29);
            pbVoltarHome.TabIndex = 9;
            pbVoltarHome.TabStop = false;
            pbVoltarHome.Click += pbVoltarHome_Click_1;
            // 
            // FrmCadastrarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Lista;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1034, 661);
            Controls.Add(pbVoltarHome);
            Controls.Add(btnSalvar);
            Controls.Add(cbUnidade);
            Controls.Add(label4);
            Controls.Add(txtDescProdutos);
            Controls.Add(label3);
            Controls.Add(txtCategoriaProd);
            Controls.Add(label2);
            Controls.Add(txtNomeProd);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmCadastrarProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCadastrarProdutos";
            ((System.ComponentModel.ISupportInitialize)pbVoltarHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomeProd;
        private TextBox txtCategoriaProd;
        private Label label2;
        private TextBox txtDescProdutos;
        private Label label3;
        private Label label4;
        private ComboBox cbUnidade;
        private Button btnSalvar;
        private PictureBox pbVoltarHome;
    }
}