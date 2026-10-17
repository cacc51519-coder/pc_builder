using PCBuilder.Data;
namespace PCBuilder.Forms;

public sealed partial class LoginForm : Form
{
    public LoginForm() { InitializeComponent(); }
    private bool _isOpeningMainForm = false;
    private bool _isLoggingOut = false;
    private bool _isExiting = false;

    private void Login(object? sender, EventArgs e)
    {
        _message.Text = string.Empty;

        if (string.IsNullOrWhiteSpace(_username.Text) ||
            string.IsNullOrEmpty(_password.Text))
        {
            _message.Text = "Vui lòng nhập tài khoản và mật khẩu.";
            return;
        }

        try
        {
            var user = new AuthRepository().Login(
                _username.Text,
                _password.Text
            );

            if (user is null)
            {
                _message.Text =
                    "Thông tin đăng nhập không đúng hoặc tài khoản đã bị khóa.";
                return;
            }

            _isOpeningMainForm = true;
            Hide();


            using (var main = new MainForm(user))
            {
                main.ShowDialog();

                _isLoggingOut = main.IsLoggingOut;
                _isExiting = main.IsExiting;
            }

            _isOpeningMainForm = false;

            if (_isLoggingOut)
            {
                _isLoggingOut = false;

                _username.Clear();
                _password.Clear();
                _message.Text = string.Empty;

                Show();
                Activate();
            }
            else
            {
                Close();
            }


        }
        catch (Exception ex)
        {
            _isOpeningMainForm = false;

            MessageBox.Show(
                "Không thể đăng nhập. Hãy kiểm tra SQL Server và connection string.\n\n"
                + ex.Message,
                "Lỗi kết nối",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private void OpenRegister(object? sender, EventArgs e) { using var f = new RegisterForm(); f.ShowDialog(this); }

    private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (_isOpeningMainForm || _isExiting)
            return;

        DialogResult result = MessageBox.Show(
            "Bạn có muốn thoát chương trình không?",
            "Xác nhận thoát",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}
