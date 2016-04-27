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
        private string _studentId;
        public PersonalClassSchedule()
        {
            InitializeComponent();
        }

        private void ClickCheckScheduleButton(object sender, EventArgs e)
        {
            _currentIdLabel.Text = "學號：" + _idTextBox.Text;
            string[] recordContent = { "8:10~9:00", "微積分", "", "", "", "", "" };
            ClearClassSchedule();   //  clear all record in schedule
            _classScheduleDataGridView.Rows.Add(recordContent);
        }

        private void ClearClassSchedule()
        {
            _classScheduleDataGridView.Rows.Clear();
        }
    }
}
