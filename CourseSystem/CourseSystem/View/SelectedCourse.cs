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
    public partial class SelectedCourse : Form
    {
        DataTable _userMapCourseList = new DataTable();
        List<int> _pIdList = new List<int>();
        List<int> _cIdList = new List<int>();
        List<string> _cNameList = new List<string>();
        List<int> _studentSelectCId = new List<int>();
        List<int> _studentSelectPId = new List<int>();
        List<string> _studentSelectCName = new List<string>();
        presentationModel _pmodel;
        public SelectedCourse(presentationModel pmodel)
        {
            _pmodel = pmodel;
            InitializeComponent();
            _showStudentNameLabel.Text = _pmodel.GetCurrentUser();
            initializeCourseData();
            RefreshSelectCourseGridView();
            RefreshStudentSelectCourseGridView();

        }

        public void initializeCourseData() 
        {
            _userMapCourseList = _pmodel.GetCourseList();
            foreach (DataRow dr in _userMapCourseList.Rows) 
            {
                _pIdList.Add(int.Parse(dr[1].ToString()));
                _cIdList.Add(_pmodel.getCourseIdByFlowCourseId(int.Parse(dr[2].ToString())));
                _cNameList.Add(_pmodel.getCourseNameByFlowCourseId(int.Parse(dr[2].ToString())));
            }
        }

        public void initializeSelectCourseGridView() 
        {
            _courseDataGridView.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                _courseDataGridView.Rows.Add();
                _courseDataGridView.Rows[i].Cells[0].Value = i.ToString();
            }
        }

        public void initializeStudentSelectCourseGridView() 
        {
            _studentSelectCourseDataGridView.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                _studentSelectCourseDataGridView.Rows.Add();
                _studentSelectCourseDataGridView.Rows[i].Cells[0].Value = i.ToString();
            }
        }

        public void RefreshSelectCourseGridView() 
        {
            SortCourseList(_cIdList, _pIdList, _cNameList);
            initializeSelectCourseGridView();
            for (int i = 0; i < _pIdList.Count; i++) 
            {
                _courseDataGridView.Rows[i].Cells[1].Value = _cIdList[i].ToString();
                _courseDataGridView.Rows[i].Cells[2].Value = _cNameList[i].ToString();
                _courseDataGridView.Rows[i].Cells[3].Value = _pIdList[i].ToString();
            }
            //Console.WriteLine(_cIdList[0]);
            //Console.WriteLine(_cIdList[1]);
            _courseDataGridView.Columns[4].Visible = true;
        }

        public void RefreshStudentSelectCourseGridView() 
        {
            //SortCourseList(_studentSelectCId, _studentSelectPId, _studentSelectCName);
            initializeStudentSelectCourseGridView();
            for (int i = 0; i < _studentSelectCId.Count; i++) 
            {
                _studentSelectCourseDataGridView.Rows[i].Cells[1].Value = _studentSelectCId[i].ToString();
                _studentSelectCourseDataGridView.Rows[i].Cells[2].Value = _studentSelectCName[i].ToString();
                _studentSelectCourseDataGridView.Rows[i].Cells[3].Value = _studentSelectPId[i].ToString();
            }
            _studentSelectCourseDataGridView.Columns[4].Visible = true;
        }

        private void ClickCourseDataGridViewCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 4)
            {
                DialogResult dr = MessageBox.Show(this, "是否確定加選", "警告", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK) 
                {
                    _studentSelectCName.Add(_cNameList[e.RowIndex]);
                    _studentSelectCId.Add(_cIdList[e.RowIndex]);
                    _studentSelectPId.Add(_pIdList[e.RowIndex]);
                    _courseDataGridView.Rows.RemoveAt(e.RowIndex);
                    _cIdList.RemoveAt(e.RowIndex);
                    _pIdList.RemoveAt(e.RowIndex);
                    _cNameList.RemoveAt(e.RowIndex);
                    RefreshSelectCourseGridView();
                    RefreshStudentSelectCourseGridView();
                }
            }
        }

        private void ClickStudentSelectCourseDataGridViewCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 4)
            {
                DialogResult dr = MessageBox.Show(this, "是否確定取消加選", "警告", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK) 
                {
                    _cIdList.Add(_studentSelectCId[e.RowIndex]);
                    _cNameList.Add(_studentSelectCName[e.RowIndex]);
                    _pIdList.Add(_studentSelectPId[e.RowIndex]);
                    _studentSelectPId.RemoveAt(e.RowIndex);
                    _studentSelectCName.RemoveAt(e.RowIndex);
                    _studentSelectCId.RemoveAt(e.RowIndex);
                    RefreshStudentSelectCourseGridView();
                    RefreshSelectCourseGridView();
                }
            }
        }

        ///
        /// 排序課號
        ///
        public void SortCourseList(List<int> cIdList,List<int> pIdList,List<string>cNameList) 
        {
            int itemp;
            string stemp;
            for (int i = 0; i < cIdList.Count; i++) 
            {
                for (int j = i + 1; j < cIdList.Count; j++) 
                {
                    if (cIdList[i] > cIdList[j]) 
                    {
                        itemp = _cIdList[i];
                        _cIdList[i] = _cIdList[j];
                        _cIdList[j] = itemp;

                        itemp = _pIdList[i];
                        _pIdList[i] = _pIdList[j];
                        _pIdList[j] = itemp;

                        stemp = _cNameList[i];
                        _cNameList[i] = _cNameList[j];
                        _cNameList[j] = stemp;
                    }
                }
            }
        }



    }
}
