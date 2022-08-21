using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {
        public int MaHD { get; set; }
        public string TenMonAn { get; set; }

        public int SoLuong { get; set; }

        public string Gia { get; set; }

        public int ThanhTien { get; set; }

        public string GhiChu { get; set; }

        public int Thue { get; set; }
        public string TrangThai { get; set; }
        public DateTime NgayBan { get; set; }
        public int TongTien { get; set; }
    }
}
