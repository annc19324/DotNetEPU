namespace SanPham_LamLai
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
            gbDL = new GroupBox();
            dgvDSSP = new DataGridView();
            btnTimKiem = new Button();
            tbTimKiem = new TextBox();
            lblTimKiem = new Label();
            gbTT = new GroupBox();
            cbbLSP = new ComboBox();
            rtbMTCT = new RichTextBox();
            tbMTN = new TextBox();
            tbHA = new TextBox();
            tbDG = new TextBox();
            tbTSP = new TextBox();
            tbMSP = new TextBox();
            lblLSP = new Label();
            label6 = new Label();
            lblMTN = new Label();
            lblHA = new Label();
            lblDG = new Label();
            lblTSP = new Label();
            lblMSP = new Label();
            gbCN = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnLamMoi = new Button();
            panel1.SuspendLayout();
            gbDL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSSP).BeginInit();
            gbTT.SuspendLayout();
            gbCN.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(gbDL);
            panel1.Controls.Add(gbTT);
            panel1.Controls.Add(gbCN);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1392, 625);
            panel1.TabIndex = 16;
            // 
            // gbDL
            // 
            gbDL.Controls.Add(dgvDSSP);
            gbDL.Controls.Add(btnTimKiem);
            gbDL.Controls.Add(tbTimKiem);
            gbDL.Controls.Add(lblTimKiem);
            gbDL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbDL.Location = new Point(465, 3);
            gbDL.Name = "gbDL";
            gbDL.Size = new Size(924, 619);
            gbDL.TabIndex = 13;
            gbDL.TabStop = false;
            gbDL.Text = "Dữ liệu";
            // 
            // dgvDSSP
            // 
            dgvDSSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSSP.Location = new Point(6, 67);
            dgvDSSP.Name = "dgvDSSP";
            dgvDSSP.RowHeadersWidth = 51;
            dgvDSSP.Size = new Size(910, 546);
            dgvDSSP.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(796, 21);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(120, 40);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // tbTimKiem
            // 
            tbTimKiem.Location = new Point(188, 27);
            tbTimKiem.Name = "tbTimKiem";
            tbTimKiem.Size = new Size(563, 34);
            tbTimKiem.TabIndex = 1;
            tbTimKiem.TextChanged += tbTimKiem_TextChanged;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(31, 30);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(100, 28);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm kiếm: ";
            // 
            // gbTT
            // 
            gbTT.Controls.Add(cbbLSP);
            gbTT.Controls.Add(rtbMTCT);
            gbTT.Controls.Add(tbMTN);
            gbTT.Controls.Add(tbHA);
            gbTT.Controls.Add(tbDG);
            gbTT.Controls.Add(tbTSP);
            gbTT.Controls.Add(tbMSP);
            gbTT.Controls.Add(lblLSP);
            gbTT.Controls.Add(label6);
            gbTT.Controls.Add(lblMTN);
            gbTT.Controls.Add(lblHA);
            gbTT.Controls.Add(lblDG);
            gbTT.Controls.Add(lblTSP);
            gbTT.Controls.Add(lblMSP);
            gbTT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbTT.Location = new Point(3, 3);
            gbTT.Name = "gbTT";
            gbTT.Size = new Size(456, 490);
            gbTT.TabIndex = 6;
            gbTT.TabStop = false;
            gbTT.Text = "Thông tin";
            // 
            // cbbLSP
            // 
            cbbLSP.FormattingEnabled = true;
            cbbLSP.Location = new Point(142, 319);
            cbbLSP.Name = "cbbLSP";
            cbbLSP.Size = new Size(272, 36);
            cbbLSP.TabIndex = 13;
            // 
            // rtbMTCT
            // 
            rtbMTCT.Location = new Point(142, 227);
            rtbMTCT.Name = "rtbMTCT";
            rtbMTCT.Size = new Size(272, 80);
            rtbMTCT.TabIndex = 12;
            rtbMTCT.Text = "";
            // 
            // tbMTN
            // 
            tbMTN.Location = new Point(142, 184);
            tbMTN.Name = "tbMTN";
            tbMTN.Size = new Size(272, 34);
            tbMTN.TabIndex = 11;
            // 
            // tbHA
            // 
            tbHA.Location = new Point(142, 144);
            tbHA.Name = "tbHA";
            tbHA.Size = new Size(272, 34);
            tbHA.TabIndex = 10;
            // 
            // tbDG
            // 
            tbDG.Location = new Point(142, 104);
            tbDG.Name = "tbDG";
            tbDG.Size = new Size(272, 34);
            tbDG.TabIndex = 9;
            // 
            // tbTSP
            // 
            tbTSP.Location = new Point(142, 65);
            tbTSP.Name = "tbTSP";
            tbTSP.Size = new Size(272, 34);
            tbTSP.TabIndex = 8;
            // 
            // tbMSP
            // 
            tbMSP.Location = new Point(142, 24);
            tbMSP.Name = "tbMSP";
            tbMSP.Size = new Size(144, 34);
            tbMSP.TabIndex = 7;
            // 
            // lblLSP
            // 
            lblLSP.AutoSize = true;
            lblLSP.Location = new Point(24, 322);
            lblLSP.Name = "lblLSP";
            lblLSP.Size = new Size(84, 28);
            lblLSP.TabIndex = 6;
            lblLSP.Text = "Loại SP: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 227);
            label6.Name = "label6";
            label6.Size = new Size(100, 28);
            label6.TabIndex = 5;
            label6.Text = "Mô tả CT: ";
            // 
            // lblMTN
            // 
            lblMTN.AutoSize = true;
            lblMTN.Location = new Point(23, 187);
            lblMTN.Name = "lblMTN";
            lblMTN.Size = new Size(122, 28);
            lblMTN.TabIndex = 4;
            lblMTN.Text = "Mô tả ngắn: ";
            // 
            // lblHA
            // 
            lblHA.AutoSize = true;
            lblHA.Location = new Point(24, 147);
            lblHA.Name = "lblHA";
            lblHA.Size = new Size(99, 28);
            lblHA.TabIndex = 3;
            lblHA.Text = "Hình ảnh: ";
            // 
            // lblDG
            // 
            lblDG.AutoSize = true;
            lblDG.Location = new Point(23, 110);
            lblDG.Name = "lblDG";
            lblDG.Size = new Size(90, 28);
            lblDG.TabIndex = 2;
            lblDG.Text = "Đơn giá: ";
            // 
            // lblTSP
            // 
            lblTSP.AutoSize = true;
            lblTSP.Location = new Point(23, 71);
            lblTSP.Name = "lblTSP";
            lblTSP.Size = new Size(77, 28);
            lblTSP.TabIndex = 1;
            lblTSP.Text = "Tên SP: ";
            // 
            // lblMSP
            // 
            lblMSP.AutoSize = true;
            lblMSP.Location = new Point(24, 30);
            lblMSP.Name = "lblMSP";
            lblMSP.Size = new Size(76, 28);
            lblMSP.TabIndex = 0;
            lblMSP.Text = "Mã SP: ";
            // 
            // gbCN
            // 
            gbCN.Controls.Add(btnXoa);
            gbCN.Controls.Add(btnSua);
            gbCN.Controls.Add(btnThem);
            gbCN.Controls.Add(btnLamMoi);
            gbCN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbCN.Location = new Point(3, 497);
            gbCN.Name = "gbCN";
            gbCN.Size = new Size(456, 125);
            gbCN.TabIndex = 12;
            gbCN.TabStop = false;
            gbCN.Text = "Chức năng";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(330, 51);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 40);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(225, 51);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 40);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(119, 51);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 40);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(13, 51);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(100, 40);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 649);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            gbDL.ResumeLayout(false);
            gbDL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSSP).EndInit();
            gbTT.ResumeLayout(false);
            gbTT.PerformLayout();
            gbCN.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox gbDL;
        private DataGridView dgvDSSP;
        private Button btnTimKiem;
        private TextBox tbTimKiem;
        private Label lblTimKiem;
        private GroupBox gbTT;
        private ComboBox cbbLSP;
        private RichTextBox rtbMTCT;
        private TextBox tbMTN;
        private TextBox tbHA;
        private TextBox tbDG;
        private TextBox tbTSP;
        private TextBox tbMSP;
        private Label lblLSP;
        private Label label6;
        private Label lblMTN;
        private Label lblHA;
        private Label lblDG;
        private Label lblTSP;
        private Label lblMSP;
        private GroupBox gbCN;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnLamMoi;
    }
}
