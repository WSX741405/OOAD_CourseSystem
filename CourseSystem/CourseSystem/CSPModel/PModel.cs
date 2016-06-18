using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CourseSystem
{
    public class presentationModel
    {
        Professor_Model _professorModel;
        Course_Model _courseModel;
        Student _studentModel;
        Model _model;
        DataTable _userdata;
        public presentationModel(Model model,Course_Model courseModel,Professor_Model professorModel,Student studentModel ) 
        {
            _model = model;
            _courseModel = courseModel;
            _professorModel = professorModel;
            _studentModel = studentModel;
        }

        /// <summary>
        /// 取得當前使用者
        /// </summary>
        public string GetCurrentUser()
        {
            return _userdata.Rows[0]["UserId"].ToString();
        }

        /// <summary>
        /// 清除當前使用者
        /// </summary>
        public void ClearCurrentUser() 
        {
            _userdata.Clear();
        }

        /// <summary>
        /// 新增使用者
        /// </summary>
        public bool CreateUser(string userId,string password,string identity) 
        {
            return _model.CreateUser(userId, password,identity);
        }

        /// <summary>
        /// 登入
        /// </summary>
        public string LogIn(string userId, string password)
        {
            string status = _model.LogIn(userId, password);
            DataTable userdata = _model.FindUser(userId);
            if (userdata.Rows.Count > 0) 
            {
                _userdata = userdata;
            }
            return status;
        }

        /// <summary>
        /// 查詢課程連結時間
        /// </summary>
        public List<int> getStudentSelectedCourse(string studentId) 
        {
            List<int> courseList = new List<int>();
            courseList = _courseModel.getStudentSelectedCourse(studentId);
            return courseList;
        }

        /// <summary>
        /// 查詢時間表BycourseId
        /// </summary>
        public List<int> getTimesliceByCourseId(int t_id) 
        {
            List<int> timeslice = new List<int>();
            timeslice = _courseModel.getTimesliceByCourseId(t_id);
            return timeslice;
        }

        /// <summary>
        /// 查詢時間表BytimesliceId
        /// </summary>
        public List<int> getTimesliceByTimesliceId(int t_id) 
        {
            List<int> timesliceData = new List<int>();
            timesliceData = _courseModel.getTimesliceByTimesliceId(t_id);
            return timesliceData;
        }

        /// <summary>
        /// 由課程ID查詢課程名稱
        /// </summary>
        public string getCourseNameByCourseId(int c_id)
        {
            string courseName = _courseModel.getCourseNameByCourseId(c_id);
            return courseName;
        }

        /// <summary>
        /// 新增課程
        /// </summary>
        public void OfferCourse(List<string>dateList,List<string>timeList, string courseName, string courseId,string userId) 
        {
            _professorModel.OfferCourse(dateList,timeList,courseName,courseId,userId);
        }

        /// <summary>
        /// 由課程流水號查詢課程名稱
        /// </summary>
        public string getCourseNameByFlowCourseId(int flowCourseId) 
        {
            string courseName = _courseModel.getCourseNameByFlowCourseId(flowCourseId);
            return courseName;
        }

        /// <summary>
        /// 搜尋所有教授開課的課程
        /// </summary>
        public DataTable GetCourseList() 
        {
            DataTable courseList = _courseModel.GetCourseList();
            return courseList;
        }

        /// <summary>
        /// 由課程流水號查詢課程ID
        /// </summary>
        public int getCourseIdByFlowCourseId(int flowCourseId) 
        {
            int courseId = _courseModel.getCourseIdByFlowCourseId(flowCourseId);
            return courseId;
        }

        /// <summary>
        /// 新增學生選課進usermapcourse
        /// </summary>
        public void StudentSelectCourse(List<int> c_id,string userId) 
        {
            _studentModel.StudentSelectCourse(c_id,userId);
        }

        /// <summary>
        /// 學生退選功能
        /// </summary>
        public void StudentDropCourse(List<int>c_id,string userId)
        {
            _studentModel.StudentDropCourse(c_id, userId);
        }

        /// <summary>
        /// 搜尋教授開課的課程
        /// </summary>
        public List<int> GetProfessorOfferCourse(string p_id)
        {
            return _professorModel.GetProfessorOfferCourse(p_id);
        }

        ///
        /// 由課程ID搜尋修課學生
        /// 
        public List<string> GetStudentIdFromCourseId(int courseId)
        {
            List<string> studentList = new List<string>();
            studentList = _courseModel.GetStudentIdFromCourseId(courseId);
            return studentList;
        }
    }
}
