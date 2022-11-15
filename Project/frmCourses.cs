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
    public partial class frmCourses : Form
    {
        List<Course> courses = new List<Course>();
        DataHandler handler = new DataHandler();
        List<string> modCodes = new List<string>();
        public frmCourses()
        {
            InitializeComponent();
            courses = DataHandler.returnAllCourses();

            ///Inserting module codes into cbxModCodes
            modCodes = handler.getModCodes();
            foreach (string val in modCodes)
            {
                cbxCourseModCode.Items.Add(val);
                cbxResourseModCode.Items.Add(val);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchCourses_Click(object sender, EventArgs e)
        {

        }
    }
}
