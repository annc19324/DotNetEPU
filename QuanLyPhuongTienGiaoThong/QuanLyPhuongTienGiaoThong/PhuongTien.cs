using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuongTienGiaoThong
{
    abstract class PhuongTien
    {
        private string tenPhuongTien;
        private string loaiNhienLieu;

        public string getTenPhuongTien() {  return tenPhuongTien; }
        public void setTenPhuongTien(string TenPhuongTien)
        {
            tenPhuongTien = TenPhuongTien;
        }
        public string getLoaiNhienLieu()
        {
            return loaiNhienLieu;
        }

        public void setLoaiNhienLieu(string LoaiNhienLieu)
        {
            loaiNhienLieu = LoaiNhienLieu;
        }

        public PhuongTien(string TenPhuongTien, string LoaiNhienLieu)
        {
            tenPhuongTien = TenPhuongTien;
            loaiNhienLieu = LoaiNhienLieu;
        }

        public abstract void DiChuyen();

    }
}
