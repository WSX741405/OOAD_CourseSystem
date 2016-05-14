using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem
{
    public class TimeSlice
    {
        //day -> one day of week
        //range -> 1~7
        private int _day;
        //time->  course is offered time 
        //range -> 1~9,A,B,C,D
        private char _time;
        void TimeSliceInirial(int day,char time)
        {
            this._day = day;
            this._time = time;
        }

        public int getDay()
        {
            return this._day;
        }

        public char getTime()
        {
            return this._time;
        }
    }
}
