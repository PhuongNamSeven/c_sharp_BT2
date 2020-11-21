using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan3_FormChaFormCon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmDangNhap());
            frmDangNhap frm = new frmDangNhap();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string ten = frm.txtTaiKhoan.Text;// doi thuoc tinh gì??
                string pas = frm.txtMatKhau.Text;
                UserDangNhap user1 = new UserDangNhap(ten, pas);
                Application.Run(new frmMain(user1));
            }
        }
    }
}
