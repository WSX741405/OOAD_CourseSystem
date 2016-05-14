using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem
{
    public class Course
    {
        public string  _courseName;
        public int _courseId;
        public TimeSlice _timeslice = new TimeSlice();
        public List<TimeSlice> _courseOfferTime = new List<TimeSlice>();
    }
}
