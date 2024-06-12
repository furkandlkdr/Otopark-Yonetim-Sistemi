using System;
using System.Windows.Forms;

namespace OtoparkYonetimSistemi {
    public partial class CarPanel : Form {
        Functions Con;
        public CarPanel() {
            InitializeComponent();
            Con = new Functions();
            ShowCars();
        }
        private void disappearLabel(object sender, KeyPressEventArgs e) {
            if (sender is TextBox) {
                TextBox text = (TextBox) sender;
                if (text.Text == "Plaka" || text.Text == "Araç Tipi" || text.Text == "Renk" || text.Text == "Sürücü") {
                    text.Text = "";
                }
            }
        }
        private void ShowCars() {
            string query = "SELECT * FROM CarInfo";
            carsGrid.DataSource = Con.GetData(query);
        }

        int Key = 0;
        private void carsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if(carsGrid.SelectedRows.Count == 0) {
                return;
            }
            plateText.Text = carsGrid.SelectedRows[0].Cells[1].Value.ToString();
            driverText.Text = carsGrid.SelectedRows[0].Cells[2].Value.ToString();
            genderBox.SelectedItem = carsGrid.SelectedRows[0].Cells[3].Value.ToString();
            carTypeText.Text = carsGrid.SelectedRows[0].Cells[4].Value.ToString();
            colorText.Text = carsGrid.SelectedRows[0].Cells[5].Value.ToString();
            if (plateText.Text == "" || plateText.Text == "Plaka") {
                Key = 0;
            } else {
                Key = Convert.ToInt32(carsGrid.SelectedRows[0].Cells[0].Value);
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            if (plateText.Text == "Plaka" || carTypeText.Text == "Araç Tipi" || colorText.Text == "Renk" || driverText.Text == "Sürücü") {
                MessageBox.Show("Tüm alanları doldurun lütfen!");
            } else {
                try {
                    string PNumber = plateText.Text;
                    string Driver = driverText.Text;
                    string Gender = genderBox.SelectedItem.ToString();
                    string CarType = carTypeText.Text;
                    string CarColor = colorText.Text;
                    string query = "INSERT INTO CarInfo VALUES('{0}', '{1}', '{2}', '{3}', '{4}')";
                    query = string.Format(query, PNumber, Driver, Gender, CarType, CarColor);
                    int rows = Con.SetData(query);
                    if (rows > 0) {
                        MessageBox.Show("Araç başarıyla eklendi");
                        ShowCars();
                    } else {
                        MessageBox.Show("Error");
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e) {
            if (Key == 0) {
                MessageBox.Show("Lütfen bir araç seçin");
            } else {
                try {
                    string PNumber = plateText.Text;
                    string Driver = driverText.Text;
                    string Gender = genderBox.SelectedItem.ToString();
                    string CarType = carTypeText.Text;
                    string CarColor = colorText.Text;
                    string query = "UPDATE CarInfo set PNumber = '{0}', Driver = '{1}', Gender = '{2}', CarType = '{3}', CarColor = '{4}' where CNum = {5}";
                    query = string.Format(query, PNumber, Driver, Gender, CarType, CarColor, Key);
                    int rows = Con.SetData(query);
                    if (rows > 0) {
                        MessageBox.Show("Araç başarıyla güncellendi");
                        ShowCars();
                    } else {
                        MessageBox.Show("Error");
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if (plateText.Text == "Plaka" || carTypeText.Text == "Araç Tipi" || colorText.Text == "Renk" || driverText.Text == "Sürücü") {
                MessageBox.Show("Tüm alanları doldurun lütfen!");
            } else {
                try {
                    string PNumber = plateText.Text;
                    string Driver = driverText.Text;
                    string Gender = genderBox.SelectedItem.ToString();
                    string CarType = carTypeText.Text;
                    string CarColor = colorText.Text;
                    string query = "DELETE FROM CarInfo WHERE CNum = {0}";
                    query = string.Format(query, Key);
                    int rows = Con.SetData(query);
                    if (rows > 0) {
                        MessageBox.Show("Araç başarıyla silindi");
                        ShowCars();
                    } else {
                        MessageBox.Show("Error");
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void genderBox_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
