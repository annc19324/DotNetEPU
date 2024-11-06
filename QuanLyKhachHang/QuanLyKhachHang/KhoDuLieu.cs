using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHang
{
    public class KhoDuLieu
    {
        public List<KhachHang> DanhSachKhachHang { get; set; } = new List<KhachHang>();
        public List<DichVu> DanhSachDichVu { get; set; } = new List<DichVu>();
        public List<HoaDon> DanhSachHoaDon { get; set; } = new List<HoaDon>();

        private int maKhachHangCounter = 1;
        private int maDichVuCounter = 1;
        private int maHoaDonCounter = 1;

        public KhachHang ThemKhachHang(string ten, string soDienThoai, string diaChi)
        {
            var khachHang = new KhachHang(maKhachHangCounter++, ten, soDienThoai, diaChi);
            DanhSachKhachHang.Add(khachHang);
            return khachHang;
        }

        public DichVu ThemDichVu(string tenDichVu, decimal giaTien)
        {
            var dichVu = new DichVu(maDichVuCounter++, tenDichVu, giaTien);
            DanhSachDichVu.Add(dichVu);
            return dichVu;
        }

        public HoaDon TaoHoaDon(KhachHang khachHang, List<DichVu> dichVuDaChon)
        {
            var hoaDon = new HoaDon(maHoaDonCounter++, khachHang, dichVuDaChon);
            DanhSachHoaDon.Add(hoaDon);
            return hoaDon;
        }
    }
}
