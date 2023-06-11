using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        private string MaSP;
        private string TenSP;
        private float GiaSP;
        private string NoiSX;
        private string MaLoai;
        private string MaCH;

        public string MaSP1
        {
            get
            {
                return MaSP;
            }

            set
            {
                MaSP = value;
            }
        }

        public string TenSP1
        {
            get
            {
                return TenSP;
            }

            set
            {
                TenSP = value;
            }
        }

        public float GiaSP1
        {
            get
            {
                return GiaSP;
            }

            set
            {
                GiaSP = value;
            }
        }

        public string NoiSX1
        {
            get
            {
                return NoiSX;
            }

            set
            {
                NoiSX = value;
            }
        }

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

        public SanPham() { }

        public SanPham(string maSP, string tenSP, float gia,string noiSX,string maLoai,string maCH)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.GiaSP = gia;
            this.NoiSX = noiSX;
            this.MaLoai = maLoai;
            this.MaCH = maCH;
        }

        
    }
}
