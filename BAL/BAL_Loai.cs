using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BAL
{
 public   class BAL_Loai
    {
        DAO_Loai loai = new DAO_Loai();
         public DataTable getdata()
        {
            return loai.selectAllLoai();
        }

        public int themLoai(string MaLoai,string TenLoai)
        {
            return loai.ThemLoai(MaLoai, TenLoai);
        }

        public int XoaLoai(string MaLoai)
        {
            return loai.XoaLoai(MaLoai);
        }

        public DataTable findLoai(string MaLoai)
        {
            return loai.FindLoai(MaLoai);
        }

        public int suaLoai(string Maloai, string TenLoai)
        {
            return loai.SuaLoai(Maloai,TenLoai);
        }
    }
}
