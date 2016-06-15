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
    public partial class DropCourse : Form
    {
        string userId;
        List<int> _studentAlreadySelectedCourse = new List<int>(); //列出學生以選課程
        List<int> _studentSelectCId = new List<int>();
        List<string> _studentSelectCName = new List<string>();
        List<int> _cIdDropList = new List<int>();
        List<string> _cNameDropList = new List<string>();
        presentationModel _pmodel;
        public DropCourse(presentationModel pmodel)
        {
            _pmodel = pmodel;
            InitializeComponent();
            InitializeCourseData();
            InitializeDropCourseDataGridView();
            RefreshCourseDataGridView();
            _showUserLabel.Text = _pmodel.GetCurrentUser();
        }

        public void InitializeCourseData()
        {
            userId = _pmodel.GetCurrentUser();
            _studentAlreadySelectedCourse = _pmodel.getStudentSelectedCourse(userId);
            for (int i = 0; i < _studentAlreadySelectedCourse.Count; i++) 
            {
                _studentSelectCId.Add(_pmodel.getCourseIdByFlowCourseId(_studentAlreadySelectedCourse[i]));
                _studentSelectCName.Add(_pmodel.getCourseNameByFlowCourseId(_studentAlreadySelectedCourse[i]));
            }
        }

        public void InitializeDropCourseDataGridView()
        {
            _dropCouresDataGridView.Rows.Clear();
            for (int i = 0; i < _studentAlreadySelectedCourse.Count; i++) 
            {
                _dropCouresDataGridView.Rows.Add();
                _dropCouresDataGridView.Rows[i].Cells[0].Value = i.ToString();
            }
        }

        public void InitializeCourseGridView()
        {
            _courseDataGridView.Rows.Clear();
            for (int i = 0; i < _studentAlreadySelectedCourse.Count; i++)
            {
                _courseDataGridView.Rows.Add();
                _courseDataGridView.Rows[i].Cells[0].Value = i.ToString();
            }
        }

        public void RefreshCourseDataGridView() 
        {
            SortCourseList(_studentSelectCId,_studentSelectCName);
            InitializeCourseGridView();
            for (int i = 0; i < _studentSelectCId.Count; i++) 
            {
                _courseDataGridView.Rows[i].Cells[1].Value = _studentSelectCName[i].ToString();
                _courseDataGridView.Rows[i].Cells[2].Value = _studentSelectCId[i].ToString();
            }
                _courseDataGridView.Columns[3].Visible = true;
        }

        public void RefreshDropCourseDataGridView() 
        {
            InitializeDropCourseDataGridView();
            for (int i = 0; i < _cIdDropList.Count; i++) 
            {
                _dropCouresDataGridView.Rows[i].Cells[1].Value = _cNameDropList[i].ToString();
                _dropCouresDataGridView.Rows[i].Cells[2].Value = _cIdDropList[i].ToString();
            }
            _dropCouresDataGridView.Columns[3].Visible = true;
        }

        public void SortCourseList(List<int> cIdList, List<string> cNameList)
        {
            int itemp;
            string stemp;
            for (int i = 0; i < cIdList.Count; i++)
            {
                for (int j = i + 1; j < cIdList.Count; j++)
                {
                    if (cIdList[i] > cIdList[j])
                    {
                        itemp = cIdList[i];
                        cIdList[i] = cIdList[j];
                        cIdList[j] = itemp;

                        stemp = cNameList[i];
                        cNameList[i] = cNameList[j];
                        cNameList[j] = stemp;
                    }
                }
            }
        }

        private void ClickCourseDataGridViewCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 3) 
            {
                _cIdDropList.Add(_studentSelectCId[e.RowIndex]);
                _cNameDropList.Add(_studentSelectCName[e.RowIndex]);
                _studentSelectCId.RemoveAt(e.RowIndex);
                _studentSelectCName.RemoveAt(e.RowIndex);
                RefreshCourseDataGridView();
                RefreshDropCourseDataGridView();
            }
        }
    }
}