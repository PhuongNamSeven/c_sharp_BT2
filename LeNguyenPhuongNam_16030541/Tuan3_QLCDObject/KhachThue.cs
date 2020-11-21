using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan3_QLCDObject
{
    public class KhachThue
    {
        private int maKhachHang;
        private string tenKhachHang;
        private int soLuong;
        private int donGia;
        private bool traDungTre;

        
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public bool TraDungTre { get => traDungTre; set => traDungTre = value; }
        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }

        public KhachThue()
        {

        }
        public KhachThue(int ma,string ten,int sl,int dg,bool tra)
        {
            this.MaKhachHang = ma;
            this.TenKhachHang = ten;
            this.SoLuong = sl;
            this.DonGia = dg;
            this.TraDungTre = tra;
        }
        public double DungTreHan()
        {
            double thanhtien;
            if (TraDungTre)
            {
                thanhtien = (SoLuong * DonGia) - ((SoLuong * DonGia) * 0.03);
            }
            else
            {
                thanhtien = (SoLuong * DonGia) + ((SoLuong * DonGia) * 0.05);
            }
            return thanhtien;
        }
        public override bool Equals(object obj)
        {
            //KhachThue khacthue = (KhachThue)obj;
            return this.MaKhachHang.Equals(((KhachThue)obj).MaKhachHang);
        }
    }
}
