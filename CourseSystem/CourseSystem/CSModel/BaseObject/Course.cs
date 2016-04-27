using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem.CSModel.BaseObject
{
    public class Course
    {
        private string  _courseName;
        private string _courseId;
        private List<TimeSlice> _courseOfferTime = new List<TimeSlice>();

    }
}
