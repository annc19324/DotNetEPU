namespace QuanLyKhachHang
{
    partial class FormHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnXoaDichVu = new Button();
            btnTaoHoaDon = new Button();
            btnThemDichVu = new Button();
            lblTongTien = new Label();
            lstDichVuDaChon = new ListBox();
            lstDichVu = new ListBox();
            cmbKhachHang = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXoaDichVu);
            panel1.Controls.Add(btnTaoHoaDon);
            panel1.Controls.Add(btnThemDichVu);
            panel1.Controls.Add(lblTongTien);
            panel1.Controls.Add(lstDichVuDaChon);
            panel1.Controls.Add(lstDichVu);
            panel1.Controls.Add(cmbKhachHang);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // btnXoaDichVu
            // 
            btnXoaDichVu.Location = new Point(3, 343);
            btnXoaDichVu.Name = "btnXoaDichVu";
            btnXoaDichVu.Size = new Size(770, 29);
            btnXoaDichVu.TabIndex = 7;
            btnXoaDichVu.Text = "Xóa dịch vụ";
            btnXoaDichVu.UseVisualStyleBackColor = true;
            btnXoaDichVu.Click += btnXoaDichVu_Click;
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.Location = new Point(3, 378);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Size = new Size(770, 29);
            btnTaoHoaDon.TabIndex = 6;
            btnTaoHoaDon.Text = "Tạo hóa đơn";
            btnTaoHoaDon.UseVisualStyleBackColor = true;
            btnTaoHoaDon.Click += btnTaoHoaDon_Click;
            // 
            // btnThemDichVu
            // 
            btnThemDichVu.Location = new Point(3, 308);
            btnThemDichVu.Name = "btnThemDichVu";
            btnThemDichVu.Size = new Size(770, 29);
            btnThemDichVu.TabIndex = 5;
            btnThemDichVu.Text = "Thêm dịch vụ";
            btnThemDichVu.UseVisualStyleBackColor = true;
            btnThemDichVu.Click += btnThemDichVu_Click;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(3, 285);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(0, 20);
            lblTongTien.TabIndex = 4;
            // 
            // lstDichVuDaChon
            // 
            lstDichVuDaChon.FormattingEnabled = true;
            lstDichVuDaChon.Location = new Point(3, 178);
            lstDichVuDaChon.Name = "lstDichVuDaChon";
            lstDichVuDaChon.Size = new Size(770, 104);
            lstDichVuDaChon.TabIndex = 3;
            // 
            // lstDichVu
            // 
            lstDichVu.FormattingEnabled = true;
            lstDichVu.Location = new Point(3, 68);
            lstDichVu.Name = "lstDichVu";
            lstDichVu.Size = new Size(770, 104);
            lstDichVu.TabIndex = 2;
            // 
            // cmbKhachHang
            // 
            cmbKhachHang.FormattingEnabled = true;
            cmbKhachHang.Location = new Point(3, 34);
            cmbKhachHang.Name = "cmbKhachHang";
            cmbKhachHang.Size = new Size(151, 28);
            cmbKhachHang.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Khách Hàng";
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHoaDon";
            Load += FormHoaDon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTaoHoaDon;
        private Button btnThemDichVu;
        private Label lblTongTien;
        private ListBox lstDichVuDaChon;
        private ListBox lstDichVu;
        private ComboBox cmbKhachHang;
        private Label label1;
        private Button btnXoaDichVu;
    }
}