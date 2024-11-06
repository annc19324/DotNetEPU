using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHang
{
    internal class DataStortage
    {
        public static List<KhachHang> DanhSachKhachHang { get; set; } = new List<KhachHang>();
        public static List<DichVu> DanhSachDichVu { get; set; } = new List<DichVu>();
        public static List<HoaDon> DanhSachHoaDon { get; set; } = new List<HoaDon>();
    }
}
