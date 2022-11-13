using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Course
    {
        private string code;
        private string name;
        private string description;
        private DataHandler handler = new DataHandler();

        public List<string> courseResourses = new List<string>();
        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }

        public Course(string code, string name, string description)
        {
            this.code = code;
            this.name = name;
            this.description = description;
            this.courseResourses = handler.returnCourseResources(this.code);
        }

        public void SaveCourse()
        {
            handler.Insert(this);
        }

        public void AddCourseResourse(string url)
        {
            this.courseResourses.Add(url);
            handler.AddCourseResourse(this, url);
        }

        public void RemoveCourseResourse(string url)
        {
            for (int i = 0; i < courseResourses.Count; i++)
            {
                if (courseResourses[i] == url)
                {
                    courseResourses.RemoveAt(i);
                    break;
                }
            }
            handler.RemoveCourseResourse(this, url);
        }
        public void UpdateCourse()
        {
            handler.Update(this);
        }

        public void RemoveCourse()
        {
            handler.Remove(this);
        }
    }
}
