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
        presentationModel _pmodel;
        public AddCourse(presentationModel pmodel)
        {
            _pmodel = pmodel;
            InitializeComponent();
        }

        private void ClickOKButton(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ClickCancelButton(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
