using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienDHKTHN
{
    public partial class Dashboard : Form
    {
        Themsuaxoa fn = new Themsuaxoa();
        String query;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_GiaoDien1.Visible = true;
            uC_DanhMuc1.Visible = false;
            uC_MuonTra1.Visible = false;
            uC_TimKiem1.Visible = false;
            uC_BaoCao1.Visible = false;
            btnMinisize.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnDanhMuc.Left + 50;
            uC_DanhMuc1.Visible = true;
            uC_DanhMuc1.BringToFront();
        }

        private void uC_DanhMuc1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnMuonTra.Left + 50;
            uC_MuonTra1.Visible = true;
            uC_MuonTra1.BringToFront();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnTimkiem.Left + 50;
            uC_TimKiem1.Visible = true;
            uC_TimKiem1.BringToFront();
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnBaocao.Left + 50;
            uC_BaoCao1.Visible = true;
            uC_BaoCao1.BringToFront();
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            uC_GiaoDien1.Visible = true;
            uC_GiaoDien1.BringToFront();
        }
    }
}
