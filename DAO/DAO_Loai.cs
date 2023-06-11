using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAO
{
   public class DAO_Loai
    {
        XuLyData dataSP = new XuLyData();
        public DataTable selectAllLoai()
        {
            DataTable dtResult = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("selectALLLoai", dataSP.sqlConn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlcmd);
            sqlAdapter.Fill(dtResult);
            return dtResult;
        }

        public DataTable FindLoai(string maLoai)
        {

            DataTable dtResult = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("findLoai", dataSP.sqlConn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaLoai", maLoai);
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlcmd);
            sqlAdapter.Fill(dtResult);
            return dtResult;
        }
        public int XoaLoai(string maLoai)
        {
            int iResult = -1;
            SqlCommand sqlcmd = new SqlCommand("deleteLoai", dataSP.sqlConn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaLoai", maLoai);
            DialogResult dia = MessageBox.Show($"Bạn có chắc chắn muốn xóa {maLoai} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        public int SuaLoai(string maLoai,string tenLoai)
        {
            int iResult = -1;
            SqlCommand sqlcmd = new SqlCommand("updateLoai", dataSP.sqlConn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaLoai", maLoai);
            sqlcmd.Parameters.AddWithValue("@TenLoai", tenLoai);
        
            DialogResult dia = MessageBox.Show($"Bạn có chắc chắn muốn sửa {maLoai} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        public int ThemLoai(string maLoai, string tenLoai)
        {
            Loai loai = new Loai();
            int iResult = -1;

            SqlCommand sqlcmd = new SqlCommand("insertLoai", dataSP.sqlConn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaLoai", maLoai);
            sqlcmd.Parameters.AddWithValue("@Tenloai", tenLoai);
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
    }
}
