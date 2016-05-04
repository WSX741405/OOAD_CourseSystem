using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace CourseSystem
{
    class Model
    {
        private string SQL;
        private string connectionString = "Data Source=localhost; User ID=root; Password=; database=test";
        DataTable data;
        DataTable userData;

        //public DataTable ConnectDatabase (string SQLCommand)
        //{
        //    MySql.Data.MySqlClient.MySqlConnection connection;
        //    string server = "localhost";
        //    string database = "test";
        //    string uid = "root";
        //    string password = "";
        //    string connectionString;
        //    connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        //    database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        //    connection = new MySqlConnection(connectionString);
        //    try
        //    {
        //        connection.ConnectionString = connectionString;
        //        connection.Open();
        //        MySqlCommand cmd = new MySqlCommand(SQLCommand, connection);
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    connection.Close();
        //    return data;
        //}

        public bool CreateUser(string userId) 
        {
            SqlParameter[] prams = {
                SqlHelper.MakeInParam("@userId", SqlDbType.VarChar, 999, userId)
            };
            SQL = "SELECT * FROM user WHERE UserId = @userId";
            data = SqlHelper.ExecuteDataTable(connectionString, CommandType.Text, SQL, prams);
            if (data.Rows.Count > 0) return true;
           
            SQL = "INSERT INTO user VALUES(@userId,@password)";
            SqlHelper.ExecuteNonQuery(connectionString, CommandType.Text, SQL, prams);
            return false;
        }
    }
    
}
