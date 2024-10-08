using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuongTienGiaoThong
{
    class XeDap : PhuongTien, IThongTinThem
    {
        public XeDap(string TenPhuongTien) : base(TenPhuongTien, "khong co")
        {

        }

        public override void DiChuyen()
        {
            Console.WriteLine($"{getTenPhuongTien()} di chuyen");
        }

        public double TocDoToiDa()
        {
            return 25;
        }

        public double MucTieuThuNhienLieu()
        {
            throw new NotImplementedException();
        }

    }
}
