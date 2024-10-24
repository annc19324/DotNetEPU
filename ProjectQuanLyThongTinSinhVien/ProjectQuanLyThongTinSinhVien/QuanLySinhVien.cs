using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQuanLyThongTinSinhVien
{
    public  class QuanLySinhVien
    {
        private static QuanLySinhVien instance;
        public static QuanLySinhVien Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new QuanLySinhVien();
                }
                return instance;
            }
        }

        public List<SinhVien> DanhSachSinhVien { get; set; }

        private QuanLySinhVien()
        {
            DanhSachSinhVien = new List<SinhVien>();
        }

        public void ThemSinhVien(SinhVien sv)
        {
            DanhSachSinhVien.Add(sv);
        }
    }
}
