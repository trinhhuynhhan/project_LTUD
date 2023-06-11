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
    public partial class FCưaHang : Form
    {
        BAL_CuaHang ch = new BAL_CuaHang();
        public FCưaHang()
        {
            InitializeComponent();
        }

        private void FCưaHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ch.getDataCH(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int iResult = -1;
            iResult = ch.themCH(txtMaCH.Text, txtTenCH.Text);
            if (iResult >= 0)
            {
                dataGridView1.DataSource = ch.getDataCH();
                txtMaCH.Text = null;
                txtTenCH.Text = null;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int iResutl = -1;
            if (txtMaCH.Text != string.Empty)
            {
                iResutl = ch.xoaCH(txtMaCH.Text);
                if (iResutl >= 0)
                {
                    dataGridView1.DataSource = ch.getDataCH();
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int iResutl = -1;
            iResutl = ch.suaCH(txtMaCH.Text, txtTenCH.Text);
            if (iResutl >= 0)
            {
                dataGridView1.DataSource = ch.getDataCH();
                txtMaCH.Text = null;
                txtTenCH.Text = null;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dio = MessageBox.Show("Bạn Có thậy sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dio== DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int iDong = e.RowIndex;
            txtMaCH.Text = dataGridView1.Rows[iDong].Cells[0].Value.ToString();
            txtTenCH.Text = dataGridView1.Rows[iDong].Cells[1].Value.ToString();
        }
    }
}
