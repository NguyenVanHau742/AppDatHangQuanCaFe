using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformDatBan
{
    public partial class FrmThuNgan : Form
    {
        public FrmThuNgan()
        {
            InitializeComponent();
        }

        private void FrmThuNgan_Load(object sender, EventArgs e)
        {
            LoadBan();
            LoadThoiGian();
            LoadGiamGia();
        }

        public void LoadThoiGian()
        {
            DateTime nowTime = DateTime.Now;
            lbDate.Text = nowTime.ToString("dd/MM/yyyy");
            lbTime.Text = nowTime.ToShortTimeString();
        }

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
        List<HoaDon_DTO> danhsachHoaDon;

        private void LoadHoaDon(int MaBan)
        {
            int tongTien = 0;
            lstViewDatMon.Items.Clear();
            danhsachHoaDon = HoaDon_BUS.LoadHoaDon(MaBan);
            if (danhsachHoaDon == null)
            {
                txtTongTien.Text = "0";
                txtThanhTien.Text = "0";
                return;
            }
            else
            {
                for (int i = 0; i < danhsachHoaDon.Count; i++)
                {
                    ListViewItem it = new ListViewItem(danhsachHoaDon[i].TenMonAn.ToString());
                    it.SubItems.Add(danhsachHoaDon[i].SoLuong.ToString());
                    it.SubItems.Add(danhsachHoaDon[i].Gia.ToString());
                    it.SubItems.Add(danhsachHoaDon[i].ThanhTien.ToString());
                    it.SubItems.Add(danhsachHoaDon[i].GhiChu.ToString());

                    tongTien += int.Parse(it.SubItems[3].Text.ToString());
                    lstViewDatMon.Items.Add(it);
                }
                txtTongTien.Text = tongTien.ToString();
                txtThanhTien.Text = txtThanhTien.Text.ToString();
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
                    LoadHoaDon(danhsachban[indexTable].MaBan);
                }
            }
        }

        public List<GiamGia_DTO> lstGiamGia;
        private void LoadGiamGia()
        {
                lstGiamGia = HoaDon_BUS.LoadGiamGia();
                drbGiamgia.DataSource = lstGiamGia;
                drbGiamgia.SelectedIndex = 3;
                drbGiamgia.DisplayMember = "TenMaGiamGia";
                drbGiamgia.ValueMember = "MaGiamGia";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (indexTable == -1)
            {
                return;
            }
            if (lstBanAn.Items[indexTable].ImageIndex == 0)
            {
                MessageBox.Show("Bàn trống!!!");
                return;
            }
            int tien = int.Parse(txtThanhTien.Text);

            CultureInfo cul = new CultureInfo("vi-VN"); // định dạng tiền việt
            string TongTien = tien.ToString("c", cul);

            if (MessageBox.Show("Thanh Toán: " + TongTien, "Thanh Toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Ban_BUS.SuaTrangThaiBanTrong(danhsachban[indexTable].MaBan) == true)
                {
                    lstBanAn.Items[indexTable].ImageIndex = 0;
                }
                //  xóa hết món ăn trên bàn ăn đó 
                HoaDon_BUS.XoaThongTinHoaDon(HoaDon_BUS.layIDHoaDon(danhsachban[indexTable].MaBan));

                // update số tiền
                DateTime time = DateTime.Now;
                string NgayBan = time.ToString("yyyy/MM/dd");
                try
                {
                    HoaDon_BUS.UpdateHoaDon("Đã thanh toán", NgayBan, int.Parse(txtThanhTien.Text),int.Parse(txtThueVat.Text), HoaDon_BUS.layMagiamgia(drbGiamgia.Text), danhsachban[indexTable].MaBan, Ban_BUS.layMaKH(txtTenKH.Text));
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi!!!");
                    return;
                }


                LoadHoaDon(danhsachban[indexTable].MaBan); // xóa rồi load lại hóa đơn mới
            }
        }

        public int inDexTable;
        public int Gia;
        private void drbGiamgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tongCong;
            try
            {
                tongCong = int.Parse(txtTongTien.Text.ToString());
            }
            catch (Exception)
            {
                return;
            }
            inDexTable = drbGiamgia.SelectedIndex;
            if (inDexTable == 0)
            {
                MessageBox.Show("Ten la" + drbGiamgia.Text);
                Gia = 10;

            } else if (inDexTable == 1)
            {
                Gia = 20;
            }
            else if (inDexTable == 2)
            {
                Gia = 30;
            }
            else
            {
                Gia = 0;
            }
            txtThanhTien.Text = (tongCong - ((tongCong * Gia) / 100)).ToString();
        }

        private void txtThueVat_TextChanged(object sender, EventArgs e)
        {
            if (txtThueVat.Text != "" && txtTongTien.Text != "")
            {

                int tongCong = int.Parse(txtTongTien.Text.ToString());
                int thueVat = int.Parse(txtThueVat.Text.ToString());
                //int khuyenMai = int.Parse(txtGiamGia.Text.ToString());

                 if (thueVat > 100)
                {
                    MessageBox.Show("Thuế Không Hợp Lệ!");
                    txtThueVat.Text = "0";
                    return;
                }
                else
                {
                    txtThanhTien.Text = (tongCong - ((tongCong * Gia) / 100 - (tongCong * thueVat) / 100)).ToString();
                }
            }
        }

        private void txtThueVat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static int MaBan;                   // các biến sẽ truyền vào reportviewer
        public static string TenBan;            // các biến sẽ truyền vào reportviewer
        public static int tongCong;           // các biến sẽ truyền vào reportviewer
        public static int khuyenMai;          // các biến sẽ truyền vào reportviewer
        public static int MaHD;          // các biến sẽ truyền vào reportviewer
        public static int thanhTien;         // các biến sẽ truyền vào reportviewer
        public static int thueVat;
        public static int MaKH;
        public static string tenKH;
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (indexTable == -1)
            {
                MessageBox.Show("Chọn bàn muốn in");
                return;
            }
            if (lstBanAn.Items[indexTable].ImageIndex == 0)
            {
                MessageBox.Show("Bàn Chưa Mở Lấy Gì In Hóa Đơn");
                return;
            }
            MaBan = danhsachban[indexTable].MaBan;
            TenBan = danhsachban[indexTable].TenBan;
            MaHD = HoaDon_BUS.layIDHoaDon(danhsachban[indexTable].MaBan);
            tongCong = int.Parse(txtTongTien.Text);
            khuyenMai = int.Parse(txtTongTien.Text) - int.Parse(txtThanhTien.Text);
            thanhTien = int.Parse(txtThanhTien.Text);
            thueVat = int.Parse(txtTongTien.Text) + int.Parse(txtThanhTien.Text);
            MaKH = Ban_BUS.layMaKH(txtTenKH.Text);
            tenKH = txtTenKH.Text.ToString();

            FrmInHoaDon InHoaDon = new FrmInHoaDon();
            InHoaDon.ShowDialog();
        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
