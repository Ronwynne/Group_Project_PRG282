using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmMain : Form
    {
        List<Student> students = new List<Student>();
        public frmMain()
        {
            InitializeComponent();
            students = DataHandler.returnAllStudents();

            frmLogin login = new frmLogin();
            if (login.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            frmCourses courses = new frmCourses();
            courses.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
