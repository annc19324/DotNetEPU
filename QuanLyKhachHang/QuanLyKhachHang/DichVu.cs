using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHang
{
    public class DichVu
    {
        public int MaDichVu { get; set; }      
        public string TenDichVu { get; set; }   
        public decimal GiaTien { get; set; }     

        public DichVu(int maDichVu, string tenDichVu, decimal giaTien)
        {
            MaDichVu = maDichVu;
            TenDichVu = tenDichVu;
            GiaTien = giaTien;
        }
    }
}

