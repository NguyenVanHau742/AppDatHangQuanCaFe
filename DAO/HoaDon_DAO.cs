using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class HoaDon_DAO
    {
        static SqlConnection conn;
        public static List<HoaDon_DTO> LoadHoaDon(int MaBan)
        {
            string cauTruyVan = string.Format("Select HD.MaHD, SP.TenSP, CTDH.SoLuong, CONCAT(SP.DonGia ,' ', SP.DonVi ) AS DonGia, (CTDH.SoLuong* SP.DonGia) AS ThanhTien, CTDH.GhiChu  From CHITIETDONHANG AS CTDH, HOADON AS HD, SANPHAM AS SP, BAN Where CTDH.MaHD = HD.MaHD AND CTDH.MaSP = SP.MaSP AND HD.MaBAn = BAN.MaBan AND BAN.MaBan = " + MaBan);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDataTable(cauTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            } 
            List<HoaDon_DTO> lstHoaDon = new List<HoaDon_DTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO hoaDon = new HoaDon_DTO();
                hoaDon.MaHD = int.Parse(dt.Rows[i]["MaHD"].ToString());
                hoaDon.TenMonAn = dt.Rows[i]["TenSP"].ToString();
                hoaDon.SoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
                hoaDon.Gia = dt.Rows[i]["DonGia"].ToString();
                hoaDon.ThanhTien = int.Parse(dt.Rows[i]["ThanhTien"].ToString());
                hoaDon.GhiChu = dt.Rows[i]["GhiChu"].ToString();

                lstHoaDon.Add(hoaDon);
            }

            return lstHoaDon;
        }

        public static List<GiamGia_DTO> LayGiamGia()
        {
            List<GiamGia_DTO> lstGiamGia = new List<GiamGia_DTO>();
            conn = DataProvider.MoKetNoi();
            string cauTruyVan = "Select * From GIAMGIA";
            DataTable dt = DataProvider.LayDataTable(cauTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                GiamGia_DTO gg = new GiamGia_DTO();

                gg.MaGiamGia = dt.Rows[i]["MaGiamGia"].ToString();
                gg.TenMaGiamGia = dt.Rows[i]["TenMaGiamGia"].ToString();
                gg.SoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
              

                lstGiamGia.Add(gg);
            }
            DataProvider.DongKetNoi(conn);
            return lstGiamGia;
        }
        public static int LayIDHoaDon(int maBan)
        {
            //string cauTruyVan = "Select HD.MaHD From HOADON AS HD, BAN Where HD.MaBan = " + maBan +" AND BAN.TrangThai = 0";
            string cauTruyVan = "Select HD.MaHD From HOADON AS HD, BAN Where HD.MaBan = " + maBan;
            conn = DataProvider.MoKetNoi();
            DataTable dtIDHoaDon = DataProvider.LayDataTable(cauTruyVan, conn);
            if (dtIDHoaDon.Rows.Count == 0)
                return -1;
            int iDHoaHon = int.Parse(dtIDHoaDon.Rows[0]["MaHD"].ToString());
            DataProvider.DongKetNoi(conn);
            return iDHoaHon;
        }

        public static string LayMaGiamGia(string Tenma)
        {
            //string cauTruyVan = "Select HD.MaHD From HOADON AS HD, BAN Where HD.MaBan = " + maBan +" AND BAN.TrangThai = 0";
            string cauTruyVan = string.Format("Select MaGiamGia From GIAMGIA Where TenMaGiamGia LIKE N'{0}'",Tenma);
            conn = DataProvider.MoKetNoi();
            DataTable dtMa = DataProvider.LayDataTable(cauTruyVan, conn);
            string Magiamgia = dtMa.Rows[0]["MaGiamGia"].ToString();
            DataProvider.DongKetNoi(conn);
            return Magiamgia;
        }
        public static bool XoaThongTinHoaDon(int MaHD)
        {
            string cauTruyvan = string.Format("Delete from CHITIETDONHANG where MaHD = {0}", MaHD);
            conn = DataProvider.MoKetNoi();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(cauTruyvan, conn);
                DataProvider.DongKetNoi(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.DongKetNoi(conn);
                return false;
            }
        }

        public static bool UpdateHoaDon(string trangThai, string ngayBan, int tongTien, int thue, string MaGiamGia, int maBan, int MaKH)
        {
            string cauTruyvan = string.Format("Update HOADON Set TrangThai = N'{0}', NgayBan = '{1}', TongTien = {2}, Thue = {3}, MaGiamGia = '{4}' Where MaBan = {5} AND MaKH = {6}", trangThai, ngayBan, tongTien, thue, MaGiamGia, maBan,MaKH);
            // string format dinh dang kieu chuoi
            conn = DataProvider.MoKetNoi();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(cauTruyvan, conn);
                DataProvider.DongKetNoi(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.DongKetNoi(conn);
                return false;
            }
        }

        public static bool ThemThongTinHoaDon(int MaHD, int MaSP, int soLuong, int ThanhTien, string Ghichu)
        {
            string cauTruyVan = string.Format("Insert Into CHITIETDONHANG(MaHD,MaSP,SoLuong,ThanhTien,DonVi,GhiChu) Values({0},{1},{2},{3},'VND',N'{4}')", MaHD, MaSP, soLuong, ThanhTien, Ghichu);
            conn = DataProvider.MoKetNoi();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(cauTruyVan, conn);
                DataProvider.DongKetNoi(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.DongKetNoi(conn);
                return false;
            }
        }

        public static bool CapNhatSoLuongMonAn(int soLuong, int ThanhTien, int MaHD, int MaSP)
        {
            string cauTruyVan = string.Format("Update CHITIETDONHANG Set SoLuong = {0}, ThanhTien = {1} Where MaHD = {2} AND MaSP = {3}", soLuong, ThanhTien, MaHD, MaSP);
            conn = DataProvider.MoKetNoi();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(cauTruyVan, conn);
                DataProvider.DongKetNoi(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.DongKetNoi(conn);
                return false;
            }
        }

        public static bool XoaMonAn(int MaHD, int MaSP)
        {
            // chuỗi truy vấn xóa 1 món ăn
            string chuoiTruyVan = string.Format("Delete From CHITIETDONHANG Where MaHD = {0} AND MaSP = {1}", MaHD, MaSP);
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


        public static bool ThemHoaDon(int MaBan,int MaKH)
        {
            string chuoiTruyVan = string.Format("Insert into HOADON(MaBan,MaKH,TrangThai) Values ({0},{1},N'Chưa thanh toán')", MaBan,MaKH);
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

        public static bool ChuyenBan(int idFromTable, int idToTable)
        {
            // chuỗi truy vấn update lại bảng hóa đơn
            string chuoiTruyVan = string.Format("Update HOADON Set MaBan = {0} Where MaBan = {1}", idToTable, idFromTable);
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

    }
}
