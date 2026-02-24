using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;

namespace MyProject
{
    public class doctorClass
    {
        private static  int _doctorId;
        private string _doctorName;
        private string _doctorPhone;
        private string _doctorAddress;
        private string _speciality;
        private string _experience;


        public doctorClass()
        {
            
        }


        public void DBthekeAiMethodDoctorClassEdataAnbe()
        {

            string query = "SELECT * FROM doctor_table WHERE doctorId = " + _doctorId ;

            // Database er query.....................
            myDbClass db = new myDbClass();
            SqlDataReader myRow = db.readQuery(query);


            // Doctor class e data asche...........
            if ((myRow != null) && (myRow.HasRows))
            {
                if (myRow.Read() == true)
                {
                    //_doctorId = (int)myRow["doctorId"]; /*Eta lagbe na karon doctorId Dashboard load howar sathe sathe "static" bhabe doctorId assign hoye gacke*/
                    _doctorName = myRow["doctorName"].ToString();
                    _doctorPhone = myRow["doctorPhone"].ToString();
                    _doctorAddress = myRow["doctorAddress"].ToString();
                    _speciality = myRow["speciality"].ToString();
                    _experience = myRow["experience"].ToString();
                }
            }

        }


        public static int DoctorId
        {
            set { _doctorId = value; }
            get { return _doctorId ;  } 
        }

        public string DoctorName
        { 
            set { _doctorName = value; }
            get { return _doctorName; }
        }

        public string DoctorPhone
        {
            set { _doctorPhone = value; }
            get { return _doctorPhone; }
        }

        public string DoctorAddress
        {
            set { _doctorAddress = value; }
            get { return _doctorAddress; }
        }
        public string DoctorSpeciality
        {
            set { _speciality = value; }
            get { return _speciality; }
        }
        public string DoctorExperience
        {
            set { _experience = value; }
            get { return _experience; }
        }
    }
}