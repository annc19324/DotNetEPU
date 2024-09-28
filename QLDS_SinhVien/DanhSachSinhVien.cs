using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDS_SinhVien
{
    internal class DanhSachSinhVien
    {
        private List<SinhVien> ds = new List<SinhVien>();
        
        public void ThemSinhVien(SinhVien sv)
        {
            ds.Add(sv);
        }

        public void HienThiDanhSach()
        {
            foreach (var s in ds)
            {
                s.HienThiThongTin();
            }
        }

        public void TimSinhVienTheoMSSV(string mssv)
        {
            //var sv = ds.Where(s => s._MSSV == mssv).FirstOrDefault();
            var sv = ds.FirstOrDefault(s=>s._MSSV == mssv);
            if(sv != null)
            {
                sv.HienThiThongTin();
            }
            else
            {
                Console.WriteLine("không tìm thấy MSSV này!");
            }
        }

        public SinhVien TinhDiemTrungBinhCaoNhat() { 
            return ds.OrderByDescending(s=>s._Score).FirstOrDefault();
        }
    }
}
