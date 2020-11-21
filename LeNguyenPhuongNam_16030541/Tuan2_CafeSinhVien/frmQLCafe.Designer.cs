namespace Tuan2_CafeSinhVien
{
    partial class frmQLCafe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radCafeKem = new System.Windows.Forms.RadioButton();
            this.radCafeDa = new System.Windows.Forms.RadioButton();
            this.radCafeSuaDa = new System.Windows.Forms.RadioButton();
            this.radCafeSua = new System.Windows.Forms.RadioButton();
            this.radCafeDen = new System.Windows.Forms.RadioButton();
            this.chkSinhVien = new System.Windows.Forms.CheckBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.chkSinhVien);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radCafeKem);
            this.groupBox3.Controls.Add(this.radCafeDa);
            this.groupBox3.Controls.Add(this.radCafeSuaDa);
            this.groupBox3.Controls.Add(this.radCafeSua);
            this.groupBox3.Controls.Add(this.radCafeDen);
            this.groupBox3.Location = new System.Drawing.Point(162, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 123);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn loại cafe";
            // 
            // radCafeKem
            // 
            this.radCafeKem.AutoSize = true;
            this.radCafeKem.Location = new System.Drawing.Point(293, 55);
            this.radCafeKem.Name = "radCafeKem";
            this.radCafeKem.Size = new System.Drawing.Size(99, 24);
            this.radCafeKem.TabIndex = 4;
            this.radCafeKem.TabStop = true;
            this.radCafeKem.Text = "cafe kem";
            this.radCafeKem.UseVisualStyleBackColor = true;
            // 
            // radCafeDa
            // 
            this.radCafeDa.AutoSize = true;
            this.radCafeDa.Location = new System.Drawing.Point(293, 25);
            this.radCafeDa.Name = "radCafeDa";
            this.radCafeDa.Size = new System.Drawing.Size(91, 24);
            this.radCafeDa.TabIndex = 3;
            this.radCafeDa.TabStop = true;
            this.radCafeDa.Text = "cafe đá ";
            this.radCafeDa.UseVisualStyleBackColor = true;
            // 
            // radCafeSuaDa
            // 
            this.radCafeSuaDa.AutoSize = true;
            this.radCafeSuaDa.Location = new System.Drawing.Point(17, 85);
            this.radCafeSuaDa.Name = "radCafeSuaDa";
            this.radCafeSuaDa.Size = new System.Drawing.Size(117, 24);
            this.radCafeSuaDa.TabIndex = 2;
            this.radCafeSuaDa.TabStop = true;
            this.radCafeSuaDa.Text = "cafe sữa đá";
            this.radCafeSuaDa.UseVisualStyleBackColor = true;
            // 
            // radCafeSua
            // 
            this.radCafeSua.AutoSize = true;
            this.radCafeSua.Location = new System.Drawing.Point(17, 55);
            this.radCafeSua.Name = "radCafeSua";
            this.radCafeSua.Size = new System.Drawing.Size(95, 24);
            this.radCafeSua.TabIndex = 1;
            this.radCafeSua.TabStop = true;
            this.radCafeSua.Text = "cafe sữa";
            this.radCafeSua.UseVisualStyleBackColor = true;
            // 
            // radCafeDen
            // 
            this.radCafeDen.AutoSize = true;
            this.radCafeDen.Location = new System.Drawing.Point(17, 25);
            this.radCafeDen.Name = "radCafeDen";
            this.radCafeDen.Size = new System.Drawing.Size(96, 24);
            this.radCafeDen.TabIndex = 0;
            this.radCafeDen.TabStop = true;
            this.radCafeDen.Text = "cafe đen";
            this.radCafeDen.UseVisualStyleBackColor = true;
            // 
            // chkSinhVien
            // 
            this.chkSinhVien.AutoSize = true;
            this.chkSinhVien.Location = new System.Drawing.Point(162, 74);
            this.chkSinhVien.Name = "chkSinhVien";
            this.chkSinhVien.Size = new System.Drawing.Size(99, 24);
            this.chkSinhVien.TabIndex = 1;
            this.chkSinhVien.Text = "Sinh viên";
            this.chkSinhVien.UseVisualStyleBackColor = true;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(162, 31);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(466, 26);
            this.txtTenKhachHang.TabIndex = 0;
            this.txtTenKhachHang.TextChanged += new System.EventHandler(this.txtTenKhachHang_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTongTien);
            this.groupBox2.Controls.Add(this.txtTongKhachHang);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnThanhToan);
            this.groupBox2.Controls.Add(this.btnNhapLai);
            this.groupBox2.Controls.Add(this.btnTinhTien);
            this.groupBox2.Location = new System.Drawing.Point(12, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(719, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblTongTien
            // 
            this.lblTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTongTien.Location = new System.Drawing.Point(195, 129);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(420, 20);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Click += new System.EventHandler(this.lblTongTien_Click);
            // 
            // txtTongKhachHang
            // 
            this.txtTongKhachHang.Location = new System.Drawing.Point(195, 89);
            this.txtTongKhachHang.Name = "txtTongKhachHang";
            this.txtTongKhachHang.Size = new System.Drawing.Size(420, 26);
            this.txtTongKhachHang.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng tiền thanh toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng khách hàng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(594, 25);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 48);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(417, 25);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(119, 48);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(212, 25);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(119, 48);
            this.btnNhapLai.TabIndex = 0;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(24, 25);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(119, 48);
            this.btnTinhTien.TabIndex = 0;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(240, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "CAFE SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQLCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQLCafe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cafe sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQLCafe_FormClosing);
            this.Load += new System.EventHandler(this.frmQLCafe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radCafeKem;
        private System.Windows.Forms.RadioButton radCafeDa;
        private System.Windows.Forms.RadioButton radCafeSuaDa;
        private System.Windows.Forms.RadioButton radCafeSua;
        private System.Windows.Forms.RadioButton radCafeDen;
        private System.Windows.Forms.CheckBox chkSinhVien;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label label1;
    }
}

