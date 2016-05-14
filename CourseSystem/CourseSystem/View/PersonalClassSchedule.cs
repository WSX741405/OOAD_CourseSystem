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
        List<int>_courseList = new List<int>();
        DataTable _timeslice;
        presentationModel _pmodel;
        public int count=0;
        private string SQL;
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
                count = 0;
            }
            _courseList = _pmodel.getUserMapCourse(_idTextBox.Text);
            _addidLabel.Text = _courseList[0].ToString();
            //count = _courseTable.Rows.Count;
            //for (int i = 1; i <= count; i++)
            //{
            //    _timeslice= _pmodel.getTimeslice(int.Parse(_courseTable.Rows[i].ToString()));
            //}
            //_addidLabel.Text = _timeslice.Rows[0].ToString();
            //RefreshClassSchedule();
        }

        private void RefreshClassSchedule()
        {
                _classScheduleDataGridView.Rows.Clear();
        }

    }
}
