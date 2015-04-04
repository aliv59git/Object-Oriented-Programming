using SoftwareAcademy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy.Models
{
    public class Teacher : ITeacher
    {
        private ICollection<ICourse> courses;
        private string name;

        public Teacher(string name = null)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
        }
        public string Name
        {
            get { return this.name; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The teacher has name!");
                }
                //if (value.Length < 2 || value.Length > 100)
                //{
                //    throw new ArgumentOutOfRangeException();
                //}
                //foreach (var ch in value)
                //{
                //    if (!Course.IsAllowed(ch))
                //    {
                //        throw new ArgumentException("Invalid name");
                //    }
                //}

                this.name = value; 
            }
        }
        
 
        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            string result = String.Format("Teacher: Name={0}", this.Name);
            if (courses.Count > 0)
            {
                result += string.Format("; Courses=[{1}]",  this.Name, string.Join(", ", courses.Select(c => c.Name)));
            }
            return result; 
        }

        //Teacher: Name=(teacher name); Courses=[(course names – comma separated)]
    }
}
