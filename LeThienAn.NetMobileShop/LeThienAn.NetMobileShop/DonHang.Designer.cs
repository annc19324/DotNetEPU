namespace LeThienAn.NetMobileShop
{
    partial class DonHang
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
            btnTImKiem = new Button();
            txtTimKiem = new TextBox();
            dgvDonHang = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            id = new TextBox();
            label6 = new Label();
            label5 = new Label();
            dtpngaymua = new DateTimePicker();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtsoluong = new TextBox();
            txtsanphamid = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtkhachhangid = new TextBox();
            label2 = new Label();
            btnReload = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnReload);
            panel1.Controls.Add(btnTImKiem);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(dgvDonHang);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(373, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(623, 426);
            panel1.TabIndex = 0;
            // 
            // btnTImKiem
            // 
            btnTImKiem.Location = new Point(401, 86);
            btnTImKiem.Name = "btnTImKiem";
            btnTImKiem.Size = new Size(90, 29);
            btnTImKiem.TabIndex = 3;
            btnTImKiem.Text = "tim kiem";
            btnTImKiem.UseVisualStyleBackColor = true;
            btnTImKiem.Click += btnTImKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(44, 86);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(341, 27);
            txtTimKiem.TabIndex = 2;
            // 
            // dgvDonHang
            // 
            dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonHang.Location = new Point(44, 119);
            dgvDonHang.Name = "dgvDonHang";
            dgvDonHang.RowHeadersWidth = 51;
            dgvDonHang.Size = new Size(547, 278);
            dgvDonHang.TabIndex = 1;
            dgvDonHang.CellClick += dgvDonHang_CellClick;
            dgvDonHang.CellContentClick += dgvDonHang_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 26);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "quan ly don hang";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(id);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpngaymua);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtsoluong);
            groupBox1.Controls.Add(txtsanphamid);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtkhachhangid);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "chuc nang";
            // 
            // id
            // 
            id.Enabled = false;
            id.Location = new Point(160, 23);
            id.Name = "id";
            id.Size = new Size(125, 27);
            id.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 26);
            label6.Name = "label6";
            label6.Size = new Size(22, 20);
            label6.TabIndex = 12;
            label6.Text = "id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 266);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 11;
            label5.Text = "ngay mua";
            // 
            // dtpngaymua
            // 
            dtpngaymua.Location = new Point(160, 261);
            dtpngaymua.Name = "dtpngaymua";
            dtpngaymua.Size = new Size(146, 27);
            dtpngaymua.TabIndex = 10;
            // 
            // button3
            // 
            button3.Location = new Point(212, 356);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "xoa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(112, 356);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "sua";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 356);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "them";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(160, 194);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(125, 27);
            txtsoluong.TabIndex = 6;
            // 
            // txtsanphamid
            // 
            txtsanphamid.Location = new Point(160, 129);
            txtsanphamid.Name = "txtsanphamid";
            txtsanphamid.Size = new Size(125, 27);
            txtsanphamid.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 201);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 3;
            label4.Text = "so luong";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 136);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "sanpham id";
            // 
            // txtkhachhangid
            // 
            txtkhachhangid.Location = new Point(160, 65);
            txtkhachhangid.Name = "txtkhachhangid";
            txtkhachhangid.Size = new Size(125, 27);
            txtkhachhangid.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 68);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 0;
            label2.Text = "khachhang id";
            // 
            // btnReload
            // 
            btnReload.Location = new Point(497, 84);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(94, 29);
            btnReload.TabIndex = 4;
            btnReload.Text = "tai lai trang";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // DonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 450);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "DonHang";
            Text = "DonHang";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvDonHang;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtsoluong;
        private TextBox txtsanphamid;
        private Label label4;
        private Label label3;
        private TextBox txtkhachhangid;
        private Label label5;
        private DateTimePicker dtpngaymua;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnTImKiem;
        private TextBox txtTimKiem;
        private TextBox id;
        private Label label6;
        private Button btnReload;
    }
}