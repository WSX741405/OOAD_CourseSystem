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
    public partial class AddCourse : Form
    {
        List<string> _dateList = new List<string>();
        List<string> _timeList = new List<string>();
        StringBuilder _classTimeList = new StringBuilder();
        presentationModel _pmodel;
        public AddCourse(presentationModel pmodel)
        {
            _pmodel = pmodel;
            InitializeComponent();
            InitializeGridView();
        }

        private void ClickOKButton(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ClickCancelButton(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        /// <summary>
        /// 新增課程到list裡
        /// </summary>
        private void ClickAddClassButton(object sender, EventArgs e)
        {
            for (int i = 0; i < _ClassCheckedListBox.CheckedItems.Count; i++) 
            {
                _classTimeList.AppendLine(_ClassCheckedListBox.CheckedItems[i].ToString());
            }
            _dateList.Add(_dateComboBox.SelectedItem.ToString());
            _timeList.Add(_classTimeList.ToString());
            RefreshDataGridView();
            _classTimeList.Clear();
        }

        public void InitializeGridView() 
        {
            for (int i = 0; i < 5; i++)
            {
                _timeDataGridView.Rows.Add();
                _timeDataGridView.Rows[i].Cells[0].Value = i.ToString();
            }
        }

        public void RefreshDataGridView() 
        {       
            for (int i = 0; i < _dateList.Count; i++) 
            {
                _timeDataGridView.Rows[i].Cells[1].Value = _dateList[i].ToString();
                _timeDataGridView.Rows[i].Cells[2].Value = _timeList[i].ToString();       
            }
        }
    }
}
