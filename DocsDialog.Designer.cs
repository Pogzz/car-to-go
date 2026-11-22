#nullable enable
namespace DriveMate;

partial class DocsDialog
{
    private System.ComponentModel.IContainer? components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblHint = new Label(); lblType = new Label(); lblId = new Label(); lblSelfie = new Label();
        cboIdType = new ComboBox(); btnId = new Button(); btnSelfie = new Button();
        picId = new PictureBox(); picSelfie = new PictureBox(); btnSubmit = new Button(); btnCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)picId).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picSelfie).BeginInit();
        SuspendLayout();
        lblHint.Location = new Point(20, 14); lblHint.Size = new Size(420, 40);
        lblType.AutoSize = true; lblType.Location = new Point(20, 68); lblType.Text = "ID type";
        cboIdType.DropDownStyle = ComboBoxStyle.DropDownList; cboIdType.Location = new Point(150, 64); cboIdType.Size = new Size(290, 28);
        lblId.AutoSize = true; lblId.Location = new Point(20, 112); lblId.Text = "ID photo";
        btnId.Location = new Point(150, 106); btnId.Size = new Size(160, 30); btnId.Text = "Choose ID photo…"; btnId.Click += btnId_Click;
        picId.BackColor = Color.WhiteSmoke; picId.BorderStyle = BorderStyle.FixedSingle;
        picId.Location = new Point(150, 144); picId.Size = new Size(290, 110); picId.SizeMode = PictureBoxSizeMode.Zoom;
        lblSelfie.AutoSize = true; lblSelfie.Location = new Point(20, 274); lblSelfie.Text = "Selfie with ID";
        btnSelfie.Location = new Point(150, 268); btnSelfie.Size = new Size(160, 30); btnSelfie.Text = "Choose selfie…"; btnSelfie.Click += btnSelfie_Click;
        picSelfie.BackColor = Color.WhiteSmoke; picSelfie.BorderStyle = BorderStyle.FixedSingle;
        picSelfie.Location = new Point(150, 306); picSelfie.Size = new Size(290, 110); picSelfie.SizeMode = PictureBoxSizeMode.Zoom;
        btnSubmit.Location = new Point(150, 432); btnSubmit.Size = new Size(140, 34); btnSubmit.Text = "Save documents"; btnSubmit.Click += btnSubmit_Click;
        btnCancel.DialogResult = DialogResult.Cancel; btnCancel.Location = new Point(300, 432); btnCancel.Size = new Size(140, 34); btnCancel.Text = "Cancel";
        AcceptButton = btnSubmit; CancelButton = btnCancel;
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(460, 482);
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false;
        StartPosition = FormStartPosition.CenterParent; Text = "Verification documents";
        Controls.AddRange(new Control[] { lblHint, lblType, cboIdType, lblId, btnId, picId, lblSelfie, btnSelfie, picSelfie, btnSubmit, btnCancel });
        ((System.ComponentModel.ISupportInitialize)picId).EndInit();
        ((System.ComponentModel.ISupportInitialize)picSelfie).EndInit();
        ResumeLayout(false); PerformLayout();
    }

    private Label lblHint, lblType, lblId, lblSelfie;
    private ComboBox cboIdType;
    private Button btnId, btnSelfie, btnSubmit, btnCancel;
    private PictureBox picId, picSelfie;
}
