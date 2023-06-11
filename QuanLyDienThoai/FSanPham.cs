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
    public partial class FSanPham : Form
    {
        BAL_SanPham sp = new BAL_SanPham();
        public FSanPham()
        {
            InitializeComponent();
        }

        private void FSanPham_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sp.getData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult dia = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int iResutl = -1;
            iResutl = sp.ThemSP(txtMaSP.Text, txtTenSP.Text, float.Parse(txtGiaSp.Text), txtNoiSX.Text, txtMaLoai.Text, txtMaCuaHang.Text);
            if (iResutl >= 0)
            {
                dataGridView1.DataSource = sp.getData();
                txtMaSP.Text = null;
                txtTenSP.Text = null;
                txtGiaSp.Text = null;
                txtNoiSX.Text = null;
                txtMaLoai.Text = null;
                txtMaCuaHang.Text = null;

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int iResutl = -1;

            if (txtMaSP.Text != String.Empty)
            {
                iResutl = sp.XoaSP(txtMaSP.Text);
                if (iResutl >= 0)
                {
                    dataGridView1.DataSource = sp.getData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int iResutl = -1;
            iResutl = sp.SuaSP(txtMaSP.Text, txtTenSP.Text, float.Parse(txtGiaSp.Text), txtNoiSX.Text, txtMaLoai.Text, txtMaCuaHang.Text);
            if (iResutl >= 0)
            {
                dataGridView1.DataSource = sp.getData();
                txtMaSP.Text = null;
                txtTenSP.Text = null;
                txtGiaSp.Text = null;
                txtNoiSX.Text = null;
                txtMaLoai.Text = null;
                txtMaCuaHang.Text = null;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int iDong = e.RowIndex;
            txtMaSP.Text = dataGridView1.Rows[iDong].Cells[0].Value.ToString();
            txtTenSP.Text = dataGridView1.Rows[iDong].Cells[1].Value.ToString();
            txtGiaSp.Text = dataGridView1.Rows[iDong].Cells[2].Value.ToString();
            txtNoiSX.Text = dataGridView1.Rows[iDong].Cells[3].Value.ToString();
            txtMaLoai.Text = dataGridView1.Rows[iDong].Cells[4].Value.ToString();
            txtMaCuaHang.Text = dataGridView1.Rows[iDong].Cells[5].Value.ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmInBang inBang = new frmInBang();
            inBang.Show();
        }
    }
}
