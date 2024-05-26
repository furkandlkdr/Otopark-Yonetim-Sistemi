using System.Windows.Forms;

namespace OtoparkYonetimSistemi {
    public partial class SignPage : Form {
        void changeButtonToRounded(Button secilenBtn) {
            Button koseliBtn = secilenBtn;
            RoundedButton yuvarlanmisBtn = new RoundedButton {
                Text = koseliBtn.Text,
                Size = koseliBtn.Size,
                Location = koseliBtn.Location,
                Font = koseliBtn.Font,
                BackColor = koseliBtn.BackColor,
                ForeColor = koseliBtn.ForeColor,
            };
            this.Controls.Add(yuvarlanmisBtn);
            this.Controls.Remove(koseliBtn);
        }
        public SignPage() {
            InitializeComponent();
            changeButtonToRounded(signInBtn);
        }

    }
}
