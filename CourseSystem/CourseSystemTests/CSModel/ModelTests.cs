using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using CourseSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CourseSystem.Tests
{
    [TestClass()]
    public class ModelTests
    {
        [TestMethod()]
        public void ModelTest()
        {
        }

        [TestMethod()]
        public void ConnectDatabaseTest()
        {
            string testUserId = "101590320", work ="S";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM user WHERE `UserId` = @userId";
            cmd.Parameters.AddWithValue("@userId", testUserId);
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
            Assert.AreEqual(dataset.Rows[0]["UserId"].ToString(), testUserId);
        }

        [TestMethod()]
        public void CreateUserTest()
        {
            string testUserId = "101590320", work = "S";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM user WHERE `UserId` = @userId";
            cmd.Parameters.AddWithValue("@userId", testUserId);
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
            Assert.AreEqual(dataset.Rows[0]["UserId"].ToString(), testUserId);
        }

        [TestMethod()]
        public void LogInTest()
        {
            string testUserId = "101590320",testUserPwd = "0000", work = "S";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM user WHERE `UserId` = @userId";
            cmd.Parameters.AddWithValue("@userId", testUserId);
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
            Assert.AreEqual(dataset.Rows[0]["Password"].ToString(), testUserPwd);
        }

        [TestMethod()]
        public void FindUserTest()
        {
            string testUserId = "101590320", work = "S";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM user WHERE `UserId` = @userId";
            cmd.Parameters.AddWithValue("@userId", testUserId);
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
            Assert.AreEqual(dataset.Rows[0]["UserId"].ToString(), testUserId);
        }
    }
}
