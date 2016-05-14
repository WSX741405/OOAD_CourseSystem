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
    public class Course_Model
    {
        public Course_Model() { }
        public List<Course> _course = new List<Course>();

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

        ///// <summary>
        ///// 教授新增課程 尚未完成
        ///// </summary>
        //public void addCourseForProfessor(string courseName,int courseId)
        //{
        //    Course course = new Course();
        //    course._courseId=courseId;
        //    course._courseName=courseName;
        //}

        /// <summary>
        /// 由學生ID查詢該名學生的課表之課程ID
        /// </summary>
        public List<int> getUserMapCourse(string studentId)
        {
            List<int>courseList=new List<int>();
            DataTable course = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM usermapcourse WHERE `s_Id` = @studentId";
            cmd.Parameters.AddWithValue("@studentId", studentId);
            string WORK = "S";
            course=ConnectDatabase(cmd,WORK);
            foreach(DataRow da in course.Rows)
            {
                courseList.Add(int.Parse(da[2].ToString()));
            }
            return courseList;
        }

        /// <summary>
        /// 由課程id查詢課程時刻id
        /// </summary>
        public List<int> getTimesliceByCourseId(int c_id)
        {
            List<int> timesliceList = new List<int>();
            DataTable timesliceData = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM coursemaptimeslice WHERE `id` = @c_id";
            cmd.Parameters.AddWithValue("@c_Id", c_id);
            string WORK = "S";
            timesliceData = ConnectDatabase(cmd, WORK);
            foreach (DataRow da in timesliceData.Rows) 
            {
                timesliceList.Add(int.Parse(da[1].ToString()));
            }
            return timesliceList;
        }

        /// <summary>
        /// 由課程時刻ID查詢上課日期與時間
        /// </summary>
        public DataTable getTimesliceByTimesliceId(int t_id) 
        {
            DataTable timesliceData = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM timeslice WHERE `id` = @t_id";
            cmd.Parameters.AddWithValue("@t_id", t_id);
            string WORK = "S";
            timesliceData = ConnectDatabase(cmd, WORK);
            return timesliceData;
        }
    }
}
