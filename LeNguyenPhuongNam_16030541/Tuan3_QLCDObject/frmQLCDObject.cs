using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan3_QLCDObject
{
    public partial class frmQLCDObject : Form
    {
        DanhSachKhachThue dskt = new DanhSachKhachThue();
        public frmQLCDObject()
        {
            InitializeComponent();
        }

        private void frmQLCDObject_Load(object sender, EventArgs e)
        {
            // 0
            for (int i = 0; i <= 100; i++)
            {
                cboSoLuong.Items.Add(i.ToString());

            }
            cboSoLuong.SelectedIndex = 2;
            chkDungHan2.Checked = true;
            //2
            CreateColumn(lvwDanhSach);
            TaoCungDanhSach(); // tao du lieu mau
            LoadDanhSachListView(dskt.GetAllDanhSach(), lvwDanhSach);
        }
        // 1
        void CreateColumn(ListView lvw)
        {
            lvw.Columns.Clear();// xoa het column
            lvw.View = View.Details;// thấy các cột
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.Columns.Add("Mã KH", 60);
            lvw.Columns.Add("Họ tên KH", 100);
            lvw.Columns.Add("Số lượng", 50);
            lvw.Columns.Add("Đơn Giá", 50);
            lvw.Columns.Add("Tình trạng", 60);
            lvw.Columns.Add("Tiền phải trả", 100);

        }
        void TaoCungDanhSach()
        {
            KhachThue kt1 = new KhachThue(1, "Phuong Nam", 10, 100, true);
            KhachThue kt2 = new KhachThue(2, "Hong Nhung", 10, 100, true);
            KhachThue kt3 = new KhachThue(3, "NGuyen Tu", 10, 100, true);
            KhachThue kt4 = new KhachThue(4, "Thu Thao", 10, 100, true);
            dskt.ThemKhachThue(kt1);
            dskt.ThemKhachThue(kt2);
            dskt.ThemKhachThue(kt3);
            dskt.ThemKhachThue(kt4);


        }
        // 3 nhap vao doi tuong => danh sach => listview
        private void btnTinhThue_Click(object sender, EventArgs e)
        {
            KhachThue khach = new KhachThue();
            khach.MaKhachHang = Convert.ToInt32(txtMaKhachHang.Text);
            khach.TenKhachHang = txtHoTenKhachHang.Text;
            khach.SoLuong = Convert.ToInt32(cboSoLuong.SelectedIndex.ToString());
            khach.DonGia = Convert.ToInt32(txtDonGia.Text);
            if(chkDungHan2.Checked)
            {
                khach.TraDungTre = true;
            }
            else
            {
                khach.TraDungTre = false;
            }
            dskt.ThemKhachThue(khach);
            LoadDanhSachListView(dskt.GetAllDanhSach(),lvwDanhSach);
        }
        float tienphaitra;
        // 4 dua vao listview
        public void LoadDanhSachListView( ArrayList AllDS,ListView lvw)
        {
            lvw.Items.Clear();
            ListViewItem lvitem;
            foreach(KhachThue item in AllDS)
            {
                lvitem = new ListViewItem();
                lvitem.Text = item.MaKhachHang.ToString();
                lvitem.SubItems.Add(item.TenKhachHang);
                lvitem.SubItems.Add(item.SoLuong.ToString());
                lvitem.SubItems.Add(item.DonGia.ToString());
                if(item.TraDungTre)
                {
                    lvitem.SubItems.Add("Dung Han");
                    tienphaitra = item.SoLuong * item.DonGia * 0.97F;
                }
                else
                {
                    lvitem.SubItems.Add("Tre Han");
                    tienphaitra = item.SoLuong * item.DonGia * 1.05F;
                }
                lvitem.SubItems.Add(tienphaitra.ToString());
                lvitem.Tag = item;
                lvw.Items.Add(lvitem);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Thong bao", "Cau hoi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(DialogResult.Yes==thongbao)
            {
                XoaItemDangChon(lvwDanhSach);
            }

        }
        public void XoaItemDangChon(ListView lvw)
        {
            KhachThue khach;
            foreach(ListViewItem item in lvwDanhSach.SelectedItems)
            {
                khach = (KhachThue)item.Tag;
                dskt.XoaKhachThue(khach);
            }
            lvwDanhSach.Items.Clear();
            LoadDanhSachListView(dskt.GetAllDanhSach(),lvwDanhSach);
        }

        void GanDuLieuVaoTex(KhachThue khachThue)
        {
            txtMaKhachHang.Text = (khachThue.MaKhachHang).ToString();
            txtHoTenKhachHang.Text = khachThue.TenKhachHang;
           

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachThue khach = new KhachThue();
            khach.MaKhachHang = Convert.ToInt32(txtMaKhachHang.Text);
            khach.TenKhachHang = txtHoTenKhachHang.Text;
            //khach.SoLuong = Convert.ToInt32( cboSoLuong.SelectedIndex.ToString());
            //khach.DonGia = Convert.ToInt32(txtDonGia.Text);
            //if (chkDungHan2.Checked)
            //{
            //    khach.TraDungTre = true;
            //}
            //else
            //{
            //    khach.TraDungTre = false;
            //}
            dskt.SuaKhachThue(khach);
            lvwDanhSach.Items.Clear();
            LoadDanhSachListView(dskt.GetAllDanhSach(),lvwDanhSach);
        }

        private void lvwDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            KhachThue dk = null;
            if (lvwDanhSach.SelectedItems.Count > 0)
            {
                dk = (KhachThue)lvwDanhSach.SelectedItems[0].Tag;
                GanDuLieuVaoTex(dk);
            }
        }

        private void btnTongTien_Click(object sender, EventArgs e)
        {
            double tongtien = dskt.TongTien();
            statusStrip1.Items[0].Text = "Tong tien la" + tongtien;

        }
    }
}
