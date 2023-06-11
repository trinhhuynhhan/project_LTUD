using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace DAO
{
    public class DAO_SanPham
    {
        XuLyData dataSP = new XuLyData();
        public DataTable selectAllSP()
        {
            DataTable dtResult = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("selectAllSP",dataSP.sqlConn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlcmd);
            sqlAdapter.Fill(dtResult);
            return dtResult;
        }

        public DataTable FindSP(string maSP)
        {

            DataTable dtResult = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("findSP", dataSP.sqlConn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaSP", maSP);
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlcmd);
            sqlAdapter.Fill(dtResult);
            return dtResult;
        }
        public int XoaSP(string maSP)
        {
            int iResult = -1;
            SqlCommand sqlcmd = new SqlCommand("deleteSP", dataSP.sqlConn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaSP", maSP);
            DialogResult dia = MessageBox.Show($"Bạn có chắc chắn muốn xóa {maSP} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                iResult = sqlcmd.ExecuteNonQuery();
                try
                {
                    if (iResult >= 0)
                    {
                        MessageBox.Show("Xoa thanh cong roi ne", "Thong Bao");
                        iResult = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xoa không thanh cong roi ne", "Thong Bao");
                    throw ex;
                }
            }

            return iResult;
        }
        public int SuaSP(string MaaSP, string TenSP, float GiaSP, string NoiSX, string MaLoai, string MaCH)
        {
            int iResult = -1;
            SqlCommand sqlcmd = new SqlCommand("updateSP", dataSP.sqlConn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaSP", MaaSP);
            sqlcmd.Parameters.AddWithValue("@TenSP", TenSP);
            sqlcmd.Parameters.AddWithValue("@GiaSP", GiaSP);
            sqlcmd.Parameters.AddWithValue("@NoiSX", NoiSX);
            sqlcmd.Parameters.AddWithValue("@MaLoai", MaLoai);
            sqlcmd.Parameters.AddWithValue("@MaCH", MaCH);
            DialogResult dia = MessageBox.Show($"Bạn có chắc chắn muốn sửa {MaaSP} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                iResult = sqlcmd.ExecuteNonQuery();
                try
                {
                    if (iResult >= 0)
                    {
                        MessageBox.Show("Sửa thành công !!!", "Thông báo");
                        iResult = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thất bại !!!" + ex.Message, "Thông báo");
                    throw;
                }
            }

            return iResult;
        }
        public int ThemSP(string MaSP, string TenSP, float GiaSP, string NoiSX, string MaLoai, string MaCH)
        {
            SanPham sp = new SanPham();
            int iResult = -1;

            SqlCommand sqlcmd = new SqlCommand("insertSP", dataSP.sqlConn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaSP", MaSP);
            sqlcmd.Parameters.AddWithValue("@TenSP", TenSP);
            sqlcmd.Parameters.AddWithValue("@GiaSP", GiaSP);
            sqlcmd.Parameters.AddWithValue("@NoiSX", NoiSX);
            sqlcmd.Parameters.AddWithValue("@MaLoai", MaLoai);
            sqlcmd.Parameters.AddWithValue("@MaCH", MaCH);
            iResult = sqlcmd.ExecuteNonQuery();
            try
            {
                if (iResult >= 0)
                {
                    MessageBox.Show("Thêm thành công !!!", "Thông báo");
                    iResult = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại !!!" + ex.Message, "Thông báo");
                throw;
            }
            return iResult;
        }
        public int Top10SPNew(string maSP)
        {
            int iResult = -1;
            SqlCommand sqlcmd = new SqlCommand("Top10SP", dataSP.sqlConn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaSP", maSP);
            
                iResult = sqlcmd.ExecuteNonQuery();
                
                    if (iResult >= 0)
                    {
                        MessageBox.Show("lấy thành cong", "Thong Bao");
                        iResult = 0;
                    }
                
                else
                   { 
                    MessageBox.Show("Xoa không thanh cong roi ne", "Thong Bao");
                    
                   }
            return iResult;
        }
    }
}
