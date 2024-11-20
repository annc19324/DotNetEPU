namespace LeThienAn.NetMobileShop
{
    partial class FormMain
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
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            danhMucSanPhâmToolStripMenuItem = new ToolStripMenuItem();
            danhMucKhachHangToolStripMenuItem = new ToolStripMenuItem();
            đơnToolStripMenuItem = new ToolStripMenuItem();
            đơnHangToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(87, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(577, 277);
            panel2.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(223, 172);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "thong ke";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(384, 82);
            button3.Name = "button3";
            button3.Size = new Size(190, 84);
            button3.TabIndex = 3;
            button3.Text = "Đơn hàng";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(188, 82);
            button2.Name = "button2";
            button2.Size = new Size(190, 84);
            button2.TabIndex = 2;
            button2.Text = "Danh mục khách hàng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 82);
            button1.Name = "button1";
            button1.Size = new Size(179, 84);
            button1.TabIndex = 1;
            button1.Text = "Danh mục sản phẩm";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 17);
            label1.Name = "label1";
            label1.Size = new Size(328, 62);
            label1.TabIndex = 0;
            label1.Text = "Di chuyển đến";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { danhMucSanPhâmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(776, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // danhMucSanPhâmToolStripMenuItem
            // 
            danhMucSanPhâmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { danhMucKhachHangToolStripMenuItem, đơnToolStripMenuItem, đơnHangToolStripMenuItem });
            danhMucSanPhâmToolStripMenuItem.Name = "danhMucSanPhâmToolStripMenuItem";
            danhMucSanPhâmToolStripMenuItem.Size = new Size(60, 24);
            danhMucSanPhâmToolStripMenuItem.Text = "menu";
            danhMucSanPhâmToolStripMenuItem.Click += danhMucSanPhâmToolStripMenuItem_Click;
            // 
            // danhMucKhachHangToolStripMenuItem
            // 
            danhMucKhachHangToolStripMenuItem.Name = "danhMucKhachHangToolStripMenuItem";
            danhMucKhachHangToolStripMenuItem.Size = new Size(236, 26);
            danhMucKhachHangToolStripMenuItem.Text = "danh mục sản phẩm";
            // 
            // đơnToolStripMenuItem
            // 
            đơnToolStripMenuItem.Name = "đơnToolStripMenuItem";
            đơnToolStripMenuItem.Size = new Size(236, 26);
            đơnToolStripMenuItem.Text = "danh mục khách hàng";
            // 
            // đơnHangToolStripMenuItem
            // 
            đơnHangToolStripMenuItem.Name = "đơnHangToolStripMenuItem";
            đơnHangToolStripMenuItem.Size = new Size(236, 26);
            đơnHangToolStripMenuItem.Text = "đơn hàng";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "FormMain";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem danhMucSanPhâmToolStripMenuItem;
        private ToolStripMenuItem danhMucKhachHangToolStripMenuItem;
        private ToolStripMenuItem đơnToolStripMenuItem;
        private ToolStripMenuItem đơnHangToolStripMenuItem;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
    }
}