using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan3_FormChaFormCon
{
    public class UserDangNhap
    {
        private string hoTen, passWord;
        public UserDangNhap()
        { }
        public UserDangNhap(string HT, string Pass)
        {
            this.HoTen = HT;
            this.PassWord = Pass;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string PassWord { get => passWord; set => passWord = value; }
    }
}
