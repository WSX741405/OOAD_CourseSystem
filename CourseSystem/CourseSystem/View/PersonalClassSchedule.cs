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
        presentationModel _pmodel;
        private string _studentId;
        private string _connectString;
        private string SQL;
        public PersonalClassSchedule()
        {
            InitializeComponent();
            _connectString = "SERVER=spring-ooad.ddns.net; DATABASE=ooad-cs; UID=ooad-cs; PASSWORD=ooad-cs;";
        }

        private void ClickCheckScheduleButton(object sender, EventArgs e)
        {
            //String SQLCommand = "insert into  test (a,b,c) values('1','12','1234')";
            //_pmodel.InseretIntoDatabase(SQLCommand);
            //getData();
            /*_currentIdLabel.Text = "學號：" + _idTextBox.Text;
            string[] recordContent = { "8:10~9:00", "微積分", "", "", "", "", "" };
            ClearClassSchedule();   //  clear all record in schedule
            _classScheduleDataGridView.Rows.Add(recordContent);*/
        }

        private void ClearClassSchedule()
        {
            _classScheduleDataGridView.Rows.Clear();
        }

        private void getData ()
        {
            string SQL = "SELECT * FROM Projects";
            _classScheduleDataGridView.DataSource= SqlHelper.ExecuteDataTable(_connectString, CommandType.Text, SQL);
        }
    }
}
