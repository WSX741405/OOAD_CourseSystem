using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CourseSystem.View
{
    public partial class PersonalClassSchedule : Form
    {
        private List<int>_courseList = new List<int>();
        private List<int> _timesliceList = new List<int>();
        presentationModel _pmodel;
        public PersonalClassSchedule(presentationModel pmodel)
        {
            _pmodel = pmodel;
            InitializeComponent();
        }

        private void ClickCheckScheduleButton(object sender, EventArgs e)
        {
            if (_courseList != null) 
            {
                _courseList.Clear();
            }
            _courseList = _pmodel.getUserMapCourse(_idTextBox.Text);

            RefreshClassSchedule();
        }

        private void RefreshClassSchedule()
        {
                _classScheduleDataGridView.Rows.Clear();
                for (int i = 0; i < _courseList.Count(); i++)  //學生所有修課之課程ID
                {
                    string courseName;
                    _timesliceList = _pmodel.getTimesliceByCourseId(_courseList[i]);
                    for (int j = 0; j < _timesliceList.Count(); j++)  //該課程之上課時程數
                    {
                        DataTable timesliceData = _pmodel.getTimesliceByTimesliceId(_timesliceList[i]);
                        foreach (DataRow time in timesliceData.Rows) 
                        {
                            //_classScheduleDataGridView.Rows[time[2]].Cells[time[1]].Value.ToString() = "1"; 
                        }
                    }
                }
        }

    }
}
