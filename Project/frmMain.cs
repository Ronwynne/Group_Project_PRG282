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
        DataHandler handler = new DataHandler();
        Validation val = new Validation();
        BindingSource ssource = new BindingSource();
        BindingSource csource = new BindingSource();
        public List<string> modCodes = new List<string>();

        // Method to clear the componets used to get user input
        public void clearComponents()
        {
            txtHomeAddress.Clear();
            txtPhone.Clear();
            txtName.Clear();
            txtSurname.Clear(); 
            txtImgPath.Clear();
            txtHomeAddress.Clear();
            lbxGender.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Parse("01/01/2000");
            cbxNewStudent.Checked = false; 
        }
        public void fillComponents()
        {
            if (ssource.Position >= 0)
            {
                DataGridViewRow row = this.dgvStudents.Rows[ssource.Position];

                txtStudentNo.Text = row.Cells["StudentNumber"].Value.ToString();
                txtName.Text = row.Cells["FirstName"].Value.ToString();
                txtSurname.Text = row.Cells["LastName"].Value.ToString();
                lbxGender.Text = row.Cells["Gender"].Value.ToString();
                string date = row.Cells["StudentDOB"].Value.ToString();
                string[] splits = date.Split('-');
                dtpDOB.Value = DateTime.Parse(splits[1] + "/" + splits[0] + "/" + splits[2]);
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtHomeAddress.Text = row.Cells["Address_"].Value.ToString();
                txtImgPath.Text = row.Cells["ImgPath"].Value.ToString();
            }
        }
        public frmMain()
        {
            InitializeComponent();
            students = handler.returnAllStudents();

            
            lbxGender.Items.Add("Female");
            lbxGender.Items.Add("Male");

            frmLogin login = new frmLogin();
            if (login.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ssource.DataSource = handler.returnAllStudents();

            dgvStudents.DataSource = ssource;

            List<string> coursesList = new List<string>();

            coursesList = handler.returnModCodes();

            foreach (string item in coursesList)
            {
                cbxModCode.Items.Add(item);
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

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            int studentID = int.Parse(dgvStudents.SelectedCells[0].ToString());
            string studentName = dgvStudents.SelectedCells[1].ToString();
            DialogResult dialogResult = MessageBox.Show("Warning", "Are you sure you want to delete the student: " + studentName + "'s data", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                handler.RemoveStudent(studentID);
                MessageBox.Show("Record deleted.");
            }

        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            if (cbxNewStudent.Checked)
            {
                ///////////////////////Insert.//////////////////////////////////
                lblStudentNo.Visible = false;
                txtStudentNo.Visible = false;

                List<Student> students = new List<Student>();
                students = handler.returnAllStudents();

                int studentID = students.Count + 1;
                string studentName = txtName.Text;
                string Surname = txtSurname.Text;
                string gender = lbxGender.Text;
                DateTime dob = dtpDOB.Value;
                string address = txtHomeAddress.Text;
                byte[] img = new byte[] { byte.Parse(txtImgPath.Text) };
                string course = cbxModCode.Text;
                string phone = txtPhone.Text;
                ///= validation
                if (val.studentDataValidation(studentID, studentName, Surname, gender, dob, phone, address, img,course) == false)
                {
                    MessageBox.Show("Please enter all the information");
                }
                else
                {
                    if (val.IsPhoneNbr(phone) == true)
                    {
                        Student student = new Student(studentID, studentName, Surname, gender, dob, phone, address, img);
                        handler.Insert(student);
                        handler.AddStudentCourse(student, course);
                    }
                    else
                    {
                        MessageBox.Show("Invalid phone number please enter correct number");
                        txtPhone.Clear();
                        txtPhone.Focus();
                    }
                }
                
            }
            else
            {
                /////////////Update//////////////////////////////
                int studentID = int.Parse(txtStudentNo.Text);
                string studentName = txtName.Text;
                string Surname = txtSurname.Text;
                string gender = lbxGender.Text;
                DateTime dob = dtpDOB.Value;
                string address = txtHomeAddress.Text;
                byte[] img = new byte[] { byte.Parse(txtImgPath.Text) };
                string course = cbxModCode.Text;
                string phone = txtPhone.Text;
                ///phone validation
                ///
                if (val.studentDataValidation(studentID, studentName, Surname, gender, dob, phone, address, img, course) == false)
                {
                    MessageBox.Show("Please enter all the information");
                }
                else
                {
                    if (val.IsPhoneNbr(phone) == true)
                    {
                        Student student = new Student(studentID, studentName, Surname, gender, dob, phone, address, img);
                        handler.Update(student);
                        handler.AddStudentCourse(student, course);
                    }
                    else
                    {
                        MessageBox.Show("Invalid phone number please enter correct number");
                        txtPhone.Clear();
                        txtPhone.Focus();
                    }
                }
                

               
            }
                
        }

        private void btnDeleteCourseForStudent_Click(object sender, EventArgs e)
        {
            int studentID = int.Parse(dgvStudentCourses.SelectedCells[0].ToString());
            string course = dgvStudentCourses.SelectedCells[1].ToString();

            DialogResult dialogResult = MessageBox.Show("Warning", "Are you sure you want to delete the student course: " + studentID.ToString() + "and module code:" + course + "?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                handler.RemoveStudentCourse(studentID, course);
                MessageBox.Show("Record deleted.");
            }

           
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            int studentID = int.Parse(txtSearchStudent.Text);
            List<Student> student = new List<Student>;
            student = handler.returSearchStudents(studentID);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            ssource.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            ssource.MovePrevious(); 
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ssource.MoveNext(); 
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            ssource.MoveLast();
        }

        private void btnFirstStudentCourse_Click(object sender, EventArgs e)
        {
            csource.MoveFirst();
        }

        private void btnPrevStudentCourse_Click(object sender, EventArgs e)
        {
            csource.MovePrevious();
        }

        private void btnNextStudentCourse_Click(object sender, EventArgs e)
        {
            csource.MoveNext();
        }

        private void btnLastStudentCourse_Click(object sender, EventArgs e)
        {
            csource.MoveLast();
        }

        private void cbxNewStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNewStudent.Checked == true)
            {
                clearComponents();
            }

            if (cbxNewStudent.Checked == false)
            {
                fillComponents();
            }
        }
    }
}
