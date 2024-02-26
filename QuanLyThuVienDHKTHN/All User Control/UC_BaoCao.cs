using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyThuVienDHKTHN.All_User_Control
{
    
    public partial class UC_BaoCao : UserControl
    {
        Themsuaxoa fn = new Themsuaxoa();
        String query;
        public UC_BaoCao()
        {
            InitializeComponent();
        }

        private void UC_BaoCao_Load(object sender, EventArgs e)
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
            guna2DataGridView2.Columns["dienthoai"].HeaderText = "Điện thoại";
        }
        private void loadData1()
        {
            query = "SELECT * FROM sach";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        private void loadData2()
        {
            query = "SELECT * FROM docgia";
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string selectedValue = cbTKSach.SelectedItem.ToString();

            // Gọi hàm thống kê dữ liệu và hiển thị lên dataGridView
            ThongKeVaHienThiDuLieu(selectedValue);
        }
        private void ThongKeVaHienThiDuLieu(string selectedValue)
        {
            // Xây dựng câu truy vấn tùy thuộc vào giá trị đã chọn từ combobox
            if (selectedValue == "Tất cả sách")
            {
                // Trường hợp "Tất cả sách"
                query = "SELECT * FROM sach"; // Thay YourTable bằng tên bảng thực tế
            }
            else if(selectedValue == "Sách đang mượn")
            {
                query = "select sach.masach,sach.tensach, nhaxb.tennxb,sach.namxb,theloai.tentheloai from sach, nhaxb,chitietmuon, theloai where (sach.manxb=nhaxb.manxb and sach.matheloai=theloai.matheloai and sach.masach=chitietmuon.masach)";
            }
            else if(selectedValue == "Sách trễ hạn")
            {
                query = "select sach.masach,sach.tensach, nhaxb.tennxb,sach.namxb,theloai.tentheloai from sach, nhaxb,chitietmuon, theloai where (sach.manxb=nhaxb.manxb and sach.matheloai=theloai.matheloai and sach.masach=chitietmuon.masach and chitietmuon.ngaytra<GETDATE())";
            }

            // Thực hiện truy vấn và nhận dữ liệu vào DataTable
            DataSet ds = fn.getData(query);

            // Hiển thị dữ liệu lên dataGridView
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnThongKeDG_Click(object sender, EventArgs e)
        {
            string selectedValue = cbThongKeDG.SelectedItem.ToString();
            if (selectedValue == "Tất cả độc giả")
            {
                // Trường hợp "Tất cả sách"
                query = "SELECT * FROM docgia"; // Thay YourTable bằng tên bảng thực tế
            }
            else if (selectedValue == "Độc giả trễ hạn")
            {
                query = "select distinct docgia.madocgia,docgia.hoten, docgia.ngaysinh,docgia.gioitinh, docgia.lop, docgia.dienthoai from docgia, phieumuon,chitietmuon where(docgia.madocgia= phieumuon.madocgia and phieumuon.maphieu= chitietmuon.mapm and chitietmuon.ngaytra<GETDATE())";
            }
            

            // Thực hiện truy vấn và nhận dữ liệu vào DataTable
            DataSet ds = fn.getData(query);

            // Hiển thị dữ liệu lên dataGridView
            guna2DataGridView2.DataSource = ds.Tables[0];
        }
    }
}
