using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OtoparkYonetimSistemi {
    public partial class SignPage : Form {
        private void disappearLabel(object sender, KeyPressEventArgs e) {
            if (sender is TextBox a && (a.Text == "Parola" || a.Text == "Kullanıcı Adı")) {
                a.Text = "";
            }
        }
        public SignPage() {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, System.EventArgs e) {
            if (usernameTxt.Text == "" || usernameTxt.Text == "Kullanıcı Adı" ||
                passwordTxt.Text == "Parola "|| passwordTxt.Text == "") {
                MessageBox.Show("Tüm alanları doldurun lütfen!");
            } else {
                if (usernameTxt.Text == "Admin" && passwordTxt.Text == "Admin") {
                    CarPanel cars = new CarPanel();
                    cars.Show();
                    this.Hide();
                } else {
                    MessageBox.Show("Kullanıcı adı veya parola hatalı!");
                    usernameTxt.Text = "";
                    passwordTxt.Text = "";
                }
            }
        }

        private void usernameRegex(object sender, EventArgs e) {
            Regex regex = new Regex("^[a-zA-Z0-9]{5,}$");
            if (!regex.IsMatch(usernameTxt.Text)) {
                MessageBox.Show("Kullanıcı adı en az 5 karakter olmalıdır!");
                usernameTxt.Text = "";
            }
        }

        private void passwordRegex(object sender, EventArgs e) {
            Regex regex = new Regex("^[a-zA-Z0-9!?]{9,}$");
            if (!regex.IsMatch(passwordTxt.Text)) {
                MessageBox.Show("Parola en az 9 karakter olmalı ve içerisinde ! veya ? içermelidir!");
                passwordTxt.Text = "";
            }
        }
    }
}
