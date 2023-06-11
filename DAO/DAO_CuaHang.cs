using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace DAO
{
  public class DAO_CuaHang
    {
        XuLyData dataCH = new XuLyData();
        public DataTable selectALLCuaHang()
        {
            DataTable dtResult = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("selectALLCuaHang", dataCH.sqlConn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlcmd);
            sqlAdapter.Fill(dtResult);
            return dtResult;
        }

        public DataTable FindCH(string MaCH)
        {

            DataTable dtResult = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("findCH", dataCH.sqlConn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaCH", MaCH);
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlcmd);
            sqlAdapter.Fill(dtResult);
            return dtResult;
        }
        public int XoaCH(string MaCH)
        {
            int iResult = -1;
            SqlCommand sqlcmd = new SqlCommand("deleteCH", dataCH.sqlConn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaCH", MaCH);
            DialogResult dia = MessageBox.Show($"Bạn có chắc chắn muốn xóa {MaCH} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        public int SuaCH(string MaCH, string TenCH)
        {
            int iResult = -1;
            SqlCommand sqlcmd = new SqlCommand("updateCH", dataCH.sqlConn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaCH", MaCH);
            sqlcmd.Parameters.AddWithValue("@TenCH", TenCH);

            DialogResult dia = MessageBox.Show($"Bạn có chắc chắn muốn sửa {MaCH} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        public int ThemCH(string MaCH , string TenCH)
        {
            CuaHang CH = new CuaHang();
            int iResult = -1;

            SqlCommand sqlcmd = new SqlCommand("insertCH", dataCH.sqlConn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaCH", MaCH);
            sqlcmd.Parameters.AddWithValue("@TenCH", TenCH);
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
