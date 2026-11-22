#nullable enable
namespace DriveMate;

partial class RegisterForm
{
    private System.ComponentModel.IContainer? components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblHead = new Label(); lblName = new Label(); lblEmail = new Label(); lblPhone = new Label(); lblPass = new Label();
        lblConf = new Label(); lblRole = new Label();
        txtName = new TextBox(); txtEmail = new TextBox(); txtPhone = new TextBox(); txtPass = new TextBox(); txtConf = new TextBox();
        cboRole = new ComboBox(); grpVerify = new GroupBox(); lblVerifyInfo = new Label(); btnDocs = new Button(); lblDocs = new Label();
        btnCreate = new Button(); btnCancel = new Button();
        grpVerify.SuspendLayout(); SuspendLayout();
        lblHead.AutoSize = true; lblHead.Font = new Font("Segoe UI", 16F, FontStyle.Bold); lblHead.Location = new Point(24, 14); lblHead.Text = "Create your account";
        lblName.AutoSize = true; lblName.Location = new Point(24, 62); lblName.Text = "Full name";
        txtName.Location = new Point(24, 84); txtName.Size = new Size(412, 27);
        lblEmail.AutoSize = true; lblEmail.Location = new Point(24, 120); lblEmail.Text = "Email";
        txtEmail.Location = new Point(24, 142); txtEmail.Size = new Size(412, 27);
        lblPhone.AutoSize = true; lblPhone.Location = new Point(24, 178); lblPhone.Text = "Mobile number";
        txtPhone.Location = new Point(24, 200); txtPhone.Size = new Size(412, 27);
        lblPass.AutoSize = true; lblPass.Location = new Point(24, 236); lblPass.Text = "Password (min. 6 characters)";
        txtPass.Location = new Point(24, 258); txtPass.Size = new Size(200, 27); txtPass.UseSystemPasswordChar = true;
        lblConf.AutoSize = true; lblConf.Location = new Point(236, 236); lblConf.Text = "Confirm password";
        txtConf.Location = new Point(236, 258); txtConf.Size = new Size(200, 27); txtConf.UseSystemPasswordChar = true;
        lblRole.AutoSize = true; lblRole.Location = new Point(24, 294); lblRole.Text = "I want to…";
        cboRole.DropDownStyle = ComboBoxStyle.DropDownList; cboRole.Location = new Point(24, 316); cboRole.Size = new Size(412, 28);
        cboRole.Items.AddRange(new object[] { "Rent cars (Renter)", "List my car and earn (Host)" });
        cboRole.SelectedIndexChanged += cboRole_SelectedIndexChanged;
        grpVerify.Location = new Point(24, 360); grpVerify.Size = new Size(412, 128); grpVerify.Text = "Identity verification (required)";
        lblVerifyInfo.Location = new Point(12, 26); lblVerifyInfo.Size = new Size(390, 40);
        lblVerifyInfo.Text = "Upload a valid ID and a selfie. Our admin reviews them manually before you can book or list cars.";
        btnDocs.Location = new Point(12, 78); btnDocs.Size = new Size(190, 34); btnDocs.Text = "Upload ID && selfie…"; btnDocs.Tag = "accent";
        btnDocs.Click += btnDocs_Click;
        lblDocs.AutoSize = true; lblDocs.ForeColor = Color.FromArgb(107, 122, 153); lblDocs.Location = new Point(212, 87); lblDocs.Text = "Not uploaded yet";
        grpVerify.Controls.AddRange(new Control[] { lblVerifyInfo, btnDocs, lblDocs });
        btnCreate.Location = new Point(24, 508); btnCreate.Size = new Size(200, 42); btnCreate.Text = "Create account"; btnCreate.Click += btnCreate_Click;
        btnCancel.DialogResult = DialogResult.Cancel; btnCancel.Location = new Point(236, 508); btnCancel.Size = new Size(200, 42); btnCancel.Text = "Cancel";
        AcceptButton = btnCreate; CancelButton = btnCancel;
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(460, 572);
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false;
        StartPosition = FormStartPosition.CenterParent; Text = "Create account";
        Controls.AddRange(new Control[] { lblHead, lblName, txtName, lblEmail, txtEmail, lblPhone, txtPhone, lblPass, txtPass, lblConf, txtConf,
            lblRole, cboRole, grpVerify, btnCreate, btnCancel });
        grpVerify.ResumeLayout(false); ResumeLayout(false); PerformLayout();
    }

    private Label lblHead, lblName, lblEmail, lblPhone, lblPass, lblConf, lblRole, lblVerifyInfo, lblDocs;
    private TextBox txtName, txtEmail, txtPhone, txtPass, txtConf;
    private ComboBox cboRole;
    private GroupBox grpVerify;
    private Button btnDocs, btnCreate, btnCancel;
}
