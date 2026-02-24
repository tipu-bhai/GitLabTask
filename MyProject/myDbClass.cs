using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyProject
{

    class myDbClass
    {
        /*Step-1 : */
        string connectionString = "Data Source=Tipu\\SQLEXPRESS;Initial Catalog=myHospitalDB;Integrated Security=True";
        /*Step-2 : */
        SqlConnection con = null;

        public myDbClass()
        {
            con = new SqlConnection(connectionString);
        }

        public int writeQuery(string query)
        {
            int rowCount = 0;

            try
            {
                /*Step-3 : */
                con.Open();

                /*Step-4 : */
                SqlCommand cmd = new SqlCommand(query, con);

                /*Step-5 : */
                rowCount = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                /*Step-6 : */
                con.Close();
            }

            return rowCount;
        }

        public SqlDataReader readQuery(string query)
        {
            try
            {
                /*Step-3 : */
                con.Open();

                /*Step-4 : */
                SqlCommand cmd = new SqlCommand(query, con);

                /*Step-5 : */
                SqlDataReader myTable = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                return myTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

    }
}