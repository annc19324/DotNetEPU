namespace QuanLySanPham
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
            groupBox3 = new GroupBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            groupBox2 = new GroupBox();
            dgv = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtQuantity = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtDescription = new RichTextBox();
            txtPrice = new TextBox();
            label2 = new Label();
            txtProductName = new TextBox();
            label1 = new Label();
            txtProductID = new TextBox();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 547);
            panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSave);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(btnEdit);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Location = new Point(9, 428);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(409, 116);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "chức năng";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(306, 49);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(206, 49);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(106, 49);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 49);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(424, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(686, 541);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "dữ liệu";
            // 
            // dgv
            // 
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(6, 66);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Resizable = DataGridViewTriState.False;
            dgv.Size = new Size(674, 469);
            dgv.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(586, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(82, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(486, 27);
            txtSearch.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 23);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 0;
            label5.Text = "Tìm kiếm";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 364);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "đầu vào";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 39);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 8;
            label6.Text = "ID";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(119, 312);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(287, 27);
            txtQuantity.TabIndex = 7;
            txtQuantity.KeyDown += txtQuantity_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 312);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 6;
            label4.Text = "Số lượng: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 279);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 5;
            label3.Text = "Giá: ";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(119, 102);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(287, 171);
            txtDescription.TabIndex = 4;
            txtDescription.Text = "";
            txtDescription.KeyDown += txtDescription_KeyDown;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(119, 279);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(287, 27);
            txtPrice.TabIndex = 3;
            txtPrice.KeyDown += txtPrice_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 102);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "Mô tả: ";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(119, 66);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(287, 27);
            txtProductName.TabIndex = 1;
            txtProductName.KeyDown += txtProductName_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 69);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm: ";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(119, 32);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(287, 27);
            txtProductID.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 571);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox txtPrice;
        private Label label2;
        private TextBox txtProductName;
        private Label label1;
        private GroupBox groupBox3;
        private Button btnSave;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private TextBox txtQuantity;
        private Label label4;
        private Label label3;
        private RichTextBox txtDescription;
        private DataGridView dgv;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label5;
        private Label label6;
        private TextBox txtProductID;
    }
}
