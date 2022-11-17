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
        CourseHandler cHandler = new CourseHandler();
        BindingSource cSource;
        bool insert;

        public frmCourses()
        {
            InitializeComponent();
        }

        private void LoadCourseDetails(int index)
        {
            txtModCode.Enabled = false;
            txtModCode.Text = cHandler.Courses[index].Code;
            txtCourseName.Text = cHandler.Courses[index].Name;
            rtbDesc.Text = cHandler.Courses[index].Description;
            dgvResources.ColumnCount = 1;
            dgvResources.Columns[0].Width = 350;
            dgvResources.Columns[0].Name = "Resource link";
            dgvResources.Rows.Clear();
            foreach (string item in cHandler.Courses[index].courseResourses)
            {
                dgvResources.Rows.Add(item);
            }
            btnDeleteCourse.Show();
            btnInsertCourse.Show();
            insert = false;
        }

        private void ClearCourseDetails()
        {
            txtModCode.Enabled = true;
            txtModCode.Text = "";
            txtCourseName.Text = "";
            rtbDesc.Text = "";
            btnDeleteCourse.Hide();
            btnInsertCourse.Hide();
            insert = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCourses_Load(object sender, EventArgs e)
        {
            cSource = new BindingSource(cHandler.Courses, null);
            dgvCourses.DataSource = cSource;
            dgvCourses.Columns[2].Width = 350;
        }

        private void btnNextCourse_Click(object sender, EventArgs e)
        {
            cSource.MoveNext();
        }

        private void btnPrevCourse_Click(object sender, EventArgs e)
        {
            cSource.MovePrevious();
        }

        private void btnFirstCourse_Click(object sender, EventArgs e)
        {
            cSource.MoveFirst();
        }

        private void btnLastCourse_Click(object sender, EventArgs e)
        {
            cSource.MoveLast();
        }

        private void dgvCourses_SelectionChanged(object sender, EventArgs e)
        {
            if (cSource != null)
            {
                LoadCourseDetails(dgvCourses.CurrentRow.Index);
            }
            else
            {
                ClearCourseDetails();
            }
        }

        private void txtSearchCourse_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchCourse.Text != "")
            {
                Course searchResult = cHandler.SearchCourses(txtSearchCourse.Text);
                if (searchResult != null)
                {
                    cSource = new BindingSource(searchResult, null);
                    dgvCourses.DataSource = cSource;
                    dgvCourses.Columns[2].Width = 350;
                    LoadCourseDetails(cHandler.Courses.IndexOf(searchResult));
                }
                else
                {
                    cSource = null;
                    dgvCourses.DataSource = cSource;
                }
            }
            else
            {
                cSource = new BindingSource(cHandler.Courses, null);
                dgvCourses.DataSource = cSource;
                dgvCourses.Columns[2].Width = 350;
            }
        }

        private void btnResourceFirst_Click(object sender, EventArgs e)
        {
            if (dgvResources.Rows.Count > 0)
            {
                dgvResources.CurrentCell = dgvResources.Rows[0].Cells[0];
            }
        }

        private void btnResourceLast_Click(object sender, EventArgs e)
        {
            if (dgvResources.Rows.Count > 0)
            {
                dgvResources.CurrentCell = dgvResources.Rows[dgvResources.Rows.Count - 1].Cells[0];
            }
        }

        private void btnResourcePrev_Click(object sender, EventArgs e)
        {
            if ((dgvResources.Rows.Count > 0) && (dgvResources.CurrentRow.Index > 0))
            {
                dgvResources.CurrentCell = dgvResources.Rows[dgvResources.CurrentRow.Index - 1].Cells[0];
            }
        }

        private void btnResourceNext_Click(object sender, EventArgs e)
        {
            if ((dgvResources.Rows.Count > 0) && (dgvResources.CurrentRow.Index < dgvResources.Rows.Count - 1))
            {
                dgvResources.CurrentCell = dgvResources.Rows[dgvResources.CurrentRow.Index + 1].Cells[0];
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure wish to remove this course?", "Confirm", MessageBoxButtons.YesNoCancel, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cHandler.Remove(dgvCourses.CurrentRow.Index);
                cSource = new BindingSource(cHandler.Courses, null);
                dgvCourses.DataSource = cSource;
            }
        }

        private void btnInsertCourse_Click(object sender, EventArgs e)
        {
            ClearCourseDetails();
            txtModCode.Focus();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string modCode = txtModCode.Text;
            string modName = txtCourseName.Text;
            string modDesc = rtbDesc.Text;

            if (insert)
            {
                cHandler.Insert(new Course(modCode, modName, modDesc));
                cSource = new BindingSource(cHandler.Courses, null);
                dgvCourses.DataSource = cSource;
                dgvCourses.CurrentCell = dgvCourses.Rows[cHandler.Courses.Count - 1].Cells[0];
                LoadCourseDetails(dgvCourses.CurrentRow.Index);
                MessageBox.Show("Course successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cHandler.Update(new Course(modCode, modName, modDesc));
                cSource = new BindingSource(cHandler.Courses, null);
                dgvCourses.DataSource = cSource;
                MessageBox.Show("Changes successfully made.", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveResource_Click(object sender, EventArgs e)
        {
            string url = txtLink.Text;
            cHandler.Courses[dgvCourses.CurrentRow.Index].AddCourseResourse(url);
            LoadCourseDetails(dgvCourses.CurrentRow.Index);
            MessageBox.Show("Resource added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtLink.Text = "";
        }

        private void btnDeleteResource_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to remove this resource?", "Confirm", MessageBoxButtons.YesNoCancel, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string url = dgvResources.Rows[dgvResources.CurrentRow.Index].Cells[0].Value.ToString();
                cHandler.Courses[dgvCourses.CurrentRow.Index].RemoveCourseResourse(url);
                LoadCourseDetails(dgvCourses.CurrentRow.Index);
                MessageBox.Show("Resource successfully removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
