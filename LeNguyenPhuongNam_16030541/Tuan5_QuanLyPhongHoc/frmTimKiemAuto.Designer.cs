namespace Tuan5_QuanLyPhongHoc
{
    partial class frmTimKiemAuto
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
            this.lstDSPhong = new System.Windows.Forms.ListBox();
            this.lvwDSMay = new System.Windows.Forms.ListView();
            this.radTheoMa = new System.Windows.Forms.RadioButton();
            this.radTheoCPU = new System.Windows.Forms.RadioButton();
            this.txtDULieuTim = new System.Windows.Forms.TextBox();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDSPhong
            // 
            this.lstDSPhong.FormattingEnabled = true;
            this.lstDSPhong.ItemHeight = 20;
            this.lstDSPhong.Location = new System.Drawing.Point(0, 0);
            this.lstDSPhong.Name = "lstDSPhong";
            this.lstDSPhong.Size = new System.Drawing.Size(290, 544);
            this.lstDSPhong.TabIndex = 0;
            this.lstDSPhong.SelectedIndexChanged += new System.EventHandler(this.lstDSPhong_SelectedIndexChanged);
            // 
            // lvwDSMay
            // 
            this.lvwDSMay.HideSelection = false;
            this.lvwDSMay.Location = new System.Drawing.Point(310, 0);
            this.lvwDSMay.Name = "lvwDSMay";
            this.lvwDSMay.Size = new System.Drawing.Size(537, 362);
            this.lvwDSMay.TabIndex = 1;
            this.lvwDSMay.UseCompatibleStateImageBehavior = false;
            this.lvwDSMay.SelectedIndexChanged += new System.EventHandler(this.lvwDSMay_SelectedIndexChanged);
            // 
            // radTheoMa
            // 
            this.radTheoMa.AutoSize = true;
            this.radTheoMa.Location = new System.Drawing.Point(310, 401);
            this.radTheoMa.Name = "radTheoMa";
            this.radTheoMa.Size = new System.Drawing.Size(121, 24);
            this.radTheoMa.TabIndex = 2;
            this.radTheoMa.TabStop = true;
            this.radTheoMa.Text = "Tìm theo mã";
            this.radTheoMa.UseVisualStyleBackColor = true;
            this.radTheoMa.CheckedChanged += new System.EventHandler(this.radTheoMa_CheckedChanged);
            // 
            // radTheoCPU
            // 
            this.radTheoCPU.AutoSize = true;
            this.radTheoCPU.Location = new System.Drawing.Point(549, 401);
            this.radTheoCPU.Name = "radTheoCPU";
            this.radTheoCPU.Size = new System.Drawing.Size(132, 24);
            this.radTheoCPU.TabIndex = 2;
            this.radTheoCPU.TabStop = true;
            this.radTheoCPU.Text = "Tìm theo CPU";
            this.radTheoCPU.UseVisualStyleBackColor = true;
            this.radTheoCPU.CheckedChanged += new System.EventHandler(this.radTheoCPU_CheckedChanged);
            // 
            // txtDULieuTim
            // 
            this.txtDULieuTim.Location = new System.Drawing.Point(310, 456);
            this.txtDULieuTim.Name = "txtDULieuTim";
            this.txtDULieuTim.Size = new System.Drawing.Size(246, 26);
            this.txtDULieuTim.TabIndex = 3;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(633, 456);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(104, 54);
            this.btnThucHien.TabIndex = 4;
            this.btnThucHien.Text = "Tìm kiếm";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // frmTimKiemAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 560);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.txtDULieuTim);
            this.Controls.Add(this.radTheoCPU);
            this.Controls.Add(this.radTheoMa);
            this.Controls.Add(this.lvwDSMay);
            this.Controls.Add(this.lstDSPhong);
            this.Name = "frmTimKiemAuto";
            this.Text = "frmTimKiemAuto";
            this.Load += new System.EventHandler(this.frmTimKiemAuto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDSPhong;
        private System.Windows.Forms.ListView lvwDSMay;
        private System.Windows.Forms.RadioButton radTheoMa;
        private System.Windows.Forms.RadioButton radTheoCPU;
        private System.Windows.Forms.TextBox txtDULieuTim;
        private System.Windows.Forms.Button btnThucHien;
    }
}