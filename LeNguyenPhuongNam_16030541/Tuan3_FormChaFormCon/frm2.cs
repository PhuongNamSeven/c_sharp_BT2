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
    public partial class frm2 : Form
    {
        string strNhan;
        public frm2()
        {
            InitializeComponent();
        }
        public frm2(string giatrinhan): this()
        {
            strNhan = giatrinhan;
            textBox1.Text = strNhan;
        }
        private void frm2_Load(object sender, EventArgs e)
        {

        }
    }
}
