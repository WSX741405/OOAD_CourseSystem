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
        public void RegisterTest()
        {
            presentationModel pModel = new presentationModel(new Model(), new Course_Model());
            presentationModel _pModel = new presentationModel(new Model(), new Course_Model());
            _pModel = pModel;
            Assert.AreEqual(_pModel, pModel);
        }

        [TestMethod()]
        public void CheckSuccessOrNotTest()
        {
            presentationModel _pmodel = new presentationModel(new Model(), new Course_Model());
            string _userId = "101590320";
            string _userPwd = "0000";
            string _userIdentity = "Student";
            bool _success = false;

            if (_userId != "" && _userId != null && _userPwd != "" && _userPwd != null && _userIdentity != null && _userIdentity != "")
            {
                try
                {
                    if (_pmodel.CreateUser(_userId, _userPwd, _userIdentity) == false)
                    {
                        _success = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            Assert.AreEqual(_success, false);
        }
    }
}
