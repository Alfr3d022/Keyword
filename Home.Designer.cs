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
            this.ptProdutos = new System.Windows.Forms.PictureBox();
            this.ptEstoque = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // ptProdutos
            // 
            this.ptProdutos.BackColor = System.Drawing.Color.Transparent;
            this.ptProdutos.BackgroundImage = global::Keyword.Properties.Resources.produtos;
            this.ptProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptProdutos.Location = new System.Drawing.Point(12, 76);
            this.ptProdutos.Name = "ptProdutos";
            this.ptProdutos.Size = new System.Drawing.Size(104, 35);
            this.ptProdutos.TabIndex = 0;
            this.ptProdutos.TabStop = false;
            // 
            // ptEstoque
            // 
            this.ptEstoque.BackColor = System.Drawing.Color.Transparent;
            this.ptEstoque.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptEstoque.BackgroundImage")));
            this.ptEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptEstoque.Location = new System.Drawing.Point(4, 139);
            this.ptEstoque.Name = "ptEstoque";
            this.ptEstoque.Size = new System.Drawing.Size(112, 38);
            this.ptEstoque.TabIndex = 1;
            this.ptEstoque.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 462);
            this.Controls.Add(this.ptEstoque);
            this.Controls.Add(this.ptProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.ptProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox ptProdutos;
        private PictureBox ptEstoque;
    }
}