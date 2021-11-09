using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class StudentModel
    {
        public string StudentRegistration(int roll, string name, string email,string address)
        {
            string dbConnection = "Data Source=ServerName, Intial Catalog=Databasename";
            SqlConnection scn = new SqlConnection(dbConnection);
            scn.Open();
            SqlCommand cmd = new SqlCommand("prc_product", scn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@roll", roll);
            int recordinserted = cmd.ExecuteNonQuery();
            return "Student record created";
        }
    }
}
