using DTO;
using BUS;
using DAO;
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

namespace WinformDatBan
{
    public partial class FrmDatMon : Form
    {
        public FrmDatMon()
        {
            InitializeComponent();
        }

        private void FrmDatMon_Load(object sender, EventArgs e)
        {
            LoadBan();
            LoadLoaiMonAn();
            LoadMonAn();
        }

        SqlConnection conn;
        public List<Ban_DTO> danhsachban;
        ListViewItem ban;

        private void LoadBan()
        {
            danhsachban = Ban_BUS.LoadBan();
            if (danhsachban == null)
                return;

            for (int i = 0; i < danhsachban.Count; i++)
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

        public int indexTable = -1;

        private void lstBanAn_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            indexTable = e.ItemIndex; 

            for (int i = 0; i < lstBanAn.Items.Count; i++) 
            {
                if (lstBanAn.Items[i].Selected)
                {
                    if (lstBanAn.Items[i].ImageIndex == 0) 
                    {
                        lbTrangThai.ForeColor = Color.ForestGreen;
                        lbLoaiBan.ForeColor = Color.ForestGreen;
                    }
                    else  
                    {
                        lbTrangThai.ForeColor = Color.Red;
                        lbLoaiBan.ForeColor = Color.Red;

                    }
                    lbTrangThai.Text = danhsachban[i].TrangThai.ToString();
                    lbLoaiBan.Text = danhsachban[i].LoaiBan.ToString();

                    LoadHoaDon(danhsachban[indexTable].MaBan);
                }
            }
        }

        private void LoadLoaiMonAn()
        {
            conn = DataProvider.MoKetNoi();
            string cauTruyVan = "Select * From LOAISP";
            DataTable dt = DataProvider.LayDataTable(cauTruyVan,conn);
            cbLoai.DataSource = dt;
            cbLoai.DisplayMember = "TenLoai";
            cbLoai.ValueMember = "Maloai";
        }

        public List<MonAn_DTO> danhsachmon;

        private void LoadMonAn()
        {
            danhsachmon = MonAn_BUS.LoadMonAn();
            dgvMonAn.DataSource = danhsachmon;
        }

        private void cbLoai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            conn = DataProvider.MoKetNoi();
            string cauTruyVan = "Select * From SANPHAM Where MaLoaiSP = " + cbLoai.SelectedValue;
            DataTable dt = DataProvider.LayDataTable(cauTruyVan, conn);
            dt.Dispose();
            dgvMonAn.DataSource = dt;
        }

        List<HoaDon_DTO> danhsachHoaDon;

        private void LoadHoaDon(int MaBan)
        {
            lstViewDatMon.Items.Clear();
            danhsachHoaDon = HoaDon_BUS.LoadHoaDon(MaBan);
            if (danhsachHoaDon == null)
            {
                return;
            } else
            {
                for (int i = 0;i< danhsachHoaDon.Count; i++)
                {
                    ListViewItem it = new ListViewItem(danhsachHoaDon[i].TenMonAn.ToString());
                    it.SubItems.Add(danhsachHoaDon[i].SoLuong.ToString());
                    it.SubItems.Add(danhsachHoaDon[i].Gia.ToString());
                    it.SubItems.Add(danhsachHoaDon[i].ThanhTien.ToString());
                    it.SubItems.Add(danhsachHoaDon[i].GhiChu.ToString());

                    lstViewDatMon.Items.Add(it);
                }
            }
        }

        DataGridViewRow dr;
        ListViewItem lstItem;
        private void dgvMonAn_Click(object sender, EventArgs e)
        {
             try
            {
                dr = dgvMonAn.SelectedRows[0];
            } 
            catch (Exception)
            {
                return;
            }
        }

        int soLuong = 1;

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (indexTable == -1)
            {
                MessageBox.Show("Chọn Bàn Muốn Thêm!!!");
                return;
            }
            if (lstBanAn.Items.Count > 0)
            {
                for (int i = 0; i < lstViewDatMon.Items.Count; i++)
                {
                    try
                    {
                        if (lstViewDatMon.Items[i].SubItems[0].Text.ToString() == dr.Cells["TenSP"].Value.ToString())
                        {
                            MessageBox.Show("Món ăn đã có rồi", "Thông Báo");
                            return;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Món ăn đã có rồi", "Thông Báo");
                        return;
                    }
                }
            }
            try
            {
                lstItem = new ListViewItem(dr.Cells["TenSP"].Value.ToString());
                lstItem.SubItems.Add("1");
                lstItem.SubItems.Add(dr.Cells["DonGia"].Value.ToString());
                lstItem.SubItems.Add((soLuong * int.Parse(dr.Cells["DonGia"].Value.ToString())).ToString());
                lstItem.SubItems.Add(txtGhiChu.Text.ToString()).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn Món Ăn Muốn Thêm", "Thông Báo");
                return;
            }
            lstViewDatMon.Items.Add(lstItem);

            HoaDon_BUS.ThemThongTinHoaDon(HoaDon_BUS.layIDHoaDon(danhsachban[indexTable].MaBan), int.Parse(dr.Cells["MaSP"].Value.ToString()), int.Parse(lstItem.SubItems[1].Text.ToString()), int.Parse(lstItem.SubItems[3].Text.ToString()), lstItem.SubItems[4].Text.ToString());

            LoadHoaDon(danhsachban[indexTable].MaBan);
        }

