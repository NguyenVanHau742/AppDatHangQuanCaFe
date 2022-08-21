using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoan_DAO
    {
        static SqlConnection conn;
        public static string LayTenNV(string tenDN)
        {
            string cauTruyVan = string.Format("Select NV.TenNV from TAIKHOAN AS TK, NHANVIEN AS NV where TK.MaTK = NV.MaTK and TK.TenTK = N'{0}'", tenDN);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDataTable(cauTruyVan, conn);
            string tenNV = dt.Rows[0]["TenNV"].ToString();
            DataProvider.DongKetNoi(conn);
            return tenNV;
        }
    }
}
