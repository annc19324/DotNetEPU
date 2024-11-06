namespace QuanLyKhachHang
{
    partial class mainForm
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
            btnKH = new Button();
            btnDV = new Button();
            btnQLHD = new Button();
            SuspendLayout();
            // 
            // btnKH
            // 
            btnKH.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKH.Location = new Point(12, 12);
            btnKH.Name = "btnKH";
            btnKH.Size = new Size(776, 140);
            btnKH.TabIndex = 0;
            btnKH.Text = "Khách Hàng";
            btnKH.UseVisualStyleBackColor = true;
            btnKH.Click += btnKH_Click;
            // 
            // btnDV
            // 
            btnDV.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDV.Location = new Point(12, 158);
            btnDV.Name = "btnDV";
            btnDV.Size = new Size(776, 131);
            btnDV.TabIndex = 1;
            btnDV.Text = "Dịch Vụ";
            btnDV.UseVisualStyleBackColor = true;
            btnDV.Click += btnDV_Click;
            // 
            // btnQLHD
            // 
            btnQLHD.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLHD.Location = new Point(12, 295);
            btnQLHD.Name = "btnQLHD";
            btnQLHD.Size = new Size(776, 143);
            btnQLHD.TabIndex = 2;
            btnQLHD.Text = "Quản Lý Hóa Đơn";
            btnQLHD.UseVisualStyleBackColor = true;
            btnQLHD.Click += btnQLHD_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQLHD);
            Controls.Add(btnDV);
            Controls.Add(btnKH);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKH;
        private Button btnDV;
        private Button btnQLHD;
    }
}