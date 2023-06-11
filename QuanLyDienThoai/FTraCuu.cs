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

namespace QuanLyDienThoai
{
    public partial class FTraCuu : Form
    {
        BAL_SanPham sp = new BAL_SanPham();
        public FTraCuu()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable tam = sp.FindSP(txtTimKiem.Text);
  
            if (tam.Rows.Count > 0)
            {
                dataGridView1.DataSource = sp.FindSP(txtTimKiem.Text);
            }
            else
            {
                txtTimKiem.Clear();
                txtTimKiem.Focus();
            }
        }

        private void FTraCuu_Load(object sender, EventArgs e)
        {

        }

        private void btnTimTiep_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTimKiem.Focus();
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
