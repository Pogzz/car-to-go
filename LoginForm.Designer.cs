#nullable enable
namespace DriveMate;

partial class LoginForm
{
    private System.ComponentModel.IContainer? components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pnlLeft = new Panel(); picLogo = new PictureBox(); lblTag = new Label();
        lblTitle = new Label(); lblEmail = new Label(); txtEmail = new TextBox();
        lblPass = new Label(); txtPass = new TextBox(); lnkForgot = new LinkLabel();
        btnLogin = new Button(); btnRegister = new Button(); lblDemo = new Label();
        pnlLeft.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        SuspendLayout();

        // Navy Brand Panel
        pnlLeft.BackColor = Theme.Navy;
        pnlLeft.Dock = DockStyle.Left;
        pnlLeft.Size = new Size(270, 440);

        picLogo.Image = Brand.Logo;
        picLogo.Location = new Point(35, 130);
        picLogo.Size = new Size(200, 56);
        picLogo.SizeMode = PictureBoxSizeMode.Zoom;

        lblTag.ForeColor = Color.FromArgb(203, 213, 225);
        lblTag.Font = new Font("Segoe UI", 9.5F);
        lblTag.Location = new Point(28, 198);
        lblTag.Size = new Size(214, 54);
        lblTag.Text = "Peer-to-peer car sharing.\nVerified hosts & renters.";
        lblTag.TextAlign = ContentAlignment.TopCenter;

        pnlLeft.Controls.AddRange(new Control[] { picLogo, lblTag });

        // Sign-In Form
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
        lblTitle.ForeColor = Theme.Navy;
        lblTitle.Location = new Point(304, 28);
        lblTitle.Text = "Welcome back";

        lblEmail.AutoSize = true;
        lblEmail.Location = new Point(304, 80);
        lblEmail.Text = "Email";

        txtEmail.Location = new Point(304, 102);
        txtEmail.Size = new Size(310, 27);

        lblPass.AutoSize = true;
        lblPass.Location = new Point(304, 142);
        lblPass.Text = "Password";

        txtPass.Location = new Point(304, 164);
        txtPass.Size = new Size(310, 27);
        txtPass.UseSystemPasswordChar = true;

        // Forgot password
        lnkForgot.AutoSize = true;
        lnkForgot.LinkColor = Theme.Blue;
        lnkForgot.ActiveLinkColor = Theme.Navy;
        lnkForgot.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lnkForgot.Location = new Point(496, 196);
        lnkForgot.Text = "Forgot password?";
        lnkForgot.Click += lnkForgot_Click;

        btnLogin.Location = new Point(304, 232);
        btnLogin.Size = new Size(310, 40);
        btnLogin.Text = "Sign in";
        btnLogin.Click += btnLogin_Click;

        btnRegister.Location = new Point(304, 282);
        btnRegister.Size = new Size(310, 38);
        btnRegister.Tag = "secondary";
        btnRegister.Text = "Create an account";
        btnRegister.Click += btnRegister_Click;

        lblDemo.ForeColor = Theme.Muted;
        lblDemo.Font = new Font("Segoe UI", 8.5F);
        lblDemo.Location = new Point(304, 336);
        lblDemo.Size = new Size(310, 76);
        //lblDemo.Text = "Demo accounts:\n• Renter: renter@demo.com / demo123\n• Host: host@demo.com / demo123\n• Admin: admin@cartogo.com / admin123";

        AcceptButton = btnLogin;
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(650, 440);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Sign in";
        Controls.AddRange(new Control[] { pnlLeft, lblTitle, lblEmail, txtEmail, lblPass, txtPass, lnkForgot, btnLogin, btnRegister, lblDemo });

        pnlLeft.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Panel pnlLeft;
    private PictureBox picLogo;
    private Label lblTag, lblTitle, lblEmail, lblPass, lblDemo;
    private TextBox txtEmail, txtPass;
    private LinkLabel lnkForgot;
    private Button btnLogin, btnRegister;
}