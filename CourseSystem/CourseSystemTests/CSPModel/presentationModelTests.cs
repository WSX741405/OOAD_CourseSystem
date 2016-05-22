using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseSystem;

namespace CourseSystem.Tests
{
    [TestClass()]
    public class presentationModelTests
    {
        presentationModel _testPModel = new presentationModel(new Model(),new Course_Model());
        [TestMethod()]
        public void presentationModelTest()
        {
            Model model = new Model();
            Model _model = new Model();
            Course_Model courseModel = new Course_Model();
            Course_Model _courseModel = new Course_Model();
            _model = model;
            _courseModel = courseModel;
            Assert.AreEqual(_model, model);
            Assert.AreEqual(_courseModel, courseModel);
        }

        [TestMethod()]
        public void GetCurrentUserTest()
        {
            string testUserId = "101590320";
            Model _model = new Model();
            DataTable _userdata = new DataTable();
            DataTable userdata = _model.FindUser(testUserId);
            if (userdata.Rows.Count > 0)
            {
                _userdata = userdata;
            }
            Assert.AreEqual(_userdata.Rows[0]["UserId"].ToString(),testUserId);
        }

        [TestMethod()]
        public void ClearCurrentUserTest()
        {
            string testUserId = "101590320";
            Model _model = new Model();
            DataTable _userdata = new DataTable();
            DataTable emptyData = new DataTable();
            DataTable userdata = _model.FindUser(testUserId);
            emptyData = _userdata;
            if (userdata.Rows.Count > 0)
            {
                _userdata = userdata;
            }
            _userdata.Clear();
            Assert.AreEqual(_userdata.Rows.Count, 0);
        }

        [TestMethod()]
        public void CreateUserTest()
        {
            //prepare test Data
            string testUserId = "101590320";
            string testPwd = "0000";
            string testIdentity="Student";
            bool fail = true, status;
            status = _testPModel.CreateUser(testUserId, testPwd, testIdentity);
            Assert.AreEqual(status, fail);
        }

        [TestMethod()]
        public void LogInTest()
        {
            string testUserId = "101590320";
            string testPwd = "0000";
            Model _model = new Model();
            string status = _model.LogIn(testUserId, testPwd);
            Assert.AreEqual(status, "Success");
        }

        //[TestMethod()]
        //public void getUserMapCourseTest()
        //{
        //    string testUserId = "101590320";
        //    Course_Model _courseModel = new Course_Model();
        //    List<int> courseList = new List<int>();
        //    courseList = _courseModel.getUserMapCourse(testUserId);
        //    Assert.Fail();
        //}
    }
}
