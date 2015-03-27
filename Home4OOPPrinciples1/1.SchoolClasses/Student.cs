using System;

namespace _1.SchoolClasses
{
    public class Student : Person
    {
        private int classNumber;

        public Student (string name, int classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber { get; set; }

        public ClassOfStudents ClassOfStudents
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
