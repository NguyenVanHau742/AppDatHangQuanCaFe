using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformDatBan
{
    public partial class FrmDatBan : Form
    {
        public FrmDatBan()
        {
            InitializeComponent();
        }

        private void FrmDatBan_Load(object sender, EventArgs e)
        {
            LoadBan();
            //LoadLoaiBan();
        }

        public List<Ban_DTO> danhsachban;
        ListViewItem ban;


        private void LoadBan()
        {
            danhsachban = Ban_BUS.LoadBan();
            if (danhsachban == null)
                return;

            for (int i = 0; i<danhsachban.Count; i++)
            {
                ban = new ListViewItem();
                if (danhsachban[i].TrangThai == "Trống")
                {
                    ban.ImageIndex = 0;
                }
                else
                {
                    ban.ImageIndex = 1;
                }

                ban.Text = danhsachban[i].TenBan;
                

                lstBanAn.Items.Add(ban);
            }
        }

        //private void LoadLoaiBan()
        //{
        //    danhsachban = Ban_BUS.LoadLoaiBan();

        //    for (int i = 0; i < danhsachban.Count; i++)
        //    {
        //        TabPage tab1 = new TabPage(danhsachban[i].LoaiBan);
        //        tabLoaiBan.TabPages.Add(tab1);
        //    }
        //}

        public int indexTable = -1; // lưu chỉ số của bàn đang được chọn

        private void lstBanAn_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            indexTable = e.ItemIndex;  // khi click vào bàn nào thì lưu lại chỉ số của bàn đó

            for (int i = 0; i< lstBanAn.Items.Count; i++) // kiểm tra nếu bàn nào được click thì
            {
                if (lstBanAn.Items[i].Selected)
                {
                    if (lstBanAn.Items[i].ImageIndex == 0)  // nếu bàn đó đang trống thì màu chữ trạng thái có màu đỏ
                    {
                        lbTrangThai.ForeColor = Color.ForestGreen;
                        lbLoaiBan.ForeColor = Color.ForestGreen;
                    }
                    else  // ngược lại thì màu chữ là màu xanh
                    {
                        lbTrangThai.ForeColor = Color.Red;
                        lbLoaiBan.ForeColor = Color.Red;

                    }
                    lbTrangThai.Text = danhsachban[i].TrangThai.ToString();
                    lbLoaiBan.Text = danhsachban[i].LoaiBan.ToString();
                }
            }
        }

        private void lbLoaiBan_Click(object sender, EventArgs e)
        {

        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            int maKh = Ban_BUS.layMaKH(txtTenKH.Text);
            if (indexTable == -1)
            {
                MessageBox.Show("Chọn 1 bàn để đặt!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (lstBanAn.Items[indexTable].ImageIndex == 1)
            {
                MessageBox.Show("Bàn đã có người đặt. Vui lòng chọn bàn khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (HoaDon_BUS.ThemHoaDon(danhsachban[indexTable].MaBan,maKh) == true && Ban_BUS.SuaTrangThaiBan(danhsachban[indexTable].MaBan) == true)
            {
                
                lstBanAn.Items[indexTable].ImageIndex = 1;
                lbTrangThai.Text = "Có Người";
                lbTrangThai.ForeColor = Color.Red;
                lbLoaiBan.ForeColor = Color.Red;
                lstBanAn.Clear();
                LoadBan();
                MessageBox.Show("Đã đặt bàn thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmDatMon frm = new FrmDatMon();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }

        private void btnHuyBan_Click(object sender, EventArgs e)
        {
            if (indexTable == -1)
            {
                MessageBox.Show("Chọn 1 bàn để hủy!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (lstBanAn.Items[indexTable].ImageIndex == 0)
            {
                MessageBox.Show("Bàn không có người đặt. Vui lòng chọn bàn khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Ban_BUS.SuaTrangThaiBanTrong(danhsachban[indexTable].MaBan) == true)
            {
                lstBanAn.Items[indexTable].ImageIndex = 0;
                lbTrangThai.Text = "Trống";
                lbTrangThai.ForeColor = Color.ForestGreen;
                lbLoaiBan.ForeColor = Color.ForestGreen;
                lstBanAn.Clear();
                LoadBan();
                MessageBox.Show("Đã hủy bàn thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //private void btnChuyenBan_Click(object sender, EventArgs e)
        //{
        //    if (indexTable == -1)
        //    {
        //        MessageBox.Show("Chọn 1 bàn để hủy!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }

        //    if (lstBanAn.Items[indexTable].ImageIndex == 0)
        //    {
        //        MessageBox.Show("Mở bàn để chuyển bàn khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    if (lstBanAn.Items[indexTable].ImageIndex == 1)
        //    {
        //        FrmChuyenBan frm = new FrmChuyenBan();
        //        frm.ShowDialog();

        //        int maBanToTable = frm.MaBanToTable;

        //        if (frm.chuyenBan == false)
        //        {
        //            return;
        //        } else
        //        {
        //            Ban_BUS.SuaTrangThaiBanTrong(danhsachban[indexTable].MaBan);
        //            Ban_BUS.SuaTrangThaiBan(maBanToTable);
        //            lstBanAn.Clear();
        //            LoadBan();
        //            MessageBox.Show("Đã chuyển bàn thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
                
        //    }

            
            
        //}
        
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Nhập tên khách hàng!!!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Nhập số điện thoại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            KhachHang_DTO khachHang = new KhachHang_DTO();
            khachHang.TenKH = txtTenKH.Text.ToString();
            khachHang.SDT = txtSDT.Text.ToString();
           

            List<KhachHang_DTO> ketqua = Ban_BUS.LayKH(txtTenKH.Text);
            if (ketqua != null)
            {
                MessageBox.Show("Đã có tên khách hàng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } else if (Ban_BUS.ThemKhachHang(khachHang))
            {
                MessageBox.Show("Đã thêm khách hàng");
                return;
            }

        }
    }
}
