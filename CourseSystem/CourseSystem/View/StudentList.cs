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
    public partial class StudentList : Form
    {
        List<string> _studentName = new List<string>();
        List<int> _userId = new List<int>();
        int _courseId;
        presentationModel _pmodel;
        public StudentList(presentationModel pmodel,int courseId)
        {
            _courseId =courseId;
            _pmodel = pmodel;
            InitializeComponent();
            InitializeSudentList();
            InitializeGridView();
        }

        public void InitializeSudentList() 
        {
            _studentName.Clear();
            _studentName=_pmodel.GetStudentIdFromCourseId(_courseId);
        }

        public void InitializeGridView() 
        {
            for (int i = 0; i < _studentName.Count; i++) 
            {
                _studentListDataGridView.Rows.Add();
                _studentListDataGridView.Rows[i].Cells[0].Value = i.ToString();
                _studentListDataGridView.Rows[i].Cells[1].Value = _studentName[i];
            }
        }

        private void ClickOKButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
