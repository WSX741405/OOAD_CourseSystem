using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CourseSystem.Tests
{
    [TestClass()]
    public class Course_ModelTests
    {
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

        [TestMethod()]
        public void ConnectDatabaseTest()
        {
            string testUserId = "101590320", work = "S";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM user WHERE `UserId` = @userId";
            cmd.Parameters.AddWithValue("@userId", testUserId);
            DataTable dataset = ConnectDatabase(cmd,work);
            Assert.AreEqual(dataset.Rows[0]["UserId"].ToString(), testUserId);
        }

        [TestMethod()]
        public void getUserMapCourseTest()
        {
            string testUserId = "101590320", work = "S";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM usermapcourse WHERE `s_Id` = @studentId";
            cmd.Parameters.AddWithValue("@studentId", testUserId);
            DataTable dataset = ConnectDatabase(cmd, work);
            Assert.AreEqual(dataset.Rows[0]["s_Id"].ToString(), testUserId);
        }

        [TestMethod()]
        public void getTimesliceByCourseIdTest()
        {
            string c_id = "1", work = "S";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM coursemaptimeslice WHERE `c_id` = @c_id";
            cmd.Parameters.AddWithValue("@c_Id", c_id);
            DataTable dataset = ConnectDatabase(cmd, work);
            Assert.AreEqual(dataset.Rows[0]["c_id"].ToString(), c_id);
        }

        [TestMethod()]
        public void getTimesliceByTimesliceIdTest()
        {
            string t_id = "1", work = "S";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM timeslice WHERE `id` = @t_id";
            cmd.Parameters.AddWithValue("@t_id", t_id);
            DataTable dataset = ConnectDatabase(cmd, work);
            Assert.AreEqual(dataset.Rows[0]["id"].ToString(), t_id);
        }

        [TestMethod()]
        public void getCourseNameByCourseIdTest()
        {
            string c_id = "1", work = "S";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM course WHERE `CourseId` = @c_id";
            cmd.Parameters.AddWithValue("@c_id", c_id);
            DataTable dataset = ConnectDatabase(cmd, work);
            Assert.AreEqual(dataset.Rows[0][1].ToString(), "資訊檢索與應用");
        }
    }
}
