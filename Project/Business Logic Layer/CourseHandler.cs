using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class CourseHandler
    {
        List<Course> courses = new List<Course>();
        internal List<Course> Courses { get => courses; }
        public CourseHandler()
        {
            courses = DataHandler.returnAllCourses();
        }

        public Course SearchCourses(string modCode)
        {
            foreach (Course course in courses)
            {
                if (course.Code == modCode)
                {
                    return course;
                }
            }

            return null;
        }
        public void Insert(Course course)
        {
            courses.Add(course);
            course.SaveCourse();
        }

        public void Remove(int courseIndex)
        {
            courses[courseIndex].RemoveCourse();
            courses.RemoveAt(courseIndex);
        }
        public void Update(Course course)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].Code == course.Code)
                {
                    courses[i] = course;
                    courses[i].UpdateCourse();
                }
            }
        }

        public List<Course> returnAvailableCourses(Student student)
        {
            List<Course> temp = new List<Course>();

            foreach (Course course in courses)
            {
                bool found = false;
                foreach (Course studentCourse in student.studentCourses)
                {
                    if (studentCourse.Code == course.Code)
                    {
                        found = true;
                    }
                }

                if (found != true)
                {
                    temp.Add(course);
                }
            }

            return temp;
        }
    }
}
