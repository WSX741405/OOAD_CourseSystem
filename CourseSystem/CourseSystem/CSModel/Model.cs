using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CourseSystem
{
    class Model
    {
        public void ConnectDatabase (string SQLCommand)
        {
            MySql.Data.MySqlClient.MySqlConnection connection;
            string server = "localhost";
            string database = "test";
            string uid = "root";
            string password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(SQLCommand, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            connection.Close();
        }
    }
    
}
