using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class StudentHandler
    {
        List<Student> students = new List<Student>();

        internal List<Student> Students { get => students; }

        public StudentHandler()
        {
            students = DataHandler.returnAllStudents();
        }

        public Student SearchStudents(int studentNumber)
        {
            foreach (Student student in students)
            {
                if (student.StudentNo == studentNumber)
                {
                    return student;
                }
            }

            return null;
        }
        public void Insert(Student student)
        {
            students.Add(student);
            student.SaveStudent();
        }

        public void Remove(int studentIndex)
        {
            students[studentIndex].RemoveStudent();
            students.RemoveAt(studentIndex);
        }
        public void Update(Student student)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].StudentNo == student.StudentNo)
                {
                    students[i] = student;
                    students[i].UpdateStudent();
                }
            }
        }
    }
}
