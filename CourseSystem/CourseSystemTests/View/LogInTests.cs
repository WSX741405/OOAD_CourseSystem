using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem.View;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CourseSystem.View.Tests
{
    [TestClass()]
    public class LogInTests
    {
        [TestMethod()]
        public void CheckSuccessOrNotTest()
        {
            presentationModel _pmodel = new presentationModel(new Model(), new Course_Model(), new Professor_Model());
            string _userId = "101590320";
            string _userPwd = "0000";
            String _success;
            _success = _pmodel.LogIn(_userId, _userPwd);
            Assert.AreEqual(_success, "Success");
        }
    }
}