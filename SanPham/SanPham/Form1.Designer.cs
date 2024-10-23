namespace SanPham
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
            panel1 = new Panel();
            comboBoxLoaiSP = new ComboBox();
            richTextBoxMTCT = new RichTextBox();
            txtMoTaNgan = new TextBox();
            txtHinhAnh = new TextBox();
            txtDonGia = new TextBox();
            txtTenSP = new TextBox();
            txtMaSP = new TextBox();
            lblLoaiSP = new Label();
            lblMoTaChiTiet = new Label();
            lblMoTaNgan = new Label();
            lblHinhAnh = new Label();
            lblDonGia = new Label();
            lblTenSP = new Label();
            lblMaSP = new Label();
            lblThongTinn = new Label();
            panel2 = new Panel();
            dataGridView = new DataGridView();
            txtMaSPg = new DataGridViewTextBoxColumn();
            txtTenSPg = new DataGridViewTextBoxColumn();
            txtDonGiag = new DataGridViewTextBoxColumn();
            txtHinhAnhg = new DataGridViewTextBoxColumn();
            txtMoTaNgang = new DataGridViewTextBoxColumn();
            txtMoTaChiTietg = new DataGridViewTextBoxColumn();
            txtLoaiSanPhamg = new DataGridViewTextBoxColumn();
            btnTimKiem = new Button();
            textBox6 = new TextBox();
            lblTimKiem = new Label();
            lblDuLieu = new Label();
            panel3 = new Panel();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnLamMoi = new Button();
            lblChucNang = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBoxLoaiSP);
            panel1.Controls.Add(richTextBoxMTCT);
            panel1.Controls.Add(txtMoTaNgan);
            panel1.Controls.Add(txtHinhAnh);
            panel1.Controls.Add(txtDonGia);
            panel1.Controls.Add(txtTenSP);
            panel1.Controls.Add(txtMaSP);
            panel1.Controls.Add(lblLoaiSP);
            panel1.Controls.Add(lblMoTaChiTiet);
            panel1.Controls.Add(lblMoTaNgan);
            panel1.Controls.Add(lblHinhAnh);
            panel1.Controls.Add(lblDonGia);
            panel1.Controls.Add(lblTenSP);
            panel1.Controls.Add(lblMaSP);
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 442);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // comboBoxLoaiSP
            // 
            comboBoxLoaiSP.FormattingEnabled = true;
            comboBoxLoaiSP.Items.AddRange(new object[] { "Công nghệ", "Thực phẩm", "Quần áo", "Nội thất", "Phương tiện" });
            comboBoxLoaiSP.Location = new Point(142, 324);
            comboBoxLoaiSP.Name = "comboBoxLoaiSP";
            comboBoxLoaiSP.Size = new Size(191, 28);
            comboBoxLoaiSP.TabIndex = 14;
            comboBoxLoaiSP.SelectedIndexChanged += comboBoxLoaiSP_SelectedIndexChanged;
            // 
            // richTextBoxMTCT
            // 
            richTextBoxMTCT.Location = new Point(142, 213);
            richTextBoxMTCT.Name = "richTextBoxMTCT";
            richTextBoxMTCT.Size = new Size(191, 102);
            richTextBoxMTCT.TabIndex = 13;
            richTextBoxMTCT.Text = "";
            richTextBoxMTCT.TextChanged += richTextBoxMTCT_TextChanged;
            // 
            // txtMoTaNgan
            // 
            txtMoTaNgan.Location = new Point(142, 180);
            txtMoTaNgan.Name = "txtMoTaNgan";
            txtMoTaNgan.Size = new Size(191, 27);
            txtMoTaNgan.TabIndex = 12;
            txtMoTaNgan.TextChanged += textBox5_TextChanged;
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Location = new Point(142, 147);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(191, 27);
            txtHinhAnh.TabIndex = 11;
            txtHinhAnh.TextChanged += textBox4_TextChanged;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(142, 111);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(191, 27);
            txtDonGia.TabIndex = 10;
            txtDonGia.TextChanged += textBox3_TextChanged;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(142, 77);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(191, 27);
            txtTenSP.TabIndex = 9;
            txtTenSP.TextChanged += textBox2_TextChanged;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(142, 44);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(80, 27);
            txtMaSP.TabIndex = 8;
            txtMaSP.TextChanged += textBox1_TextChanged;
            // 
            // lblLoaiSP
            // 
            lblLoaiSP.AutoSize = true;
            lblLoaiSP.Location = new Point(29, 324);
            lblLoaiSP.Name = "lblLoaiSP";
            lblLoaiSP.Size = new Size(60, 20);
            lblLoaiSP.TabIndex = 7;
            lblLoaiSP.Text = "Loại SP:";
            lblLoaiSP.Click += lblLoaiSP_Click;
            // 
            // lblMoTaChiTiet
            // 
            lblMoTaChiTiet.AutoSize = true;
            lblMoTaChiTiet.Location = new Point(27, 225);
            lblMoTaChiTiet.Name = "lblMoTaChiTiet";
            lblMoTaChiTiet.Size = new Size(100, 20);
            lblMoTaChiTiet.TabIndex = 6;
            lblMoTaChiTiet.Text = "Mô tả chi tiết:";
            // 
            // lblMoTaNgan
            // 
            lblMoTaNgan.AutoSize = true;
            lblMoTaNgan.Location = new Point(27, 187);
            lblMoTaNgan.Name = "lblMoTaNgan";
            lblMoTaNgan.Size = new Size(92, 20);
            lblMoTaNgan.TabIndex = 5;
            lblMoTaNgan.Text = "Mô tả ngắn: ";
            // 
            // lblHinhAnh
            // 
            lblHinhAnh.AutoSize = true;
            lblHinhAnh.Location = new Point(27, 147);
            lblHinhAnh.Name = "lblHinhAnh";
            lblHinhAnh.Size = new Size(75, 20);
            lblHinhAnh.TabIndex = 4;
            lblHinhAnh.Text = "Hình ảnh: ";
            lblHinhAnh.Click += label3_Click;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(27, 111);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(65, 20);
            lblDonGia.TabIndex = 3;
            lblDonGia.Text = "Đơn giá:";
            lblDonGia.Click += label2_Click;
            // 
            // lblTenSP
            // 
            lblTenSP.AutoSize = true;
            lblTenSP.Location = new Point(27, 76);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(55, 20);
            lblTenSP.TabIndex = 2;
            lblTenSP.Text = "Tên SP:";
            lblTenSP.Click += lblTenSP_Click;
            // 
            // lblMaSP
            // 
            lblMaSP.AutoSize = true;
            lblMaSP.Location = new Point(29, 42);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(53, 20);
            lblMaSP.TabIndex = 1;
            lblMaSP.Text = "Mã SP:";
            // 
            // lblThongTinn
            // 
            lblThongTinn.AutoSize = true;
            lblThongTinn.Location = new Point(8, 18);
            lblThongTinn.Name = "lblThongTinn";
            lblThongTinn.Size = new Size(72, 20);
            lblThongTinn.TabIndex = 4;
            lblThongTinn.Text = "Thông tin";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(lblTimKiem);
            panel2.Location = new Point(372, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(951, 566);
            panel2.TabIndex = 1;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { txtMaSPg, txtTenSPg, txtDonGiag, txtHinhAnhg, txtMoTaNgang, txtMoTaChiTietg, txtLoaiSanPhamg });
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new Point(20, 82);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(928, 479);
            dataGridView.TabIndex = 3;
            dataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtMaSPg
            // 
            txtMaSPg.HeaderText = "Mã SP";
            txtMaSPg.MinimumWidth = 6;
            txtMaSPg.Name = "txtMaSPg";
            txtMaSPg.Width = 125;
            // 
            // txtTenSPg
            // 
            txtTenSPg.HeaderText = "Tên SP";
            txtTenSPg.MinimumWidth = 6;
            txtTenSPg.Name = "txtTenSPg";
            txtTenSPg.Width = 125;
            // 
            // txtDonGiag
            // 
            txtDonGiag.HeaderText = "Đơn giá";
            txtDonGiag.MinimumWidth = 6;
            txtDonGiag.Name = "txtDonGiag";
            txtDonGiag.Width = 125;
            // 
            // txtHinhAnhg
            // 
            txtHinhAnhg.HeaderText = "Hình Ảnh";
            txtHinhAnhg.MinimumWidth = 6;
            txtHinhAnhg.Name = "txtHinhAnhg";
            txtHinhAnhg.Width = 125;
            // 
            // txtMoTaNgang
            // 
            txtMoTaNgang.HeaderText = "Mô Tả Ngắn";
            txtMoTaNgang.MinimumWidth = 6;
            txtMoTaNgang.Name = "txtMoTaNgang";
            txtMoTaNgang.Width = 125;
            // 
            // txtMoTaChiTietg
            // 
            txtMoTaChiTietg.HeaderText = "Mô Tả Chi Tiết";
            txtMoTaChiTietg.MinimumWidth = 6;
            txtMoTaChiTietg.Name = "txtMoTaChiTietg";
            txtMoTaChiTietg.Width = 125;
            // 
            // txtLoaiSanPhamg
            // 
            txtLoaiSanPhamg.HeaderText = "Loại Sản Phẩm";
            txtLoaiSanPhamg.MinimumWidth = 6;
            txtLoaiSanPhamg.Name = "txtLoaiSanPhamg";
            txtLoaiSanPhamg.Width = 125;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(848, 43);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(161, 44);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(607, 27);
            textBox6.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(20, 51);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(77, 20);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm kiếm: ";
            // 
            // lblDuLieu
            // 
            lblDuLieu.AutoSize = true;
            lblDuLieu.Location = new Point(386, 18);
            lblDuLieu.Name = "lblDuLieu";
            lblDuLieu.Size = new Size(57, 20);
            lblDuLieu.TabIndex = 5;
            lblDuLieu.Text = "Dữ liệu";
            lblDuLieu.Click += lblDuLieu_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnSua);
            panel3.Controls.Add(btnThem);
            panel3.Controls.Add(btnLamMoi);
            panel3.Location = new Point(0, 482);
            panel3.Name = "panel3";
            panel3.Size = new Size(366, 111);
            panel3.TabIndex = 2;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(267, 40);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(66, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(205, 40);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(56, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(135, 40);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(64, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(29, 40);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblChucNang
            // 
            lblChucNang.AutoSize = true;
            lblChucNang.Location = new Point(7, 472);
            lblChucNang.Name = "lblChucNang";
            lblChucNang.Size = new Size(79, 20);
            lblChucNang.TabIndex = 3;
            lblChucNang.Text = "Chức năng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 605);
            Controls.Add(lblDuLieu);
            Controls.Add(lblThongTinn);
            Controls.Add(lblChucNang);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblLoaiSP;
        private Label lblMoTaChiTiet;
        private Label lblMoTaNgan;
        private Label lblHinhAnh;
        private Label lblDonGia;
        private Label lblTenSP;
        private Label lblMaSP;
        private TextBox txtMoTaNgan;
        private TextBox txtHinhAnh;
        private TextBox txtDonGia;
        private TextBox txtTenSP;
        private TextBox txtMaSP;
        private ComboBox comboBoxLoaiSP;
        private RichTextBox richTextBoxMTCT;
        private Panel panel3;
        private Label lblChucNang;
        private Label lblThongTinn;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label lblDuLieu;
        private Button btnTimKiem;
        private TextBox textBox6;
        private Label lblTimKiem;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn txtMaSPg;
        private DataGridViewTextBoxColumn txtTenSPg;
        private DataGridViewTextBoxColumn txtDonGiag;
        private DataGridViewTextBoxColumn txtHinhAnhg;
        private DataGridViewTextBoxColumn txtMoTaNgang;
        private DataGridViewTextBoxColumn txtMoTaChiTietg;
        private DataGridViewTextBoxColumn txtLoaiSanPhamg;
    }
}
