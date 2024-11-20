namespace LeThienAn.NetMobileShop
{
    partial class thongke
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
            cbThang = new ComboBox();
            btnThongKe = new Button();
            label1 = new Label();
            dgvThongKe = new DataGridView();
            label2 = new Label();
            lblDoanhThu = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // cbThang
            // 
            cbThang.FormattingEnabled = true;
            cbThang.Location = new Point(12, 103);
            cbThang.Name = "cbThang";
            cbThang.Size = new Size(151, 28);
            cbThang.TabIndex = 0;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(12, 137);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(94, 29);
            btnThongKe.TabIndex = 1;
            btnThongKe.Text = "ok";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 2;
            label1.Text = "chon thang can thong ke";
            // 
            // dgvThongKe
            // 
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Location = new Point(203, 80);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.RowHeadersWidth = 51;
            dgvThongKe.Size = new Size(562, 241);
            dgvThongKe.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 333);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "doanh thu";
            // 
            // lblDoanhThu
            // 
            lblDoanhThu.AutoSize = true;
            lblDoanhThu.Location = new Point(285, 333);
            lblDoanhThu.Name = "lblDoanhThu";
            lblDoanhThu.Size = new Size(0, 20);
            lblDoanhThu.TabIndex = 5;
            // 
            // thongke
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDoanhThu);
            Controls.Add(label2);
            Controls.Add(dgvThongKe);
            Controls.Add(label1);
            Controls.Add(btnThongKe);
            Controls.Add(cbThang);
            Name = "thongke";
            Text = "thongke";
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbThang;
        private Button btnThongKe;
        private Label label1;
        private DataGridView dgvThongKe;
        private Label label2;
        private Label lblDoanhThu;
    }
}