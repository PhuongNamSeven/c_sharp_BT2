namespace Tuan5_QuanLyPhongHoc
{
    partial class frmDuLieuHonLoan
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
            this.dgrHonLoan = new System.Windows.Forms.DataGridView();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.btnCPUCoChua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrHonLoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrHonLoan
            // 
            this.dgrHonLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrHonLoan.Location = new System.Drawing.Point(72, 27);
            this.dgrHonLoan.Name = "dgrHonLoan";
            this.dgrHonLoan.RowHeadersWidth = 62;
            this.dgrHonLoan.RowTemplate.Height = 28;
            this.dgrHonLoan.Size = new System.Drawing.Size(604, 254);
            this.dgrHonLoan.TabIndex = 1;
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(196, 325);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(358, 26);
            this.txtGiaTri.TabIndex = 2;
            // 
            // btnCPUCoChua
            // 
            this.btnCPUCoChua.Location = new System.Drawing.Point(279, 383);
            this.btnCPUCoChua.Name = "btnCPUCoChua";
            this.btnCPUCoChua.Size = new System.Drawing.Size(197, 41);
            this.btnCPUCoChua.TabIndex = 3;
            this.btnCPUCoChua.Text = "CPU Có chứa";
            this.btnCPUCoChua.UseVisualStyleBackColor = true;
            this.btnCPUCoChua.Click += new System.EventHandler(this.btnCPUCoChua_Click);
            // 
            // frmDuLieuHonLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCPUCoChua);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.dgrHonLoan);
            this.Name = "frmDuLieuHonLoan";
            this.Text = "frmDuLieuHonLoan";
            this.Load += new System.EventHandler(this.frmDuLieuHonLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrHonLoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrHonLoan;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Button btnCPUCoChua;
    }
}