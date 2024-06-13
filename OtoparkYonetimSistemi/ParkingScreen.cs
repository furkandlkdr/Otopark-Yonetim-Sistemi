using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkYonetimSistemi {
    public partial class ParkingScreen : Form {
        Functions Con;
        public ParkingScreen() {
            InitializeComponent();
            Con = new Functions();
            GetCars();
            GetPlaces();
            GetParkingCarInfo();
        }

        private void GetCars() {
            string query = "SELECT * FROM CarInfo";
            carBox.ValueMember = Con.GetData(query).Columns["CNum"].ToString();
            carBox.DisplayMember = Con.GetData(query).Columns["PNumber"].ToString();
            carBox.DataSource = Con.GetData(query);
        }
        private void GetPlaces() {
            string PSt = "Bos";
            string query = "SELECT * FROM PlaceInfo where PStatus = '{0}'";
            query = string.Format(query, PSt);
            placeBox.ValueMember = Con.GetData(query).Columns["PlaceNumber"].ToString();
            placeBox.DisplayMember = Con.GetData(query).Columns["PPosition"].ToString();
            placeBox.DataSource = Con.GetData(query);
        }

        private void GetParkingCarInfo() {
            string query = "SELECT * FROM ParkingCarInfo";
            parkingGrid.DataSource = Con.GetData(query);
        }

        private void UpdateStatus() {
            try {
                string PSt = "Dolu";
                string Place = placeBox.SelectedValue.ToString();
                string query = "UPDATE PlaceInfo set PStatus = '{0}' where PlaceNumber = {1}";
                query = string.Format(query, PSt, Place);
                int rows = Con.SetData(query);
                if (rows > 0) {
                    MessageBox.Show("Alan başarıyla güncellendi");
                } else {
                    MessageBox.Show("Error");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void bookBtn_Click(object sender, EventArgs e) {
            if (carBox.SelectedIndex == -1 || placeBox.SelectedIndex == -1 ||
                amountText.Text == "" || amountText.Text == "Miktar" ||
                durationText.Text == "" || durationText.Text == "Süre") {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            } else {
                try {
                    string Car = carBox.SelectedValue.ToString();
                    string Duration = durationText.Text.ToString();
                    int Amount = Convert.ToInt32(amountText.Text);
                    string Place = placeBox.SelectedValue.ToString();
                    string date = DateTime.Now.ToString();
                    string query = "INSERT INTO ParkingCarInfo VALUES('{0}', '{1}', '{2}', '{3}', '{4}')";
                    query = string.Format(query, Car, date, Duration, Amount, Place);
                    int rows = Con.SetData(query);
                    if (rows > 0) {
                        MessageBox.Show("Alan başarıyla ayrıldı.");
                        GetParkingCarInfo();
                        UpdateStatus();

                    } else {
                        MessageBox.Show("Error");
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void garagePic_Click(object sender, EventArgs e) {
            CarPanel carPanel = new CarPanel();
            carPanel.Show();
            this.Hide();
        }

        private void placesPic_Click(object sender, EventArgs e) {
            Places places = new Places();
            places.Show();
            this.Hide();
        }

        private void disappearLabel(object sender, KeyPressEventArgs e) {
            if (sender is TextBox a && (a.Text == "Miktar" || a.Text == "Süre")) {
                a.Text = "";
            }
        }

        private void closePic_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e) {
            SignPage login = new SignPage();
            login.Show();
            this.Hide();
        }
    }
}
