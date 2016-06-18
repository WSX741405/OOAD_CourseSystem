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
    public partial class ReviewSelectedCourse : Form
    {
        string userId;
        List<int> _courseList = new List<int>();
        List<int> _cIdList = new List<int>();
        List<string> _cNameList = new List<string>();
        presentationModel _pmodel;
        public ReviewSelectedCourse(presentationModel pmodel)
        {
            _pmodel = pmodel;
            InitializeComponent();
            InitializeCourseData();
            RefreshCourseListGridView();
            _userNameLabel.Text = _pmodel.GetCurrentUser();
        }

        public void InitializeCourseData() 
        {
            userId = _pmodel.GetCurrentUser();
            _courseList = _pmodel.GetProfessorOfferCourse(userId);
            for (int i = 0; i < _courseList.Count; i++) 
            {
                _cIdList.Add(_pmodel.getCourseIdByFlowCourseId(_courseList[i]));
                _cNameList.Add(_pmodel.getCourseNameByFlowCourseId(_courseList[i]));
            }
            SortCourseList(_cIdList, _cNameList);
        }

        public void InitializeCourseListGridView()
        {
            for (int i = 0; i < _courseList.Count; i++) 
            {
                _courseListDataGridView.Rows.Add();
                _courseListDataGridView.Rows[i].Cells[0].Value = i.ToString();
            }
        }

        public void RefreshCourseListGridView() 
        {
            _courseListDataGridView.Rows.Clear();
            InitializeCourseListGridView();
            for (int i = 0; i < _courseList.Count; i++) 
            {
                _courseListDataGridView.Rows[i].Cells[1].Value = _cIdList[i].ToString();
                _courseListDataGridView.Rows[i].Cells[1].Value = _cIdList[i].ToString();
            }
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

        private void CellClickCourseListDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 3) 
            {
                StudentList studentList = new StudentList(_pmodel,int.Parse(_courseListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()));
                studentList.ShowDialog();
            }
        }
    }
}
