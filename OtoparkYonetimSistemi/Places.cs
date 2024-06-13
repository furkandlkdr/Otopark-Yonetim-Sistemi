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
    public partial class Places : Form {
        Functions Con;
        public Places() {
            InitializeComponent();
            Con = new Functions();
            ShowPlaces();
        }

        void resetBoxes() {
            placeText.Text = "Alan";
            statusBox.SelectedIndex = -1;
            statusBox.Text = "Durumu";
        }

        private void disappearLabel(object sender, KeyPressEventArgs e) {
            if (sender is TextBox a && a.Text == "Alan") {
                a.Text = "";
            }
        }
        private void ShowPlaces() {
            string query = "SELECT * FROM PlaceInfo";
            placeGrid.DataSource = Con.GetData(query);
        }

        int Key;
        private void placeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            placeText.Text = placeGrid.SelectedRows[0].Cells[1].Value.ToString();
            statusBox.SelectedItem = placeGrid.SelectedRows[0].Cells[2].Value.ToString();
            if (placeText.Text == "Alan" || placeText.Text == "" || statusBox.SelectedIndex == -1) {
                Key = 0;
            } else {
                Key = Convert.ToInt32(placeGrid.SelectedRows[0].Cells[0].Value);
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            if (placeText.Text == "Alan" || placeText.Text == "" || statusBox.SelectedIndex == -1) {
                MessageBox.Show("Tüm alanları doldurun lütfen!");
            } else {
                try {
                    string PPosition = placeText.Text;
                    string PStatus = statusBox.SelectedItem.ToString();
                    string query = "INSERT INTO PlaceInfo VALUES('{0}', '{1}')";
                    query = string.Format(query, PPosition, PStatus);
                    int rows = Con.SetData(query);
                    if (rows > 0) {
                        MessageBox.Show("Alan başarıyla eklendi");
                        resetBoxes();
                        ShowPlaces();
                    } else {
                        MessageBox.Show("Error");
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e) {
            if (placeText.Text == "Alan" || placeText.Text == "" || statusBox.SelectedIndex == -1) {
                MessageBox.Show("Tüm alanları doldurun lütfen!");
            } else {
                try {
                    string PPosition = placeText.Text;
                    string PStatus = statusBox.SelectedItem.ToString();
                    string query = "UPDATE PlaceInfo set PPosition = '{0}' ,PStatus = '{1}' where PlaceNumber = {2}";
                    query = string.Format(query, PPosition, PStatus, Key);
                    int rows = Con.SetData(query);
                    if (rows > 0) {
                        MessageBox.Show("Alan başarıyla güncellendi");
                        ShowPlaces();
                        resetBoxes();
                    } else {
                        MessageBox.Show("Error");
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if (placeText.Text == "Alan" || placeText.Text == "" || statusBox.SelectedIndex == -1) {
                MessageBox.Show("Tüm alanları doldurun lütfen!");
            } else {
                try {
                    string PPosition = placeText.Text;
                    string PStatus = statusBox.SelectedItem.ToString();
                    string query = "DELETE PlaceInfo where PlaceNumber = {0}";
                    query = string.Format(query, Key);
                    int rows = Con.SetData(query);
                    if (rows > 0) {
                        MessageBox.Show("Alan başarıyla silindi");
                        ShowPlaces();
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

        private void pictureBox1_Click(object sender, EventArgs e) {
            ParkingScreen parkingScreen = new ParkingScreen();
            parkingScreen.Show();
            this.Hide();
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
