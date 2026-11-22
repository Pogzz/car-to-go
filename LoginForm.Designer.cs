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
        pnlBrand = new Panel(); picLogo = new PictureBox(); lblTagline = new Label();
        lblWelcome = new Label(); lblSub = new Label(); lblEmail = new Label(); lblPass = new Label();
        txtEmail = new TextBox(); txtPass = new TextBox(); btnLogin = new Button();
        lblNew = new Label(); btnRegister = new Button(); lblDemo = new Label();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        pnlBrand.SuspendLayout(); SuspendLayout();
        // brand panel
        pnlBrand.BackColor = Color.FromArgb(12, 24, 50); pnlBrand.Dock = DockStyle.Left; pnlBrand.Width = 420;
        pnlBrand.Controls.Add(picLogo); pnlBrand.Controls.Add(lblTagline);
        picLogo.Location = new Point(25, 190); picLogo.Size = new Size(370, 78); picLogo.SizeMode = PictureBoxSizeMode.Zoom;
        lblTagline.ForeColor = Color.FromArgb(150, 170, 205); lblTagline.Font = new Font("Segoe UI", 11F);
        lblTagline.Location = new Point(25, 290); lblTagline.Size = new Size(370, 50); lblTagline.TextAlign = ContentAlignment.TopCenter;
        lblTagline.Text = "Rent a car. Share your car.\nGo anywhere.";
        // right side
        lblWelcome.AutoSize = true; lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblWelcome.ForeColor = Color.FromArgb(12, 24, 50); lblWelcome.Location = new Point(460, 80); lblWelcome.Text = "Welcome back";
        lblSub.AutoSize = true; lblSub.ForeColor = Color.FromArgb(107, 122, 153); lblSub.Location = new Point(463, 128);
        lblSub.Text = "Sign in to continue to car-to-go";
        lblEmail.AutoSize = true; lblEmail.Location = new Point(463, 180); lblEmail.Text = "Email";
        txtEmail.Font = new Font("Segoe UI", 11F); txtEmail.Location = new Point(463, 202); txtEmail.Size = new Size(360, 27);
        lblPass.AutoSize = true; lblPass.Location = new Point(463, 245); lblPass.Text = "Password";
        txtPass.Font = new Font("Segoe UI", 11F); txtPass.Location = new Point(463, 267); txtPass.Size = new Size(360, 27); txtPass.UseSystemPasswordChar = true;
        btnLogin.Location = new Point(463, 322); btnLogin.Size = new Size(360, 42); btnLogin.Text = "Log in"; btnLogin.Click += btnLogin_Click;
        lblNew.AutoSize = true; lblNew.Location = new Point(463, 395); lblNew.Text = "New to car-to-go?";
        btnRegister.Location = new Point(463, 418); btnRegister.Size = new Size(360, 38); btnRegister.Tag = "secondary";
        btnRegister.Text = "Create an account (renter or host)"; btnRegister.Click += btnRegister_Click;
        lblDemo.ForeColor = Color.FromArgb(107, 122, 153); lblDemo.Font = new Font("Segoe UI", 8.5F);
        lblDemo.Location = new Point(463, 478); lblDemo.Size = new Size(360, 36);
        //lblDemo.Text = "Demo logins (password demo123): renter@demo.com, host@demo.com\nAdmin: admin@cartogo.com / admin123";
        AcceptButton = btnLogin;
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(860, 540);
        FormBorderStyle = FormBorderStyle.FixedSingle; MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen; Text = "car-to-go";
        Controls.AddRange(new Control[] { lblWelcome, lblSub, lblEmail, txtEmail, lblPass, txtPass, btnLogin, lblNew, btnRegister, lblDemo, pnlBrand });
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        pnlBrand.ResumeLayout(false); ResumeLayout(false); PerformLayout();
    }

    private Panel pnlBrand;
    private PictureBox picLogo;
    private Label lblTagline, lblWelcome, lblSub, lblEmail, lblPass, lblNew, lblDemo;
    private TextBox txtEmail, txtPass;
    private Button btnLogin, btnRegister;
}
