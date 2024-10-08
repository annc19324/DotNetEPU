using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuongTienGiaoThong
{
    class XeHoi : PhuongTien, IThongTinThem
    {
        public XeHoi(string TenPhuongTien, string LoaiNhienLieu) : base(TenPhuongTien, LoaiNhienLieu){}

        public override void DiChuyen()
        {
            Console.WriteLine($"{getTenPhuongTien()} di chuyen bang {getLoaiNhienLieu()}");
        }

        public double TocDoToiDa()
        {
            return 200;
        }

        public double MucTieuThuNhienLieu()
        {
            return 7.5; 
        }

    }
}
