using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformDatBan
{
    public partial class FrmNhaBep : Form
    {
        public FrmNhaBep()
        {
            InitializeComponent();
        }

        private void FrmNhaBep_Load(object sender, EventArgs e)
        {
            LoadBan();
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

        List<HoaDon_DTO> danhsachHoaDon;

        private void LoadHoaDon(int MaBan)
        {
            lstViewDatMon.Items.Clear();
            danhsachHoaDon = HoaDon_BUS.LoadHoaDon(MaBan);
            if (danhsachHoaDon == null)
            {
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

                    lstViewDatMon.Items.Add(it);
                }
            }
        }

        int chiSolstHoaDon = -1;

        private void lstViewDatMon_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            chiSolstHoaDon = e.ItemIndex;
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (chiSolstHoaDon != -1)
            {
               
                    if (RbChuahoanthanh.Checked == true)
                    {
                        if (MonAn_BUS.ThemTrangThaiNhaBep(danhsachban[indexTable].MaBan, MonAn_BUS.layIDMonAn(lstViewDatMon.Items[chiSolstHoaDon].SubItems[0].Text.ToString()), RbChuahoanthanh.Text))
                        {
                            MessageBox.Show("Món ăn đang làm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    if (RbDaHoanThanh.Checked == true)
                    {
                        if (MonAn_BUS.CapNhatTrangThaiNhaBep(RbDaHoanThanh.Text, danhsachban[indexTable].MaBan, MonAn_BUS.layIDMonAn(lstViewDatMon.Items[chiSolstHoaDon].SubItems[0].Text.ToString())))
                        {
                            MessageBox.Show("Món ăn đã hoàn thành!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lstViewDatMon.Items.RemoveAt(chiSolstHoaDon);
                        }

                    }

                //if (MonAn_BUS.LayTrangThai(danhsachban[indexTable].MaBan, MonAn_BUS.layIDMonAn(lstViewDatMon.Items[chiSolstHoaDon].SubItems[0].Text.ToString())) == "Đã hoàn thành")
                //{
                //    MessageBox.Show("Món ăn đã làm rồi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            } else
            {
                MessageBox.Show("Vui lòng chọn món ăn!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
