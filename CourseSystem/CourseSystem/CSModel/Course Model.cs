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

        /// <summary>
        /// 由學生ID查詢該名學生的課表之課程ID
        /// </summary>
        public List<int> getStudentSelectedCourse(string studentId)
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
            List<int> timesliceList= new List<int>();
            DataTable timesliceData = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM coursemaptimeslice WHERE `c_id` = @c_id";
            cmd.Parameters.AddWithValue("@c_Id", c_id);
            string WORK = "S";
            timesliceData = ConnectDatabase(cmd, WORK);
            Console.WriteLine("c_id" + c_id.ToString() + timesliceData.Rows);
            foreach (DataRow da in timesliceData.Rows) 
            {
                timesliceList.Add(int.Parse(da[1].ToString()));
            }
            return timesliceList;
        }

        /// <summary>
        /// 由課程時刻ID查詢上課日期與時間
        /// </summary>
        public List<int> getTimesliceByTimesliceId(int t_id) 
        {
            List<int> timeslice = new List<int>();
            DataTable timesliceData = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM timeslice WHERE `id` = @t_id";
            cmd.Parameters.AddWithValue("@t_id", t_id);
            string WORK = "S";
            timesliceData = ConnectDatabase(cmd, WORK);
            foreach (DataRow da in timesliceData.Rows) 
            {
                timeslice.Add(int.Parse(da[1].ToString()));
                timeslice.Add(int.Parse(da[2].ToString()));
            }
            return timeslice;
        }

        /// <summary>
        /// 由課程ID查詢課程名稱
        /// </summary>
        public string getCourseNameByCourseId(int c_id) 
        {
            DataTable courseData = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM course WHERE `Id` = @c_id";
            cmd.Parameters.AddWithValue("@c_id", c_id);
            string WORK = "S";
            courseData = ConnectDatabase(cmd, WORK);
            string courseName = courseData.Rows[0][2].ToString();
            return courseName;
        }

        /// <summary>
        /// 由課程ID查詢課程流水號
        /// </summary>
        public int getFlowCourseIdByCourseId(int courseId) 
        {
            DataTable courseData = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM course WHERE `CourseId` = @c_id";
            cmd.Parameters.AddWithValue("@c_id",courseId);
            string WORK = "S";
            courseData = ConnectDatabase(cmd, WORK);
            int flowCourseId = int.Parse(courseData.Rows[0][0].ToString());
            return flowCourseId;
        }

        /// <summary>
        /// 由課程名稱查詢課程流水號
        /// </summary>
        public int getFlowCourseIdByCourseName(string courseName) 
        {
            DataTable courseData = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM course WHERE `CourseName` = @courseName";
            cmd.Parameters.AddWithValue("@courseName", courseName);
            string WORK = "S";
            courseData = ConnectDatabase(cmd, WORK);
            int courseFlowId = int.Parse(courseData.Rows[0][0].ToString());
            return courseFlowId;
        }

        /// <summary>
        /// 由課程流水號查詢課程名稱
        /// </summary>
        public string getCourseNameByFlowCourseId(int flowCourseId)
        {
            DataTable courseData = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM course WHERE `Id` = @flowCourseId";
            cmd.Parameters.AddWithValue("@flowCourseId", flowCourseId);
            string WORK = "S";
            courseData = ConnectDatabase(cmd, WORK);
            string courseName = courseData.Rows[0][2].ToString();
            return courseName;
        }

        /// <summary>
        /// 由課程流水號查詢課程ID
        /// </summary>
        public int getCourseIdByFlowCourseId (int flowCourseId)
        {
            DataTable courseData = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM course WHERE `Id` = @flowCourseId";
            cmd.Parameters.AddWithValue("@flowCourseId", flowCourseId);
            string WORK = "S";
            courseData = ConnectDatabase(cmd, WORK);
            int courseid = int.Parse(courseData.Rows[0][1].ToString());
            return courseid;
        }

        /// <summary>
        /// 搜尋所有教授開課的課程
        /// </summary>
        public DataTable GetCourseList()
        {
            DataTable courseList = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM `usermapcourse` WHERE `p_id` !=''";
            string WORK = "S";
            courseList = ConnectDatabase(cmd, WORK);
            return courseList;
        }
    }
}
