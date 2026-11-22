namespace DriveMate;

public partial class LoginForm : ThemedForm
{
    public User? User { get; private set; }

    public LoginForm()
    {
        InitializeComponent();
        picLogo.Image = Brand.Logo;
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        BackColor = Color.White;   
    }

    private void btnLogin_Click(object? sender, EventArgs e)
    {
        var u = Database.GetUserByEmail(txtEmail.Text.Trim());
        if (u is null || !Security.Verify(txtPass.Text, u.PasswordHash))
        { Ui.Info("Invalid email or password."); return; }
        User = u;
        DialogResult = DialogResult.OK;
    }

    private void btnRegister_Click(object? sender, EventArgs e)
    {
        using var f = new RegisterForm();
        if (f.ShowDialog(this) == DialogResult.OK && f.Created != null)
        {
            User = f.Created;
            DialogResult = DialogResult.OK;
        }
    }
    private void lnkForgot_Click(object? sender, EventArgs e)
    {
        using var d = new ForgotPasswordDialog(txtEmail.Text);
        if (d.ShowDialog(this) == DialogResult.OK)
        {
            txtPass.Clear();
            txtPass.Focus();
        }
    }
}
