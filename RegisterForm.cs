#nullable enable
using System.Text.RegularExpressions;

namespace DriveMate;

public partial class RegisterForm : ThemedForm
{
    public User? Created { get; private set; }
    string idType = "";
    PhotoItem? idPhoto, selfie;

    public RegisterForm()
    {
        InitializeComponent();
        cboRole.SelectedIndex = 0;
    }

    Role CurrentRole => cboRole.SelectedIndex == 1 ? Role.Host : Role.Renter;

    private void cboRole_SelectedIndexChanged(object? sender, EventArgs e)
    {
        idPhoto = null; selfie = null; idType = "";      // required ID type depends on the role
        lblDocs.Text = "Not uploaded yet";
    }

    private void btnDocs_Click(object? sender, EventArgs e)
    {
        using var d = new DocsDialog(CurrentRole);
        if (d.ShowDialog(this) != DialogResult.OK) return;
        idType = d.IdType; idPhoto = d.IdPhoto; selfie = d.Selfie;
        lblDocs.Text = $"✔ {idType} + selfie attached";
    }

    private void btnCreate_Click(object? sender, EventArgs e)
    {
        var mail = txtEmail.Text.Trim().ToLowerInvariant();
        if (txtName.Text.Trim().Length < 2) { Ui.Info("Please enter your full name."); return; }
        if (!mail.Contains('@') || !mail.Contains('.')) { Ui.Info("Please enter a valid email address."); return; }
        if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^\+?[\d\s-]{10,15}$")) { Ui.Info("Please enter a valid mobile number."); return; }
        if (txtPass.Text.Length < 6) { Ui.Info("Your password must be at least 6 characters."); return; }
        if (txtPass.Text != txtConf.Text) { Ui.Info("The passwords do not match."); return; }
        if (idPhoto is null || selfie is null) { Ui.Info("Please upload your ID and selfie. They are needed for verification."); return; }
        if (Database.EmailTaken(mail, Guid.Empty)) { Ui.Info("That email is already registered."); return; }

        var u = new User
        {
            FullName = txtName.Text.Trim(), Email = mail, Phone = txtPhone.Text.Trim(), PasswordHash = Security.Hash(txtPass.Text),
            Role = CurrentRole, IdType = idType, Verification = VerifStatus.Pending
        };
        Database.AddUser(u, idPhoto, selfie);
        Created = u;
        Ui.Info("Welcome to car-to-go!\n\nYour documents were sent to our admin team for manual verification. " +
                (u.Role == Role.Renter ? "You can browse cars now and book once you're verified."
                                       : "Your cars will appear in the listings once you're verified."));
        DialogResult = DialogResult.OK;
    }
}
