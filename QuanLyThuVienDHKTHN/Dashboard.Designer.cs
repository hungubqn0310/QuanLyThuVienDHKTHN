namespace QuanLyThuVienDHKTHN
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinisize = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnBaocao = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.btnMuonTra = new Guna.UI2.WinForms.Guna2Button();
            this.btnDanhMuc = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelMoving = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_TimKiem1 = new QuanLyThuVienDHKTHN.All_User_Control.UC_TimKiem();
            this.uC_MuonTra1 = new QuanLyThuVienDHKTHN.All_User_Control.UC_MuonTra();
            this.uC_DanhMuc1 = new QuanLyThuVienDHKTHN.All_User_Control.UC_DanhMuc();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_BaoCao1 = new QuanLyThuVienDHKTHN.All_User_Control.UC_BaoCao();
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_GiaoDien1 = new QuanLyThuVienDHKTHN.All_User_Control.UC_GiaoDien();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.MediumPurple;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(35, 35);
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 45);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinisize
            // 
            this.btnMinisize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinisize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinisize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinisize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinisize.FillColor = System.Drawing.Color.MediumPurple;
            this.btnMinisize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinisize.ForeColor = System.Drawing.Color.White;
            this.btnMinisize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinisize.Image")));
            this.btnMinisize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMinisize.Location = new System.Drawing.Point(0, 51);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Size = new System.Drawing.Size(45, 45);
            this.btnMinisize.TabIndex = 1;
            this.btnMinisize.Click += new System.EventHandler(this.btnMinisize_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnOut);
            this.panel2.Controls.Add(this.btnBaocao);
            this.panel2.Controls.Add(this.btnTimkiem);
            this.panel2.Controls.Add(this.btnMuonTra);
            this.panel2.Controls.Add(this.btnDanhMuc);
            this.panel2.Location = new System.Drawing.Point(65, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1823, 130);
            this.panel2.TabIndex = 5;
            // 
            // btnOut
            // 
            this.btnOut.BorderRadius = 18;
            this.btnOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOut.ForeColor = System.Drawing.Color.White;
            this.btnOut.Location = new System.Drawing.Point(1495, 3);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(284, 116);
            this.btnOut.TabIndex = 5;
            this.btnOut.Text = "Đăng xuất";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnBaocao
            // 
            this.btnBaocao.BorderRadius = 18;
            this.btnBaocao.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBaocao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBaocao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBaocao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBaocao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBaocao.FillColor = System.Drawing.Color.Indigo;
            this.btnBaocao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBaocao.ForeColor = System.Drawing.Color.White;
            this.btnBaocao.Location = new System.Drawing.Point(1135, 3);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(284, 116);
            this.btnBaocao.TabIndex = 4;
            this.btnBaocao.Text = "Báo cáo thống kê";
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BorderRadius = 18;
            this.btnTimkiem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTimkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimkiem.FillColor = System.Drawing.Color.Indigo;
            this.btnTimkiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.White;
            this.btnTimkiem.Location = new System.Drawing.Point(752, 3);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(284, 116);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnMuonTra
            // 
            this.btnMuonTra.BorderRadius = 18;
            this.btnMuonTra.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMuonTra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMuonTra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMuonTra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMuonTra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMuonTra.FillColor = System.Drawing.Color.Indigo;
            this.btnMuonTra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMuonTra.ForeColor = System.Drawing.Color.White;
            this.btnMuonTra.Location = new System.Drawing.Point(392, 3);
            this.btnMuonTra.Name = "btnMuonTra";
            this.btnMuonTra.Size = new System.Drawing.Size(284, 116);
            this.btnMuonTra.TabIndex = 1;
            this.btnMuonTra.Text = "Mượn trả sách";
            this.btnMuonTra.Click += new System.EventHandler(this.btnMuonTra_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.BorderRadius = 18;
            this.btnDanhMuc.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDanhMuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDanhMuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDanhMuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDanhMuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDanhMuc.FillColor = System.Drawing.Color.Indigo;
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDanhMuc.ForeColor = System.Drawing.Color.White;
            this.btnDanhMuc.Location = new System.Drawing.Point(30, 3);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(284, 116);
            this.btnDanhMuc.TabIndex = 0;
            this.btnDanhMuc.Text = "Danh mục";
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.uC_GiaoDien1);
            this.panel1.Controls.Add(this.uC_BaoCao1);
            this.panel1.Controls.Add(this.uC_TimKiem1);
            this.panel1.Controls.Add(this.uC_MuonTra1);
            this.panel1.Controls.Add(this.uC_DanhMuc1);
            this.panel1.Location = new System.Drawing.Point(27, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1882, 852);
            this.panel1.TabIndex = 6;
            // 
            // PanelMoving
            // 
            this.PanelMoving.BackColor = System.Drawing.Color.Yellow;
            this.PanelMoving.Location = new System.Drawing.Point(97, 161);
            this.PanelMoving.Name = "PanelMoving";
            this.PanelMoving.Size = new System.Drawing.Size(287, 7);
            this.PanelMoving.TabIndex = 7;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1742, 1033);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "*Liên hệ hỗ trợ: 0961992655";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this;
            // 
            // uC_TimKiem1
            // 
            this.uC_TimKiem1.BackColor = System.Drawing.Color.White;
            this.uC_TimKiem1.Location = new System.Drawing.Point(-2, -2);
            this.uC_TimKiem1.Name = "uC_TimKiem1";
            this.uC_TimKiem1.Size = new System.Drawing.Size(1882, 852);
            this.uC_TimKiem1.TabIndex = 2;
            // 
            // uC_MuonTra1
            // 
            this.uC_MuonTra1.BackColor = System.Drawing.Color.White;
            this.uC_MuonTra1.Location = new System.Drawing.Point(-2, -2);
            this.uC_MuonTra1.Name = "uC_MuonTra1";
            this.uC_MuonTra1.Size = new System.Drawing.Size(1882, 852);
            this.uC_MuonTra1.TabIndex = 1;
            // 
            // uC_DanhMuc1
            // 
            this.uC_DanhMuc1.BackColor = System.Drawing.Color.White;
            this.uC_DanhMuc1.Location = new System.Drawing.Point(-2, -2);
            this.uC_DanhMuc1.Name = "uC_DanhMuc1";
            this.uC_DanhMuc1.Size = new System.Drawing.Size(1882, 852);
            this.uC_DanhMuc1.TabIndex = 0;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this;
            // 
            // uC_BaoCao1
            // 
            this.uC_BaoCao1.BackColor = System.Drawing.Color.White;
            this.uC_BaoCao1.Location = new System.Drawing.Point(-2, -2);
            this.uC_BaoCao1.Name = "uC_BaoCao1";
            this.uC_BaoCao1.Size = new System.Drawing.Size(1882, 852);
            this.uC_BaoCao1.TabIndex = 3;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this;
            // 
            // uC_GiaoDien1
            // 
            this.uC_GiaoDien1.Location = new System.Drawing.Point(-2, -2);
            this.uC_GiaoDien1.Name = "uC_GiaoDien1";
            this.uC_GiaoDien1.Size = new System.Drawing.Size(1882, 852);
            this.uC_GiaoDien1.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelMoving);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnMinisize);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnMinisize;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnOut;
        private Guna.UI2.WinForms.Guna2Button btnBaocao;
        private Guna.UI2.WinForms.Guna2Button btnTimkiem;
        private Guna.UI2.WinForms.Guna2Button btnMuonTra;
        private Guna.UI2.WinForms.Guna2Button btnDanhMuc;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel PanelMoving;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Control.UC_DanhMuc uC_DanhMuc1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Control.UC_MuonTra uC_MuonTra1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Control.UC_TimKiem uC_TimKiem1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Control.UC_BaoCao uC_BaoCao1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_User_Control.UC_GiaoDien uC_GiaoDien1;
    }
}