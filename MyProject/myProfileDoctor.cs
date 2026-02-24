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

    public partial class myProfileDoctor : Form
    {
        // Jahetu "myProfileDoctor" different class tai Oi doctor er data dekhar jonno abar 
        // database theke Data ante hobe /*---- Doctor er Id jahetu same tai pera nai-------*/
        doctorClass drClass = new doctorClass();

        public myProfileDoctor()
        {
            InitializeComponent();

            // Tarpor Database theke attrubute sync hobe.
            drClass.DBthekeAiMethodDoctorClassEdataAnbe();


            // Form load howar sathe sathe Doctor er Textbox gulo fill hoye jabe.
            textBoxDoctorId.Text = doctorClass.DoctorId.ToString();
            textBoxDoctorName.Text = drClass.DoctorName;
            textBoxDoctorPhone.Text = drClass.DoctorPhone;
            textBoxDoctorAddress.Text = drClass.DoctorAddress;
            textBoxDoctorSpeciality.Text = drClass.DoctorSpeciality;
            textBoxDoctorExperienceYear.Text = drClass.DoctorExperience;

            textBoxDisable();
            textBoxDoctorId2.Enabled = false;
        }

        void textBoxDisable()
        {
            textBoxDoctorId.Enabled = false;
            textBoxDoctorName.Enabled = false;
            textBoxDoctorPhone.Enabled = false;
            textBoxDoctorAddress.Enabled = false;
            textBoxDoctorSpeciality.Enabled = false;
            textBoxDoctorExperienceYear.Enabled = false;
        }
       

        private void buttonUpdateMyDetails_Click(object sender, EventArgs e)
        {
            // Doctor er Details click korar jonno jokhon ai button click korbe tokhon
            // text box gulo te Doctor er data asbe.
            drClass.DBthekeAiMethodDoctorClassEdataAnbe();

            // I'd change hote parbe nah.
            textBoxDoctorId2.Text = doctorClass.DoctorId.ToString() ;

            textBoxDoctorName2.Text = drClass.DoctorName;
            textBoxDoctorPhone2.Text = drClass.DoctorPhone;
            textBoxDoctorAddress2.Text = drClass.DoctorAddress;
            textBoxDoctorSpeciality2.Text = drClass.DoctorSpeciality;
            textBoxDoctorExperienceYear2.Text = drClass.DoctorExperience;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Jodi update na korte chay tahole sob field clear hoye jabe...
            if (textBoxDoctorId2.Text != "")
            {
                textBoxDoctorId2.Clear();
                textBoxDoctorName2.Clear();
                textBoxDoctorPhone2.Clear();
                textBoxDoctorAddress2.Clear();
                textBoxDoctorSpeciality2.Clear();
                textBoxDoctorExperienceYear2.Clear();

                textBoxDoctorId2.Focus();
            }
            else
            {
                MessageBox.Show("There is nothing to clear");
                textBoxDoctorName2.Focus();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool isAllEmpty = true;
            if ( (textBoxDoctorId2.Text=="") && (textBoxDoctorName2.Text == "") && (textBoxDoctorPhone2.Text == "") && (textBoxDoctorAddress2.Text == "") && (textBoxDoctorSpeciality2.Text == "") && (textBoxDoctorExperienceYear2.Text == "") )
            {
                MessageBox.Show("Press the Click button for Update");
                isAllEmpty = false;
            }

            if (isAllEmpty == true)
            {
                myDbClass db = new myDbClass();

                if ((textBoxDoctorName2.Text != "") && (drClass.DoctorName != textBoxDoctorName2.Text))
                {
                    string updateQuery = "UPDATE doctor_table SET doctorName = '" + textBoxDoctorName2.Text + "' WHERE doctorId = " + doctorClass.DoctorId;

                    int rows = db.writeQuery(updateQuery);
                    if (rows > 0)
                    {
                        textBoxDoctorName.Text = textBoxDoctorName2.Text;
                        drClass.DoctorName = textBoxDoctorName2.Text;
                        MessageBox.Show("Name Update is Successful");
                    }
                    else
                    {
                        MessageBox.Show("Name Update is not Valid");
                    }
                }
                else if (textBoxDoctorName2.Text == "")
                {
                    MessageBox.Show("Please give a Valid Name");
                }

                if ((textBoxDoctorPhone2.Text != "") && (drClass.DoctorPhone != textBoxDoctorPhone2.Text))
                {
                    string updateQuery = "UPDATE doctor_table SET doctorPhone = '" + textBoxDoctorPhone2.Text + "' WHERE doctorId = " + doctorClass.DoctorId;

                    int rows = db.writeQuery(updateQuery);
                    if (rows > 0)
                    {
                        textBoxDoctorPhone.Text = textBoxDoctorPhone2.Text;
                        drClass.DoctorPhone = textBoxDoctorPhone2.Text;
                        MessageBox.Show("Phone No. Update is Successful");
                    }
                    else
                    {
                        MessageBox.Show("Phone No. Update is not Valid");
                    }
                }
                else if (textBoxDoctorPhone2.Text == "")
                {
                    MessageBox.Show("Please give a Valid Phone No.");
                }

                if ((textBoxDoctorAddress2.Text != "") && (drClass.DoctorAddress != textBoxDoctorAddress2.Text))
                {
                    string updateQuery = "UPDATE doctor_table SET doctorAddress = '" + textBoxDoctorAddress2.Text + "' WHERE doctorId = " + doctorClass.DoctorId;

                    int rows = db.writeQuery(updateQuery);
                    if (rows > 0)
                    {
                        textBoxDoctorAddress.Text = textBoxDoctorAddress2.Text;
                        drClass.DoctorAddress = textBoxDoctorAddress2.Text;
                        MessageBox.Show("Address Update is Successful");
                    }
                    else
                    {
                        MessageBox.Show("Address Update is not Valid");
                    }
                }
                else if (textBoxDoctorAddress2.Text == "")
                {
                    MessageBox.Show("Please give a Valid Address");
                }

                if ((textBoxDoctorSpeciality2.Text != "") && (drClass.DoctorSpeciality != textBoxDoctorSpeciality2.Text))
                {
                    string updateQuery = "UPDATE doctor_table SET speciality = '" + textBoxDoctorSpeciality2.Text + "' WHERE doctorId = " + doctorClass.DoctorId;

                    int rows = db.writeQuery(updateQuery);
                    if (rows > 0)
                    {
                        textBoxDoctorSpeciality.Text = textBoxDoctorSpeciality2.Text;
                        drClass.DoctorSpeciality = textBoxDoctorSpeciality2.Text;
                        MessageBox.Show("Speciality Update is Successful");
                    }
                    else
                    {
                        MessageBox.Show("Speciality Update is not Valid");
                    }
                }
                else if (textBoxDoctorSpeciality2.Text == "")
                {
                    MessageBox.Show("Please give a Valid Speciality");
                }

                if ((textBoxDoctorExperienceYear2.Text != "") && (drClass.DoctorExperience != textBoxDoctorExperienceYear2.Text))
                {
                    string updateQuery = "UPDATE doctor_table SET experience = '" + textBoxDoctorExperienceYear2.Text + "' WHERE doctorId = " + doctorClass.DoctorId;

                    int rows = db.writeQuery(updateQuery);
                    if (rows > 0)
                    {
                        textBoxDoctorExperienceYear.Text = textBoxDoctorExperienceYear2.Text;
                        drClass.DoctorExperience = textBoxDoctorExperienceYear2.Text;
                        MessageBox.Show("Experience Year Update is Successful");
                    }
                    else
                    {
                        MessageBox.Show("Experience Year Update is not Valid");
                    }
                }
                else if (textBoxDoctorExperienceYear2.Text == "")
                {
                    MessageBox.Show("Please give a Valid Experience Year");
                }

            }
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new doctorDashboard().Show();
        }
    }
}
