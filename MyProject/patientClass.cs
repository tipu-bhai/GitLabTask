using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;

namespace MyProject
{
    class patientClass
    {
        private static int _patientId;
        private string _patientName;
        private string _patientPhone;
        private string _patientAddress;
        private int _patientAge;
        private string _patientGender;
        private string _patientBloodGroup;

        public patientClass()
        {
        }

        public void DBthekeAiMethodPatientClassEdataAnbe()
        {
            string query = "SELECT * FROM patient_table WHERE patientId = " + _patientId;

            // Database er query.....................
            myDbClass db = new myDbClass();
            SqlDataReader reader = db.readQuery(query);

            // Patient class e data asche...........
            if ((reader != null) && (reader.HasRows))
            {
                if (reader.Read())
                {
                    //_patientId = (int)reader["patientId"];
                    /*Eta lagbe na karon doctorId Dashboard load howar sathe sathe "static" bhabe doctorId assign hoye gacke*/
                    _patientName = reader["patientName"].ToString();
                    _patientPhone = reader["patientPhone"].ToString();
                    _patientAddress = reader["patientAddress"].ToString();
                    _patientAge = (int)reader["patientAge"];
                    _patientGender = reader["patientGender"].ToString();
                    _patientBloodGroup = reader["patientBloodGroup"].ToString();
                }
            }
        }

        public static int PatientId
        {
            set { _patientId = value; }
            get { return _patientId; }
        }
        public string PatientName
        {
            set { _patientName = value; }
            get { return _patientName; }
        }
        public string PatientPhone
        {
            set { _patientPhone = value; }
            get { return _patientPhone; }
        }
        public string PatientAddress
        {
            set { _patientAddress = value; }
            get { return _patientAddress; }
        }
        public int PatientAge
        {
            set { _patientAge = value; }
            get { return _patientAge; }
        }
        public string PatientGender
        {
            set { _patientGender = value; }
            get { return _patientGender; }
        }
        public string PatientBloodGroup
        {
            set { _patientBloodGroup = value; }
            get { return _patientBloodGroup; }
        }
    }


}
