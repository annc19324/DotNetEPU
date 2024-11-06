using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachHang
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            Form1 formKhachHang = new Form1();
            formKhachHang.ShowDialog();
        }

        private void btnDV_Click(object sender, EventArgs e)
        {
            DanhSachDichVu formDichVu = new DanhSachDichVu();
            formDichVu.ShowDialog();
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            FormHoaDon formHoaDon = new FormHoaDon();
            formHoaDon.ShowDialog();
        }
    }
}
