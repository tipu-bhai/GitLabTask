using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 
using System.Data.SqlClient;
namespace MyProject
{
    public partial class myProfilePatient : Form
    {
        // Ekhane Doctor er sob Attribute ache...
        patientClass ptClasss = new patientClass();

        public myProfilePatient()
        {
            InitializeComponent();

            //patientClass.PatientId = 1;

            // Tarpor Database theke attrubute sync hobe
            ptClasss.DBthekeAiMethodPatientClassEdataAnbe();

            // Form load howar sathe sathe Patient er Textbox gulo fill hoye jabe.
            textBoxPatientId.Text = patientClass.PatientId.ToString();

            textBoxPatientName.Text = ptClasss.PatientName;
            textBoxPatientPhone.Text = ptClasss.PatientPhone;
            textBoxPatientAddress.Text = ptClasss.PatientAddress;
            textBoxPatientAge.Text = ptClasss.PatientAge.ToString() ;
            textBoxPatientGender.Text = ptClasss.PatientGender;
            textBoxPatientBloodGroup.Text = ptClasss.PatientBloodGroup;

            disableTextBoxes();

            textBoxPatientId2.Enabled = false;
        }

        void disableTextBoxes()
        {
            textBoxPatientId.Enabled = false;
            textBoxPatientName.Enabled = false;
            textBoxPatientPhone.Enabled = false;
            textBoxPatientAddress.Enabled = false;
            textBoxPatientAge.Enabled = false;
            textBoxPatientGender.Enabled = false;
            textBoxPatientBloodGroup.Enabled = false;
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new patientDashboard().Show();
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            // Patient er Details dekhar jonno jokhon ai button click korbe tokhon
            // text box gulote Patient er data asbe.
            ptClasss.DBthekeAiMethodPatientClassEdataAnbe();

            // I'd change hote parbe nah.
            textBoxPatientId2.Text = patientClass.PatientId.ToString();

            textBoxPatientName2.Text = ptClasss.PatientName;
            textBoxPatientPhone2.Text = ptClasss.PatientPhone;
            textBoxPatientAddress2.Text = ptClasss.PatientAddress;
            textBoxPatientAge2.Text = ptClasss.PatientAge.ToString() ;
            textBoxPatientGender2.Text = ptClasss.PatientGender;
            textBoxPatientBloodGroup2.Text = ptClasss.PatientBloodGroup;

        }


        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            // Jodi update na korte chay tahole sob field clear hoye jabe...
            if (textBoxPatientId2.Text != "")
            {
                textBoxPatientId2.Clear();
                textBoxPatientName2.Clear();
                textBoxPatientPhone2.Clear();
                textBoxPatientAddress2.Clear();
                textBoxPatientAge2.Clear();
                textBoxPatientGender2.Clear();
                textBoxPatientBloodGroup2.Clear();

                textBoxPatientName2.Focus();
            }
            else
            {
                MessageBox.Show("There is nothing to clear");
                textBoxPatientName2.Focus();
            }
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            if ((textBoxPatientId2.Text == "") && (textBoxPatientName2.Text == "") && (textBoxPatientPhone2.Text == "") && (textBoxPatientAddress2.Text == "") && (textBoxPatientAge2.Text == "") && (textBoxPatientGender2.Text == "") && (textBoxPatientBloodGroup2.Text == ""))
            {
                MessageBox.Show("Press the Click button for Update");

                return;
            }


            myDbClass db = new myDbClass();

            if ((textBoxPatientName2.Text != "") && (ptClasss.PatientName != textBoxPatientName2.Text))
            {
                string updateQuery = "UPDATE patient_table SET patientName = '" + textBoxPatientName2.Text + "' WHERE patientId = " + patientClass.PatientId;

                int rows = db.writeQuery(updateQuery);
                if (rows > 0)
                {
                    textBoxPatientName.Text = textBoxPatientName2.Text;
                    ptClasss.PatientName = textBoxPatientName2.Text;
                    MessageBox.Show("Name Update is Successful");
                }
                else
                {
                    MessageBox.Show("Name Update is not Valid");
                }
            }
            else if (textBoxPatientName2.Text == "")
            {
                MessageBox.Show("Please give a Valid Name");
            }

