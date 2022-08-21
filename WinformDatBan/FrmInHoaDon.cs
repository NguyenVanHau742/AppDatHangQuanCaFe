using Microsoft.Reporting.WinForms;
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
    public partial class FrmInHoaDon : Form
    {
        public FrmInHoaDon()
        {
            InitializeComponent();
        }

        private void FrmInHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsHoaDon.DataTable1' table. You can move, or remove it, as needed.


            CultureInfo cul = new CultureInfo("vi-VN"); // mệnh giá tiền việt nam
            DateTime nowTime = DateTime.Now;

            ReportParameter p1 = new ReportParameter("tenBan", FrmThuNgan.TenBan);
            ReportParameter p2 = new ReportParameter("maHD", FrmThuNgan.MaHD.ToString());
            ReportParameter p3 = new ReportParameter("ngayBan", nowTime.ToString("dd/MM/yyyy"));
            ReportParameter p4 = new ReportParameter("tongTien", FrmThuNgan.tongCong.ToString("c", cul));
            ReportParameter p5 = new ReportParameter("khuyenMai", FrmThuNgan.khuyenMai.ToString("c", cul));
            ReportParameter p6 = new ReportParameter("thanhTien", FrmThuNgan.thanhTien.ToString("c", cul));
            ReportParameter p7 = new ReportParameter("thueVat", FrmThuNgan.thueVat.ToString("c", cul));

            this.rpvInHoaDon.LocalReport.SetParameters(new ReportParameter[] { p1,p2,p3,p4,p5,p6,p7});
            // đường dẫn báo cáo
            rpvInHoaDon.LocalReport.ReportPath = "RpInHoaDon.rdlc";
            //reportViewer1.LocalReport.ReportEmbeddedResource = "RpHoaDon.rdlc";
            // Khai báo chế độ xử lý báo cáo , trong trường hợp này báo cáo ở dạng local
            rpvInHoaDon.ProcessingMode = ProcessingMode.Local;

            // in hóa đơn dựa vào id bàn
            this.dataTable1TableAdapter.Fill(this.dsHoaDon.DataTable1, FrmThuNgan.MaBan, FrmThuNgan.MaKH);


            this.rpvInHoaDon.RefreshReport();
        }
    }
}
