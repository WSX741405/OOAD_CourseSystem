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

    public partial class Register : Form
    {
        private bool _success = false;
        private string _userId;
        private string _userPwd;
        private string _userIdentity;
        presentationModel _pmodel;
        public Register(presentationModel pModel)
        {
            _pmodel = pModel;
            InitializeComponent();
        }

        private void ClickRegisterOKButton(object sender, EventArgs e)
        {
            _userId = _userIdTextBox.Text;
            _userPwd = _userPwdTextBox.Text;
            _userIdentity = _userComboBox.Text;
            if (_userId != "" && _userId != null && _userPwd != "" && _userPwd != null && _userIdentity != null && _userIdentity != "")
            {
                try
                {
                    if (_pmodel.CreateUser(_userId, _userPwd,_userIdentity) == true)
                    {
                        MessageBox.Show(this, "已存在的使用者Id!!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(this, "註冊成功!!", "成功", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                        _success = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                MessageBox.Show(this, "使用者Id、密碼或使用者身分不得為空!!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClickRegisterCancelButton(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool CheckSuccessOrNot()
        {
            return _success;
        }

        private void TextChangeduserPwdTextBox(object sender, EventArgs e)
        {
            _userPwdTextBox.PasswordChar = '*';
        }
    }
}
