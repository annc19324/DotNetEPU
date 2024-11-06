namespace QuanLyKhachHang
{
    partial class DanhSachDichVu
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
            dgvDichVu = new DataGridView();
            panel2 = new Panel();
            btnXoaDV = new Button();
            btnSuaDV = new Button();
            btnThemDV = new Button();
            txtGiaTien = new TextBox();
            label3 = new Label();
            txtTenDV = new TextBox();
            label2 = new Label();
            txtMaDV = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvDichVu);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // dgvDichVu
            // 
            dgvDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDichVu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDichVu.Location = new Point(259, 3);
            dgvDichVu.Name = "dgvDichVu";
            dgvDichVu.RowHeadersWidth = 51;
            dgvDichVu.Size = new Size(514, 420);
            dgvDichVu.TabIndex = 1;
            dgvDichVu.CellClick += dgvDichVu_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXoaDV);
            panel2.Controls.Add(btnSuaDV);
            panel2.Controls.Add(btnThemDV);
            panel2.Controls.Add(txtGiaTien);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtTenDV);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtMaDV);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 420);
            panel2.TabIndex = 0;
            // 
            // btnXoaDV
            // 
            btnXoaDV.Location = new Point(7, 383);
            btnXoaDV.Name = "btnXoaDV";
            btnXoaDV.Size = new Size(240, 29);
            btnXoaDV.TabIndex = 8;
            btnXoaDV.Text = "Xóa DV";
            btnXoaDV.UseVisualStyleBackColor = true;
            btnXoaDV.Click += btnXoaDV_Click;
            // 
            // btnSuaDV
            // 
            btnSuaDV.Location = new Point(7, 348);
            btnSuaDV.Name = "btnSuaDV";
            btnSuaDV.Size = new Size(240, 29);
            btnSuaDV.TabIndex = 7;
            btnSuaDV.Text = "Sửa DV";
            btnSuaDV.UseVisualStyleBackColor = true;
            btnSuaDV.Click += btnSuaDV_Click;
            // 
            // btnThemDV
            // 
            btnThemDV.Location = new Point(7, 313);
            btnThemDV.Name = "btnThemDV";
            btnThemDV.Size = new Size(240, 29);
            btnThemDV.TabIndex = 6;
            btnThemDV.Text = "Thêm DV";
            btnThemDV.UseVisualStyleBackColor = true;
            btnThemDV.Click += btnThemDV_Click;
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(0, 129);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(244, 27);
            txtGiaTien.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 106);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 4;
            label3.Text = "Giá: ";
            // 
            // txtTenDV
            // 
            txtTenDV.Location = new Point(0, 76);
            txtTenDV.Name = "txtTenDV";
            txtTenDV.Size = new Size(244, 27);
            txtTenDV.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 53);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên DV: ";
            // 
            // txtMaDV
            // 
            txtMaDV.Location = new Point(3, 23);
            txtMaDV.Name = "txtMaDV";
            txtMaDV.Size = new Size(244, 27);
            txtMaDV.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã DV:";
            // 
            // DanhSachDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "DanhSachDichVu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DanhSachDichVu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvDichVu;
        private Panel panel2;
        private TextBox txtTenDV;
        private Label label2;
        private TextBox txtMaDV;
        private Label label1;
        private Button btnXoaDV;
        private Button btnSuaDV;
        private Button btnThemDV;
        private TextBox txtGiaTien;
        private Label label3;
    }
}