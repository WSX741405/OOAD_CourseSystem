using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CourseSystem
{
    class PModel
    {
        Model _model = new Model();
        //public void InseretIntoDatabase(string SQLCommand) 
        //{
        //    _model.ConnectDatabase(SQLCommand);
        //}

        public bool CreateUser(string userId,string password) 
        {
            return _model.CreateUser(userId, password);
        }
        public bool LogIn(string userId, string password)
        {
            return false;
        }
    }
}
