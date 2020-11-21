using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5_QuanLyPhongHoc
{
    public class clsPhongHoc_PhuongNam : KetNoiCSDL
    {
        QuanLyPhongHocdbmlDataContext dt;
        public clsPhongHoc_PhuongNam()
        {
            dt = getDatacontex();
        }
        public IEnumerable<tblPhonghoc> GetAllPhongHoc()
        {
            IEnumerable<tblPhonghoc> ph = from bien in dt.tblPhonghocs
                                          select bien;
            return ph;
        }
        public int LuuTru()
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;

                dt.SubmitChanges();
                dt.Transaction.Commit();
                return 1;

            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi cập nhật " + ex.Message);

            }
        }
    }
}
