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
    public partial class OfferCourse : Form
    {
        List<string> _tempDateList = new List<string>();
        List<string> _tempTimeList = new List<string>();
        presentationModel _pmodel;
        public OfferCourse(presentationModel pmodel)
        {
            _pmodel = pmodel;
            InitializeComponent();
            InitializeGridView();
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
            string userId = _pmodel.GetCurrentUser();
            _pmodel.OfferCourse(_tempDateList,_tempTimeList,_courseNameTextBox.Text,_courseIdTextBox.Text,userId);
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
                    int flag = 0;
                    for (int j = 0; j < _tempDateList.Count; j++) 
                    {
                        if (_tempDateList[j] == _dateComboBox.SelectedItem.ToString() && _tempTimeList[j] == _ClassCheckedListBox.CheckedItems[i].ToString())
                        {
                            flag = 1;
                        }
                    }
                    if (flag != 1)
                    {
                        _tempDateList.Add(_dateComboBox.SelectedItem.ToString());
                        _tempTimeList.Add(_ClassCheckedListBox.CheckedItems[i].ToString());
                    }
                }
                RefreshDataGridView();;
                //for (int i = 0; i < _ClassCheckedListBox.CheckedItems.Count; i++) 
                //{
                //    _ClassCheckedListBox.SetItemChecked(i, false);
                //}
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
                _timeDataGridView.Rows[i].Cells[2].Value = _tempTimeList[i].ToString();
            }
            _timeDataGridView.Columns[3].Visible = true;
            
        }

        /// <summary>
        /// 刪除list裡面的課程表
        /// </summary>
        private void ClickTimeDataGridViewCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 3 ) 
            {
                DialogResult dr = MessageBox.Show(this, "是否確定刪除", "警告", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK) 
                {
                    _timeDataGridView.Rows.RemoveAt(e.RowIndex);
                    _tempDateList.RemoveAt(e.RowIndex);
                    _tempTimeList.RemoveAt(e.RowIndex);
                    RefreshDataGridView();
                    Console.WriteLine(_tempDateList);
                    Console.WriteLine(_tempTimeList);
                }
            }
        }
    }
}
