using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseSystem
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Model model = new Model();
            Course_Model courseModel = new Course_Model();
            Professor_Model professorModel = new Professor_Model(courseModel);
            Student studentModel = new Student(courseModel);
            presentationModel PModel = new presentationModel(model,courseModel,professorModel,studentModel);
            Application.Run(new Form1(PModel));
        }
    }
}
