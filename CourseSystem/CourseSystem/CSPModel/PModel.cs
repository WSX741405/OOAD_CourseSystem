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
            if (_model.CreateUser(userId, password) == false) 
            {
                return false;
            }
            return true;
        }
    }
}
