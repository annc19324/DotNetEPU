using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDS_SinhVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            DanhSachSinhVien ds = new DanhSachSinhVien();

            Console.Write("nhập số lượng sinh viên: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) { 
                SinhVien sv = new SinhVien();
                sv.NhapThongTin();
                ds.ThemSinhVien(sv);
            }

            Console.WriteLine("danh sách thông tin sinh viên vừa nhập: ");
            ds.HienThiDanhSach();

            var svWithMaxScore = ds.TinhDiemTrungBinhCaoNhat();
            Console.WriteLine("thông tin sinh viên có điểm trung bình cao nhất là: ");
            svWithMaxScore.HienThiThongTin();
            
            string mssv;
            Console.Write("nhập mã sinh viên cần tìm: ");
            mssv = Console.ReadLine();
            ds.TimSinhVienTheoMSSV(mssv);
            
            
            Console.ReadKey();


        }
    }
}
