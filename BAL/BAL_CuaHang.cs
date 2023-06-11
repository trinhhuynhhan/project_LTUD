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
  public  class BAL_CuaHang
    {
        DAO_CuaHang ch = new DAO_CuaHang();
        public DataTable getDataCH()
        {
            return ch.selectALLCuaHang();
        }

        public int themCH(string maCH, string tenCH)
        {
            return ch.ThemCH(maCH, tenCH);
        }

        public int xoaCH(string maCH)
        {
            return ch.XoaCH(maCH);
        }

        public int suaCH(string maCH,string tenCH)
        {
            return ch.SuaCH(maCH,tenCH);
        }

        public DataTable FindCH(string maCH)
        {
            return ch.FindCH(maCH);
        }
    }
}
