using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPham_LamLai
{
    public class SanPham
    {
        public string? MaSP { get; set; }
        public string? TSP { get; set; }
        public decimal DG { get; set; }
        public string? HA { get; set; }
        public string? MTN { get; set; }
        public string? MTCT { get; set; }
        public string? LSP { get; set; }

    }

    public class QuanLySanPham
    {
        private static QuanLySanPham instance;
        public static QuanLySanPham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new QuanLySanPham();
                }
                return instance;
            }
        }

        public List<SanPham> DanhSachSanPham { get; set; }
        private QuanLySanPham()
        {
            DanhSachSanPham = new List<SanPham>();

        }

        public void ThemSanPham(SanPham sp)
        {
            DanhSachSanPham.Add(sp);
        }
    }
}
