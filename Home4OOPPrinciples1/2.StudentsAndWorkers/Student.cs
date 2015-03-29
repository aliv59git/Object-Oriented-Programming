using System;
using System.Collections;
using System.Collections.Generic;


namespace _2.StudentsAndWorkers
{
    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public Student()
        {
        }

        public int Grade 
        {
            get { return this.grade; }
            protected set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.grade = value;
           }
        }

        public int CompareTo(Student other)
        {
            return this.Grade.CompareTo(other.Grade);
        }
        public static void PrintStudent(List<Student> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString() +" -> "+ item.Grade);
            }
        }
    }
}
