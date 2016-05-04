using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace CourseSystem
{
    class Model
    {
     //   private string SQL;
     //   private string connectionString = "Server=127.0.0.1;Database=test;Uid=test;Pwd=test";
        DataTable data;
        DataTable userData;
        public Model() { }
        public DataSet ConnectDatabase(string SQLCommand)
        {
            MySql.Data.MySqlClient.MySqlConnection connection;
            string server = "127.0.0.1";
            string database = "test";
            string uid = "test";
            string password = "test";
            string connectionString;
            DataSet dataset = new DataSet();
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(SQLCommand, connection);
                cmd.ExecuteNonQuery();
                
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                // Fill the DataSet using default values for DataTable names, etc
                da.Fill(dataset);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            connection.Close();
            return dataset;
        }

        public bool CreateUser(string userId, string password) 
        {
            string SQL = "SELECT * FROM user WHERE `UserId` =" + userId;
            DataSet ds = ConnectDatabase(SQL);
            string tableUserId = "";
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    tableUserId = dr["UserId"].ToString();
                    if (tableUserId.Equals(userId)) return true;
                }
            }
            SQL = "INSERT INTO `user`(`UserId`,`Password`) Values("+ userId+","+ password+")";
            ds = ConnectDatabase(SQL);
            return false;
            //string test = ds.Table[0].Rows[0]["UserId"].ToString();
            //SqlParameter[] prams = {
            //    SqlHelper.MakeInParam("@userId", SqlDbType.VarChar, 999, userId)
            //};
            //SQL = "SELECT * FROM user WHERE UserId = @userId";
            //data = SqlHelper.ExecuteDataTable(connectionString, CommandType.Text, SQL, prams);
            //if (data.Rows.Count > 0) return true;

            //SQL = "INSERT INTO user VALUES(@userId,@password)";
            //SqlHelper.ExecuteNonQuery(connectionString, CommandType.Text, SQL, prams);
        }
    }
    
}
