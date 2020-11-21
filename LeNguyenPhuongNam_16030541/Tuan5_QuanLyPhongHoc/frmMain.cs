using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan5_QuanLyPhongHoc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void quảnLýPhòngHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyPhongHoc frmQLPhongHoc = new frmQuanLyPhongHoc();
            frmQLPhongHoc.Show();
        }
    }
}
