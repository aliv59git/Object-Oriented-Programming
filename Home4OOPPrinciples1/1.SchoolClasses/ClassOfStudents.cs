using System;
using System.Collections.Generic;


namespace _1.SchoolClasses
{
    public class ClassOfStudents : IComments
    {
        private List<Student> students;
        private List<Teacher> teachers;
        private string textIdentifier;
        private string comments;
        public ClassOfStudents(string textIdentifyer, string comments)
            :this()
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


        public string TextIdentifier 
        {
            get { return this.textIdentifier; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The class must have text identifier!");
                }
                if (value.Length < 2 || value.Length > 30)
                {
                    throw new ArgumentOutOfRangeException();
                }
                foreach (var ch in value)
                {
                    if (!IsAllowedSymbol(ch))
                    {
                        throw new ArgumentException();
                    }
                }
                this.textIdentifier = value;
            }
        }
        public string Comments
        {
            get { return this.comments; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The class of students must have comments.");
                }
                if (value.Length < 3 || value.Length > 256)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.comments = value;
            }
        }


        internal bool IsAllowedSymbol(char ch) 
        {
            bool isAllowed = Char.IsLetterOrDigit(ch) || ch == '-' || ch == ' ' || ch =='_';
            return isAllowed;
        }

    }
}
