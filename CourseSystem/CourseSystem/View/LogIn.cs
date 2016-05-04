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
            
            //string SQL;
            //string connectionString = "Data Source=127.0.0.1; User ID=root; Password=; database=test";

            //SqlParameter[] prams = {
            //    SqlHelper.MakeInParam("@userId", SqlDbType.VarChar, 999, _userId)
            //};
            //SQL = "INSERT INTO user VALUES(@userId,@password)";
            //SqlHelper.ExecuteNonQuery(connectionString, CommandType.Text, SQL, prams);
            try
            {
              if( _model.CreateUser(_userId))
                  _userIdTextBox.Text = "OK";
               /* if (_pmodel.CreateUser(_userId) == true)
                {
                   
                    MessageBox.Show(this, "User Exist!!", "Login Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
