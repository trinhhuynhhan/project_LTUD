using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DTO;

namespace QuanLyDienThoai
{

    public partial class QuanLyDT : Form
    {
        BAL_SanPham sp = new BAL_SanPham();
        public QuanLyDT()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bntDT_Click(object sender, EventArgs e)
        {
            FSanPham fsp = new FSanPham();
            fsp.ShowDialog();
            
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            FCưaHang fch = new FCưaHang();
            fch.ShowDialog();
        }

        private void btnLoaiDT_Click(object sender, EventArgs e)
        {
                FLoai fl = new FLoai();
            fl.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FTraCuu ftr = new FTraCuu();
            ftr.ShowDialog();
        }
    }
}
