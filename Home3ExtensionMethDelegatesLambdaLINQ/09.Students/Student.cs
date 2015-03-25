using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Students
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int fN;
        private string tel;
        private string email;
        private List<int> marks;
        private int groupNumber;

        public Student()
        {
        }
        public Student(string firstName, string lastName, int fN, string tel, string email, List<int> marks, int groupNumber): this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.Marks = new List<int>();
            this.GroupNumber = groupNumber;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                if (value.Length > 30)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                if (value.Length > 30)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.lastName = value;
            }
        }
        public int FN
        {
            get { return this.fN; }
            set
            {
                if ((value <= 6) && (value > 15))
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.fN = value;
            }
        }
        public string Tel
        {
            get { return this.tel; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                if (value.Length > 15)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.tel = value;
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                if (value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.email = value;
            }
        }
        public List<int> Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }
        public int GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }

        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }

        public static void PrintStudent(List<Student> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine("Name: {0} {1} \nFN: {2} Tel.: {3}, Email: {4}\nMarks: {5}, GroupNumber: {6}",
                    item.FirstName, item.LastName, item.FN, item.Tel, item.Email, string.Join(", ", item.Marks), item.GroupNumber);
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} has marks: {2}", this.FirstName, this.LastName, string.Join(", ", this.Marks));
        }

    }
}
