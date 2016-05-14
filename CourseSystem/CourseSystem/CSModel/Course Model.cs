using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;;

namespace CourseSystem
{
    public class Course_Model
    {
        public Course_Model() { }
        List<Course> _course = new List<Course>();

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
        /// 教授新增課程 尚未完成
        /// </summary>
        public void addCourseForProfessor(string courseName,int courseId)
        {
            Course course = new Course();
            course._courseId=courseId;
            course._courseName=courseName;
        }

        /// <summary>
        /// 學生查詢課程
        /// </summary>
        public DataTable getCourse(string studentId)
        {
            DataTable course = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM coursemaptimeslice WHERE `s_Id` = @courseId";
            cmd.Parameters.AddWithValue("@s_Id", studentId);
            string WORK = "S";
            course=ConnectDatabase(cmd,WORK);

            return course;
        }
    }
}
