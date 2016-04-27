using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem
{
    class PModel
    {
        Model _model = new Model();
        public void InseretIntoDatabase(string SQLCommand) 
        {
            _model.ConnectDatabase(SQLCommand);
        }
    }
}
