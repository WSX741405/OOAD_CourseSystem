﻿using CourseSystem.View;
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

namespace CourseSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickCheckClassScheduleButton(object sender, EventArgs e)
        {
            PersonalClassSchedule classSchedule = new PersonalClassSchedule();
            classSchedule.ShowDialog();
        }

        private void ClickComputeGradeButton(object sender, EventArgs e)
        {
            ComputeGrade studentGrade = new ComputeGrade();
            studentGrade.ShowDialog();
        }

        private void ClickLogInButton(object sender, EventArgs e)
        {
            LogIn _logInForm = new LogIn();
            _logInForm.ShowDialog();
        }

        private void ClickRegisterButton(object sender, EventArgs e)
        {
            Register _registerForm = new Register();
            _registerForm.ShowDialog();
        }
    }
}
