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
    public class Student
    {
        Course_Model _courseModel;
        public Student(Course_Model courseModel) 
        {
            _courseModel = courseModel;
        }

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

        public void StudentSelectCourse(List<int>c_id,string userId) 
        {
            MySqlCommand cmd = new MySqlCommand();
            for (int i = 0; i < c_id.Count; i++) 
            {
                int flowCourseId=_courseModel.getFlowCourseIdByCourseId(c_id[i]);
                cmd.CommandText = "INSERT INTO `usermapcourse`(`s_id`, `p_id`, `c_id`) VALUES (@userId,'',@c_id)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@c_id",flowCourseId);
                string WORK = "I";
                DataTable da = ConnectDatabase(cmd, WORK);
            }
        }

        public void StudentDropCourse(List<int> c_id, string userId) 
        {
            MySqlCommand cmd = new MySqlCommand();
            for (int i = 0; i < c_id.Count; i++)
            {
                int flowCourseId = _courseModel.getFlowCourseIdByCourseId(c_id[i]);
                cmd.CommandText = "DELETE FROM `usermapcourse` WHERE `c_id`=@c_id AND`s_id`=@userId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@c_id", flowCourseId);
                string WORK = "D";
                DataTable da = ConnectDatabase(cmd, WORK);
            }
        }
    }
}
