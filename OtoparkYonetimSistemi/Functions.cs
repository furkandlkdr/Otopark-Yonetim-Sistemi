using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkYonetimSistemi {
    internal class Functions {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter Sda;
        private string ConStr;
        public Functions() {
            ConStr = @"Data Source=MONSTERABRAA7V9\MOBSTERABRAA7DB;Initial Catalog=Parking_Lot;Integrated Security=True;";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }
        public DataTable GetData(string Query) {
            dt = new DataTable();
            Sda = new SqlDataAdapter(Query, ConStr);
            Sda.Fill(dt);
            return dt; 
        }
        public int SetData (string Query) {
            int Cnt = 0;
            if (Con.State == ConnectionState.Closed) {
                Con.Open();
            }
            Cmd.CommandText = Query;
            Cnt = Cmd.ExecuteNonQuery();
            Con.Close();
            return Cnt;
        }
    }
}
