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
            btnEfetuarMov = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rTextDescricao = new RichTextBox();
            cbTipoMovimentacao = new ComboBox();
            txtQuantidade = new TextBox();
            txtCodProduto = new TextBox();
            dtGridProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pbVoltarHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGridProdutos).BeginInit();
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
            // btnEfetuarMov
            // 
            btnEfetuarMov.BackgroundImage = (Image)resources.GetObject("btnEfetuarMov.BackgroundImage");
            btnEfetuarMov.FlatStyle = FlatStyle.Flat;
            btnEfetuarMov.ForeColor = Color.WhiteSmoke;
            btnEfetuarMov.Location = new Point(620, 251);
            btnEfetuarMov.Name = "btnEfetuarMov";
            btnEfetuarMov.Size = new Size(87, 40);
            btnEfetuarMov.TabIndex = 30;
            btnEfetuarMov.Text = "Efetuar";
            btnEfetuarMov.UseVisualStyleBackColor = true;
            btnEfetuarMov.Click += btnEfetuarMov_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 154);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 29;
            label4.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(445, 95);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 28;
            label3.Text = "Tipo de movimentação";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 95);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 27;
            label2.Text = "Quantidade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 26;
            label1.Text = "Código do produto:";
            // 
            // rTextDescricao
            // 
            rTextDescricao.BorderStyle = BorderStyle.FixedSingle;
            rTextDescricao.Location = new Point(12, 172);
            rTextDescricao.Name = "rTextDescricao";
            rTextDescricao.Size = new Size(586, 119);
            rTextDescricao.TabIndex = 25;
            rTextDescricao.Text = "";
            // 
            // cbTipoMovimentacao
            // 
            cbTipoMovimentacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoMovimentacao.FormattingEnabled = true;
            cbTipoMovimentacao.Items.AddRange(new object[] { "Entrada", "Saída" });
            cbTipoMovimentacao.Location = new Point(445, 113);
            cbTipoMovimentacao.Name = "cbTipoMovimentacao";
            cbTipoMovimentacao.Size = new Size(153, 23);
            cbTipoMovimentacao.TabIndex = 24;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(234, 113);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(154, 23);
            txtQuantidade.TabIndex = 23;
            // 
            // txtCodProduto
            // 
            txtCodProduto.Location = new Point(12, 113);
            txtCodProduto.Name = "txtCodProduto";
            txtCodProduto.Size = new Size(155, 23);
            txtCodProduto.TabIndex = 22;
            // 
            // dtGridProdutos
            // 
            dtGridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridProdutos.Location = new Point(12, 312);
            dtGridProdutos.Name = "dtGridProdutos";
            dtGridProdutos.RowTemplate.Height = 25;
            dtGridProdutos.Size = new Size(776, 173);
            dtGridProdutos.TabIndex = 31;
            // 
            // Movimentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 492);
            Controls.Add(dtGridProdutos);
            Controls.Add(btnEfetuarMov);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rTextDescricao);
            Controls.Add(cbTipoMovimentacao);
            Controls.Add(txtQuantidade);
            Controls.Add(txtCodProduto);
            Controls.Add(pbVoltarHome);
            Controls.Add(pictureBox1);
            Name = "Movimentacao";
            Text = "Movimentação";
            Load += Movimentacao_Load;
            ((System.ComponentModel.ISupportInitialize)pbVoltarHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGridProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbVoltarHome;
        private PictureBox pictureBox1;
        private Button btnEfetuarMov;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox rTextDescricao;
        private ComboBox cbTipoMovimentacao;
        private TextBox txtQuantidade;
        private TextBox txtCodProduto;
        private DataGridView dtGridProdutos;
    }
}