        int chiSolstHoaDon = -1;

        private void lstViewDatMon_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            chiSolstHoaDon = e.ItemIndex;
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            int sl,thanhtien;
            try
            {
                sl = int.Parse(lstViewDatMon.Items[chiSolstHoaDon].SubItems[1].Text.ToString());
            } catch (Exception)
            {
                return;
            }

            if (chiSolstHoaDon != -1)
            {
                sl = sl + 1;
                thanhtien = int.Parse(dr.Cells["DonGia"].Value.ToString()) * sl;
                lstViewDatMon.Items[chiSolstHoaDon].SubItems[1].Text = sl.ToString();
                lstViewDatMon.Items[chiSolstHoaDon].SubItems[3].Text = thanhtien.ToString();
                HoaDon_BUS.CapNhatSoLuongMonAn(sl, thanhtien, HoaDon_BUS.layIDHoaDon(danhsachban[indexTable].MaBan),MonAn_BUS.layIDMonAn(lstViewDatMon.Items[chiSolstHoaDon].SubItems[0].Text.ToString()));
                LoadHoaDon(danhsachban[indexTable].MaBan);
            }
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            int sl,thanhtien;
            try
            {
                sl = int.Parse(lstViewDatMon.Items[chiSolstHoaDon].SubItems[1].Text.ToString());
            }
            catch (Exception)
            {
                return;
            }

            if (chiSolstHoaDon != -1)
            {
                if (sl > 1)
                {
                    sl = sl - 1;
                    thanhtien = int.Parse(dr.Cells["DonGia"].Value.ToString()) * sl;
                    lstViewDatMon.Items[chiSolstHoaDon].SubItems[1].Text = sl.ToString();
                    lstViewDatMon.Items[chiSolstHoaDon].SubItems[3].Text = thanhtien.ToString();
                    HoaDon_BUS.CapNhatSoLuongMonAn(sl, thanhtien, HoaDon_BUS.layIDHoaDon(danhsachban[indexTable].MaBan), MonAn_BUS.layIDMonAn(lstViewDatMon.Items[chiSolstHoaDon].SubItems[0].Text.ToString()));
                    LoadHoaDon(danhsachban[indexTable].MaBan);
                } else
                {
                    MessageBox.Show("Không thể giảm số lượng!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnHuyMon_Click(object sender, EventArgs e)
        {
            if (lstViewDatMon.Items.Count < 1)
            {
                return;
            }
            if (chiSolstHoaDon != -1)
            {
                try
                {
                    HoaDon_BUS.XoaMonAn(HoaDon_BUS.layIDHoaDon(danhsachban[indexTable].MaBan), MonAn_BUS.layIDMonAn(lstViewDatMon.Items[chiSolstHoaDon].SubItems[0].Text.ToString()));
                }
                catch (Exception)
                {
                    return;
                }

                lstViewDatMon.Items.RemoveAt(chiSolstHoaDon);

                LoadHoaDon(danhsachban[indexTable].MaBan);
            } else
            {
                MessageBox.Show("Vui lòng chọn món ăn để xóa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            if (indexTable == -1)
            {
                MessageBox.Show("Chọn 1 bàn để chuyển!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (lstBanAn.Items[indexTable].ImageIndex == 0)
            {
                MessageBox.Show("Mở bàn để chuyển bàn khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            FrmChuyenBan frm = new FrmChuyenBan();
            frm.ShowDialog();
            int maBanToTable = frm.MaBanToTable;
            if (frm.chuyenBan == false)
            {
                return;
            }
            if (HoaDon_BUS.ChuyenBan(danhsachban[indexTable].MaBan, maBanToTable))
                {

                Ban_BUS.SuaTrangThaiBanTrong(danhsachban[indexTable].MaBan);
                Ban_BUS.SuaTrangThaiBan(maBanToTable);
                lstBanAn.Clear();
                LoadBan();
                LoadHoaDon(danhsachban[indexTable].MaBan);

                lbTrangThai.ForeColor = Color.Red;
                lbLoaiBan.ForeColor = Color.Red;
                lbTrangThai.Text = danhsachban[indexTable].TrangThai.ToString();
                lbLoaiBan.Text = danhsachban[indexTable].LoaiBan.ToString();

                MessageBox.Show("Đã chuyển bàn thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.ForeColor = Color.Black;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<MonAn_DTO> ketQua = MonAn_BUS.TimMonAn(txtTimKiem.Text);
            if (ketQua == null)
                return;
            dgvMonAn.DataSource = ketQua;
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Nhập tên món ăn ... ";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            //FrmThuNgan frm = new FrmThuNgan();
            //this.Hide();
            //frm.ShowDialog();
            //this.Show();
        }
    }
}
