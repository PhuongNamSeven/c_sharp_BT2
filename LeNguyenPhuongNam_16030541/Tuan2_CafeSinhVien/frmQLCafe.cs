using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan2_CafeSinhVien
{
    public partial class frmQLCafe : Form
    {
        public frmQLCafe()
        {
            InitializeComponent();
        }
        int cafeDen = 20000;
        int cafeDa = 25000;
        int cafeSua = 25000;
        int cafeSuaDa = 30000;
        int cafeKem = 35000;
        Double thanhTien= 0;
        int dem = 0;
        private void frmQLCafe_Load(object sender, EventArgs e)
        {
            btnTinhTien.Enabled = false;
            btnNhapLai.Enabled = false;
            btnThanhToan.Enabled = false;
            //chkSinhVien.Checked = true;
            radCafeDen.Checked = true;
            //if(txtTenKhachHang.Text.Length >0 )
            //{
            //    btnTinhTien.Enabled = true;
            //}
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text == "")
            {
                DialogResult thongbao = MessageBox.Show("Ban can nhap ten khach hang", "Luu y", MessageBoxButtons.OK);

            }
            else
            {
                if (chkSinhVien.Checked)
                {
                    if (radCafeDen.Checked)
                    {
                        thanhTien += cafeDen *0.8;
                    }
                    else if (radCafeSua.Checked)
                    {
                        thanhTien += cafeSua * 0.8;
                    }
                    else if (radCafeSuaDa.Checked)
                    {
                        thanhTien += cafeSuaDa * 0.8;
                    }
                    else if (radCafeDa.Checked)
                    {
                        thanhTien += cafeDa * 0.8;
                    }
                    else if (radCafeKem.Checked)
                    {
                        thanhTien += cafeKem * 0.8;
                    }
                }
                else
                {
                    if (radCafeDen.Checked)
                    {
                        thanhTien += cafeDen ;
                    }
                    else if (radCafeSua.Checked)
                    {
                        thanhTien += cafeSua;
                    }
                    else if (radCafeSuaDa.Checked)
                    {
                        thanhTien += cafeSuaDa;
                    }
                    else if (radCafeDa.Checked)
                    {
                        thanhTien += cafeDa;
                    }
                    else if (radCafeKem.Checked)
                    {
                        thanhTien += cafeKem;
                    }
                }
                
            }
            lblTongTien.Text = thanhTien.ToString();
        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            dem += 1;
            txtTongKhachHang.Text = dem.ToString();
            btnThanhToan.Enabled = false;
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            if(txtTenKhachHang.Text.Length > 0)
            {
                btnTinhTien.Enabled = true;
                btnNhapLai.Enabled = true;
                btnThanhToan.Enabled = true;
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenKhachHang.Text = "";
            chkSinhVien.Checked = false;
            radCafeDa.Checked = false;
            btnNhapLai.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQLCafe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("ban muon dong form ???","Cau hoi",MessageBoxButtons.YesNo);
            if(DialogResult.Yes== thongbao)
            {
                e.Cancel = false;
            }else
            { e.Cancel = true; }
        }
    }
}
