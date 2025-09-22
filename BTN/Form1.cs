namespace BTN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin đăng nhập
            if (txtUserName.Text == "admin" && txtPassword.Text == "admin")
            {
                // Đăng nhập thành công - mở form mới
                frmLoginSucces loginSuccessForm = new frmLoginSucces();
                loginSuccessForm.Show();

                // Ẩn form hiện tại
                this.Hide();
            }
            else
            {
                // Đăng nhập thất bại - hiển thị thông báo lỗi
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!",
                               "Lỗi đăng nhập",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);

                // Xóa nội dung và focus lại username
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }

    }
}
