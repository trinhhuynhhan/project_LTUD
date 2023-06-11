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
    public class BAL_SanPham
    {
        DAO_SanPham sp = new DAO_SanPham();
        public DataTable getData()
        {
            return sp.selectAllSP();
        }

        public int ThemSP(string MaaSP, string TenSP, float GiaSP, string NoiSX, string MaLoai, string MaCH)
        {
            return sp.ThemSP(MaaSP, TenSP, GiaSP, NoiSX, MaLoai, MaCH);
        }

        public int XoaSP(string MaSP)
        {
            return sp.XoaSP(MaSP);
        }

        public int SuaSP(string MaaSP, string TenSP, float GiaSP, string NoiSX, string MaLoai, string MaCH)
        {
            return sp.SuaSP(MaaSP, TenSP, GiaSP, NoiSX, MaLoai, MaCH);
        }

        public DataTable FindSP(string MaSP)
        {
            return sp.FindSP(MaSP);
        }
    }
}
