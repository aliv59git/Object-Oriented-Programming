using SchoolSystem.Inetrface;
using System;


namespace SchoolSystem
{
    public class Student : Person, IPerson, IComparable<Student>
    {
        public Student(string name, string email, int studentID)
            : base(name, email)
        {
            this.StudentID = studentID;
        }

        public int StudentID { get; private set; }


        public int CompareTo(Student other)
        {
            return this.StudentID - other.StudentID;
        }
    }
}
