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
        List<string> _tempDateList = new List<string>();
        List<string> _tempTimeList = new List<string>();
        List<string> _timeList = new List<string>();
        StringBuilder _classTime = new StringBuilder();
        DataTable _timeslice = new DataTable();
        presentationModel _pmodel;
        public AddCourse(presentationModel pmodel)
        {
            _pmodel = pmodel;
            InitializeComponent();
            InitializeGridView();
            InitializeDataTable();
        }

        /// <summary>
        /// 初始化datatable
        /// </summary>
        public void InitializeDataTable() 
        {
            _timeslice.Columns.Add(new DataColumn("date", typeof(string)));
            _timeslice.Columns.Add(new DataColumn("time", typeof(string)));
        }

        /// <summary>
        /// 初始化datagridview
        /// </summary>
        public void InitializeGridView()
        {
            _timeDataGridView.Rows.Clear();
            for (int i = 0; i < 5; i++)
            {
                _timeDataGridView.Rows.Add();
                _timeDataGridView.Rows[i].Cells[0].Value = i.ToString();
            }
        }

        /// <summary>
        /// 確認新增課程
        /// </summary>
        private void ClickOKButton(object sender, EventArgs e)
        {
            _pmodel.OfferCourse(_timeslice,_courseNameTextBox.Text,_courseIdTextBox.Text);
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// 取消新增課程
        /// </summary>
        private void ClickCancelButton(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        /// <summary>
        /// 新增課程到list裡
        /// </summary>
        private void ClickAddClassButton(object sender, EventArgs e)
        {
            if (_courseNameTextBox.Text == "") 
            {
                MessageBox.Show(this, "課程名稱不可為空!!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (_courseIdTextBox.Text == "") 
            {
                MessageBox.Show(this, "課號不可為空!!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (_dateComboBox.SelectedIndex==-1)
            {
                MessageBox.Show(this, "日期不可為空!!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (_ClassCheckedListBox.SelectedIndex == -1) 
            {
                MessageBox.Show(this, "節數不可為空!!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else //將課程時間暫存
            {
                for (int i = 0; i < _ClassCheckedListBox.CheckedItems.Count; i++)
                {
                    _tempTimeList.Add(_ClassCheckedListBox.CheckedItems[i].ToString());
                    _classTime.AppendLine(_ClassCheckedListBox.CheckedItems[i].ToString());
                }
                _tempDateList.Add(_dateComboBox.SelectedItem.ToString());
                _timeList.Add(_classTime.ToString());
                for (int i = 0; i < _tempTimeList.Count; i++)
                {
                    DataRow dr = _timeslice.NewRow();
                    dr["date"] = _tempDateList[0].ToString();
                    dr["time"] = _tempTimeList[i].ToString();
                    _timeslice.Rows.Add(dr);
                    
                }
                //Console.WriteLine(_timeslice.Rows[0].ItemArray[0]);
                RefreshDataGridView();
                _tempTimeList.Clear();
                _classTime.Clear();
            }
        }



        /// <summary>
        /// 刷新datagridview頁面
        /// </summary>
        public void RefreshDataGridView() 
        {

            InitializeGridView();
            if (_tempDateList.Count == 0) 
            {
                _timeDataGridView.Columns[3].Visible = false;
            }
            for (int i = 0; i < _tempDateList.Count; i++)
            {
                _timeDataGridView.Rows[i].Cells[1].Value = _tempDateList[i].ToString();
                _timeDataGridView.Rows[i].Cells[2].Value = _timeList[i].ToString();
            }
            _timeDataGridView.Columns[3].Visible = true;
            
        }

        /// <summary>
        /// 刪除list裡面的課程表
        /// </summary>
        private void ClickTimeDataGridViewCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 ) 
            {
                DialogResult dr = MessageBox.Show(this, "是否確定刪除", "警告", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK) 
                {
                    foreach(DataRow da in _timeslice.Rows)
                    {
                        if (Convert.ToInt32(da[0]) == e.RowIndex) 
                        {
                            da.Delete();
                        }
                    }
                    _timeDataGridView.Rows.RemoveAt(e.RowIndex);
                    _tempDateList.RemoveAt(e.RowIndex);
                    _timeList.RemoveAt(e.RowIndex);
                    RefreshDataGridView();
                }
            }
        }
    }
}
