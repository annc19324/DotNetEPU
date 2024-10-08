using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuongTienGiaoThong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<PhuongTien> danhSachPhuongTien = new List<PhuongTien>();

            Console.Write("Nhập số lượng xe hơi: ");
            int soXeHoi = int.Parse(Console.ReadLine());

            for (int i = 0; i < soXeHoi; i++)
            {
                Console.WriteLine($"Nhập thông tin cho xe hơi thứ {i + 1}:");

                Console.Write("Tên xe: ");
                string tenXeHoi = Console.ReadLine();

                Console.Write("Loại nhiên liệu: ");
                string loaiNhienLieu = Console.ReadLine();

                // Thêm xe hơi vào danh sách
                XeHoi xeHoi = new XeHoi(tenXeHoi, loaiNhienLieu);
                danhSachPhuongTien.Add(xeHoi);
            }

            Console.Write("Nhập số lượng xe đạp: ");
            int soXeDap = int.Parse(Console.ReadLine());

            for (int i = 0; i < soXeDap; i++)
            {
                Console.WriteLine($"Nhập thông tin cho xe đạp thứ {i + 1}:");

                Console.Write("Tên xe: ");
                string tenXeDap = Console.ReadLine();

                // Thêm xe đạp vào danh sách
                XeDap xeDap = new XeDap(tenXeDap);
                danhSachPhuongTien.Add(xeDap);
            }

            // In thông tin các phương tiện
            Console.WriteLine("\nDanh sách phương tiện:");
            foreach (PhuongTien pt in danhSachPhuongTien)
            {
                Console.WriteLine($"Phương tiện: {pt.getTenPhuongTien()}");
                pt.DiChuyen();

                if (pt is XeDap xd)
                {
                    Console.WriteLine($"Tốc độ tối đa: {xd.TocDoToiDa()} km/h");
                }

                if (pt is XeHoi xh)
                {
                    Console.WriteLine($"Mức tiêu thụ nhiên liệu: {xh.MucTieuThuNhienLieu()} lít/100km");
                    Console.WriteLine($"Tốc độ tối đa: {xh.TocDoToiDa()} km/h");
                }



            }
                Console.ReadKey();
        }
    }
}
