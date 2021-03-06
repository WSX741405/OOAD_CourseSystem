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
        presentationModel _pmodel;
        public Form1(presentationModel pmodel)
        {
            _pmodel = pmodel;
            InitializeComponent();
        }

        private void ClickCheckClassScheduleButton(object sender, EventArgs e)
        {
            PersonalClassSchedule classSchedule = new PersonalClassSchedule(_pmodel);
            classSchedule.ShowDialog();
        }

        private void ClickSelectCourseButton(object sender, EventArgs e)
        {
            SelectedCourse selectCourse = new SelectedCourse(_pmodel);
            if (selectCourse.ShowDialog() == DialogResult.OK) 
            {
                MessageBox.Show(this, "加選課程成功!!", "成功", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClickLogInButton(object sender, EventArgs e)
        {
            LogIn _logInForm = new LogIn(_pmodel);
            _logInForm.ShowDialog();
            if (_logInForm.CheckSuccessOrNot() == true)
            {
                if (_pmodel.IdentifyUser(_pmodel.GetCurrentUser()) == "Professor") 
                {
                    _reviewSelectCourseButton.Visible = true;
                    _addCourseButton.Visible = true;
                }
                else if (_pmodel.IdentifyUser(_pmodel.GetCurrentUser()) == "Student")
                {
                    _dropCourseButton.Visible = true;
                    _selectCourseButton.Visible = true;
                }
                _checkClassScheduleButton.Visible = true;
                _registerButton.Visible = false;
                _logoutButton.Visible = true;
                _loginButton.Visible = false;
                _helloLabel.Text = "Hello!! "+_pmodel.GetCurrentUser();
            }
        }

        private void ClickRegisterButton(object sender, EventArgs e)
        {
            Register _registerForm = new Register(_pmodel);
            _registerForm.ShowDialog();
        }

        private void ClickLogOutButton(object sender, EventArgs e)
        {
            _checkClassScheduleButton.Visible = false;
            _selectCourseButton.Visible = false;
            _addCourseButton.Visible = false;
            _registerButton.Visible = true;
            _logoutButton.Visible = false;
            _loginButton.Visible = true;
            _dropCourseButton.Visible = false;
            _reviewSelectCourseButton.Visible = false;
            _helloLabel.Text = "";
            _pmodel.ClearCurrentUser();
        }

        private void ClickAddCourseButton(object sender, EventArgs e)
        {
            OfferCourse _addCourseForm = new OfferCourse(_pmodel);
            _addCourseForm.ShowDialog();
            if (_addCourseForm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(this, "開設課程成功!!", "成功", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClickDropCourseButton(object sender, EventArgs e)
        {
            DropCourse _dropCourseForm = new DropCourse(_pmodel);
            _dropCourseForm.ShowDialog();
            if (_dropCourseForm.DialogResult == DialogResult.OK) 
            {
                MessageBox.Show(this, "退選課程成功!!", "成功", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClickReviewSelectCourseButton(object sender, EventArgs e)
        {
            ReviewSelectedCourse reviewForm = new ReviewSelectedCourse(_pmodel);
            reviewForm.ShowDialog();
        }
    }
}
