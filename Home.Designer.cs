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
            ptProdutos = new PictureBox();
            ptEstoque = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptEstoque).BeginInit();
            SuspendLayout();
            // 
            // ptProdutos
            // 
            ptProdutos.BackColor = Color.Transparent;
            ptProdutos.BackgroundImage = Properties.Resources.produtos;
            ptProdutos.BackgroundImageLayout = ImageLayout.Zoom;
            ptProdutos.Cursor = Cursors.Hand;
            ptProdutos.Location = new Point(12, 76);
            ptProdutos.Name = "ptProdutos";
            ptProdutos.Size = new Size(104, 35);
            ptProdutos.TabIndex = 0;
            ptProdutos.TabStop = false;
            ptProdutos.Click += ptProdutos_Click;
            // 
            // ptEstoque
            // 
            ptEstoque.BackColor = Color.Transparent;
            ptEstoque.BackgroundImage = (Image)resources.GetObject("ptEstoque.BackgroundImage");
            ptEstoque.BackgroundImageLayout = ImageLayout.Zoom;
            ptEstoque.Cursor = Cursors.Hand;
            ptEstoque.Location = new Point(4, 139);
            ptEstoque.Name = "ptEstoque";
            ptEstoque.Size = new Size(112, 38);
            ptEstoque.TabIndex = 1;
            ptEstoque.TabStop = false;
            ptEstoque.Click += ptEstoque_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(ptEstoque);
            Controls.Add(ptProdutos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)ptProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptEstoque).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptProdutos;
        private PictureBox ptEstoque;
    }
}