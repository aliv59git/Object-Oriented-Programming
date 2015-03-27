using System;
using System.Collections.Generic;


namespace _1.SchoolClasses
{
    public class ClassOfStudents
    {
        private List<Student> students;
        private List<Teacher> teachers;
        private string textIdentifier;
        public ClassOfStudents(string textIdentifyer):this()
        {
            this.TextIdentifier = textIdentifier;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();

        }

        public ClassOfStudents()
        {
        }

        public List<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }
        public List<Teacher> Teachers 
        {
            get { return this.teachers; }
            set { this.teachers = value; }
        }


        public string TextIdentifier { get; private set; }

        public School School
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
