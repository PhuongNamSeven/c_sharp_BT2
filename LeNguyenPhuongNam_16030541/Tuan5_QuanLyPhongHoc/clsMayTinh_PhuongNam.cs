using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan5_QuanLyPhongHoc
{
    public class clsMayTinh_PhuongNam : KetNoiCSDL
    {
        QuanLyPhongHocdbmlDataContext dt;
        public clsMayTinh_PhuongNam()
        {
            dt = getDatacontex();
        }
        public IEnumerable<tblMaytinh> GetMayTinhThuocPhong(string strMaPhong)
        {
            IEnumerable<tblMaytinh> mt;
            if (strMaPhong.Equals("")) // neu khong co ma phong thi get all may
            {
                mt = from bien in dt.tblMaytinhs
                     select bien;
            }
            else
            {
                mt = from bien in dt.tblMaytinhs
                     where bien.msPhong.Equals(strMaPhong) // ma phong trung voi ma phong may tinh
                     select bien; 
            }
            return mt; // tra ve Inumerable bang may tinh
        }
        public tblMaytinh KiemTraMa(string strMT)
        {
            tblMaytinh mt;
            mt = (from bien in dt.tblMaytinhs
                  where bien.msMay.Equals(strMT) // neu trung tra ve gia tri dau tien
                  select bien).FirstOrDefault();
            if (mt != null)
                return mt;
            return null;
        }
        public int ThemMayTinh(tblMaytinh tblMT)
        {
            System.Data.Common.DbTransaction dbTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = dbTran; // ket noi thu vien thanh cong
                if(KiemTraMa(tblMT.msMay) != null) // neu tim thay trung 
                {
                    return 0;
                }
                else
                {
                    dt.tblMaytinhs.InsertOnSubmit(tblMT);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return 1;
                }
            }catch(Exception ex)
            {
                dt.Transaction.Rollback(); // rollback cua transaction
                throw new Exception("Không thêm dc bạn ơi !!!" + ex.Message);
            }
        }
        public bool SuaMayTinh(tblMaytinh tblMT)
        {
            System.Data.Common.DbTransaction dbTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = dbTran;
                IQueryable<tblMaytinh> mt = (from n in dt.tblMaytinhs
                                             where n.msMay == tblMT.msMay
                                             select n);
                mt.First().CPU = tblMT.CPU;
                mt.First().HardDisk = tblMT.HardDisk;
                mt.First().RAM = tblMT.RAM;
                mt.First().VGA = tblMT.VGA;
                mt.First().Monitor = tblMT.Monitor;
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch(Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Sửa không thành công" + ex.Message);
            }
        }
        public int XoaMayTinh(tblMaytinh tblMT)
        {
            System.Data.Common.DbTransaction dbTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = dbTran;
                if (KiemTraMa(tblMT.msMay) != null)
                {
                    dt.tblMaytinhs.DeleteOnSubmit(tblMT);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return 1;
                }
                return 0; // khong tim thay khong lam gi het
                
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Xóa không thành công" + ex.Message);
            }
        }
    }
}
