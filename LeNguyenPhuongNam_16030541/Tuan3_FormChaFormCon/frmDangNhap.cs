using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan3_FormChaFormCon
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        int count = 0;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Equals("123") && txtTaiKhoan.Text.Equals("nam"))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("sai ten tai khoan hoac mat khau");
                count++;
            }
            if (count == 6)
            {
                MessageBox.Show("Ban vuot qua lan dang nhap");
                this.Close();
            }
        
        }
    }
}
