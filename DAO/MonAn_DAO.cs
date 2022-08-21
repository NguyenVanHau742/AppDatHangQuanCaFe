using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MonAn_DAO
    {
        static SqlConnection conn;

        public static List<MonAn_DTO> LayMonAn()
        {
            List<MonAn_DTO> lstMon = new List<MonAn_DTO>();
            conn = DataProvider.MoKetNoi();
            string cauTruyVan = "Select * From SANPHAM";
            DataTable dt = DataProvider.LayDataTable(cauTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonAn_DTO monan = new MonAn_DTO();

                monan.MaSP = int.Parse(dt.Rows[i]["MaSP"].ToString());
                monan.TenSP = dt.Rows[i]["TenSP"].ToString();
                monan.DonGia = int.Parse(dt.Rows[i]["DonGia"].ToString());
                monan.DonVi = dt.Rows[i]["DonVi"].ToString();
                monan.MoTa = dt.Rows[i]["MoTa"].ToString();
                monan.HinhAnh = dt.Rows[i]["HinhAnh"].ToString();

                lstMon.Add(monan);
            }
            DataProvider.DongKetNoi(conn);
            return lstMon;
        }

        public static int layIDMonAn(string tenSP)
        {
            string cauTruyVan = string.Format("Select SP.MaSP From SANPHAM AS SP Where SP.TenSP = N'{0}'", tenSP);
            conn = DataProvider.MoKetNoi();
            DataTable dtIDMonAn = DataProvider.LayDataTable(cauTruyVan, conn);
            if (dtIDMonAn.Rows.Count == 0)
                return -1;
            int idMonAn = int.Parse(dtIDMonAn.Rows[0]["MaSP"].ToString());
            DataProvider.DongKetNoi(conn);
            return idMonAn;
        }

        public static List<MonAn_DTO> TimMonAn(string tenMonAn)
        {
            string chuoiTruyVan = "Select * From SANPHAM where TenSP like N'%" + tenMonAn + "%'";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<MonAn_DTO> lstMonAn = new List<MonAn_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonAn_DTO monAn = new MonAn_DTO();
                monAn.MaSP = int.Parse(dt.Rows[i]["MaSP"].ToString());
                monAn.TenSP = dt.Rows[i]["TenSP"].ToString();
                monAn.DonGia = int.Parse(dt.Rows[i]["DonGia"].ToString());
                monAn.DonVi = dt.Rows[i]["DonVi"].ToString();
                monAn.MoTa = dt.Rows[i]["MoTa"].ToString();
                monAn.HinhAnh = dt.Rows[i]["HinhAnh"].ToString();

                lstMonAn.Add(monAn);
            }
            DataProvider.DongKetNoi(conn);
            return lstMonAn;
        }

        public static bool ThemTrangThaiNhaBep(int MaBan, int MaSP, string TrangThai)
        {
            string chuoiTruyVan = string.Format("Insert into DATMON(MaBan,MaSP,TrangThai) Values ({0},{1},N'{2}')", MaBan, MaSP, TrangThai);
            conn = DataProvider.MoKetNoi();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(chuoiTruyVan, conn);
                DataProvider.DongKetNoi(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.DongKetNoi(conn);
                return false;
            }
        }

        public static bool CapNhatTrangThaiNhaBep(string TrangThai, int MaBan, int MaSP )
        {
            string chuoiTruyVan = string.Format("Update DATMON Set TrangThai = N'{0}' Where MaBan = {1} AND MaSP = {2}", TrangThai, MaBan, MaSP);
            conn = DataProvider.MoKetNoi();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(chuoiTruyVan, conn);
                DataProvider.DongKetNoi(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.DongKetNoi(conn);
                return false;
            }
        }

        public static string layTrangThai(int MaBan,int MaSP)
        {
            string cauTruyVan = string.Format("Select TrangThai From DATMON Where MaBan = {0} and MaSP = {1}", MaBan, MaSP);
            conn = DataProvider.MoKetNoi();
            DataTable dtTrangThai = DataProvider.LayDataTable(cauTruyVan, conn);
            string TrangThai = dtTrangThai.Rows[0]["TrangThai"].ToString();
            DataProvider.DongKetNoi(conn);
            return TrangThai;
        }
    }
}
