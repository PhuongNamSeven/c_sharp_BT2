using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5_QuanLyPhongHoc
{
    public class KetNoiCSDL
    {
        QuanLyPhongHocdbmlDataContext dt;
        public QuanLyPhongHocdbmlDataContext getDatacontex()
        {
            //string str = @"Data Source=4000_DUOC_TIEN\THANG;Initial Catalog=ComputerManager;User ID=sa; Password =sapassword";
            string str = @"Data Source=DESKTOP-3JAEAPC;Initial Catalog=QuanLyPhongHoc;User ID=sa; Password =sapassword";
            dt = new QuanLyPhongHocdbmlDataContext(str);
            dt.Connection.Open();
            return dt;
        }
    }
}
