using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class MonAn_BUS
    {
        public static List<MonAn_DTO> LoadMonAn()
        {
            return MonAn_DAO.LayMonAn();
        }

        public static int layIDMonAn(string tenSP)
        {
            return MonAn_DAO.layIDMonAn(tenSP);
        }

        public static List<MonAn_DTO> TimMonAn(string tenMonAn)
        {
            return MonAn_DAO.TimMonAn(tenMonAn);
        }

        public static bool ThemTrangThaiNhaBep(int MaBan, int MaSP, string TrangThai)
        {
            return MonAn_DAO.ThemTrangThaiNhaBep(MaBan, MaSP, TrangThai);
        }

        public static bool CapNhatTrangThaiNhaBep(string TrangThai,int MaBan, int MaSP)
        {
            return MonAn_DAO.CapNhatTrangThaiNhaBep(TrangThai, MaBan, MaSP);
        }

        public static string LayTrangThai(int MaBan, int MaSP)
        {
            return MonAn_DAO.layTrangThai(MaBan,MaSP);
        }
    }
}
