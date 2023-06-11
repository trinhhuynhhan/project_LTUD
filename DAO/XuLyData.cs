using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAO
{
    public class XuLyData
    {
      public  SqlConnection sqlConn = new SqlConnection();

        public XuLyData()
        {
            sqlConn.ConnectionString =@"Data Source=LAPTOP-4I6GQ1QK\MISASME2021;Initial Catalog=UDQuanLyDienThoai;Integrated Security=True";
            try
            {
                sqlConn.Open();
                MessageBox.Show("Kết nối thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối SQL thất bại" + ex.Message);
                throw;
            }
        }

       
    }
}
