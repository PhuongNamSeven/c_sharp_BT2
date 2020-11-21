using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5_QuanLyPhongHoc
{
    public class clsHonLoan:KetNoiCSDL
    {
        QuanLyPhongHocdbmlDataContext dt;
        public clsHonLoan()
        {
            dt = getDatacontex();
        }
        public IEnumerable<dynamic> GetMayTinhPhongHocHonLoan()
        {

            var q = from n in dt.tblPhonghocs
                    join x in dt.tblMaytinhs
                    on n.msPhong equals x.msPhong
                    select new { aaaChuYTen = n.tenPhong, x.msMay, x.Monitor, x.CPU };
            return q;
        }
        public IEnumerable<dynamic> GetCoChuaMayTinhPhongHocHonLoan(string strChua)
        {

            var q = from n in dt.tblPhonghocs
                    join x in dt.tblMaytinhs
                    on n.msPhong equals x.msPhong
                    where x.CPU.Contains(strChua)
                    select new { n.tenPhong, x.msMay, x.Monitor, x.CPU };
            return q;
        }
    }
}
