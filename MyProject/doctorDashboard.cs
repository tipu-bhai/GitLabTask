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
    public partial class doctorDashboard : Form
    {

        doctorClass drClass = new doctorClass();

        public doctorDashboard()
        {
            InitializeComponent();

            // Age Doctor I'd set korbe
            doctorClass.DoctorId = 1 ;

            // Tarpor Database theke attrubute sync hobe.
            drClass.DBthekeAiMethodDoctorClassEdataAnbe();

            // Doctor Dashboard e Doctor er name dekhabe
            textBoxDoctorName.Text = drClass.DoctorName;

            pictureBoxDoctorDashboard.Show();
            panelGiveTreatment.Hide();
        }

  
        private void buttonMyProfile_Click_1(object sender, EventArgs e)
        {
            myProfileDoctor myProfile = new myProfileDoctor();

            this.Hide();
            myProfile.Show();
        }

        private void buttonGiveTreatment_Click_1(object sender, EventArgs e)
        {
            textBoxSearchAppoinmentID.Focus();

            labelColour2.ForeColor = System.Drawing.Color.Black;
            labelColour1.ForeColor = System.Drawing.Color.Red;

            pictureBoxDoctorDashboard.Hide();
            panelGiveTreatment.Show();
        }


        private void buttonFind_Click_1(object sender, EventArgs e)
        {
            if(textBoxSearchAppoinmentID.Text == "")
            {
                MessageBox.Show("Please Give a Appt. ID");
                return;
            }
            dataGridViewGiveTreatment.Rows.Clear();

            string findByAppoinmentId = "SELECT a.appoinmentId, d.doctorName, p.patientName, a.patientComplain, p.patientAge, p.patientGender, p.patientBloodGroup, a.appoinmentDate " +
                                        "FROM appoinment_table AS a INNER JOIN patient_table AS p " +
                                            "ON a.patientId = p.patientId " +
                                        "INNER JOIN doctor_table AS d " +
                                            "ON a.doctorId = d.doctorId " +
                                        "WHERE d.doctorId = ' "+doctorClass.DoctorId+" ' AND a.appoinmentId = " + textBoxSearchAppoinmentID.Text ;

            myDbClass db = new myDbClass();
            SqlDataReader myRow = db.readQuery(findByAppoinmentId);

            if ((myRow != null) && (myRow.HasRows))
            {
                if (myRow.Read() == true)
                {
                    int appoinmentId = (int)myRow["appoinmentId"];
                    string doctorName = myRow["doctorName"].ToString();
                    string patientName = myRow["patientName"].ToString();
                    string patientComplain = myRow["patientComplain"].ToString();
                    int patientAge = (int)myRow["patientAge"];
                    string patientGender = myRow["patientGender"].ToString();
                    string patientBloodGroup = myRow["patientBloodGroup"].ToString();
                    string appoinmentDate = myRow["appoinmentDate"].ToString();

                    dataGridViewGiveTreatment.Rows.Add(appoinmentId, doctorName, patientName, patientComplain, patientAge, patientGender, patientBloodGroup, appoinmentDate);
                }
            }
            else
            {
                MessageBox.Show("No Appointment Found Against This Appt. ID");
                textBoxSearchAppoinmentID.Clear();
                textBoxSearchAppoinmentID.Focus();
            }
        }

        private void buttonOk_Click_1(object sender, EventArgs e)
        {
            if (textBoxChifComplain.Text != "" && comboBoxInvestigation.Text != "" && textBoxMedicine.Text != "" && textBoxAdvise.Text != "")
            {
                string insertQuery = "UPDATE appoinment_table SET doctorComplain = '" + textBoxChifComplain.Text + "', " +
                "investigation = '" + comboBoxInvestigation.Text + "', " +
                "medicine = '" + textBoxMedicine.Text + "', " +
                "advise = '" + textBoxAdvise.Text + "' " +
                "WHERE appoinmentId = '"+textBoxSearchAppoinmentID.Text+"' ";

                myDbClass db = new myDbClass();
                int rows = db.writeQuery(insertQuery);

                if (rows > 0)
                {
                    MessageBox.Show("Giving treatment is successful");
                }
                else
                {
                    MessageBox.Show("Giving treatment is Unsuccessful");
                }

                textBoxChifComplain.Clear();
                comboBoxInvestigation.Text = "";
                textBoxMedicine.Clear();
                textBoxAdvise.Clear();

                dataGridViewGiveTreatment.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Please Fill all The Teatment Box");
            }
        }

        private void buttonSeePatientList_Click_1(object sender, EventArgs e)
        {
            labelColour2.ForeColor = System.Drawing.Color.Red;
            labelColour1.ForeColor = System.Drawing.Color.Black;

            this.Hide();
            new patientList().Show();
        }

        private void buttonEXIT_Click(object sender, EventArgs e)
        {
            //pictureBox1.Hide();
            //panelGiveTreatment.Hide();

            Button myButton = new Button();

            myButton.BackColor = System.Drawing.Color.Red;
            myButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            myButton.Location = new System.Drawing.Point(600, 250);
            myButton.Name = "buttonEXIT2";
            myButton.Size = new System.Drawing.Size(84, 37);
            myButton.TabIndex = 20;
            myButton.Text = "EXIT";
            myButton.UseVisualStyleBackColor = false;

            myButton.Click += new System.EventHandler(my_Button);

            //Application.Exit();
            this.Controls.Add(myButton);
            myButton.BringToFront();
        }

        private void my_Button(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Really Want to EXIT ?", "This is Runtime EXIT Button", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("You pressed NO");

                // ❌ Runtime button destroy
                Button btn = sender as Button;
                if (btn != null)
                {
                    this.Controls.Remove(btn);
                    btn.Dispose();
                }

            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("You pressed CANCEL");

                // ❌ Runtime button destroy
                Button btn = sender as Button;
                if (btn != null)
                {
                    this.Controls.Remove(btn);
                    btn.Dispose();
                }
            }
        }
    }
}
