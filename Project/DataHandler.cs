using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Project
{
    class DataHandler
    {
        private static string connectionString = @"Server=.; Database=BC_STUDENTS; Integrated Security=SSPI";
        private static string commandText;
        private static SqlConnection conn = new SqlConnection(connectionString);
        private static SqlCommand cmd = new SqlCommand("", conn);
        public DataHandler()
        {

        }

        public void Insert(Student student)
        {
            cmd.Parameters.Clear();
            commandText = "INSERT INTO Students(StudentNumber, FirstName, LastName, Gender, StudentDOB, Phone, HomeAddress, Picture) " +
                            "VALUES (@studentNo, @firstName, @lastName, @Gender, @StudentDOB, @phone, @address, @picture)";
            cmd.Parameters.Add("@studentNo", SqlDbType.Int).Value = student.StudentNo;
            cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 40).Value = student.FirstName;
            cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 80).Value = student.LastName;
            cmd.Parameters.Add("@Gender", SqlDbType.VarChar, 14).Value = student.Gender;
            cmd.Parameters.Add("@StudentDOB", SqlDbType.Date).Value = student.Dob;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar, 10).Value = student.Phone;
            cmd.Parameters.Add("@address", SqlDbType.VarChar, 100).Value = student.Address;
            cmd.Parameters.Add("@picture", SqlDbType.Image).Value = student.Picture;
            cmd.CommandText = commandText;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Insert(Course course)
        {
            cmd.Parameters.Clear();
            commandText = "INSERT INTO Courses(ModCode, ModName, ModDesc) VALUES " + 
                            "(@modCode, @modName, @modDesc)";
            cmd.Parameters.Add("@modCode", SqlDbType.Char, 6).Value = course.Code;
            cmd.Parameters.Add("@modName", SqlDbType.VarChar, 50).Value = course.Name;
            cmd.Parameters.Add("@modDesc", SqlDbType.VarChar, 200).Value = course.Description;
            cmd.CommandText = commandText;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Insert(int resourceID, string url, string modCode)
        {
            cmd.Parameters.Clear();
            commandText = "INSERT INTO Resources(ResourceID, Link, Module) VALUES" +
                            "(@resourceID, @url, @modCode)";
            cmd.Parameters.Add("@resourceID", SqlDbType.Int).Value = resourceID;
            cmd.Parameters.Add("@url", SqlDbType.VarChar, 255).Value = url;
            cmd.Parameters.Add("@modCode", SqlDbType.Char, 6).Value = modCode;
            cmd.CommandText = commandText;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void AddStudentCourse(Student student, Course course)
        {
            cmd.Parameters.Clear();
            commandText = "INSERT INTO StudentCourses (StudentNumber, ModCode) VALUES " + 
                            "(@studentNo, @modCode)";
            cmd.Parameters.Add("@studentNo", SqlDbType.Int).Value = student.StudentNo;
            cmd.Parameters.Add("@modCode", SqlDbType.Char, 6).Value = course.Code;
            cmd.CommandText = commandText;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void AddCourseResourse(Course course, string url)
        {
            cmd.Parameters.Clear();
            commandText = "SELECT COUNT(*) FROM Resources";
            cmd.CommandText = commandText;
            conn.Open();
            int resourseID = (int)cmd.ExecuteScalar() + 1;
            conn.Close();
            commandText = "INSERT INTO Resources(ResourceID, Link, Module) VALUES " + 
                            "(@resourseID, @url, @modCode)";
            cmd.Parameters.Add("@resourseID", SqlDbType.Int).Value = resourseID;
            cmd.Parameters.Add("@url", SqlDbType.NVarChar, 255).Value = url;
            cmd.Parameters.Add("@modCode", SqlDbType.Char, 6).Value = course.Code;
            cmd.CommandText = commandText;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(Course course)
        {
            cmd.Parameters.Clear();
            commandText = "UPDATE Courses SET ModName = @modName, ModDesc = @modDesc " +
                            "WHERE ModCode = @modCode";
            cmd.Parameters.Add("@modCode", SqlDbType.Char, 6).Value = course.Code;
            cmd.Parameters.Add("@modName", SqlDbType.VarChar, 50).Value = course.Name;
            cmd.Parameters.Add("@modDesc", SqlDbType.VarChar, 200).Value = course.Description;
            cmd.CommandText = commandText;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Update(Student student)
        {
            cmd.Parameters.Clear();
            commandText = "UPDATE Students SET FirstName = @firstName, LastName = @lastName, Gender = @Gender, " +
                            "StudentDOB = @StudentDOB, Phone = @phone, HomeAddress = @address, " +
                            "Picture = @picture WHERE StudentNumber = @studentNo";
            cmd.Parameters.Add("@studentNo", SqlDbType.Int).Value = student.StudentNo;
            cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 40).Value = student.FirstName;
            cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 80).Value = student.LastName;
            cmd.Parameters.Add("@Gender", SqlDbType.VarChar, 14).Value = student.Gender;
            cmd.Parameters.Add("@StudentDOB", SqlDbType.Date).Value = student.Dob;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar, 10).Value = student.Phone;
            cmd.Parameters.Add("@address", SqlDbType.VarChar, 100).Value = student.Address;
            cmd.Parameters.Add("@picture", SqlDbType.Image).Value = student.Picture;
            cmd.CommandText = commandText;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Remove(Student student)
        {
            cmd.Parameters.Clear();
            commandText = "DELETE FROM Students " + 
                            "WHERE StudentNumber = @studentNo";
            cmd.Parameters.Add("@studentNo", SqlDbType.Int).Value = student.StudentNo;
            cmd.CommandText = commandText;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Remove(Course course)
        {
            cmd.Parameters.Clear();
            commandText = "DELETE FROM Courses " +
                            "WHERE ModCode = @modCode";
            cmd.Parameters.Add("@modCode", SqlDbType.Char, 6).Value = course.Code;
            cmd.CommandText = commandText;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Remove(int resourceID)
        {
            cmd.Parameters.Clear();
            commandText = "DELETE FROM Resources " +
                            "WHERE ResourceID = @resourceID";
            cmd.Parameters.Add("@resourceID", SqlDbType.Int).Value = resourceID;
            cmd.CommandText = commandText;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void RemoveStudentCourse(Student student, Course course)
        {
            cmd.Parameters.Clear();
            commandText = "DELETE FROM StudentCourses " +
                            "WHERE (StudentNumber = @studentNo) AND (ModCode = @modCode)";
            cmd.Parameters.Add("@studentNo", SqlDbType.Int).Value = student.StudentNo;
            cmd.Parameters.Add("@modCode", SqlDbType.Char, 6).Value = course.Code;
            cmd.CommandText = commandText;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void RemoveCourseResourse(Course course, string url)
        {
            cmd.Parameters.Clear();
            commandText = "DELETE FROM Resources " + 
                            "WHERE (Module = @modCode) AND (Link = @url)";
            cmd.Parameters.Add("@modCode", SqlDbType.Char, 6).Value = course.Code;
            cmd.Parameters.Add("@url", SqlDbType.NVarChar, 255).Value = url;
            cmd.CommandText = commandText;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<string> returnCourseResources(string modCode)
        {
            List<string> temp = new List<string>();
            cmd.Parameters.Clear();
            commandText = "SELECT Link FROM Resources " +
                            "WHERE Module = @modCode";
            cmd.Parameters.Add("@modCode", SqlDbType.Char, 6).Value = modCode;
            cmd.CommandText = commandText;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                temp.Add(reader[0].ToString());
            }
            conn.Close();

            return temp;
        }

        public List<Course> returnStudentCourses(int studentNumber)
        {
            List<Course> temp = new List<Course>();
            cmd.Parameters.Clear();
            commandText = "SELECT C.ModCode, C.ModName, C.ModDesc " +
                            "FROM Students AS S " +
                            "INNER JOIN StudentCourses AS SC " +
                            "ON(S.StudentNumber = SC.StudentNumber) " +
                            "INNER JOIN Courses AS C " +
                            "ON(SC.ModCode = C.ModCode) " +
                            "WHERE S.StudentNumber = @studentNumber";

            cmd.Parameters.Add("@studentNumber", SqlDbType.Int).Value = studentNumber;
            cmd.CommandText = commandText;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> rows = new List<string>();
            while (reader.Read())
            {
                rows.Add(reader[0].ToString() + "," + reader[1].ToString() + "," + reader[2].ToString());
            }
            conn.Close();

            foreach (string row in rows)
            {
                string[] fields = row.Split(',');
                temp.Add(new Course(fields[0], fields[1], fields[2]));
            }

            return temp;
        }

        public static List<Student> returnAllStudents()
        {
            List<Student> temp = new List<Student>();
            commandText = "SELECT * FROM Students";
            cmd.CommandText = commandText;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> rows = new List<string>();
            while (reader.Read())
            {
                rows.Add(reader[0].ToString() + "," + reader[1].ToString() + "," + reader[2].ToString() + "," + reader[3].ToString() + 
                         "," + reader[4].ToString() + "," + reader[5].ToString() + "," + reader[6].ToString() + "," + reader[7].ToString());
            }
            conn.Close();

            foreach (string row in rows)
            {
                string[] fields = row.Split(',');
                temp.Add(new Student(int.Parse(fields[0]), fields[1], fields[2], fields[3], DateTime.Parse(fields[4]), 
                        fields[5], fields[6], Encoding.ASCII.GetBytes(fields[7])));
            }

            return temp;
        }

        public static List<Course> returnAllCourses()
        {
            List<Course> temp = new List<Course>();
            cmd.Parameters.Clear();
            commandText = "SELECT * FROM Courses";
            cmd.CommandText = commandText;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> rows = new List<string>();
            while (reader.Read())
            {
                rows.Add(reader[0].ToString() + "," + reader[1].ToString() + "," + reader[2].ToString());
            }
            conn.Close();

            foreach (string row in rows)
            {
                string[] fields = row.Split(',');
                temp.Add(new Course(fields[0], fields[1], fields[2]));
            }

            return temp;
        }
    }
}
