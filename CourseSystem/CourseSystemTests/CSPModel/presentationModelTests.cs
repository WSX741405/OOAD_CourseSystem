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
        Course_Model _courseModel = new Course_Model();
        Model _model = new Model();
        DataTable _userdata = new DataTable();
        presentationModel _testPModel = new presentationModel(new Model(), new Course_Model(), new Professor_Model());

        [TestMethod()]
        public void GetCurrentUserTest()
        {
            string testUserId = "101590320";
            DataTable userdata = _model.FindUser(testUserId);
                _userdata = userdata;
            Assert.AreEqual(_userdata.Rows[0]["UserId"].ToString(),testUserId);
        }

        [TestMethod()]
        public void ClearCurrentUserTest()
        {
            string testUserId = "101590320";
            DataTable emptyData = new DataTable();
            DataTable userdata = _model.FindUser(testUserId);
            emptyData = _userdata;
                _userdata = userdata;
            _userdata.Clear();
            Assert.AreEqual(_userdata.Rows.Count, 0);
        }

        [TestMethod()]
        public void CreateUserTest()
        {
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
            string status = _model.LogIn(testUserId, testPwd);
            Assert.AreEqual(status, "Success");
        }

        [TestMethod()]
        public void getUserMapCourseTest()
        {
            string testUserId = "101590320";
            List<int> courseList = new List<int>();
            courseList = _courseModel.getUserMapCourse(testUserId);
            Assert.AreEqual(courseList[0],1);
        }

        [TestMethod()]
        public void getTimesliceByCourseIdTest()
        {
            int t_id = 1;
            List<int> timeslice = new List<int>();
            timeslice = _courseModel.getTimesliceByCourseId(t_id);
            Assert.AreEqual(timeslice[0], 6);
        }

        [TestMethod()]
        public void getTimesliceByTimesliceIdTest()
        {
            int t_id = 1;
            List<int> timesliceData = new List<int>();
            timesliceData = _courseModel.getTimesliceByTimesliceId(t_id);
            Assert.AreEqual(timesliceData[0], 1);
        }

        [TestMethod()]
        public void getCourseNameByCourseIdTest()
        {
            int c_id = 1;
            string courseName = _courseModel.getCourseNameByCourseId(c_id);
            Assert.AreEqual(courseName, "資訊檢索與應用");
        }
    }
}
