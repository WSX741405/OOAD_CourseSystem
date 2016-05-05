using CourseSystem.View;
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
        presentationModel _pmodel;
        public Form1(presentationModel pmodel)
        {
            _pmodel = pmodel;
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
            LogIn _logInForm = new LogIn(_pmodel);
            _logInForm.ShowDialog();
            if (_logInForm.CheckSuccessOrNot() == true)
            {
                _checkClassScheduleButton.Visible = true;
                _computeGradeButton.Visible = true;
                _registerButton.Visible = false;
                _logoutButton.Visible = true;
            }
        }

        private void ClickRegisterButton(object sender, EventArgs e)
        {
            Register _registerForm = new Register(_pmodel);
            _registerForm.ShowDialog();
        }
    }
}
