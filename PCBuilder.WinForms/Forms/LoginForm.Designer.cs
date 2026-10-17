namespace PCBuilder.Forms;
partial class LoginForm
{
    private System.ComponentModel.IContainer? components;

    private TableLayoutPanel root=null!; private Panel hero=null!; private Label brand=null!; private Label heroText=null!; private Label heroSub=null!; private Label badge=null!; private Panel right=null!; private Label formTitle=null!; private Label subtitle=null!; private Label userLabel=null!; private Label passLabel=null!; private Button login=null!; private Label registerText=null!; private LinkLabel register=null!; private Label hint=null!;
    private TextBox _username = null!; private TextBox _password = null!; private Label _message = null!;
    private void InitializeComponent()
    {
        _username = new TextBox();
        _password = new TextBox();
        _message = new Label();
        root = new TableLayoutPanel();
        hero = new Panel();
        brand = new Label();
        heroText = new Label();
        heroSub = new Label();
        badge = new Label();
        right = new Panel();
        formTitle = new Label();
        subtitle = new Label();
        userLabel = new Label();
        passLabel = new Label();
        login = new Button();
        registerText = new Label();
        register = new LinkLabel();
        hint = new Label();
        root.SuspendLayout();
        hero.SuspendLayout();
        right.SuspendLayout();
        SuspendLayout();
        // 
        // _username
        // 
        _username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _username.Location = new Point(45, 190);
        _username.Name = "_username";
        _username.PlaceholderText = "Nhập tên tài khoản";
        _username.Size = new Size(626, 27);
        _username.TabIndex = 3;
        // 
        // _password
        // 
        _password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _password.Location = new Point(45, 275);
        _password.Name = "_password";
        _password.PlaceholderText = "Nhập mật khẩu";
        _password.Size = new Size(626, 27);
        _password.TabIndex = 5;
        _password.UseSystemPasswordChar = true;
        // 
        // _message
        // 
        _message.AutoSize = true;
        _message.ForeColor = Color.FromArgb(220, 70, 70);
        _message.Location = new Point(45, 465);
        _message.MaximumSize = new Size(330, 0);
        _message.Name = "_message";
        _message.Size = new Size(0, 20);
        _message.TabIndex = 9;
        // 
        // root
        // 
        root.ColumnCount = 2;
        root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
        root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52F));
        root.Controls.Add(hero, 0, 0);
        root.Controls.Add(right, 1, 0);
        root.Dock = DockStyle.Fill;
        root.Location = new Point(0, 0);
        root.Name = "root";
        root.Padding = new Padding(18);
        root.RowCount = 1;
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        root.Size = new Size(982, 603);
        root.TabIndex = 0;
        // 
        // hero
        // 
        hero.Controls.Add(brand);
        hero.Controls.Add(heroText);
        hero.Controls.Add(heroSub);
        hero.Controls.Add(badge);
        hero.Dock = DockStyle.Fill;
        hero.Location = new Point(21, 21);
        hero.Name = "hero";
        hero.Padding = new Padding(42);
        hero.Size = new Size(448, 561);
        hero.TabIndex = 0;
        // 
        // brand
        // 
        brand.AutoSize = true;
        brand.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
        brand.ForeColor = Color.White;
        brand.Location = new Point(38, 65);
        brand.Name = "brand";
        brand.Size = new Size(253, 144);
        brand.TabIndex = 0;
        brand.Text = "PC\nBUILDER";
        // 
        // heroText
        // 
        heroText.AutoSize = true;
        heroText.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        heroText.ForeColor = Color.FromArgb(222, 230, 245);
        heroText.Location = new Point(42, 205);
        heroText.Name = "heroText";
        heroText.Size = new Size(326, 82);
        heroText.TabIndex = 1;
        heroText.Text = "Xây dựng cấu hình PC\nthông minh hơn.";
        // 
        // heroSub
        // 
        heroSub.AutoSize = true;
        heroSub.Font = new Font("Segoe UI", 11F);
        heroSub.ForeColor = Color.FromArgb(165, 180, 205);
        heroSub.Location = new Point(44, 290);
        heroSub.Name = "heroSub";
        heroSub.Size = new Size(350, 50);
        heroSub.TabIndex = 2;
        heroSub.Text = "Tra cứu linh kiện  •  Kiểm tra tương thích\nTối ưu hiệu năng theo ngân sách";
        // 
        // badge
        // 
        badge.AutoSize = true;
        badge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        badge.ForeColor = Color.FromArgb(190, 205, 255);
        badge.Location = new Point(44, 390);
        badge.Name = "badge";
        badge.Size = new Size(161, 20);
        badge.TabIndex = 3;
        badge.Text = ".NET 8  |  SQL SERVER";
        // 
        // right
        // 
        right.Controls.Add(formTitle);
        right.Controls.Add(subtitle);
        right.Controls.Add(userLabel);
        right.Controls.Add(_username);
        right.Controls.Add(passLabel);
        right.Controls.Add(_password);
        right.Controls.Add(login);
        right.Controls.Add(registerText);
        right.Controls.Add(register);
        right.Controls.Add(_message);
        right.Controls.Add(hint);
        right.Dock = DockStyle.Fill;
        right.Location = new Point(475, 21);
        right.Name = "right";
        right.Padding = new Padding(48, 50, 48, 30);
        right.Size = new Size(486, 561);
        right.TabIndex = 1;
        // 
        // formTitle
        // 
        formTitle.AutoSize = true;
        formTitle.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
        formTitle.Location = new Point(42, 55);
        formTitle.Name = "formTitle";
        formTitle.Size = new Size(356, 52);
        formTitle.TabIndex = 0;
        formTitle.Text = "Chào mừng trở lại";
        // 
        // subtitle
        // 
        subtitle.AutoSize = true;
        subtitle.Location = new Point(45, 105);
        subtitle.Name = "subtitle";
        subtitle.Size = new Size(340, 20);
        subtitle.TabIndex = 1;
        subtitle.Text = "Đăng nhập để tiếp tục xây dựng cấu hình của bạn.";
        // 
        // userLabel
        // 
        userLabel.AutoSize = true;
        userLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        userLabel.Location = new Point(45, 165);
        userLabel.Name = "userLabel";
        userLabel.Size = new Size(125, 20);
        userLabel.TabIndex = 2;
        userLabel.Text = "TÊN TÀI KHOẢN";
        // 
        // passLabel
        // 
        passLabel.AutoSize = true;
        passLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        passLabel.Location = new Point(45, 250);
        passLabel.Name = "passLabel";
        passLabel.Size = new Size(90, 20);
        passLabel.TabIndex = 4;
        passLabel.Text = "MẬT KHẨU";
        // 
        // login
        // 
        login.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        login.Location = new Point(45, 345);
        login.Name = "login";
        login.Size = new Size(626, 46);
        login.TabIndex = 6;
        login.Text = "Đăng nhập";
        login.Click += Login;
        // 
        // registerText
        // 
        registerText.AutoSize = true;
        registerText.Location = new Point(45, 415);
        registerText.Name = "registerText";
        registerText.Size = new Size(135, 20);
        registerText.TabIndex = 7;
        registerText.Text = "Chưa có tài khoản?";
        // 
        // register
        // 
        register.AutoSize = true;
        register.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        register.Location = new Point(186, 415);
        register.Name = "register";
        register.Size = new Size(187, 21);
        register.TabIndex = 8;
        register.TabStop = true;
        register.Text = "Đăng ký tài khoản User";
        register.Click += OpenRegister;
        // 
        // hint
        // 
        hint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        hint.Location = new Point(45, 961);
        hint.Name = "hint";
        hint.Size = new Size(626, 45);
        hint.TabIndex = 10;
        hint.Text = "Tài khoản Admin được quản lý riêng. Đăng ký mới chỉ tạo quyền User.";
        // 
        // LoginForm
        // 
        AcceptButton = login;
        ClientSize = new Size(982, 603);
        Controls.Add(root);
        MinimumSize = new Size(900, 590);
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "PC Builder | Đăng nhập";
        FormClosing += LoginForm_FormClosing;
        root.ResumeLayout(false);
        hero.ResumeLayout(false);
        hero.PerformLayout();
        right.ResumeLayout(false);
        right.PerformLayout();
        ResumeLayout(false);
    }
    protected override void Dispose(bool disposing) { if(disposing) components?.Dispose(); base.Dispose(disposing); }
}
