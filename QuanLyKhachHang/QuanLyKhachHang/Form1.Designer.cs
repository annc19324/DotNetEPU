namespace QuanLyKhachHang
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
            groupBox1 = new GroupBox();
            txtDC = new TextBox();
            txtSDT = new TextBox();
            txtTenKH = new TextBox();
            txtMaKH = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnSuaKH = new Button();
            btnThemKH = new Button();
            groupBox3 = new GroupBox();
            dgvKhachHang = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDC);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 440);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // txtDC
            // 
            txtDC.Location = new Point(133, 138);
            txtDC.Name = "txtDC";
            txtDC.Size = new Size(249, 27);
            txtDC.TabIndex = 7;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(133, 99);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(249, 27);
            txtSDT.TabIndex = 6;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(133, 61);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(249, 27);
            txtTenKH.TabIndex = 5;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(133, 23);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(249, 27);
            txtMaKH.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 145);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 3;
            label4.Text = "Đ/C: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 106);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "SĐT: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 68);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 30);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSuaKH);
            groupBox2.Controls.Add(btnThemKH);
            groupBox2.Location = new Point(12, 458);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(410, 105);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "chức năng";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(288, 26);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSuaKH
            // 
            btnSuaKH.Location = new Point(165, 26);
            btnSuaKH.Name = "btnSuaKH";
            btnSuaKH.Size = new Size(94, 29);
            btnSuaKH.TabIndex = 1;
            btnSuaKH.Text = "Sửa";
            btnSuaKH.UseVisualStyleBackColor = true;
            btnSuaKH.Click += btnSuaKH_Click;
            // 
            // btnThemKH
            // 
            btnThemKH.Location = new Point(40, 26);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.Size = new Size(94, 29);
            btnThemKH.TabIndex = 0;
            btnThemKH.Text = "Thêm";
            btnThemKH.UseVisualStyleBackColor = true;
            btnThemKH.Click += btnThemKH_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvKhachHang);
            groupBox3.Location = new Point(428, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(700, 551);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "dữ liệu";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(6, 26);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(688, 519);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 575);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtDC;
        private TextBox txtSDT;
        private TextBox txtTenKH;
        private TextBox txtMaKH;
        private Button btnXoa;
        private Button btnSuaKH;
        private Button btnThemKH;
        private DataGridView dgvKhachHang;
    }
}
