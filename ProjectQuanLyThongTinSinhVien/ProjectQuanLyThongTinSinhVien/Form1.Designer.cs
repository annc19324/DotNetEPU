namespace ProjectQuanLyThongTinSinhVien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            panel1 = new Panel();
            gbTTSV = new GroupBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cbbKhoa = new ComboBox();
            cbbGT = new ComboBox();
            tbSDT = new TextBox();
            tbEmail = new TextBox();
            tbDiaChi = new TextBox();
            tbNgaySinh = new TextBox();
            tbHoTen = new TextBox();
            tbMSV = new TextBox();
            lblKhoa = new Label();
            lblGioiTinh = new Label();
            lblDienThoai = new Label();
            lblEmail = new Label();
            lblDiaChi = new Label();
            lblNgaySinh = new Label();
            lblHoTen = new Label();
            lblMSV = new Label();
            gbDSSV = new GroupBox();
            dgvDSSV = new DataGridView();
            panel1.SuspendLayout();
            gbTTSV.SuspendLayout();
            gbDSSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSSV).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(552, 5);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(481, 46);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Quản Lý Thông Tin Sinh Viên";
            lblTieuDe.Click += lblTieuDe_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.AutoSize = true;
            panel1.Controls.Add(lblTieuDe);
            panel1.Location = new Point(12, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1584, 68);
            panel1.TabIndex = 1;
            // 
            // gbTTSV
            // 
            gbTTSV.Anchor = AnchorStyles.Top;
            gbTTSV.Controls.Add(btnLamMoi);
            gbTTSV.Controls.Add(btnXoa);
            gbTTSV.Controls.Add(btnSua);
            gbTTSV.Controls.Add(btnThem);
            gbTTSV.Controls.Add(cbbKhoa);
            gbTTSV.Controls.Add(cbbGT);
            gbTTSV.Controls.Add(tbSDT);
            gbTTSV.Controls.Add(tbEmail);
            gbTTSV.Controls.Add(tbDiaChi);
            gbTTSV.Controls.Add(tbNgaySinh);
            gbTTSV.Controls.Add(tbHoTen);
            gbTTSV.Controls.Add(tbMSV);
            gbTTSV.Controls.Add(lblKhoa);
            gbTTSV.Controls.Add(lblGioiTinh);
            gbTTSV.Controls.Add(lblDienThoai);
            gbTTSV.Controls.Add(lblEmail);
            gbTTSV.Controls.Add(lblDiaChi);
            gbTTSV.Controls.Add(lblNgaySinh);
            gbTTSV.Controls.Add(lblHoTen);
            gbTTSV.Controls.Add(lblMSV);
            gbTTSV.Location = new Point(114, 75);
            gbTTSV.Name = "gbTTSV";
            gbTTSV.Size = new Size(350, 526);
            gbTTSV.TabIndex = 2;
            gbTTSV.TabStop = false;
            gbTTSV.Text = "Thông tin sinh viên";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(19, 457);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(325, 29);
            btnLamMoi.TabIndex = 19;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(19, 422);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(325, 29);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(19, 387);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(325, 29);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(19, 352);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(325, 29);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cbbKhoa
            // 
            cbbKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbKhoa.FormattingEnabled = true;
            cbbKhoa.Location = new Point(142, 298);
            cbbKhoa.Name = "cbbKhoa";
            cbbKhoa.Size = new Size(202, 28);
            cbbKhoa.TabIndex = 15;
            cbbKhoa.SelectedIndexChanged += cbbKhoa_SelectedIndexChanged;
            cbbKhoa.KeyPress += cbbKhoa_KeyPress;
            // 
            // cbbGT
            // 
            cbbGT.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbGT.FormattingEnabled = true;
            cbbGT.Location = new Point(142, 261);
            cbbGT.Name = "cbbGT";
            cbbGT.Size = new Size(202, 28);
            cbbGT.TabIndex = 14;
            cbbGT.SelectedIndexChanged += cbbGT_SelectedIndexChanged;
            cbbGT.KeyPress += cbbGT_KeyPress;
            // 
            // tbSDT
            // 
            tbSDT.Location = new Point(142, 226);
            tbSDT.Name = "tbSDT";
            tbSDT.Size = new Size(202, 27);
            tbSDT.TabIndex = 13;
            tbSDT.KeyPress += tbSDT_KeyPress;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(142, 191);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(202, 27);
            tbEmail.TabIndex = 12;
            tbEmail.KeyPress += tbEmail_KeyPress;
            // 
            // tbDiaChi
            // 
            tbDiaChi.Location = new Point(142, 156);
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(202, 27);
            tbDiaChi.TabIndex = 11;
            tbDiaChi.KeyPress += tbDiaChi_KeyPress;
            // 
            // tbNgaySinh
            // 
            tbNgaySinh.Location = new Point(142, 118);
            tbNgaySinh.Name = "tbNgaySinh";
            tbNgaySinh.Size = new Size(202, 27);
            tbNgaySinh.TabIndex = 10;
            tbNgaySinh.KeyPress += tbNgaySinh_KeyPress;
            // 
            // tbHoTen
            // 
            tbHoTen.Location = new Point(142, 80);
            tbHoTen.Name = "tbHoTen";
            tbHoTen.Size = new Size(202, 27);
            tbHoTen.TabIndex = 9;
            tbHoTen.KeyPress += tbHoTen_KeyPress;
            // 
            // tbMSV
            // 
            tbMSV.Location = new Point(142, 44);
            tbMSV.Name = "tbMSV";
            tbMSV.Size = new Size(202, 27);
            tbMSV.TabIndex = 8;
            tbMSV.TextChanged += tbMSV_TextChanged;
            tbMSV.KeyPress += tbMSV_KeyPress;
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Location = new Point(19, 306);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(46, 20);
            lblKhoa.TabIndex = 7;
            lblKhoa.Text = "Khoa:";
            lblKhoa.Click += label8_Click;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(19, 269);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(68, 20);
            lblGioiTinh.TabIndex = 6;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Location = new Point(19, 233);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(81, 20);
            lblDienThoai.TabIndex = 5;
            lblDienThoai.Text = "Điện thoại:";
            lblDienThoai.Click += label6_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(19, 195);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(19, 163);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(58, 20);
            lblDiaChi.TabIndex = 3;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(19, 125);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(79, 20);
            lblNgaySinh.TabIndex = 2;
            lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(19, 87);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(61, 20);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ tên: ";
            // 
            // lblMSV
            // 
            lblMSV.AutoSize = true;
            lblMSV.Location = new Point(19, 51);
            lblMSV.Name = "lblMSV";
            lblMSV.Size = new Size(94, 20);
            lblMSV.TabIndex = 0;
            lblMSV.Text = "Mã sinh viên:";
            // 
            // gbDSSV
            // 
            gbDSSV.Anchor = AnchorStyles.Top;
            gbDSSV.Controls.Add(dgvDSSV);
            gbDSSV.Location = new Point(467, 75);
            gbDSSV.Name = "gbDSSV";
            gbDSSV.Size = new Size(1044, 526);
            gbDSSV.TabIndex = 3;
            gbDSSV.TabStop = false;
            gbDSSV.Text = "Danh sách sinh viên";
            // 
            // dgvDSSV
            // 
            dgvDSSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSSV.Dock = DockStyle.Fill;
            dgvDSSV.Location = new Point(3, 23);
            dgvDSSV.Name = "dgvDSSV";
            dgvDSSV.ReadOnly = true;
            dgvDSSV.RowHeadersWidth = 51;
            dgvDSSV.Size = new Size(1038, 500);
            dgvDSSV.TabIndex = 0;
            dgvDSSV.CellClick += dgvDSSV_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1608, 671);
            Controls.Add(gbDSSV);
            Controls.Add(gbTTSV);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gbTTSV.ResumeLayout(false);
            gbTTSV.PerformLayout();
            gbDSSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Panel panel1;
        private GroupBox gbTTSV;
        private Label lblKhoa;
        private Label lblGioiTinh;
        private Label lblDienThoai;
        private Label lblEmail;
        private Label lblDiaChi;
        private Label lblNgaySinh;
        private Label lblHoTen;
        private Label lblMSV;
        private GroupBox gbDSSV;
        private DataGridView dgvDSSV;
        private ComboBox cbbKhoa;
        private ComboBox cbbGT;
        private TextBox tbSDT;
        private TextBox tbEmail;
        private TextBox tbDiaChi;
        private TextBox tbNgaySinh;
        private TextBox tbHoTen;
        private TextBox tbMSV;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}
