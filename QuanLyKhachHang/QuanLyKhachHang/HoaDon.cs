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
        public List<DichVu> DichVuDaChon { get; set; } 
        public decimal TongTien => DichVuDaChon.Sum(dv => dv.GiaTien); 

        public HoaDon(int maHoaDon, KhachHang khachHang, List<DichVu> dichVuDaChon)
        {
            MaHoaDon = maHoaDon;
            KhachHang = khachHang;
            DichVuDaChon = dichVuDaChon;
        }
    }
}
