using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace QuanLyThuVienDHKTHN
{
    internal class Themsuaxoa
    {
        //: Phương thức này trả về một đối tượng SqlConnection được sử dụng để kết nối đến cơ sở dữ liệu.
        //Phương thức này được đánh dấu là protected, có nghĩa là nó chỉ có thể được truy cập từ các lớp con.

        protected SqlConnection getConnection()
        {
           
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Demo\\do an\\dbMyThuVien.mdf\";Integrated Security=True;Connect Timeout=30";
            return con;
        }
        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query, String message)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(message,"success",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        public SqlDataReader getForcombo(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
        public SqlConnection GetConnection()
        {
            return getConnection();
        }
        
    }
}
