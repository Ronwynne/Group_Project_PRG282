using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class frmStudents : Form
    {
        StudentHandler sHandler = new StudentHandler();
        CourseHandler cHandler = new CourseHandler();
        BindingSource sSource;
        BindingSource cSource;
        bool insert;
        public frmStudents()
        {
            InitializeComponent();
        }

        private void LoadStudentDetails(int index)
        {
            txtStudentNo.Text = sHandler.Students[index].StudentNo.ToString();
            txtStudentNo.Enabled = false;
            txtName.Text = sHandler.Students[index].FirstName;
            txtSurname.Text = sHandler.Students[index].LastName;
            lbxGender.Text = sHandler.Students[index].Gender;
            ofdStudentPic.FileName = "";
            using (MemoryStream stream = new MemoryStream(sHandler.Students[index].Picture))
            {
                pbxStudentImage.Image = Image.FromStream(stream);
            }
            dtpDOB.Value = sHandler.Students[index].Dob;
            txtPhone.Text = sHandler.Students[index].Phone;
            txtHomeAddress.Text = sHandler.Students[index].Address;
            cSource = new BindingSource(sHandler.Students[index].studentCourses, null);
            dgvStudentCourses.DataSource = cSource;

            lbxModCode.Items.Clear();
            foreach (Course course in cHandler.returnAvailableCourses(sHandler.Students[index]))
            {
                lbxModCode.Items.Add(course.Code);
            }

            btnRemove.Show();
            btnInsertNew.Show();
            dgvStudents.Enabled = true;
            dgvStudentCourses.Enabled = true;
            lbxModCode.Enabled = true;
            btnAddStudentModule.Enabled = true;
            btnRemoveStudentModule.Enabled = true;
            insert = false;
        }

        private void ClearStudentDetails()
        {
            txtStudentNo.Text = "";
            txtStudentNo.Enabled = true;
            txtName.Text = "";
            txtSurname.Text = "";
            lblGender.Text = "";
            pbxStudentImage.Image = null;
            dtpDOB.Value = DateTime.Now;
            txtPhone.Text = "";
            txtHomeAddress.Text = "";
            btnRemove.Hide();
            btnInsertNew.Hide();
            lbxModCode.Enabled = false;
            btnAddStudentModule.Enabled = false;
            btnRemoveStudentModule.Enabled = false;
            cSource.DataSource = null;
            insert = true;
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (new frmLogin().ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }

            sSource = new BindingSource(sHandler.Students, null);
            dgvStudents.DataSource = sSource;
            dgvStudents.Columns.RemoveAt(7);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                ofdStudentPic.ShowDialog();
                pbxStudentImage.Image = new Bitmap(ofdStudentPic.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error occured",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            sSource.MoveNext();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            sSource.MovePrevious();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            sSource.MoveFirst();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            sSource.MoveLast();
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (sSource.DataSource != null)
            {
                LoadStudentDetails(dgvStudents.CurrentRow.Index);
            }
            else
            {
                ClearStudentDetails();
            }
        }

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            if ((txtSearchStudent.Text != ""))
            {
                Student searchResult = sHandler.SearchStudents(int.Parse(txtSearchStudent.Text));
                if (searchResult != null)
                {
                    sSource.DataSource = new BindingSource(searchResult, null);
                    dgvStudents.Columns.RemoveAt(7);
                    LoadStudentDetails(sHandler.Students.IndexOf(searchResult));
                }
                else
                {
                    sSource.DataSource = null;
                }
            }
            else
            {
                sSource.DataSource = new BindingSource(sHandler.Students, null);
                dgvStudents.Columns.RemoveAt(7);
            }
        }

        private void btnFirstStudentCourse_Click(object sender, EventArgs e)
        {
            cSource.MoveFirst();
        }

        private void btnLastStudentCourse_Click(object sender, EventArgs e)
        {
            cSource.MoveLast();
        }

        private void btnPrevStudentCourse_Click(object sender, EventArgs e)
        {
            cSource.MovePrevious();
        }

        private void btnNextStudentCourse_Click(object sender, EventArgs e)
        {
            cSource.MoveNext();
        }

        private void btnInsertNew_Click(object sender, EventArgs e)
        {
            ClearStudentDetails();
            txtStudentNo.Focus();
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            int studentNo = int.Parse(txtStudentNo.Text);
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string gender = lbxGender.Text;
            DateTime dob = dtpDOB.Value;
            string phone = txtPhone.Text;
            string address = txtHomeAddress.Text;
            string picturePath = ofdStudentPic.FileName;

            if (insert)
            {
                sHandler.Insert(new Student(studentNo, name, surname, gender, dob, phone, address, picturePath));
                sSource.DataSource = new BindingSource(sHandler.Students, null);
                dgvStudents.Columns.RemoveAt(7);
                dgvStudents.CurrentCell = dgvStudents.Rows[sHandler.Students.Count - 1].Cells[0];
                LoadStudentDetails(sHandler.Students.Count - 1);
                MessageBox.Show("Student has successfully been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (ofdStudentPic.FileName == "")
                {
                    Student student = sHandler.SearchStudents(int.Parse(dgvStudents.CurrentRow.Cells[0].Value.ToString()));
                    byte[] img = student.Picture;
                    sHandler.Update(new Student(studentNo, name, surname, gender, dob, phone, address, img));
                }
                else
                {
                    sHandler.Update(new Student(studentNo, name, surname, gender, dob, phone, address, picturePath));
                }
                sSource.DataSource = new BindingSource(sHandler.Students, null);
                dgvStudents.Columns.RemoveAt(7);
                MessageBox.Show("Changes successfully made.", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to delete this student?", "Confirm", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sHandler.Remove(dgvStudents.CurrentRow.Index);
                sSource.DataSource = new BindingSource(sHandler.Students, null);
                dgvStudents.Columns.RemoveAt(7);
            }
        }

        private void btnAddStudentModule_Click(object sender, EventArgs e)
        {
            Course course = cHandler.SearchCourses(lbxModCode.Text);
            sHandler.Students[dgvStudents.CurrentRow.Index].AddStudentCourse(course);
            cSource = new BindingSource(sHandler.Students[dgvStudents.CurrentRow.Index].studentCourses, null);
            dgvStudentCourses.DataSource = cSource;
            lbxModCode.Items.Clear();
            lbxModCode.Text = "";
            foreach (Course c in cHandler.returnAvailableCourses(sHandler.Students[dgvStudents.CurrentRow.Index]))
            {
                lbxModCode.Items.Add(c.Code);
            }

            MessageBox.Show("Module successfully added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemoveStudentModule_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to remove this subject from the student's list?", "Confirmation",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Course course = cHandler.SearchCourses(dgvStudentCourses.CurrentRow.Cells[0].Value.ToString());
                sHandler.Students[dgvStudents.CurrentRow.Index].RemoveStudentCourse(course);
                cSource = new BindingSource(sHandler.Students[dgvStudents.CurrentRow.Index].studentCourses, null);
                dgvStudentCourses.DataSource = cSource;
            }
        }

        private void dgvStudentCourses_SelectionChanged(object sender, EventArgs e)
        {
            if (sSource.DataSource != null)
            {
                btnRemoveStudentModule.Enabled = true;
            }
            else
            {
                btnRemoveStudentModule.Enabled = false;
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnManageCourses_Click(object sender, EventArgs e)
        {
            new frmCourses().Show();
        }
    }
}
