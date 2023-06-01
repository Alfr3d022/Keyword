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
            this.pbProdutos = new System.Windows.Forms.PictureBox();
            this.pbEstoque = new System.Windows.Forms.PictureBox();
            this.pbHistorico = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProdutos
            // 
            this.pbProdutos.BackColor = System.Drawing.Color.Transparent;
            this.pbProdutos.BackgroundImage = global::Keyword.Properties.Resources.produtos;
            this.pbProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProdutos.Location = new System.Drawing.Point(12, 76);
            this.pbProdutos.Name = "pbProdutos";
            this.pbProdutos.Size = new System.Drawing.Size(104, 35);
            this.pbProdutos.TabIndex = 0;
            this.pbProdutos.TabStop = false;
            // 
            // pbEstoque
            // 
            this.pbEstoque.BackColor = System.Drawing.Color.Transparent;
            this.pbEstoque.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbEstoque.BackgroundImage")));
            this.pbEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEstoque.Location = new System.Drawing.Point(4, 139);
            this.pbEstoque.Name = "pbEstoque";
            this.pbEstoque.Size = new System.Drawing.Size(112, 38);
            this.pbEstoque.TabIndex = 1;
            this.pbEstoque.TabStop = false;
            this.pbEstoque.Click += new System.EventHandler(this.pbEstoque_Click);
            // 
            // pbHistorico
            // 
            this.pbHistorico.Location = new System.Drawing.Point(4, 204);
            this.pbHistorico.Name = "pbHistorico";
            this.pbHistorico.Size = new System.Drawing.Size(112, 36);
            this.pbHistorico.TabIndex = 2;
            this.pbHistorico.TabStop = false;
            this.pbHistorico.Click += new System.EventHandler(this.pbHistorico_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbHistorico);
            this.Controls.Add(this.pbEstoque);
            this.Controls.Add(this.pbProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pbProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbProdutos;
        private PictureBox pbEstoque;
        private PictureBox pbHistorico;
    }
}