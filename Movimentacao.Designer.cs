namespace Keyword
{
    partial class Movimentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movimentacao));
            pbVoltarHome = new PictureBox();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnEfetuarMov = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rTextDescricao = new RichTextBox();
            cbTipoMovimentacao = new ComboBox();
            txtQuantidade = new TextBox();
            txtCodProduto = new TextBox();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)pbVoltarHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // pbVoltarHome
            // 
            pbVoltarHome.BackColor = Color.Transparent;
            pbVoltarHome.BackgroundImage = (Image)resources.GetObject("pbVoltarHome.BackgroundImage");
            pbVoltarHome.BackgroundImageLayout = ImageLayout.Stretch;
            pbVoltarHome.Cursor = Cursors.Hand;
            pbVoltarHome.Location = new Point(0, 51);
            pbVoltarHome.Name = "pbVoltarHome";
            pbVoltarHome.Size = new Size(73, 30);
            pbVoltarHome.TabIndex = 10;
            pbVoltarHome.TabStop = false;
            pbVoltarHome.Click += pbVoltarHome_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 55);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 77);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 345);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(btnEfetuarMov);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(rTextDescricao);
            tabPage1.Controls.Add(cbTipoMovimentacao);
            tabPage1.Controls.Add(txtQuantidade);
            tabPage1.Controls.Add(txtCodProduto);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 317);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Movimentação";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEfetuarMov
            // 
            btnEfetuarMov.BackgroundImage = (Image)resources.GetObject("btnEfetuarMov.BackgroundImage");
            btnEfetuarMov.FlatStyle = FlatStyle.Flat;
            btnEfetuarMov.ForeColor = Color.WhiteSmoke;
            btnEfetuarMov.Location = new Point(361, 257);
            btnEfetuarMov.Name = "btnEfetuarMov";
            btnEfetuarMov.Size = new Size(87, 40);
            btnEfetuarMov.TabIndex = 21;
            btnEfetuarMov.Text = "Efetuar";
            btnEfetuarMov.UseVisualStyleBackColor = true;
            btnEfetuarMov.Click += btnEfetuarMov_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 102);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 20;
            label4.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(541, 43);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 19;
            label3.Text = "Tipo de movimentação";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 43);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 18;
            label2.Text = "Quantidade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 43);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 17;
            label1.Text = "Código do produto:";
            // 
            // rTextDescricao
            // 
            rTextDescricao.BorderStyle = BorderStyle.FixedSingle;
            rTextDescricao.Location = new Point(108, 120);
            rTextDescricao.Name = "rTextDescricao";
            rTextDescricao.Size = new Size(586, 119);
            rTextDescricao.TabIndex = 16;
            rTextDescricao.Text = "";
            // 
            // cbTipoMovimentacao
            // 
            cbTipoMovimentacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoMovimentacao.FormattingEnabled = true;
            cbTipoMovimentacao.Items.AddRange(new object[] { "Entrada", "Saída" });
            cbTipoMovimentacao.Location = new Point(541, 61);
            cbTipoMovimentacao.Name = "cbTipoMovimentacao";
            cbTipoMovimentacao.Size = new Size(153, 23);
            cbTipoMovimentacao.TabIndex = 15;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(330, 61);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(154, 23);
            txtQuantidade.TabIndex = 14;
            // 
            // txtCodProduto
            // 
            txtCodProduto.Location = new Point(108, 61);
            txtCodProduto.Name = "txtCodProduto";
            txtCodProduto.Size = new Size(155, 23);
            txtCodProduto.TabIndex = 13;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 317);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Histórico";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Movimentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(pbVoltarHome);
            Controls.Add(pictureBox1);
            Name = "Movimentacao";
            Text = "Movimentação";
            ((System.ComponentModel.ISupportInitialize)pbVoltarHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbVoltarHome;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnEfetuarMov;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox rTextDescricao;
        private ComboBox cbTipoMovimentacao;
        private TextBox txtQuantidade;
        private TextBox txtCodProduto;
        private TabPage tabPage2;
    }
}