using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem
{
    public class Course
    {
        private string  _courseName;
        private string _courseId;
        private TimeSlice _timeslice = new TimeSlice();
        private List<TimeSlice> _courseOfferTime = new List<TimeSlice>();


    }
}
