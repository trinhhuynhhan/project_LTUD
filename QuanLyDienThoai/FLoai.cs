using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;
using DTO;
using System.Windows.Forms;

namespace QuanLyDienThoai
{
    public partial class FLoai : Form
    {
        BAL_Loai loai = new BAL_Loai();
        public FLoai()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int iResult = -1;
            iResult = loai.themLoai(txtMaLoai.Text, txtTenLoai.Text);
            if(iResult >= 0)
            {
                dataGridView1.DataSource = loai.getdata();
                txtMaLoai.Text = null;
                txtTenLoai.Text = null;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int iDong = e.RowIndex;
            txtMaLoai.Text = dataGridView1.Rows[iDong].Cells[0].Value.ToString();
            txtTenLoai.Text = dataGridView1.Rows[iDong].Cells[1].Value.ToString();

        }

        private void FLoai_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = loai.getdata();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int iResutl = -1;
            if (txtMaLoai.Text != string.Empty)
            {
                iResutl = loai.XoaLoai(txtMaLoai.Text);
                if (iResutl >= 0)
                {
                    dataGridView1.DataSource = loai.getdata();
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int iResutl = -1;
            iResutl = loai.suaLoai(txtMaLoai.Text,txtTenLoai.Text);
            if (iResutl >= 0)
            {
                dataGridView1.DataSource = loai.getdata();
                txtMaLoai.Text = null;
                txtTenLoai.Text = null;
               
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có Chắc chắc muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtMaLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTenLoai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
