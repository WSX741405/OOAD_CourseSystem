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
        Model _model;
        DataSet _userdata;
        public presentationModel(Model model) 
        {
            _model = model;
        }
        /// <summary>
        /// 新增使用者
        /// </summary>

        public bool CreateUser(string userId,string password) 
        {
            return _model.CreateUser(userId, password);
        }

        /// <summary>
        /// 登入
        /// </summary>
        public string LogIn(string userId, string password)
        {
            string status = _model.LogIn(userId, password);
            DataTable userdata = _model.FindUser(userId);
            return status;
        }

    }
}
