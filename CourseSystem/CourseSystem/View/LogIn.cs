using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CourseSystem.View
{

    public partial class LogIn : Form
    {
        Model _model = new Model();
        private string SQL;
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

            try
            {
              if (_pmodel.CreateUser(_userId, _userPwd) == true)
                {                   
                    MessageBox.Show(this, "User Exist!!", "Login Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
              else
              {
                  MessageBox.Show(this, "Done!!", "Login Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  this.Close();
              }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
