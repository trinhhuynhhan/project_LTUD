using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class CuaHang
    {
        private string MaCH;
        private string TenCH;

        public string MaCH1
        {
            get
            {
                return MaCH;
            }

            set
            {
                MaCH = value;
            }
        }

        public string TenCH1
        {
            get
            {
                return TenCH;
            }

            set
            {
                TenCH = value;
            }
        }

        public CuaHang() { }
        
        public CuaHang(string maCH, string tenCH)
        {
            this.MaCH = maCH;
            this.TenCH = tenCH;
        }
    }
}
