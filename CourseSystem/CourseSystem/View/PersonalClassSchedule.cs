﻿using System;
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
        presentationModel _pmodel;
        private string _studentId;
        private string SQL;
        public PersonalClassSchedule(presentationModel pmodel)
        {
            _pmodel = pmodel;
            InitializeComponent();
        }

        private void ClickCheckScheduleButton(object sender, EventArgs e)
        {
            ClearClassSchedule();
            
        }

        private void ClearClassSchedule()
        {
            _classScheduleDataGridView.Rows.Clear();
        }

    }
}
