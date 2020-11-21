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
    public partial class frmDuLieuHonLoan : Form
    {
        public frmDuLieuHonLoan()
        {
            InitializeComponent();
        }
        string strMaPhong = "";
        clsHonLoan hLoan;
        public frmDuLieuHonLoan(string strMa)// thêm vào
        {
            strMaPhong = strMa;
            InitializeComponent();
            this.Text = "Bạn vừa truyền vào " + strMa;
           // btnTheoMaPhong.Text = "Theo mã " + strMa;
        }
        private void frmDuLieuHonLoan_Load(object sender, EventArgs e)
        {
            hLoan = new clsHonLoan();
            dgrHonLoan.DataSource = hLoan.GetMayTinhPhongHocHonLoan();
        }

        private void btnCPUCoChua_Click(object sender, EventArgs e)
        {
            string strCPUCoChua = txtGiaTri.Text;
            dgrHonLoan.DataSource = hLoan.GetCoChuaMayTinhPhongHocHonLoan(strCPUCoChua);
        }
    }
}
