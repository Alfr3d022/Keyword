namespace Keyword
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pbProdutos = new PictureBox();
            pbEstoque = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEstoque).BeginInit();
            SuspendLayout();
            // 
            // pbProdutos
            // 
            pbProdutos.BackColor = Color.Transparent;
            pbProdutos.BackgroundImage = Properties.Resources.produtos;
            pbProdutos.BackgroundImageLayout = ImageLayout.Zoom;
            pbProdutos.Cursor = Cursors.Hand;
            pbProdutos.Location = new Point(12, 76);
            pbProdutos.Name = "pbProdutos";
            pbProdutos.Size = new Size(104, 35);
            pbProdutos.TabIndex = 0;
            pbProdutos.TabStop = false;
            pbProdutos.Click += ptProdutos_Click;
            // 
            // pbEstoque
            // 
            pbEstoque.BackColor = Color.Transparent;
            pbEstoque.BackgroundImage = (Image)resources.GetObject("pbEstoque.BackgroundImage");
            pbEstoque.BackgroundImageLayout = ImageLayout.Zoom;
            pbEstoque.Cursor = Cursors.Hand;
            pbEstoque.Location = new Point(4, 139);
            pbEstoque.Name = "pbEstoque";
            pbEstoque.Size = new Size(112, 38);
            pbEstoque.TabIndex = 1;
            pbEstoque.TabStop = false;
            pbEstoque.Click += ptEstoque_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pbEstoque);
            Controls.Add(pbProdutos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pbProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEstoque).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbProdutos;
        private PictureBox pbEstoque;
    }
}