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
    public partial class patientList : Form
    {
        public patientList()
        {
            InitializeComponent();
        }

        // Form load howar sathe sathe doctorId er sob Appoinment dekhabe.......
        private void patientList_Load(object sender, EventArgs e)
        {
            dataGridViewSeePatientList.Rows.Clear();

            textBoxSearch.Focus();
            loadAllAppoinments();
        }

        public void loadAllAppoinments()
        {
            string findQuery = "SELECT " +
                                "a.appoinmentId, " +
                                "d.doctorName, " +
                                "a.appoinmentDate, " +
                                "a.patientComplain, " +
                                "p.patientName, " +
                                "p.patientAddress, " +
                                "p.patientPhone, " +
                                "p.patientAge, " +
                                "p.patientGender, " +
                                "p.patientBloodGroup " +
                            "FROM appoinment_table a " +
                            "JOIN doctor_table d ON a.doctorId = d.doctorId " +
                            "JOIN patient_table p ON a.patientId = p.patientId " +
                            "WHERE d.doctorId = " + doctorClass.DoctorId;

            myDbClass db = new myDbClass();
            SqlDataReader myRow = db.readQuery(findQuery);

            if (myRow != null && myRow.HasRows)
            {
                while (myRow.Read())
                {
                    int appoinmentId = (int)myRow["appoinmentId"];
                    string doctorName = myRow["doctorName"].ToString();
                    string appoinmentDate = myRow["appoinmentDate"].ToString();
                    string patientComplain = myRow["patientComplain"].ToString();
                    string patientName = myRow["patientName"].ToString();
                    string patientAddress = myRow["patientAddress"].ToString();
                    string patientPhone = myRow["patientPhone"].ToString();
                    int patientAge = (int)myRow["patientAge"];
                    string patientGender = myRow["patientGender"].ToString();
                    string patientBloodGroup = myRow["patientBloodGroup"].ToString();

                    dataGridViewSeePatientList.Rows.Add(appoinmentId, doctorName, appoinmentDate, patientComplain, patientName, patientAddress, patientPhone, patientAge, patientGender, patientBloodGroup);
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if((comboBoxSearchByIDOrName.Text=="") && (textBoxSearch.Text == ""))
            {
                MessageBox.Show("Fill ID/Name and Give appoinment");
                return;
            }

            if ((comboBoxSearchByIDOrName.Text == ""))
            {
                MessageBox.Show("Fill ID/Name");
                return;
            }

            if ((textBoxSearch.Text == ""))
            {
                MessageBox.Show("Fill search box");
                return;
            }

            // Appoinment id diye search korle..............................
            if ((comboBoxSearchByIDOrName.Text == "Appoinment ID") )
            {
                int searchId;

                if (!int.TryParse(textBoxSearch.Text, out searchId))
                {
                    MessageBox.Show("Please enter a valid numeric Appointment ID");
                    return;
                }

                string findQuery = "SELECT " +
                                "a.appoinmentId, " +
                                "d.doctorName, " +
                                "a.appoinmentDate, " +
                                "a.patientComplain, " +
                                "p.patientName, " +
                                "p.patientAddress, " +
                                "p.patientPhone, " +
                                "p.patientAge, " +
                                "p.patientGender, " +
                                "p.patientBloodGroup " +
                            "FROM appoinment_table a " +
                            "JOIN doctor_table d ON a.doctorId = d.doctorId " +
                            "JOIN patient_table p ON a.patientId = p.patientId " +
                            "WHERE d.doctorId = " + doctorClass.DoctorId +
                            " AND a.appoinmentId = " + searchId ;

                myDbClass db = new myDbClass();
                SqlDataReader myRow = db.readQuery(findQuery);

                // Appoinment id  diye search dewar age sob clear kore falbe.....................
                dataGridViewSeePatientList.Rows.Clear();

                if (myRow == null || myRow.HasRows == false)
                {
                    MessageBox.Show("No appointment found with this ID!");
                    textBoxSearch.Focus();
                    return;
                }

                if (myRow != null && myRow.HasRows)
                {
                    while (myRow.Read())
                    {
                        int appoinmentId = (int)myRow["appoinmentId"];
                        string doctorName = myRow["doctorName"].ToString();
                        string appoinmentDate = myRow["appoinmentDate"].ToString();
                        string patientComplain = myRow["patientComplain"].ToString();
                        string patientName = myRow["patientName"].ToString();
                        string patientAddress = myRow["patientAddress"].ToString();
                        string patientPhone = myRow["patientPhone"].ToString();
                        int patientAge = (int)myRow["patientAge"];
                        string patientGender = myRow["patientGender"].ToString();
                        string patientBloodGroup = myRow["patientBloodGroup"].ToString();

                        dataGridViewSeePatientList.Rows.Add(appoinmentId, doctorName, appoinmentDate, patientComplain, patientName, patientAddress, patientPhone, patientAge, patientGender, patientBloodGroup);
                    }
                }
            }

            if (comboBoxSearchByIDOrName.Text == "Patient Name")
            {
                if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
                {
                    MessageBox.Show("Please enter a patient name!");
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    return;
                }

                foreach (char c in textBoxSearch.Text)
                {
                    if (char.IsDigit(c))
                    {
                        MessageBox.Show("Name cannot contain numbers!");
                        textBoxSearch.Clear();
                        textBoxSearch.Focus();
                        return;
                    }
                }

                string findQuery = "SELECT " +
                                "a.appoinmentId, " +
                                "d.doctorName, " +
                                "a.appoinmentDate, " +
                                "a.patientComplain, " +
                                "p.patientName, " +
                                "p.patientAddress, " +
                                "p.patientPhone, " +
                                "p.patientAge, " +
                                "p.patientGender, " +
                                "p.patientBloodGroup " +
                            "FROM appoinment_table a " +
                            "JOIN doctor_table d ON a.doctorId = d.doctorId " +
                            "JOIN patient_table p ON a.patientId = p.patientId " +
                            "WHERE d.doctorId = " + doctorClass.DoctorId +
                            " AND p.patientName LIKE '%" + textBoxSearch.Text + "%'";

                myDbClass db = new myDbClass();
                SqlDataReader myRow = db.readQuery(findQuery);

                // Appoinment id  diye search dewar age sob clear kore falbe.....................
                dataGridViewSeePatientList.Rows.Clear();

                if (myRow == null || myRow.HasRows == false)
                {
                    MessageBox.Show("No appointment found with this ID!");
                    textBoxSearch.Focus();
                    return;
                }

                if (myRow != null && myRow.HasRows)
                {
                    while (myRow.Read())
                    {
                        int appoinmentId = (int)myRow["appoinmentId"];
                        string doctorName = myRow["doctorName"].ToString();
                        string appoinmentDate = myRow["appoinmentDate"].ToString();
                        string patientComplain = myRow["patientComplain"].ToString();
                        string patientName = myRow["patientName"].ToString();
                        string patientAddress = myRow["patientAddress"].ToString();
                        string patientPhone = myRow["patientPhone"].ToString();
                        int patientAge = (int)myRow["patientAge"];
                        string patientGender = myRow["patientGender"].ToString();
                        string patientBloodGroup = myRow["patientBloodGroup"].ToString();

                        dataGridViewSeePatientList.Rows.Add(appoinmentId, doctorName, appoinmentDate, patientComplain, patientName, patientAddress, patientPhone, patientAge, patientGender, patientBloodGroup);
                    }
                }
            }

            //if (textBoxSearch.Text == "")
            //{
            //    loadAllAppoinments();
            //}

        }

        private void textBoxLiveSearch_TextChanged(object sender, EventArgs e)
        {
            //loadLiveSearch();
        }

        private void buttonSeeAllAppoinment_Click(object sender, EventArgs e)
        {
            dataGridViewSeePatientList.Rows.Clear();
            loadAllAppoinments();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new doctorDashboard().Show();
        }

        //public void loadLiveSearch()
        //{
        //    if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
        //    {
        //        loadAllAppoinments();
        //        return;
        //    }

        //    dataGridViewSeePatientList.Rows.Clear();

        //    string findQuery = "SELECT " +
        //                        "a.appoinmentId, " +
        //                        "d.doctorName, " +
        //                        "a.appoinmentDate, " +
        //                        "a.patientComplain, " +
        //                        "p.patientName, " +
        //                        "p.patientAddress, " +
        //                        "p.patientPhone, " +
        //                        "p.patientAge, " +
        //                        "p.patientGender, " +
        //                        "p.patientBloodGroup " +
        //                    "FROM appoinment_table a " +
        //                    "JOIN doctor_table d ON a.doctorId = d.doctorId " +
        //                    "JOIN patient_table p ON a.patientId = p.patientId " +
        //                    "WHERE d.doctorId = " + doctorClass.DoctorId +
        //                    " AND p.patientName LIKE '%" + textBoxSearch.Text + "%'";

        //    myDbClass db = new myDbClass();
        //    SqlDataReader myRow = db.readQuery(findQuery);

        //    dataGridViewSeePatientList.Rows.Clear();

        //    if (myRow != null && myRow.HasRows)
        //    {
        //        while (myRow.Read())
        //        {
        //            int appoinmentId = (int)myRow["appoinmentId"];
        //            string doctorName = myRow["doctorName"].ToString();
        //            string appoinmentDate = myRow["appoinmentDate"].ToString();
        //            string patientComplain = myRow["patientComplain"].ToString();
        //            string patientName = myRow["patientName"].ToString();
        //            string patientAddress = myRow["patientAddress"].ToString();
        //            string patientPhone = myRow["patientPhone"].ToString();
        //            int patientAge = (int)myRow["patientAge"];
        //            string patientGender = myRow["patientGender"].ToString();
        //            string patientBloodGroup = myRow["patientBloodGroup"].ToString();

        //            dataGridViewSeePatientList.Rows.Add(appoinmentId, doctorName, appoinmentDate, patientComplain, patientName, patientAddress, patientPhone, patientAge, patientGender, patientBloodGroup);
        //        }
        //    }
        //}

    }
}
