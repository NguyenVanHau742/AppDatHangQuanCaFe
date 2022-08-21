using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace WinformDatBan
{
    public partial class FrmMenu : Form
    {
        public FrmMenu(string TenDN)
        {
            InitializeComponent();
            lbTenNhanVien.Text = TaiKhoan_BUS.layTenNV(TenDN);
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            FrmDatBan frm = new FrmDatBan();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            FrmDatMon frm = new FrmDatMon();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất???", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
            }

        }
    }
}
