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
        public Professor_Model() { }

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

        public void OfferCourse(DataTable timeslice, string courseName, string courseId)
        {
            //新增進course
            MySqlCommand cmd = new MySqlCommand();
            string WORK = "I"; //傳入執行動作進入ConnectDatabase
            cmd.CommandText = "INSERT INTO `course`(`Id`, `CourseId`, `CourseName`) VALUES (,@courseId,@courseName)";
            //必須先Clear 因為前面有新增過 @userId,重覆會出問題
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@courseId", courseId);
            cmd.Parameters.AddWithValue("@courseName", courseName);
            DataTable insertDs = ConnectDatabase(cmd, WORK);
            //新增進timeslice
            foreach (DataRow dr in timeslice.Rows) 
            {
                switch(dr[0].ToString())
                {
                    case "星期一":
                        cmd.CommandText = "INSERT INTO `timeslice`(`id`, `day`, `time`) VALUES (,1,@time)";
                        break;
                    case "星期二":
                        cmd.CommandText = "INSERT INTO `timeslice`(`id`, `day`, `time`) VALUES (,2,@time)";
                        break;
                    case "星期三":
                        cmd.CommandText = "INSERT INTO `timeslice`(`id`, `day`, `time`) VALUES (,3,@time)";
                        break;
                    case "星期四":
                        cmd.CommandText = "INSERT INTO `timeslice`(`id`, `day`, `time`) VALUES (,4,@time)";
                        break;
                    case "星期五":
                        cmd.CommandText = "INSERT INTO `timeslice`(`id`, `day`, `time`) VALUES (,5,@time)";
                        break;
                }
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@time", int.Parse(dr[1].ToString()));
                DataTable da = ConnectDatabase(cmd, WORK);

                //新增進coursemaptimeslice
                int t_id = int.Parse(da.Rows[0][0].ToString());
                //int c_id = _courseModel.getFlowCourseIdByCourseName(courseName);
                cmd.CommandText = "INSERT INTO `coursemaptimeslice`(`c_id`, `t_id`) VALUES (@c_id,@t_id)";
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@c_id",c_id);
                cmd.Parameters.AddWithValue("@t_id",t_id);
                DataTable time = ConnectDatabase(cmd, WORK);
            }
        }
    }
}
