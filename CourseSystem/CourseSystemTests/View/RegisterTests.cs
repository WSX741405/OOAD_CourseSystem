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
    public class RegisterTests
    {

        [TestMethod()]
        public void CheckSuccessOrNotTest()
        {
            presentationModel _pmodel = new presentationModel(new Model(), new Course_Model());
            string _userId = "101590320";
            string _userPwd = "0000";
            string _userIdentity = "Student";
            bool _success;

            _success = _pmodel.CreateUser(_userId, _userPwd, _userIdentity);
            Assert.AreEqual(_success, true);
        }
    }
}
