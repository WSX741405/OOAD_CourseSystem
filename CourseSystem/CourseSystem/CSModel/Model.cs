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
    public class Model
    {
        public Model() { }

        /// <summary>
        /// 連結資料庫
        /// </summary>
        public DataTable ConnectDatabase(MySqlCommand cmd, string work)
        {
            MySql.Data.MySqlClient.MySqlConnection connection;
            string server = "127.0.0.1";
            string database = "test";
            string uid = "test";
            string password = "test";
            string connectionString;
            DataTable dataset = new DataTable();
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                cmd.Connection = connection;
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

        /// <summary>
        /// 新增user
        /// </summary>
        public bool CreateUser(string userId, string password,string identity) 
        {
            MySqlCommand cmd = new MySqlCommand();
            string WORK = "S"; //傳入執行動作進入ConnectDatabase
            //搜尋此userId是否已註冊
            cmd.CommandText = "SELECT * FROM user WHERE `UserId` = @userId";
            cmd.Parameters.AddWithValue("@userId", userId);
            DataTable searchDs = ConnectDatabase(cmd, WORK);
            string tableUserId = "";
            foreach (DataRow searchDr in searchDs.Rows)
            {
                tableUserId = searchDr["UserId"].ToString();
                if (tableUserId.Equals(userId)) return true;
            }
            //若沒註冊，進行註冊動作
            cmd.CommandText =  "INSERT INTO user (`UserId`,`Password`,`userIdentity`) Values(@userId,@Pwd,@userIdentity)";
            //必須先Clear 因為前面有新增過 @userId,重覆會出問題
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@Pwd", password);
            cmd.Parameters.AddWithValue("@userIdentity", identity);
            WORK = "I";
            DataTable insertDs = ConnectDatabase(cmd, WORK);
            return false;
        }

        /// <summary>
        /// 登入
        /// </summary>
        public string LogIn(string userId, string password)
        {
            MySqlCommand cmd = new MySqlCommand();
            string WORK = "S"; //傳入執行動作進入ConnectDatabase
            //搜尋此userId是否已註冊
            cmd.CommandText = "SELECT * FROM user WHERE `UserId` = @userId";
            cmd.Parameters.AddWithValue("@userId", userId);
            DataTable searchDs = ConnectDatabase(cmd, WORK);
            string tableUserId = "", tableUserPwd = "";
            foreach (DataRow searchDr in searchDs.Rows)
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
            return "None";
        }

        /// <summary>
        /// 搜尋使用者
        /// </summary>
        public DataTable FindUser(string userId)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM user WHERE `UserId` = @userId";
            cmd.Parameters.AddWithValue("@userId", userId);
            string WORK = "S";
            DataTable user = ConnectDatabase(cmd, WORK);
            return user; 
        }
    }
}
