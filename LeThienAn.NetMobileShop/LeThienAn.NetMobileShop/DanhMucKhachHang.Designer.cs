namespace LeThienAn.NetMobileShop
{
    partial class DanhMucKhachHang
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
            dgvDMKH = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtid = new TextBox();
            txtTen = new TextBox();
            txtDC = new TextBox();
            txtSDT = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDMKH).BeginInit();
            SuspendLayout();
            // 
            // dgvDMKH
            // 
            dgvDMKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDMKH.Location = new Point(288, 58);
            dgvDMKH.Name = "dgvDMKH";
            dgvDMKH.RowHeadersWidth = 51;
            dgvDMKH.Size = new Size(475, 320);
            dgvDMKH.TabIndex = 0;
            dgvDMKH.CellClick += dgvDMKH_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 1;
            label1.Text = "id: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 133);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 2;
            label2.Text = "ten: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 181);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 3;
            label3.Text = "dia chi: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 237);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 4;
            label4.Text = "sdt: ";
            // 
            // button1
            // 
            button1.Location = new Point(24, 301);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "them";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(24, 343);
            button2.Name = "button2";
            button2.Size = new Size(94, 35);
            button2.TabIndex = 6;
            button2.Text = "sua";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(24, 384);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "xoa";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            txtid.Location = new Point(109, 78);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(125, 27);
            txtid.TabIndex = 8;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(109, 126);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(125, 27);
            txtTen.TabIndex = 9;
            // 
            // txtDC
            // 
            txtDC.Location = new Point(109, 174);
            txtDC.Name = "txtDC";
            txtDC.Size = new Size(125, 27);
            txtDC.TabIndex = 10;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(109, 230);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(125, 27);
            txtSDT.TabIndex = 11;
            // 
            // DanhMucKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSDT);
            Controls.Add(txtDC);
            Controls.Add(txtTen);
            Controls.Add(txtid);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDMKH);
            Name = "DanhMucKhachHang";
            Text = "DanhMucKhachHang";
            Load += DanhMucKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDMKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDMKH;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtid;
        private TextBox txtTen;
        private TextBox txtDC;
        private TextBox txtSDT;
    }
}