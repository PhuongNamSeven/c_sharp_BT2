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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(UserDangNhap us)
        {
            InitializeComponent();
            this.Text += "Bạn vừa đăng nhập với tên" + us.HoTen + "và pass" + us.PassWord;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        bool KiemTraForm(string strTenForm)
        {
            // duyet cac form con da mở
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(strTenForm))//đã tồn tại rồi
                {
                    frm.Activate();
                    return true;
                }
            }
            return false;
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!KiemTraForm("frmCon1"))
            {
                frm1 frmchildForm = new frm1();
                frmchildForm.Name = "frm1";
                frmchildForm.MdiParent = this;
                frmchildForm.Text = "Window " ;
                frmchildForm.Show();
            }
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!KiemTraForm("frmCon1"))
            {
                frm2 frmchildForm = new frm2();
                frmchildForm.Name = "frm2";
                frmchildForm.MdiParent = this;
                frmchildForm.Text = "Window ";
                frmchildForm.Show();
            }
        }
    }
}
