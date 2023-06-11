using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class Loai
    {
        private string MaLoai;
        private string TenLoai;

        public string MaLoai1
        {
            get
            {
                return MaLoai;
            }

            set
            {
                MaLoai = value;
            }
        }

        public string TenLoai1
        {
            get
            {
                return TenLoai;
            }

            set
            {
                TenLoai = value;
            }
        }

        public Loai() { }

        public Loai(string maLoai, string tenLoai)
        {
            this.MaLoai = maLoai;
            this.TenLoai = tenLoai;

        }
    }
}
