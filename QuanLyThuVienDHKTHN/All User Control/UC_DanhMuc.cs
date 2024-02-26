using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienDHKTHN.All_User_Control
{
    
    public partial class UC_DanhMuc : UserControl
    {
        
        Themsuaxoa fn = new Themsuaxoa();
        String query;
        public UC_DanhMuc()
        {
            InitializeComponent();
        }
        private void SetDataGridViewFont(Guna.UI2.WinForms.Guna2DataGridView dataGridView)
        {
            // Thiết lập font cho các ô trong DataGridView
            dataGridView.DefaultCellStyle.Font = new Font("Arial", 12);

            // Thiết lập font cho tiêu đề cột
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
        }
        private void UC_DanhMuc_Load(object sender, EventArgs e)
        {
            
            loadData6();
            guna2DataGridView1.Columns["manxb"].HeaderText = "Mã nhà xuất bản";
            guna2DataGridView1.Columns["tennxb"].HeaderText = "Tên nhà xuất bản";
            guna2DataGridView1.Columns["diachi"].HeaderText = "Địa Chỉ";
            guna2DataGridView1.Columns["sdtnxb"].HeaderText = "Điện Thoại";

            loadData5();
            guna2DataGridView2.Columns["matacgia"].HeaderText = "Mã tác giả";
            guna2DataGridView2.Columns["tentacgia"].HeaderText = "Tên tác giả";
            loadData4();
            guna2DataGridView3.Columns["matheloai"].HeaderText = "Mã thể loại";
            guna2DataGridView3.Columns["tentheloai"].HeaderText = "Tên thể loại";
            loadData3();
            guna2DataGridView4.Columns["masach"].HeaderText = "Mã sách";
            guna2DataGridView4.Columns["tensach"].HeaderText = "Tên sách";
            guna2DataGridView4.Columns["namxb"].HeaderText = "Năm xuất bản";
            guna2DataGridView4.Columns["manxb"].HeaderText = "Mã nhà xuất bản";
            guna2DataGridView4.Columns["matheloai"].HeaderText = "Mã thể loại";
            guna2DataGridView4.Columns["matacgia"].HeaderText = "Mã tác giả";
            loadData2();
            guna2DataGridView5.Columns["manv"].HeaderText = "Mã nhân viên";
            guna2DataGridView5.Columns["hoten"].HeaderText = "Tên nhân viên";
            guna2DataGridView5.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            guna2DataGridView5.Columns["gioitinh"].HeaderText = "Giới tính";
            guna2DataGridView5.Columns["diachi"].HeaderText = "Địa chỉ";
            guna2DataGridView5.Columns["dienthoai"].HeaderText = "Điện thoại";
            guna2DataGridView5.Columns["emailid"].HeaderText = "Email";
            guna2DataGridView5.Columns["username"].HeaderText = "Tên đăng nhập";
            guna2DataGridView5.Columns["pass"].HeaderText = "Mật khẩu";
            loadData1();
            guna2DataGridView6.Columns["madocgia"].HeaderText = "Mã độc giả";
            guna2DataGridView6.Columns["hoten"].HeaderText = "Tên độc giả";
            guna2DataGridView6.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            guna2DataGridView6.Columns["gioitinh"].HeaderText = "Giới tính";
            guna2DataGridView6.Columns["lop"].HeaderText = "Lớp";
            guna2DataGridView6.Columns["dienthoai"].HeaderText = "Điện thoại";
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {
            loadData3();
        }
        private void tabPage4_Click(object sender, EventArgs e)
        {
            loadData4();
        }
        private void tabPage5_Click_1(object sender, EventArgs e)
        {
            loadData5();
        }
        private void tabPage6_Click(object sender, EventArgs e)
        {
            loadData6();
        }
        private void btnAdd6_Click_1(object sender, EventArgs e)
        {
            if (txtMaxb.Text != "" && txtTenxb.Text != "" && txtDCxb.Text != "" && txtDTxb.Text != "")
            {
                String MaXB = txtMaxb.Text;
                String TenXB = txtTenxb.Text;
                String DiaChi = txtDCxb.Text;
                String DienThoai = txtDTxb.Text;

                query = "insert into nhaxb (manxb, tennxb, diachi, sdtnxb) values('" + MaXB + "','" + TenXB + "','" + DiaChi + "','" + DienThoai + "')";
                fn.setData(query, "Đã thêm nhà xuất bản");
                tabPage6_Click(this, null);
                loadData1();
                clearAll();
            }
        }
        private void loadData1()
        {
            guna2DataGridView6.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            query = "select * from docgia";
            DataSet ds = fn.getData(query);
            guna2DataGridView6.DataSource = ds.Tables[0];
        }
        private void loadData2()
        {
            query = "select * from nhanvien";
            DataSet ds = fn.getData(query);
            guna2DataGridView5.DataSource = ds.Tables[0];
        }
        private void loadData3()
        {
            // Load dữ liệu vào DataGridView
            query = "select * from sach";
            DataSet ds = fn.getData(query);
            guna2DataGridView4.DataSource = ds.Tables[0];
            query = "SELECT * FROM nhaxb";
            DataSet dsNXB = fn.getData(query);
            ComboBoxNXB.DataSource = dsNXB.Tables[0];
            ComboBoxNXB.DisplayMember = "tennxb"; // Hiển thị tên nhà xuất bản
            ComboBoxNXB.ValueMember = "manxb";
            query = "SELECT * FROM tacgia";
            DataSet dsTG = fn.getData(query);
            ComboBoxTacGia.DataSource = dsTG.Tables[0];
            ComboBoxTacGia.DisplayMember = "tentacgia"; // Hiển thị tên nhà xuất bản
            ComboBoxTacGia.ValueMember = "matacgia";
            query = "SELECT * FROM theloai";
            DataSet dsTL = fn.getData(query);
            ComboBoxTheLoai.DataSource = dsTL.Tables[0];
            ComboBoxTheLoai.DisplayMember = "tentheloai"; // Hiển thị tên nhà xuất bản
            ComboBoxTheLoai.ValueMember = "matheloai";
            SetDataGridViewFont(guna2DataGridView4);
        }
        private void loadData4()
        {
            // Load dữ liệu vào DataGridView
            query = "select * from theloai";
            DataSet ds = fn.getData(query);
            guna2DataGridView3.DataSource = ds.Tables[0];
            SetDataGridViewFont(guna2DataGridView3);

        }
        private void loadData5()
        {
            // Load dữ liệu vào DataGridView
            query = "select * from tacgia";
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
            SetDataGridViewFont(guna2DataGridView2);

        }
        private void loadData6()
        {
            // Load dữ liệu vào DataGridView
            query = "select * from nhaxb";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            SetDataGridViewFont(guna2DataGridView1);

        }
        public void clearAll()
        {
            txtMaxb.Clear();
            txtTenxb.Clear();
            txtDCxb.Clear();
            txtDTxb.Clear();
            txtTentacgia.Clear();
            txtMatacgia.Clear();
            txtMatheloai.Clear();
            txtTentheloai.Clear();
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtdatexb.Clear();
            ComboBoxNXB.SelectedIndex = -1;
            ComboBoxTacGia.SelectedIndex = -1;
            ComboBoxTheLoai.SelectedIndex = -1;
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDateNV.ResetText();
            txtDiaChiNV.Clear();
            txtDTNV.Clear();
            txtGioiTinhNV.SelectedIndex = -1;
            txtMail.Clear();
            txtUsername.Clear();
            txtPass.Clear();
            txtMaDG.Clear();
            txtTenDG.Clear();
            txtDateDG.ResetText();
            txtGioiTinhDG.SelectedIndex = -1;
            txtLopDG.Clear();
            txtDTDG.Clear();
        }
        private void btnDel6_Click_1(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = guna2DataGridView1.SelectedRows[0].Index;
                string MaXB = guna2DataGridView1.Rows[selectedIndex].Cells["manxb"].Value.ToString();

                query = "delete from nhaxb where manxb='" + MaXB + "'";
                fn.setData(query, "Đã xóa nhà xuất bản");
                loadData6();
            }
        }
        
        private void CapNhatDuLieu4(string maTheLoai, string tenTheLoai)
        {
            query = "update theloai set tentheloai='" + tenTheLoai + "' where matheloai ='" + maTheLoai + "'";
            fn.setData(query, "Đã cập nhật thể loại");
            loadData4();
        }
        private void CapNhatDuLieu5(string maTacGia, string tenTacGia)
        {
            query = "update tacgia set tentacgia='" + tenTacGia + "' where matacgia ='" + maTacGia + "'";
            fn.setData(query, "Đã cập nhật tác giả");
            loadData5();
        }
        private void CapNhatDuLieu6(string maXB, string tenXB, string diaChi, string dienThoai)
        {
            query = "update nhaxb set tennxb='" + tenXB + "', diachi='" + diaChi + "', sdtnxb='" + dienThoai + "' where manxb='" + maXB + "'";
            fn.setData(query, "Đã cập nhật nhà xuất bản");
            loadData6();
        }
        private void btnSua6_Click_1(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = guna2DataGridView1.SelectedRows[0].Index;

                // Lấy dữ liệu cũ từ DataGridView
                string maXB = guna2DataGridView1.Rows[selectedIndex].Cells["manxb"].Value.ToString();
                string tenXB = guna2DataGridView1.Rows[selectedIndex].Cells["tennxb"].Value.ToString();
                string diaChi = guna2DataGridView1.Rows[selectedIndex].Cells["diachi"].Value.ToString();
                string dienThoai = guna2DataGridView1.Rows[selectedIndex].Cells["sdtnxb"].Value.ToString();

                // Hiển thị dữ liệu cũ lên các TextBox
                txtMaxb.Text = maXB;
                txtTenxb.Text = tenXB;
                txtDCxb.Text = diaChi;
                txtDTxb.Text = dienThoai;
            }
        }
        private void btnLuu6_Click_1(object sender, EventArgs e)
        {
            string maXB = txtMaxb.Text;
            string tenXB = txtTenxb.Text;
            string diaChi = txtDCxb.Text;
            string dienThoai = txtDTxb.Text;

            // Gọi phương thức cập nhật dữ liệu
            CapNhatDuLieu6(maXB, tenXB, diaChi, dienThoai);

            // Xóa trắng các TextBox sau khi cập nhật
            clearAll();
        }

        
        private void btnAdd5_Click_1(object sender, EventArgs e)
        {
            if (txtMatacgia.Text != "" && txtTentacgia.Text != "")
            {
                String Matacgia = txtMatacgia.Text;
                String Tentacgia = txtTentacgia.Text;

                query = "insert into tacgia (matacgia, tentacgia) values('" + Matacgia + "','" + Tentacgia + "')";
                fn.setData(query, "Đã thêm nhà xuất bản");
                tabPage5_Click_1(this, null);
                clearAll();
            }
        }

        private void btnDel5_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView2.SelectedRows.Count > 0)
            {
                int selectedIndex = guna2DataGridView2.SelectedRows[0].Index;
                string Matacgia = guna2DataGridView2.Rows[selectedIndex].Cells["matacgia"].Value.ToString();

                query = "delete from tacgia where matacgia='" + Matacgia + "'";
                fn.setData(query, "Đã xóa tác giả");
                loadData5();
            }
        }
        private int selectedTacGiaIndex = -1;
        private int selectedTheLoaiIndex = -1;
        private void btnSua5_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView2.SelectedRows.Count > 0)
            {
                int selectedIndex = guna2DataGridView2.SelectedRows[0].Index;
                selectedTacGiaIndex = selectedIndex;

                // Lấy dữ liệu cũ từ DataGridView
                string maTacGia = guna2DataGridView2.Rows[selectedIndex].Cells["matacgia"].Value.ToString();
                string tenTacGia = guna2DataGridView2.Rows[selectedIndex].Cells["tentacgia"].Value.ToString();

                // Hiển thị dữ liệu cũ lên các ô văn bản
                txtMatacgia.Text = maTacGia;
                txtTentacgia.Text = tenTacGia;
            }
        }

        private void btnLuu5_Click(object sender, EventArgs e)
        {
            if (selectedTacGiaIndex != -1)
            {
                string maTacGia = txtMatacgia.Text;
                string tenTacGia = txtTentacgia.Text;

                // Gọi phương thức cập nhật dữ liệu
                CapNhatDuLieu5(maTacGia, tenTacGia);

                // Xóa trắng các ô văn bản sau khi cập nhật
                clearAll();

                // Đặt lại chỉ mục đã chọn
                selectedTacGiaIndex = -1;
            }
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            if (txtMatheloai.Text != "" && txtTentheloai.Text != "")
            {
                String Matheloai = txtMatheloai.Text;
                String Tentheloai = txtTentheloai.Text;

                query = "insert into theloai (matheloai, tentheloai) values('" + Matheloai + "','" + Tentheloai + "')";
                fn.setData(query, "Đã thêm thể loại");
                tabPage4_Click(this, null);
                clearAll();
            }
        }

        private void btnDel4_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView3.SelectedRows.Count > 0)
            {
                int selectedIndex = guna2DataGridView3.SelectedRows[0].Index;
                string Matheloai = guna2DataGridView3.Rows[selectedIndex].Cells["matheloai"].Value.ToString();

                query = "delete from theloai where matheloai='" + Matheloai + "'";
                fn.setData(query, "Đã xóa thể loại");
                loadData4();
            }
        }

        private void btnSua4_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView3.SelectedRows.Count > 0)
            {
                int selectedIndex = guna2DataGridView3.SelectedRows[0].Index;
                selectedTheLoaiIndex = selectedIndex;

                // Lấy dữ liệu cũ từ DataGridView
                string maTheLoai = guna2DataGridView3.Rows[selectedIndex].Cells["matheloai"].Value.ToString();
                string tenTheLoai = guna2DataGridView3.Rows[selectedIndex].Cells["tentheloai"].Value.ToString();

                // Hiển thị dữ liệu cũ lên các ô văn bản
                txtMatheloai.Text = maTheLoai;
                txtTentheloai.Text = tenTheLoai;
            }
        }

        private void btnLuu4_Click(object sender, EventArgs e)
        {
            if(selectedTheLoaiIndex != -1)
            {
                string maTheLoai = txtMatheloai.Text;
                string tenTheLoai = txtTentheloai.Text; 
                
                CapNhatDuLieu4(maTheLoai, tenTheLoai);

                // Xóa trắng các ô văn bản sau khi cập nhật
                clearAll();

                // Đặt lại chỉ mục đã chọn
                selectedTheLoaiIndex = -1;
            }
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "" && txtTenSach.Text != "" && txtdatexb.Text != "" && ComboBoxNXB.Text != "" && ComboBoxTheLoai.Text != "" && ComboBoxTacGia.Text != "")
            {
                string MaSach = txtMaSach.Text;
                string TenSach = txtTenSach.Text;
                string NamXB = txtdatexb.Text;
                string MaNXB = ComboBoxNXB.SelectedValue.ToString(); // Giả sử ComboBoxNXB là ComboBox được nạp với dữ liệu nhà xuất bản
                string MaTheLoai = ComboBoxTheLoai.SelectedValue.ToString(); // Giả sử ComboBoxTheLoai là ComboBox được nạp với dữ liệu thể loại
                string MaTacGia = ComboBoxTacGia.SelectedValue.ToString(); // Giả sử ComboBoxTacGia là ComboBox được nạp với dữ liệu tác giả

                query = "INSERT INTO sach (masach, tensach, namxb, manxb, matheloai, matacgia) VALUES('" + MaSach + "','" + TenSach + "','" + NamXB + "','" + MaNXB + "','" + MaTheLoai + "','" + MaTacGia + "')";
                fn.setData(query, "Đã thêm sách");
                loadData3();
                clearAll();
            }
        }

        private void btnDel3_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView4.SelectedRows.Count > 0)
            {
                int selectedIndex = guna2DataGridView4.SelectedRows[0].Index;
                string MaSach = guna2DataGridView4.Rows[selectedIndex].Cells["masach"].Value.ToString();

                query = "DELETE FROM sach WHERE masach='" + MaSach + "'";
                fn.setData(query, "Đã xóa sách");
                loadData3();
            }
        }

        private void btnSua3_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView4.SelectedRows.Count > 0)
            {
                int selectedIndex = guna2DataGridView4.SelectedRows[0].Index;

                // Lấy dữ liệu từ hàng được chọn trong DataGridView
                string MaSach = guna2DataGridView4.Rows[selectedIndex].Cells["masach"].Value.ToString();
                string TenSach = guna2DataGridView4.Rows[selectedIndex].Cells["tensach"].Value.ToString();
                string NamXB = guna2DataGridView4.Rows[selectedIndex].Cells["namxb"].Value.ToString();
                string MaNXB = guna2DataGridView4.Rows[selectedIndex].Cells["manxb"].Value.ToString();
                string MaTheLoai = guna2DataGridView4.Rows[selectedIndex].Cells["matheloai"].Value.ToString();
                string MaTacGia = guna2DataGridView4.Rows[selectedIndex].Cells["matacgia"].Value.ToString();

                // Hiển thị dữ liệu trong các ô văn bản hoặc ô chọn để chỉnh sửa
                txtMaSach.Text = MaSach;
                txtTenSach.Text = TenSach;
                txtdatexb.Text = NamXB;
                ComboBoxNXB.SelectedValue = MaNXB;
                ComboBoxTheLoai.SelectedValue = MaTheLoai;
                ComboBoxTacGia.SelectedValue = MaTacGia;
            }
        }
        private void btnLuu3_Click(object sender, EventArgs e)
        {
            string MaSach = txtMaSach.Text;
            string TenSach = txtTenSach.Text;
            string NamXB = txtdatexb.Text;
            string MaNXB = ComboBoxNXB.SelectedValue.ToString();
            string MaTheLoai = ComboBoxTheLoai.SelectedValue.ToString();
            string MaTacGia = ComboBoxTacGia.SelectedValue.ToString();

            // Cập nhật dữ liệu trong cơ sở dữ liệu
            query = "UPDATE sach SET tensach='" + TenSach + "', namxb='" + NamXB + "', manxb='" + MaNXB + "', matheloai='" + MaTheLoai + "', matacgia='" + MaTacGia + "' WHERE masach='" + MaSach + "'";
            fn.setData(query, "Đã cập nhật sách");
            loadData3();
            clearAll();
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtTenNV.Text != "" && txtDateNV.Text != "" && txtGioiTinhNV.Text != "" &&
           txtDiaChiNV.Text != "" && txtDTNV.Text != "" && txtMail.Text != "" && txtUsername.Text != "" && txtPass.Text != "")
            {
                string maNV = txtMaNV.Text;
                string tenNV = txtTenNV.Text;
                string ngaySinh = txtDateNV.Text;
                string gioiTinh = txtGioiTinhNV.Text;
                string diaChi = txtDiaChiNV.Text;
                string dienThoai = txtDTNV.Text;
                string email = txtMail.Text;
                string tenDangNhap = txtUsername.Text;
                string matKhau = txtPass.Text;

                query = $"insert into nhanvien (manv, hoten, ngaysinh, gioitinh, diachi, dienthoai, emailid, username, pass) " +
                        $"values('{maNV}','{tenNV}','{ngaySinh}','{gioiTinh}','{diaChi}','{dienThoai}','{email}','{tenDangNhap}','{matKhau}')";
                fn.setData(query, "Đã thêm nhân viên");
                loadData2();
                clearAll();
            }
        }

        private void btnDel2_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView5.SelectedRows.Count > 0)
            {
                int selectedIndex = guna2DataGridView5.SelectedRows[0].Index;
                string maNV = guna2DataGridView5.Rows[selectedIndex].Cells["manv"].Value.ToString();

                query = $"delete from nhanvien where manv='{maNV}'";
                fn.setData(query, "Đã xóa nhân viên");
                loadData2();
            }
        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView5.SelectedRows.Count > 0)
            {
                int selectedIndex = guna2DataGridView5.SelectedRows[0].Index;

                string maNV = guna2DataGridView5.Rows[selectedIndex].Cells["manv"].Value.ToString();
                string tenNV = guna2DataGridView5.Rows[selectedIndex].Cells["hoten"].Value.ToString();
                string ngaySinh = guna2DataGridView5.Rows[selectedIndex].Cells["ngaysinh"].Value.ToString();
                string gioiTinh = guna2DataGridView5.Rows[selectedIndex].Cells["gioitinh"].Value.ToString();
                string diaChi = guna2DataGridView5.Rows[selectedIndex].Cells["diaChi"].Value.ToString();
                string dienThoai = guna2DataGridView5.Rows[selectedIndex].Cells["dienthoai"].Value.ToString();
                string email = guna2DataGridView5.Rows[selectedIndex].Cells["emailid"].Value.ToString();
                string tenDangNhap = guna2DataGridView5.Rows[selectedIndex].Cells["username"].Value.ToString();
                string matKhau = guna2DataGridView5.Rows[selectedIndex].Cells["pass"].Value.ToString();

                txtMaNV.Text = maNV;
                txtTenNV.Text = tenNV;
                txtDateNV.Text = ngaySinh;
                txtGioiTinhNV.Text = gioiTinh;
                txtDiaChiNV.Text = diaChi;
                txtDTNV.Text = dienThoai;
                txtMail.Text = email;
                txtUsername.Text = tenDangNhap;
                txtPass.Text = matKhau;
            }
        }

        private void btnLuu2_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtTenNV.Text;
            string ngaySinh = txtDateNV.Text;
            string gioiTinh = txtGioiTinhNV.Text;
            string diaChi = txtDiaChiNV.Text;
            string dienThoai = txtDTNV.Text;
            string email = txtMail.Text;
            string tenDangNhap = txtUsername.Text;
            string matKhau = txtPass.Text;

            query = $"update nhanvien set hoten='{tenNV}', ngaysinh='{ngaySinh}', gioitinh='{gioiTinh}', diachi='{diaChi}', " +
                    $"dienthoai='{dienThoai}', emailid='{email}', username='{tenDangNhap}', pass='{matKhau}' where maNV='{maNV}'";
            fn.setData(query, "Đã cập nhật thông tin nhân viên");
            loadData2();
            clearAll();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            if (txtMaDG.Text != "" && txtTenDG.Text != "" && txtDateDG.Text != "" &&
            txtGioiTinhDG.Text != "" && txtLopDG.Text != "" && txtDTDG.Text != "")
            {
                string maDocGia = txtMaDG.Text;
                string hoTen = txtTenDG.Text;
                string ngaySinh = txtDateDG.Text;
                string gioiTinh = txtGioiTinhDG.Text;
                string lop = txtLopDG.Text;
                string dienThoai = txtDTDG.Text;

                query = $"insert into docgia (madocgia, hoten, ngaySinh, gioitinh, lop, dienthoai) " +
                        $"values('{maDocGia}','{hoTen}','{ngaySinh}','{gioiTinh}','{lop}','{dienThoai}')";
                fn.setData(query, "Đã thêm độc giả");
                loadData1();
                clearAll();
            }
        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView6.SelectedRows.Count > 0)
            {
                int selectedIndex = guna2DataGridView6.SelectedRows[0].Index;

                string maDocGia = guna2DataGridView6.Rows[selectedIndex].Cells["madocgia"].Value.ToString();
                string hoTenDocGia = guna2DataGridView6.Rows[selectedIndex].Cells["hoten"].Value.ToString();
                string ngaySinhDocGia = guna2DataGridView6.Rows[selectedIndex].Cells["ngaysinh"].Value.ToString();
                string gioiTinhDocGia = guna2DataGridView6.Rows[selectedIndex].Cells["gioitinh"].Value.ToString();
                string lopDocGia = guna2DataGridView6.Rows[selectedIndex].Cells["lop"].Value.ToString();
                string dienThoaiDocGia = guna2DataGridView6.Rows[selectedIndex].Cells["dienthoai"].Value.ToString();

                txtMaDG.Text = maDocGia;
                txtTenDG.Text = hoTenDocGia;
                txtDateDG.Text = ngaySinhDocGia;
                txtGioiTinhDG.Text = gioiTinhDocGia;
                txtLopDG.Text = lopDocGia;
                txtDTDG.Text = dienThoaiDocGia;
            }
        }

        private void btnLuu1_Click(object sender, EventArgs e)
        {
            string maDocGia = txtMaDG.Text;
            string hoTenDocGia = txtTenDG.Text;
            string ngaySinhDocGia = txtDateDG.Text;
            string gioiTinhDocGia = txtGioiTinhDG.Text;
            string lopDocGia = txtLopDG.Text;
            string dienThoaiDocGia = txtDTDG.Text;

            query = $"update docgia set hoten='{hoTenDocGia}', ngaysinh='{ngaySinhDocGia}', gioitinh='{gioiTinhDocGia}', " +
                    $"lop='{lopDocGia}', dienthoai='{dienThoaiDocGia}' where madocgia='{maDocGia}'";
            fn.setData(query, "Đã cập nhật thông tin độc giả");
            loadData1();
            clearAll();
        }

        private void btnDel1_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView6.SelectedRows.Count > 0)
            {
                int selectedIndex = guna2DataGridView6.SelectedRows[0].Index;
                string maDocGia = guna2DataGridView6.Rows[selectedIndex].Cells["madocgia"].Value.ToString();

                query = $"delete from docgia where madocgia='{maDocGia}'";
                fn.setData(query, "Đã xóa độc giả");
                loadData1();
            }
        }

        private void guna2DataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
