using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string[] recordContent = { "8:00~9:00", "微積分", "", "", "", "", "" };
            ClearClassSchedule();   //  clear all record in schedule
            PushRecordIntoClassSchedule(recordContent);  // push record after final record
        }

        private void ClearClassSchedule()
        {
            _classScheduleDataGridView.Rows.Clear();
        }

        private void PushRecordIntoClassSchedule(string[] record)
        {
            int numberOfAttribute = record.Length;
            int row = _classScheduleDataGridView.Rows.Count;
            _classScheduleDataGridView.Rows.Add();
            for (int column = 0; column < numberOfAttribute; column++)
            {
                DataGridViewCell classSchedulCell = _classScheduleDataGridView[column, row];
                classSchedulCell.Value = record[column];
            }
            
        }
    }
}
