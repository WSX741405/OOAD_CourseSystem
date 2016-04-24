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
        public string _studentId;
        private DataGridView _classSchedule = new DataGridView();
        public PersonalClassSchedule()
        {
            InitializeComponent();     
        }

        private void ClickCheckScheduleButton(object sender, EventArgs e)
        {
            _studentId = _idTextBox.Text;
            _classSchedule.Rows.Add("8:00~9:00", "微積分", "", "", "", "", "");
        }

    }
}
