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
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridMov = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMov)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(306, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movimentação de produtos";
            // 
            // dtGridMov
            // 
            this.dtGridMov.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridMov.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtGridMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridMov.Location = new System.Drawing.Point(12, 110);
            this.dtGridMov.Name = "dtGridMov";
            this.dtGridMov.ReadOnly = true;
            this.dtGridMov.RowHeadersVisible = false;
            this.dtGridMov.RowTemplate.Height = 25;
            this.dtGridMov.Size = new System.Drawing.Size(1010, 539);
            this.dtGridMov.TabIndex = 1;
            // 
            // FrmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.dtGridMov);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "FrmHistorico";
            this.Text = "FrmHistorico";
            this.Load += new System.EventHandler(this.FrmHistorico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dtGridMov;
    }
}