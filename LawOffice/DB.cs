using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LawOffice
{
    internal class DB
    {
        public static List<string> fullName = new List<string>();
        public static List<int> passport = new List<int>();
        public static List<int> phone = new List<int>();
        public static List<int> idClient = new List<int>();
        public static bool OkClick = false;
        SqlConnection conn = new SqlConnection(@"Data Source=Lilith;Initial Catalog=LawOffice;Integrated Security=True");

        public void OpenConnection()
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return conn;
        }
    }
}
