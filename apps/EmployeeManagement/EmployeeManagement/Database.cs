using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Database
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string conStr;

        public Database()
        {
            conStr = ConfigurationManager.ConnectionStrings["empDB"].ConnectionString;
            conn = new SqlConnection(conStr);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        public DataTable GetEmployeeData(string query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(query, conStr);
            sda.Fill(dt);
            return dt;
        }

        public int ExecuteSQLCommand(string query)
        {
            int cnt = 0;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            cmd.CommandText = query;
            cnt = cmd.ExecuteNonQuery();
            Console.WriteLine(cnt);
            return cnt;
        }
    }
}
