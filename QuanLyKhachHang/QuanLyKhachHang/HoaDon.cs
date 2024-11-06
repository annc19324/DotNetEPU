using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHang
{
    public class HoaDon
    {
        public int MaHoaDon { get; set; }  
        public KhachHang KhachHang { get; set; }  
        public List<DichVu> DanhSachDichVu { get; set; } = new List<DichVu>(); 

       
        public decimal TongTien => DanhSachDichVu.Sum(dv => dv.GiaTien);

        public HoaDon(int maHoaDon, KhachHang khachHang, List<DichVu> danhSachDichVu)
        {
            MaHoaDon = maHoaDon;
            KhachHang = khachHang;
            DanhSachDichVu = danhSachDichVu;
        }
    }
}
