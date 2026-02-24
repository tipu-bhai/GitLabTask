using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace MyProject
{
    public partial class doctorList : Form
    {
        public doctorList()
        {
            InitializeComponent();

            dataGridViewSeeDoctorList_CellContentClick(this, null);
        }

        private void dataGridViewSeeDoctorList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT * FROM doctor_table";

            myDbClass db = new myDbClass();
            SqlDataReader myRow = db.readQuery(query);

            if (myRow != null && myRow.HasRows)
            {
                while (myRow.Read())
                {
                    int doctorId = (int)myRow["doctorId"];
                    string doctorName = myRow["doctorName"].ToString();
                    string doctorPhone = myRow["doctorPhone"].ToString();
                    string doctorAddress = myRow["doctorAddress"].ToString();
                    string speciality = myRow["speciality"].ToString();
                    string experience = myRow["experience"].ToString();

                    dataGridViewSeeDoctorList.Rows.Add(doctorId, doctorName, doctorPhone, doctorAddress, speciality, experience);
                }
            }
        }



        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new patientDashboard().Show();
        }
    }
}
