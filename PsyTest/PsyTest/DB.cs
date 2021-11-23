using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PsyTest
{
    class DB
    {
        static string connStr = "server=localhost;user=root;database=psytest;password=12345;";

        public MySqlConnection conn = new MySqlConnection(connStr);

        public bool Connection()
        {
            conn.Open();
            return true;
        }

        public bool Close()
        {
            conn.Close();
            return true;
        }

        public string sqlRequestSELECT(string request)
        {
            string sql = request;
            Connection();
            MySqlCommand command = new MySqlCommand(sql, conn);
            return command.ExecuteScalar().ToString();
        }

        public void sqlRequestINSERT(string request)
        {
            string sql = request;
            Connection();
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();
            Close();
        }

        public void sqlRequestDELETE(string request)
        {
            string sql = request;
            Connection();
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();
            Close();
        }

        public void sqlRequestUPDATE(string request)
        {
            string sql = request;
            Connection();
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();
            Close();
        }
    }
}
