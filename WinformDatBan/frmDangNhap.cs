using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using DAO;

namespace WinformDatBan
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            txtTenDangNhap.Text = "NV001";
            txtMatKhau.Text = "nvphucvu001";
        }
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            try
            {
                conn = DataProvider.MoKetNoi();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_TaiKhoan";
                cmd.Parameters.AddWithValue("@TenDN", txtTenDangNhap.Text);
                cmd.Parameters.AddWithValue("@MK", txtMatKhau.Text);
                cmd.Connection = conn;
                string tenDN = txtTenDangNhap.Text;
                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                if (code == 0)
                {
                    MessageBox.Show("Bạn không có quyền ở đây!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else if (code == 1)
                {
                    FrmMenu frm = new FrmMenu(tenDN);
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                } else if (code == 2 )
                {
                    MessageBox.Show("Bạn không có quyền ở đây!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else if (code == 3)
                {
                    MessageBox.Show("Bạn không có quyền ở đây!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else if (code == 4)
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatKhau.Text = "";
                    txtTenDangNhap.Text = "";
                    txtTenDangNhap.Focus();
                } else
                {
                    MessageBox.Show("Tài khoản không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatKhau.Text = "";
                    txtTenDangNhap.Text = "";
                    txtTenDangNhap.Focus();
                }
                DataProvider.DongKetNoi(conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }

        //bool DangNhap(string tenDangNhap,string matKhau)
        //{
        //    return true;
        //}

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình???","Thông báo" , MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
            }

        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
            } else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void chkLuu_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text != "" && txtMatKhau.Text != "")
            {
                string tenDN = txtTenDangNhap.Text; // set ở settig chuỗi kết nối set đăng nhập của user 
                string MK = txtMatKhau.Text;
                Properties.Settings.Default.tenDN = tenDN;
                Properties.Settings.Default.MK = MK;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.Reset(); //nếu người dùng không nhấn vào check box thì tự reset
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = Properties.Settings.Default.tenDN; //gọi cài đặt đã nhập trước và đã lưu lại
            txtMatKhau.Text = Properties.Settings.Default.MK; // hiện thông tin đã lưu 
            if (Properties.Settings.Default.tenDN != "") //kiểm tra nếu người dùng đã để tên rỗng, thì sẻ reset hết 2 ô username và password
            {
                chkLuu.Checked = true;
            }
        }
    }
}
