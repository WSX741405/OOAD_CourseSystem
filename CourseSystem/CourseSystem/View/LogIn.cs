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
    public partial class LogIn : Form
    {
        private string _userId;
        private string _userPwd;
        PModel _pmodel = new PModel();
        public LogIn()
        {
            InitializeComponent();
        }

        private void ClickLogInOKButton(object sender, EventArgs e)
        {
            _userId = _userIdTextBox.Text;
            _userPwd = _userPwdTextBox.Text;

            _userId = _userIdTextBox.Text;
            _userPwd = _userPwdTextBox.Text;

            if (_userId != "" && _userId != null && _userPwd != "" && _userPwd != null)
            {
                try
                {
                    if (_pmodel.LogIn(_userId, _userPwd).Equals("Wrong"))
                    {
                        MessageBox.Show(this, "使用者Id或密碼輸入錯誤!!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (_pmodel.LogIn(_userId, _userPwd).Equals("None"))
                    {
                        MessageBox.Show(this, "查無此使用者Id!!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(this, "登入成功!!", "成功", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                MessageBox.Show(this, "使用者Id或密碼不得為空!!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void ClickLogInCancelButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
