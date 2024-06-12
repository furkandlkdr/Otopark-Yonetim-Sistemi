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
            posRowBox.SelectedIndex = -1;
            posRowBox.Text = "Satır";
            posColBox.SelectedIndex = -1;
            posColBox.Text = "Sütun";
            statusBox.SelectedIndex = -1;
            statusBox.Text = "Durumu";
        }

        private void disappearLabel(object sender, KeyPressEventArgs e) {
            if (sender is TextBox) {
                TextBox text = (TextBox) sender;
                if (text.Text == "Park yeri") {
                    text.Text = "";
                }
            }
        }
        private void ShowPlaces() {
            string query = "SELECT * FROM PlaceInfo";
            placeGrid.DataSource = Con.GetData(query);
        }

        int Key;
        private void placeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            posRowBox.SelectedIndex = (int) placeGrid.SelectedRows[0].Cells[1].Value - 1;
            posColBox.SelectedIndex = (int) placeGrid.SelectedRows[0].Cells[2].Value - 1;
            statusBox.SelectedItem = placeGrid.SelectedRows[0].Cells[3].Value.ToString();
            if (posColBox.SelectedIndex == -1 || posRowBox.SelectedIndex == -1 || statusBox.SelectedIndex == -1) {
                Key = 0;
            } else {
                Key = Convert.ToInt32(placeGrid.SelectedRows[0].Cells[0].Value);
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            if (posColBox.SelectedIndex == -1 || posRowBox.SelectedIndex == -1 || statusBox.SelectedIndex == -1) {
                MessageBox.Show("Tüm alanları doldurun lütfen!");
            } else {
                try {
                    int PRowPos = Convert.ToInt32(posRowBox.SelectedItem.ToString());
                    int PColPos = Convert.ToInt32(posColBox.SelectedItem.ToString());
                    string PStatus = statusBox.SelectedItem.ToString();
                    string query = "INSERT INTO PlaceInfo VALUES('{0}', '{1}', '{2}')";
                    query = string.Format(query, PRowPos, PColPos, PStatus);
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
            if (posColBox.SelectedIndex == -1 || posRowBox.SelectedIndex == -1 || statusBox.SelectedIndex == -1) {
                MessageBox.Show("Tüm alanları doldurun lütfen!");
            } else {
                try {
                    int PRowPos = Convert.ToInt32(posRowBox.SelectedItem.ToString());
                    int PColPos = Convert.ToInt32(posColBox.SelectedItem.ToString());
                    string PStatus = statusBox.SelectedItem.ToString();
                    string query = "UPDATE PlaceInfo set PRowPos = '{0}', PColPos = '{1}' ,PStatus = '{2}' where PlaceNumber = {3}";
                    query = string.Format(query, PRowPos, PColPos, PStatus, Key);
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
            if (posColBox.SelectedIndex == -1 || posRowBox.SelectedIndex == -1 || statusBox.SelectedIndex == -1) {
                MessageBox.Show("Tüm alanları doldurun lütfen!");
            } else {
                try {
                    int PRowPos = Convert.ToInt32(posRowBox.SelectedItem.ToString());
                    int PColPos = Convert.ToInt32(posColBox.SelectedItem.ToString());
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
    }
}
