using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Student
    {
        private int studentNo;
        private string firstName;
        private string lastName;
        private string gender;
        private DateTime dob;
        private string phone;
        private string address;
        private byte[] picture;
        private DataHandler handler = new DataHandler();

        public List<Course> studentCourses = new List<Course>();

        public int StudentNo { get => studentNo; set => studentNo = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public byte[] Picture { get => picture; set => picture = value; }

        public Student(int studentNo, string firstName, string lastName, string gender, DateTime dob, string phone, 
                        string address, byte[] picture)
        {
            this.StudentNo = studentNo;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.Dob = dob;
            this.Phone = phone;
            this.Address = address;
            this.Picture = picture;
            this.studentCourses = handler.returnStudentCourses(this.studentNo);
        }

        public Student(int studentNo, string firstName, string lastName, string gender, DateTime dob, string phone,
                string address, string picturePath)
        {
            this.StudentNo = studentNo;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.Dob = dob;
            this.Phone = phone;
            this.Address = address;
            this.Picture = System.IO.File.ReadAllBytes(picturePath);
            this.studentCourses = handler.returnStudentCourses(this.studentNo);
        }

        public void SaveStudent()
        {
            handler.Insert(this);
        }

        public void AddStudentCourse(string course)
        { 
            handler.AddStudentCourse(this, course);
        }

        
        public void UpdateStudent()
        {
            handler.Update(this);
        }

        public void Remove(int studentID)
        {
            handler.RemoveStudent(studentID);
        }
    }
}
