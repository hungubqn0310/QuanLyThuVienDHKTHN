using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienDHKTHN.All_User_Control
{
    public partial class UC_TimKiem : UserControl
    {
        Themsuaxoa fn = new Themsuaxoa();
        String query;
        public UC_TimKiem()
        {
            InitializeComponent();
        }
        private void UC_TimKiem_Load(object sender, EventArgs e)
        {
            loadData1();
            guna2DataGridView1.Columns["masach"].HeaderText = "Mã sách";
            guna2DataGridView1.Columns["tensach"].HeaderText = "Tên sách";
            guna2DataGridView1.Columns["namxb"].HeaderText = "Năm xuất bản";
            guna2DataGridView1.Columns["manxb"].HeaderText = "Mã nhà xuất bản";
            guna2DataGridView1.Columns["matheloai"].HeaderText = "Mã thể loại";
            guna2DataGridView1.Columns["matacgia"].HeaderText = "Mã tác giả";
            loadData2();
            guna2DataGridView2.Columns["madocgia"].HeaderText = "Mã độc giả";
            guna2DataGridView2.Columns["hoten"].HeaderText = "Tên độc giả";
            guna2DataGridView2.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            guna2DataGridView2.Columns["gioitinh"].HeaderText = "Giới tính";
            guna2DataGridView2.Columns["lop"].HeaderText = "Lớp";
            guna2DataGridView2.Columns["dienthoai"].HeaderText = "Số điện thoại";

        }
        private void DisplayData(string query)
        {
            // Thực hiện truy vấn và nhận DataTable
            DataSet dt = fn.getData(query);

            // Kiểm tra xem có dữ liệu hay không
            if (dt != null)
            {
                // Hiển thị dữ liệu lên DataGridView
                guna2DataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu.");
            }
        }
        private void loadData2()
        {
            query = "SELECT * FROM docgia";
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }
        private void loadData1()
        {
            query = "SELECT * FROM sach";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        private void txtTimSach_TextChanged(object sender, EventArgs e)
        {
            // Lấy tên sách từ TextBox
            string tenSach = txtTimSach.Text.Trim();

            // Kiểm tra xem tên sách có rỗng không
            if (!string.IsNullOrEmpty(tenSach))
            {
                // Sửa câu truy vấn để tìm sách với tên bắt đầu bằng các ký tự đã nhập
                query = "SELECT * FROM sach WHERE tensach LIKE '" + tenSach + "%'";

                // Gọi phương thức DisplayData để thực hiện truy vấn và hiển thị kết quả
                DisplayData(query);
            }
            else
            {
                // Nếu tên sách rỗng, tải lại tất cả dữ liệu
                loadData1();
            }
        }
        private void btnTimSach_Click(object sender, EventArgs e)
        {
            if (rbMaSach.Checked)
            {
                // Lấy mã sách từ textbox
                string maSach = txtTimSach.Text.Trim();

                // Kiểm tra xem mã sách có rỗng không
                if (maSach != "")
                {
                    // Tạo câu truy vấn SQL
                    query = "SELECT * FROM sach WHERE masach = '" + maSach + "'";

                    // Gọi hàm để thực hiện tìm kiếm và hiển thị kết quả lên DataGridView
                    DataSet ds = fn.getData(query);
                    guna2DataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã sách.");
                }
            }
            else if (rbTenSach.Checked)
            {
                // Lấy tên sách từ TextBox
                string tenSach = txtTimSach.Text.Trim();

                // Kiểm tra xem tên sách có rỗng không
                query = "SELECT * FROM sach WHERE tensach LIKE '" + tenSach + "%'";

                // Gọi phương thức DisplayData để thực hiện truy vấn và hiển thị kết quả
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }


        }

        private void btnTimDG_Click(object sender, EventArgs e)
        {
            if (rbMaDG.Checked)
            {
                // Lấy mã độc giả từ textbox
                string maDocGia = txtTimDG.Text.Trim();

                // Kiểm tra xem mã độc giả có rỗng không
                if (maDocGia != "")
                {
                    // Tạo câu truy vấn SQL
                    query = "SELECT * FROM docgia WHERE madocgia = '" + maDocGia + "'";

                    // Gọi hàm để thực hiện tìm kiếm và hiển thị kết quả lên DataGridView
                    DataSet ds = fn.getData(query);
                    guna2DataGridView2.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã độc giả.");
                }
            }
            else if (rbTenDG.Checked)
            {
                // Lấy tên độc giả từ TextBox
                string tenDocGia = txtTimDG.Text.Trim();

                // Kiểm tra xem tên độc giả có rỗng không
                query = "SELECT * FROM docgia WHERE hoten LIKE '" + tenDocGia + "%'";

                // Gọi phương thức DisplayData để thực hiện truy vấn và hiển thị kết quả
                DataSet ds = fn.getData(query);
                guna2DataGridView2.DataSource = ds.Tables[0];
            }
        }
    }
}
