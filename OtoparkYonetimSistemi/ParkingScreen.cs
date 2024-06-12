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
        }

        private void GetCars() {
            string query = "SELECT * FROM CarInfo";
            carBox.ValueMember = Con.GetData(query).Columns["CNum"].ToString();
            carBox.DisplayMember = Con.GetData(query).Columns["PNumber"].ToString();
            carBox.DataSource = Con.GetData(query);
        }
        private void GetPlaces() {
            string query = "SELECT * FROM PlaceInfo";
            posColBox.ValueMember = Con.GetData(query).Columns["PlaceNumber"].ToString();
            posColBox.DisplayMember = Con.GetData(query).Columns["PColPos"].ToString();
            posColBox.DataSource = Con.GetData(query);

            //posRowBox.ValueMember = Con.GetData(query).Columns["PlaceNumber"].ToString();
            //posRowBox.DisplayMember = Con.GetData(query).Columns["PRowPos"].ToString();
            //posRowBox.DataSource = Con.GetData(query);
            // TODO: Fix this bug 
        }

        private void bookBtn_Click(object sender, EventArgs e) {

        }
    }
}
