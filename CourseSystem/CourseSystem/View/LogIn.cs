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
        private string SQL;
        private string _userId;
        private string _userPwd;
        PModel _pmodel;
        public LogIn()
        {
            InitializeComponent();
        }

        private void ClickLogInOKButton(object sender, EventArgs e)
        {
            _userId = _userIdTextBox.Text;
            _userPwd = _userPwdTextBox.Text;
            if (_pmodel.FindUser(_userId) == false)
            {
                _pmodel.InseretIntoDatabase(SQL);
            }
            else 
            {
                MessageBox.Show(this, "User Exist!!", "Login Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
