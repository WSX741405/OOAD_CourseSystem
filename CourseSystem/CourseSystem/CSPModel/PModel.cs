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
        Course_Model _courseModel;
        Model _model;
        DataTable _userdata;
        public presentationModel(Model model,Course_Model courseModel) 
        {
            _model = model;
            _courseModel = courseModel;
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
        /// 學生查詢課表
        /// </summary>
        public DataTable getCourse(string studentId) 
        {
            DataTable course = new DataTable();
            _courseModel.getCourse(studentId);
            return course;
        }

    }
}
