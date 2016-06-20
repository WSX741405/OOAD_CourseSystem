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
    public class Professor_Model
    {
        Course_Model _courseModel;
        public Professor_Model(Course_Model coursemodel)
        {
            _courseModel = coursemodel;
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

        /// <summary>
        /// 新增課程
        /// </summary>

        public void OfferCourse(List<string> dateList, List<string> timeList, string courseName, string courseId,string userId)
        {
            //新增進course
            MySqlCommand cmd = new MySqlCommand();
            string WORK = "I"; //傳入執行動作進入ConnectDatabase
            int c_Id = int.Parse(courseId.ToString());
            cmd.CommandText = "INSERT INTO `course`(`Id`, `CourseId`, `CourseName`) VALUES ('',@courseId,@courseName)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@courseId", c_Id);
            cmd.Parameters.AddWithValue("@courseName", courseName);
            DataTable insertDs = ConnectDatabase(cmd, WORK);

            //新增進usermapcourse
            int courseFlowId = _courseModel.getFlowCourseIdByCourseName(courseName);
            WORK = "I"; //傳入執行動作進入ConnectDatabase
            cmd.CommandText = "INSERT INTO `usermapcourse`(`s_id`, `p_id`, `c_id`) VALUES ('',@p_id,@c_id)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@p_id", userId);
            cmd.Parameters.AddWithValue("@c_id", courseFlowId);
            DataTable umc = ConnectDatabase(cmd, WORK);

            //新增進coursemaptimeslice
            for (int i = 0; i < dateList.Count; i++)
            {
                //找尋正確的t_id
                int classtime = int.Parse(timeList[i]);
                switch (dateList[i])
                {
                    case "星期一":
                        cmd.CommandText = "SELECT * FROM `timeslice` WHERE `day`=1 AND`time`=@classtime";
                        break;
                    case "星期二":
                        cmd.CommandText = "SELECT * FROM `timeslice` WHERE `day`=2 AND`time`=@classtime";
                        break;
                    case "星期三":
                        cmd.CommandText = "SELECT * FROM `timeslice` WHERE `day`=3 AND`time`=@classtime";
                        break;
                    case "星期四":
                        cmd.CommandText = "SELECT * FROM `timeslice` WHERE `day`=4 AND`time`=@classtime";
                        break;
                    case "星期五":
                        cmd.CommandText = "SELECT * FROM `timeslice` WHERE `day`=5 AND`time`=@classtime";
                        break;
                }
                WORK = "S";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@classtime", classtime);
                DataTable timesliceId = ConnectDatabase(cmd, WORK);

                //實作寫資料進coursemaptimeslice
                WORK = "I";
                int t_id = int.Parse(timesliceId.Rows[0][0].ToString());
                int c_id = _courseModel.getFlowCourseIdByCourseName(courseName);
                cmd.CommandText = "INSERT INTO `coursemaptimeslice`(`c_id`, `t_id`) VALUES (@c_id,@t_id)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@c_id", c_id);
                cmd.Parameters.AddWithValue("@t_id", t_id);
                DataTable time = ConnectDatabase(cmd, WORK);
            }
        }
        /// <summary>
        /// 搜尋教授開課的課程
        /// </summary>
        public List<int> GetProfessorOfferCourse(string p_id)
        {
            List<int> course = new List<int>();
            DataTable courseList = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM `usermapcourse` WHERE `p_id` =@p_id";
            cmd.Parameters.AddWithValue("@p_id", p_id);
            string WORK = "S";
            courseList = ConnectDatabase(cmd, WORK);
            foreach (DataRow dr in courseList.Rows) 
            {
                course.Add(int.Parse(dr[2].ToString()));
            }
            return course;
        }
    }
}
