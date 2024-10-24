namespace FormSignUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.ToString();
            string password = txtPassWord.Text.ToString();
            if (user == "admin" && password == "1234")
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! tài khoản hoặc mật khẩu không chính xác!");
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
