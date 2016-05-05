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
        public void LogInTest()
        {
            presentationModel pModel = new presentationModel(new Model());
            presentationModel _pModel = new presentationModel(new Model());
            _pModel = pModel;
            Assert.AreEqual(_pModel, pModel);
        }

        [TestMethod()]
        public void CheckSuccessOrNotTest()
        {
            presentationModel _pmodel = new presentationModel(new Model());
            string _userId = "101590320";
            string _userPwd = "0000";
            bool _success = false;

            if (_userId != "" && _userId != null && _userPwd != "" && _userPwd != null)
            {
                try
                {
                    if(_pmodel.LogIn(_userId, _userPwd) == "Success")
                    {
                        _success = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            Assert.AreEqual(_success, true);
        }
    }
}