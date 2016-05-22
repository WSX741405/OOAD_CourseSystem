using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CourseSystem.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            presentationModel pModel = new presentationModel(new Model(), new Course_Model());
            presentationModel _pModel = new presentationModel(new Model(), new Course_Model());
            _pModel = pModel;
            Assert.AreEqual(_pModel, pModel);
        }
    }
}
