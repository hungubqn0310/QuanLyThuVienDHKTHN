using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVienDHKTHN
{
    public partial class Form2 : Form
    {
        Themsuaxoa fn = new Themsuaxoa();
        String query;
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btnGuiMail_Click(object sender, EventArgs e)
        {
            string emailAddress = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(emailAddress))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                using (SqlConnection connection = fn.GetConnection()) {
                    connection.Open();
                    // Truy vấn CSDL để lấy thông tin tên người dùng và mật khẩu tương ứng với địa chỉ email
                    string query = "SELECT username, pass FROM nhanvien WHERE emailid = @emailid";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@emailid", emailAddress);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string userName = reader["username"].ToString();
                                string password = reader["pass"].ToString();

                                // Tạo và hiển thị textbox mới
                                CreateAndShowTextbox(userName, password);
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy thông tin cho địa chỉ email này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }

            }    }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CreateAndShowTextbox(string username, string pass)
        {
            string message = $"Tên người dùng: {username}\nMật khẩu: {pass}";

            MessageBox.Show(message, "Thông tin người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
