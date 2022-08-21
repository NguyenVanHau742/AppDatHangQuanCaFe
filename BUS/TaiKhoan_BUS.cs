using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaiKhoan_BUS
    {
        public static string layTenNV(string TenDN)
        {
            return TaiKhoan_DAO.LayTenNV(TenDN);
        }
    }
}
