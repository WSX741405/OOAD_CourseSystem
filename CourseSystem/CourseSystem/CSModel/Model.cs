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
        public DataSet ConnectDatabase(string SQLCommand, string work)
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

                if (!work.Equals("I"))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(dataset);
                }
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
            string WORK = "S"; //傳入執行動作進入ConnectDatabase
            //搜尋此userId是否已註冊
            string SQL = "SELECT * FROM user WHERE `UserId` =" + userId;
            DataSet searchDs = ConnectDatabase(SQL,WORK);
            string tableUserId = "";
            foreach (DataTable searchDt in searchDs.Tables)
            {
                foreach (DataRow searchDr in searchDt.Rows)
                {
                    tableUserId = searchDr["UserId"].ToString();
                    if (tableUserId.Equals(userId)) return true;
                }
            }
            //若沒註冊，進行註冊動作
            SQL = "INSERT INTO `user`(`UserId`,`Password`) Values("+ userId+","+ password+")";
            WORK = "I";
            DataSet insertDs = ConnectDatabase(SQL,WORK);
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

        public string LogIn(string userId, string password)
        {
            string WORK = "S"; //傳入執行動作進入ConnectDatabase
            //搜尋此userId是否已註冊
            string SQL = "SELECT * FROM user WHERE `UserId` =" + userId;
            DataSet searchDs = ConnectDatabase(SQL, WORK);
            string tableUserId = "", tableUserPwd = "";
            foreach (DataTable searchDt in searchDs.Tables)
            {
                foreach (DataRow searchDr in searchDt.Rows)
                {
                    tableUserId = searchDr["UserId"].ToString();
                    tableUserPwd = searchDr["Password"].ToString();
                    if (tableUserId.Equals(userId))
                    {
                        if (tableUserPwd.Equals(password))
                        {
                            return "Success";
                        }
                        else
                        {
                            return "Wrong";
                        }
                    }
                }
            }
            return "None";
        }
    }
}
