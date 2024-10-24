namespace FormSignUp
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
            btnExit = new Button();
            btnSignUp = new Button();
            txtPassWord = new TextBox();
            txtUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(txtPassWord);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(130, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 182);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveBorder;
            btnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(291, 113);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(255, 45);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.ActiveBorder;
            btnSignUp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(3, 113);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(282, 45);
            btnSignUp.TabIndex = 4;
            btnSignUp.Text = "Sign In";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += button1_Click;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(155, 80);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.Size = new Size(391, 27);
            txtPassWord.TabIndex = 3;
            txtPassWord.TextChanged += textBox2_TextChanged;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(155, 33);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(391, 27);
            txtUser.TabIndex = 2;
            txtUser.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 74);
            label2.Name = "label2";
            label2.Size = new Size(120, 31);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 27);
            label1.Name = "label1";
            label1.Size = new Size(69, 31);
            label1.TabIndex = 0;
            label1.Text = "User:";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnExit;
        private Button btnSignUp;
        private TextBox txtPassWord;
        private TextBox txtUser;
    }
}
