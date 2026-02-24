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
    public partial class patientDashboard : Form
    {
        patientClass ptClass = new patientClass();

        public patientDashboard()
        {
            InitializeComponent();

            patientClass.PatientId = 2;

            ptClass.DBthekeAiMethodPatientClassEdataAnbe();
            //textBoxPatientName.Text = pc.PatientName;
            panelTakeAppoinment.Hide();            
        }

        private void buttonMyProfile_Click(object sender, EventArgs e)
        {
            myProfilePatient profileForm = new myProfilePatient();
            profileForm.Show();
            this.Hide();

            //string query = "SELECT * FROM patient_table WHERE patientId = " + patientClass.PatientId;

            //myDbClass db = new myDbClass();
            //SqlDataReader reader = db.readQuery(query);

            //if ((reader != null) && (reader.HasRows))
            //{
            //    if (reader.Read())
            //    {
            //        //profileForm.patientClassthekeAiMethodGuiEdataAnbe();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("There is a NULL Row");
            //}
        }

        private void buttonSeeDoctorList_Click(object sender, EventArgs e)
        {
            this.Hide();
            new doctorList().Show();
        }

        private void patientDashboard_Load(object sender, EventArgs e)
        {
            if (ptClass != null && ptClass.PatientName != null)
                textBoxPatientName.Text = ptClass.PatientName;
        }

        int doctorId = 0;

        private void buttonTakeAppoinment_Click(object sender, EventArgs e)
        {
            panelTakeAppoinment.Show();

            string query = "SELECT * FROM doctor_table";

            myDbClass db = new myDbClass();
            SqlDataReader myRow = db.readQuery(query);

            if (myRow != null && myRow.HasRows)
            {
                dataGridView.Rows.Clear();
                while (myRow.Read())
                {
                    int id = (int)myRow["doctorId"];
                    string doctorName = myRow["doctorName"].ToString();
                    string speciality = myRow["speciality"].ToString();

                    dataGridView.Rows.Add(id, doctorName, speciality, "SELECT");
                }
            }
        }

        private void buttonCancle_Click_1(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            textBoxPatientComplain.Clear();
            doctorId = 0;
            MessageBox.Show("Appoinment Confirmation is Cancel");
        }

        private void buttonConfirm_Click_1(object sender, EventArgs e)
        {
            if (doctorId == 0)
            {
                MessageBox.Show("Please select a doctor first!");
                return;
            }

            string dateOnly = dateTimePicker.Value.ToString("yyyy-MM-dd");

            string query = "INSERT INTO appoinment_table " +
                           "(doctorId, patientId, appoinmentDate, patientComplain) " +
                           "VALUES " +
                           "('" + doctorId + "', '"+ patientClass.PatientId + "', '" + dateOnly + "', '" + textBoxPatientComplain.Text + "')";

            myDbClass db = new myDbClass();
            int rows = db.writeQuery(query);

            if (rows > 0)
            {
                MessageBox.Show("Appoinment Confirmation is Successful");
            }
            else
            {
                MessageBox.Show("Appoinment Confirmation is not Valid");
            }
        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                doctorId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("Doctor Selected: ID = " + doctorId);
            }
        }
    }
}
