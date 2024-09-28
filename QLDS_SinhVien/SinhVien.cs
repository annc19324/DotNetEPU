using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDS_SinhVien
{
    internal class SinhVien
    {
        private string fullName;
        private string MSSV;
        private double Score;

        public string FullName { get { return fullName; } set { fullName = value; } }
        public string _MSSV {  get { return MSSV; } set { MSSV = value; } }
        public double _Score {  get { return Score; } set { Score = value; } }
        public void NhapThongTin()
        {
            Console.Write("nhập họ tên sinh viên: ");
            fullName = Console.ReadLine();
            Console.Write("nhập MSSV: ");
            MSSV = Console.ReadLine();
            Console.Write("nhập điểm trung bình: ");
            Score = double.Parse(Console.ReadLine());
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"họ tên sinh viên: {fullName}, MSSV: {MSSV}, điểm trung bình: {Score}");
        }
    }
}
