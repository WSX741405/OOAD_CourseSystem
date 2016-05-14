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
        private List<int> _courseList = new List<int>();
        private List<int> _timesliceList = new List<int>();
        presentationModel _pmodel;
        public PersonalClassSchedule(presentationModel pmodel)
        {
            _pmodel = pmodel;
            InitializeComponent();
            InitializeGridView();
        }

        private void InitializeGridView()
        {
            // 13 row's
            int startTime = 8;
            for (int counter = 0; counter < 13; counter++)
            {
                string content = counter != 4 ? ":10 - " : ":00 - ";
                _classScheduleDataGridView.Rows.Add();
                _classScheduleDataGridView.Rows[counter].Cells[0].Value = (startTime + counter).ToString() + content + (startTime + counter + 1).ToString() + ":00";
            }

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
            InitializeGridView();
            for (int i = 0; i < _courseList.Count(); i++)  //學生所有修課之課程ID
            {
                string courseName =_pmodel.getCourseNameByCourseId(_courseList[i]);
                _timesliceList = _pmodel.getTimesliceByCourseId(_courseList[i]);
                for (int j = 0; j < _timesliceList.Count(); j++)  //該課程之上課時程數
                {
                    List<int> timesliceData = _pmodel.getTimesliceByTimesliceId(_timesliceList[j]);
                    int d = timesliceData[0];
                    int t = timesliceData[1] - 1;   // 預設8點為 1 GridView 最上面row(8點)為0 所以-1
                    _classScheduleDataGridView.Rows[t].Cells[d].Value = courseName; 
                }
            }
        }

    }
}
