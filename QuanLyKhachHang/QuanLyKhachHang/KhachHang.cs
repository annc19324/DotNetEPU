using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHang
{
    public class KhachHang
    {
        public KhachHang(int maKhachHang, string tenKhachHang, string soDienThoai, string diaChi)
        {
            MaKhachHang = maKhachHang;
            TenKhachHang = tenKhachHang;
            SoDienThoai = soDienThoai;
            DiaChi = diaChi;
        }

        public int MaKhachHang {  get; set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }

    }
}
