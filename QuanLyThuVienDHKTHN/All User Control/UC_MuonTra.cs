using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienDHKTHN.All_User_Control
{
    public partial class UC_MuonTra : UserControl
    {
        Themsuaxoa fn = new Themsuaxoa();
        String query;
        public UC_MuonTra()
        {
            InitializeComponent();
        }
        private void UC_MuonTra_Load(object sender, EventArgs e)
        {
            loadData1();
            
            guna2DataGridView1.Columns["maphieu"].HeaderText = "Mã phiếu";
            guna2DataGridView1.Columns["madocgia"].HeaderText = "Mã độc giả";
            guna2DataGridView1.Columns["nguoilapphieu"].HeaderText = "Mã nhân viên lập phiếu";
            loadData2();
            guna2DataGridView2.Columns["mapm"].HeaderText = "Mã phiếu mượn";
            guna2DataGridView2.Columns["masach"].HeaderText = "Mã sách";
            guna2DataGridView2.Columns["ngaymuon"].HeaderText = "Ngày mượn";
            guna2DataGridView2.Columns["ngaytra"].HeaderText = "Ngày hẹn trả";
            guna2DataGridView2.Columns["ghichu"].HeaderText = "Tình trạng sách";

        }
        private void loadData1()
        {
            query = "select * from phieumuon";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            query = "SELECT * FROM docgia";
            DataSet dsDG = fn.getData(query);
            txtMaDG.DataSource = dsDG.Tables[0];
            txtMaDG.DisplayMember = "hoten"; 
            txtMaDG.ValueMember = "madocgia";
            query = "SELECT * FROM nhanvien";
            DataSet dsNV = fn.getData(query);
            txtMaNV.DataSource = dsNV.Tables[0];
            txtMaNV.DisplayMember = "hoten";
            txtMaNV.ValueMember = "manv";

        }
        private void loadData2()
        {
            query = "SELECT * FROM chitietmuon";
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
            query = "SELECT * FROM phieumuon";
            DataSet dsPhieuMuon = fn.getData(query);
            txtMaPhieuMT.DataSource = dsPhieuMuon.Tables[0];
            txtMaPhieuMT.DisplayMember = "maphieu";
            txtMaPhieuMT.ValueMember = "maphieu";
            // ComboBox cho mã sách
            query = "SELECT * FROM sach";
            DataSet dsSach = fn.getData(query);
            txtMaSachMT.DataSource = dsSach.Tables[0];
            txtMaSachMT.DisplayMember = "tensach";
            txtMaSachMT.ValueMember = "masach";
            
        }
        public void clearAll()
        {
            txtMaPhieu.Clear();
            txtMaDG.SelectedIndex = -1;
            txtMaNV.SelectedIndex = -1;
            txtMaPhieuMT.SelectedIndex = -1;
            txtMaSachMT.SelectedIndex = -1;
            txtDateMuon.ResetText();
            txtDateTra.ResetText();
            
        }
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            if(txtMaPhieu.Text != "" && txtMaDG.Text != "" && txtMaNV.Text != "")
            {
                string maPhieu = txtMaPhieu.Text;
                string maDocGia = txtMaDG.SelectedValue.ToString();
                string maNhanVien = txtMaNV.SelectedValue.ToString();
                query = "INSERT INTO phieumuon (maphieu, madocgia, nguoilapphieu) VALUES('" + maPhieu + "','" + maDocGia + "','" + maNhanVien + "')";
                fn.setData(query, "Đã tạo phiếu");
                tabPage1_Click(this, null);
                loadData1();
                clearAll();
            }
        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = guna2DataGridView1.SelectedRows[0].Index;

                // Lấy dữ liệu từ hàng được chọn trong DataGridView
                string maPhieu = guna2DataGridView1.Rows[selectedIndex].Cells["maphieu"].Value.ToString();
                string maDocGia = guna2DataGridView1.Rows[selectedIndex].Cells["madocgia"].Value.ToString();
                string maNhanVien = guna2DataGridView1.Rows[selectedIndex].Cells["nguoilapphieu"].Value.ToString();
                

                // Hiển thị dữ liệu trong các ô văn bản hoặc ô chọn để chỉnh sửa
                txtMaPhieu.Text = maPhieu;
                txtMaDG.SelectedValue = maDocGia;
                txtMaNV.SelectedValue = maNhanVien;
            }
        }

        private void btnLuu1_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaPhieu.Text;
            string maDocGia = txtMaDG.SelectedValue.ToString();
            string maNhanVien = txtMaNV.SelectedValue.ToString();

            // Cập nhật dữ liệu trong cơ sở dữ liệu
            query = "UPDATE phieumuon SET madocgia='" + maDocGia + "', nguoilapphieu='" + maNhanVien + "' WHERE maphieu='" + maPhieu + "'";
            fn.setData(query, "Đã cập nhật");
            loadData1();
            clearAll();
        }

        private void btnDel1_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = guna2DataGridView1.SelectedRows[0].Index;
                string maPhieu = guna2DataGridView1.Rows[selectedIndex].Cells["maphieu"].Value.ToString();

                query = "DELETE FROM phieumuon WHERE maphieu='" + maPhieu + "'";
                fn.setData(query, "Đã xóa");
                loadData1();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            loadData1();
        }
        
        
        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuMT.Text != "" && txtDateMuon.Text != "" && txtDateTra.Text != "" && txtTinhTrang.Text != "")
            {
                string maPhieu = txtMaPhieuMT.SelectedValue.ToString();
                string ngayMuon = txtDateMuon.Text;
                string ngayHenTra = txtDateTra.Text;
                string tinhTrangSach = txtTinhTrang.Text;

                foreach (var checkedItem in txtMaSachMT.CheckedItems)
                {
                    // Lấy mã sách từ mục được chọn
                    string maSach = ((DataRowView)checkedItem)["masach"].ToString(); // Điều chỉnh dựa trên nguồn dữ liệu của bạn

                    // Thêm vào DataGridView
                    query = $"INSERT INTO chitietmuon (mapm, masach, ngaymuon, ngaytra, ghichu) VALUES('{maPhieu}', '{maSach}', '{ngayMuon}', '{ngayHenTra}', '{tinhTrangSach}')";
                    fn.setData(query, "Đã tạo");
                }

                tabPage2_Click(this, null);
                loadData2();
                clearAll();
            }
        }
        private void btnDel2_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView2.SelectedRows.Count > 0)
            {
                int selectedIndex = guna2DataGridView2.SelectedRows[0].Index;
                string mapm = guna2DataGridView2.Rows[selectedIndex].Cells["mapm"].Value.ToString();

                query = "DELETE FROM chitietmuon WHERE mapm='" + mapm + "'";
                fn.setData(query, "Đã xóa");
                loadData2();
            }
        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView2.SelectedRows.Count > 0)
            {
                int selectedIndex = guna2DataGridView2.SelectedRows[0].Index;

                // Lấy dữ liệu từ hàng được chọn trong DataGridView
                
                string maPhieu = guna2DataGridView2.Rows[selectedIndex].Cells["mapm"].Value.ToString();
                string maSach = guna2DataGridView2.Rows[selectedIndex].Cells["masach"].Value.ToString();
                string ngayMuon = guna2DataGridView2.Rows[selectedIndex].Cells["ngaymuon"].Value.ToString();
                string ngayHenTra = guna2DataGridView2.Rows[selectedIndex].Cells["ngaytra"].Value.ToString();
                string tinhTrangSach = guna2DataGridView2.Rows[selectedIndex].Cells["ghichu"].Value.ToString();

                // Hiển thị dữ liệu trong các ô văn bản hoặc ô chọn để chỉnh sửa
               
                txtMaPhieuMT.SelectedValue = maPhieu;
                txtMaSachMT.SelectedValue = maSach;
                txtDateMuon.Text = ngayMuon;
                txtDateTra.Text = ngayHenTra;
                txtTinhTrang.Text = tinhTrangSach;
            }
        }

        private void btnLuu2_Click(object sender, EventArgs e)
        {
            
            string maPhieu = txtMaPhieuMT.SelectedValue.ToString();
            string maSach = txtMaSachMT.SelectedValue.ToString();
            string ngayMuon = txtDateMuon.Text;
            string ngayHenTra = txtDateTra.Text;
            string tinhTrangSach = txtTinhTrang.Text;

            // Cập nhật dữ liệu trong cơ sở dữ liệu
            query = "UPDATE chitietmuon SET masach='" + maSach + "', ngaymuon='" + ngayMuon + "', ngaytra='" + ngayHenTra + "', ghichu='" + tinhTrangSach + "' where mapm='" + maPhieu + "'";
            fn.setData(query, "Đã cập nhật");
            loadData2();
            clearAll();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            loadData2();
        }
    }
}
