namespace Keyword
{
    partial class FrmHistorico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorico));
            label1 = new Label();
            dtGridMov = new DataGridView();
            pbVoltarHome = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtGridMov).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVoltarHome).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(306, 9);
            label1.Name = "label1";
            label1.Size = new Size(387, 41);
            label1.TabIndex = 0;
            label1.Text = "Movimentação de produtos";
            // 
            // dtGridMov
            // 
            dtGridMov.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGridMov.BackgroundColor = SystemColors.ButtonFace;
            dtGridMov.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridMov.Location = new Point(12, 110);
            dtGridMov.Name = "dtGridMov";
            dtGridMov.ReadOnly = true;
            dtGridMov.RowHeadersVisible = false;
            dtGridMov.RowTemplate.Height = 25;
            dtGridMov.Size = new Size(1010, 539);
            dtGridMov.TabIndex = 1;
            // 
            // pbVoltarHome
            // 
            pbVoltarHome.BackColor = Color.Transparent;
            pbVoltarHome.BackgroundImage = (Image)resources.GetObject("pbVoltarHome.BackgroundImage");
            pbVoltarHome.BackgroundImageLayout = ImageLayout.Stretch;
            pbVoltarHome.Cursor = Cursors.Hand;
            pbVoltarHome.Location = new Point(12, 74);
            pbVoltarHome.Name = "pbVoltarHome";
            pbVoltarHome.Size = new Size(73, 30);
            pbVoltarHome.TabIndex = 11;
            pbVoltarHome.TabStop = false;
            pbVoltarHome.Click += pbVoltarHome_Click;
            // 
            // FrmHistorico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1034, 661);
            Controls.Add(pbVoltarHome);
            Controls.Add(dtGridMov);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "FrmHistorico";
            Text = "FrmHistorico";
            Load += FrmHistorico_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridMov).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVoltarHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtGridMov;
        private PictureBox pbVoltarHome;
    }
}