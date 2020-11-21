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
    public partial class frmQuanLyPhongHoc : Form
    {
        public frmQuanLyPhongHoc()
        {
            InitializeComponent();
        }
        clsPhongHoc_PhuongNam p;
        clsMayTinh_PhuongNam m;
        TreeNode nGoc;
        private void frmQuanLyPhongHoc_Load(object sender, EventArgs e)
        {
            //btnThem.Enabled = false;
            //btnLuu.Enabled = false;
            //btnXoa.Enabled = false;
            CreateColumnListView(lvwDanhSachMay);
            nGoc = new TreeNode("Danh sách phòng");
            p = new clsPhongHoc_PhuongNam();
            m = new clsMayTinh_PhuongNam();
            IEnumerable<tblPhonghoc> dsP = p.GetAllPhongHoc();
            LoadPhongHocTreeView(trePhong,dsP);
        }
        public void CreateColumnListView(ListView lvw)
        {
            lvw.Items.Clear();
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.Columns.Add("Mã Máy",60);
            lvw.Columns.Add("CPU", 60);
            lvw.Columns.Add("HardDisk", 60);
            lvw.Columns.Add("RAM", 60);
            lvw.Columns.Add("VGA", 60);
            lvw.Columns.Add("Monitor", 60);
        }
        public void LoadPhongHocTreeView(TreeView tv, IEnumerable<tblPhonghoc> dsP)
        {
            tv.Nodes.Clear();
            nGoc.Nodes.Clear();
            TreeNode nCon;
            foreach(tblPhonghoc ph in dsP)
            {
                nCon = new TreeNode();
                nCon.Text = ph.tenPhong;
                nCon.Tag = ph.msPhong;
                nGoc.Nodes.Add(nCon);
            }
            tv.Nodes.Add(nGoc);
            tv.ExpandAll();
        }

        private void trePhong_AfterSelect(object sender, TreeViewEventArgs e)
        {
            IEnumerable<tblMaytinh> dsMay; // tao bien nhan danh sach may tinh thuoc phong
            string strMaPhong= "";
            if(trePhong.SelectedNode != null)
            {
                if(trePhong.SelectedNode.Level == 0)
                strMaPhong = "";
                else
                {
                    strMaPhong = trePhong.SelectedNode.Tag.ToString();
                }
                dsMay = m.GetMayTinhThuocPhong(strMaPhong);
                LoadMayTinhToListView(lvwDanhSachMay, dsMay);
            }
        }
        public void LoadMayTinhToListView(ListView lvw, IEnumerable<tblMaytinh> dsM)
        {
            lvw.Items.Clear();
            ListViewItem lvitem;
            foreach(tblMaytinh mt in dsM)
            {
                lvitem = new ListViewItem(mt.msMay);
                lvitem.SubItems.Add(mt.CPU);
                lvitem.SubItems.Add(mt.HardDisk);
                lvitem.SubItems.Add(mt.RAM);
                lvitem.SubItems.Add(mt.VGA);
                lvitem.SubItems.Add(mt.Monitor);
                lvitem.Tag = mt;
                lvw.Items.Add(lvitem);
            }
        }

        private void lvwDanhSachMay_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblMaytinh mt = null;
            if(lvwDanhSachMay.SelectedItems.Count > 0)
            {
                mt = (tblMaytinh)lvwDanhSachMay.SelectedItems[0].Tag;
                txtMaMay.Text = mt.msMay;
                txtCPU.Text = mt.CPU;
                txtHardDisk.Text = mt.HardDisk;
                txtRam.Text = mt.RAM;
                txtVGA.Text = mt.VGA;
                txtMonitor.Text = mt.Monitor;
                lblMaPhong.Text = mt.msPhong;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiemAuto frmTimKiem = new frmTimKiemAuto();
            frmTimKiem.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaMay.Text = "";
            txtCPU.Text = "";
            txtHardDisk.Text = "";
            txtRam.Text = "";
            txtVGA.Text = "";
            txtMonitor.Text = "";
            if (!btnThem.Text.Equals("Hủy Thêm"))
            {
                btnLuu.Enabled = true;
                btnThem.Text = "Hủy Thêm";
            }
            else
            {
                btnLuu.Enabled = false;
                btnThem.Text = "Thêm";

            }
        }
        tblMaytinh TaoMayTinh()
        {
            //Buoc 1 
            tblMaytinh mt = new tblMaytinh();
            mt.msMay = txtMaMay.Text;
            mt.CPU = txtCPU.Text;
            mt.HardDisk = txtHardDisk.Text;
            mt.VGA = txtVGA.Text;
            mt.RAM = txtRam.Text;
            mt.Monitor = txtMonitor.Text;
            mt.msPhong = lblMaPhong.Text;
            ///mt.msPhong = trePhong.SelectedNode.Tag.ToString();
            return mt;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (trePhong.SelectedNode.Level == 1)
            {
                tblMaytinh mt = TaoMayTinh();
                m.ThemMayTinh(mt);
                IEnumerable<tblMaytinh> dsMay = m.GetMayTinhThuocPhong(trePhong.SelectedNode.Tag.ToString());
                LoadMayTinhToListView(lvwDanhSachMay, dsMay);
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlgHoiXoa;
            tblMaytinh mt;
            int vitTriThuc;
            if (lvwDanhSachMay.SelectedItems.Count > 0)//chon 1 dong listview
            {
                dlgHoiXoa = MessageBox.Show("Bạn chắc xóa?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dlgHoiXoa == DialogResult.Yes)
                {
                    for (int i = 0; i < lvwDanhSachMay.SelectedItems.Count; i++)
                    {
                        vitTriThuc = lvwDanhSachMay.SelectedIndices[i];
                        mt = (tblMaytinh)lvwDanhSachMay.Items[vitTriThuc].Tag;
                        m.XoaMayTinh(mt);
                    }
                    IEnumerable<tblMaytinh> dsMay = m.GetMayTinhThuocPhong(trePhong.SelectedNode.Tag.ToString());
                    LoadMayTinhToListView(lvwDanhSachMay, dsMay);
                    btnXoa.Enabled = false;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tblMaytinh mt = TaoMayTinh();
            m.SuaMayTinh(mt);
            //sửa xong load lại
            IEnumerable<tblMaytinh> dsMay = m.GetMayTinhThuocPhong(trePhong.SelectedNode.Tag.ToString());
            LoadMayTinhToListView(lvwDanhSachMay, dsMay);
            btnSua.Enabled = false;
        }

        private void btnTruyenDLHL_Click(object sender, EventArgs e)
        {
            if (trePhong.SelectedNode != null)
            {
                if (trePhong.SelectedNode.Level == 1)
                {
                    string strMaPhong = trePhong.SelectedNode.Tag.ToString();
                    frmDuLieuHonLoan frmDLHL = new frmDuLieuHonLoan(strMaPhong);
                    //frmDLHL.MdiParent = this.MdiParent;
                    frmDLHL.Show();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