            if ((textBoxPatientPhone2.Text != "") && (ptClasss.PatientPhone != textBoxPatientPhone2.Text))
            {
                string updateQuery = "UPDATE patient_table SET patientPhone = '" + textBoxPatientPhone2.Text + "' WHERE patientId = " + patientClass.PatientId;

                int rows = db.writeQuery(updateQuery);
                if (rows > 0)
                {
                    textBoxPatientPhone.Text = textBoxPatientPhone2.Text;
                    ptClasss.PatientPhone = textBoxPatientPhone2.Text;
                    MessageBox.Show("Phone No. Update is Successful");
                }
                else
                {
                    MessageBox.Show("Phone No. Update is not Valid");
                }
            }
            else if (textBoxPatientPhone2.Text == "")
            {
                MessageBox.Show("Please give a Valid Phone No.");
            }

            if ((textBoxPatientAddress2.Text != "") && (ptClasss.PatientAddress != textBoxPatientAddress2.Text))
            {
                string updateQuery = "UPDATE patient_table SET patientAddress = '" + textBoxPatientAddress2.Text + "' WHERE patientId = " + patientClass.PatientId;

                int rows = db.writeQuery(updateQuery);
                if (rows > 0)
                {
                    textBoxPatientAddress.Text = textBoxPatientAddress2.Text;
                    ptClasss.PatientAddress = textBoxPatientAddress2.Text;
                    MessageBox.Show("Address Update is Successful");
                }
                else
                {
                    MessageBox.Show("Address Update is not Valid");
                }
            }
            else if (textBoxPatientAddress2.Text == "")
            {
                MessageBox.Show("Please give a Valid Address");
            }

            if ((textBoxPatientAge2.Text != "") && (ptClasss.PatientAge.ToString() != textBoxPatientAge2.Text))
            {
                string updateQuery = "UPDATE patient_table SET patientAge = '" + textBoxPatientAge2.Text + "' WHERE patientId = " + patientClass.PatientId;

                int rows = db.writeQuery(updateQuery);
                if (rows > 0)
                {
                    textBoxPatientAge.Text = textBoxPatientAge2.Text;
                    ptClasss.PatientAge = int.Parse(textBoxPatientAge2.Text);
                    MessageBox.Show("Patient Age Update is Successful");
                }
                else
                {
                    MessageBox.Show("Patient Age Update is not Valid");
                }
            }
            else if (textBoxPatientAge2.Text == "")
            {
                MessageBox.Show("Please give a Valid Patient Age");
            }

            if ((textBoxPatientGender2.Text != "") && (ptClasss.PatientGender != textBoxPatientGender2.Text))
            {
                string updateQuery = "UPDATE patient_table SET patientGender = '" + textBoxPatientGender2.Text + "' WHERE patientId = " + patientClass.PatientId;

                int rows = db.writeQuery(updateQuery);
                if (rows > 0)
                {
                    textBoxPatientGender.Text = textBoxPatientGender2.Text;
                    ptClasss.PatientGender = textBoxPatientGender2.Text;
                    MessageBox.Show("Patient Gender Update is Successful");
                }
                else
                {
                    MessageBox.Show("Patient Gender Update is not Valid");
                }
            }
            else if (textBoxPatientGender2.Text == "")
            {
                MessageBox.Show("Please give a Valid Patient Gender");
            }

            if ((textBoxPatientBloodGroup2.Text != "") && (ptClasss.PatientBloodGroup != textBoxPatientBloodGroup2.Text))
            {
                string updateQuery = "UPDATE patient_table SET patientBloodGroup = '" + textBoxPatientBloodGroup2.Text + "' WHERE patientId = " + patientClass.PatientId;

                int rows = db.writeQuery(updateQuery);
                if (rows > 0)
                {
                    textBoxPatientBloodGroup.Text = textBoxPatientBloodGroup2.Text;
                    ptClasss.PatientBloodGroup = textBoxPatientBloodGroup2.Text;
                    MessageBox.Show("Blood Group Update is Successful");
                }
                else
                {
                    MessageBox.Show("Blood Group Update is not Valid");
                }
            }
            else if (textBoxPatientBloodGroup2.Text == "")
            {
                MessageBox.Show("Please give a Valid Blood Group");
            }
        }
    }
}
