using System;

namespace _1.StudentClass
{
    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int sSNumber;
        private string permanentAddress;
        private string email;
        private int? course;
        private University uinversity;
        private Specialty speialty;
        private Faculty faculty;

        public Student(string firstName, string middleName, string lastName, University university, Faculty faculty, Specialty specialty, int? sSNumber = null, string permanentAddress = null, string email = null, int? course = null)
            :this(firstName, lastName, (int)sSNumber)
        {
            this.MiddleName = middleName;
            this.PermanentAddress = permanentAddress;
            this.Email = email;
            this.Course = 3;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }
        public Student(string firstName, string lastName, int sSNumber)
            : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SSNumber = sSNumber;
        }
        public Student()
        {
        }

        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public int SSNumber { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public Specialty Specialty
        {
            get { return speialty; }
            set { speialty = value; }
        }
        public University University
        {
            get { return uinversity; }
            set { uinversity = value; }
        }
        public Faculty Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public override bool Equals(object obj)
        {
            var objAsStudent = obj as Student;
            if (!Object.Equals(objAsStudent.FirstName, this.FirstName))
            {
                return false;
            }
            if (!Object.Equals(objAsStudent.MiddleName, this.MiddleName))
            {
                return false;
            }
            if (!Object.Equals(objAsStudent.LastName, this.LastName))
            {
                return false;
            }
            if (objAsStudent.SSNumber!=this.SSNumber)
            {
                return false;
            }
            if (!Object.Equals(objAsStudent.PermanentAddress, this.PermanentAddress))
            {
                return false;
            }
            if (!Object.Equals(objAsStudent.MobilePhone, this.MobilePhone))
            {
                return false;
            }
            if (!Object.Equals(objAsStudent.Email, this.Email))
            {
                return false;
            }
            if (objAsStudent.Course != this.Course)
            {
                return false;
            }
            if (objAsStudent.University.GetHashCode() != this.University.GetHashCode())
            {
                return false;
            } 
            if (objAsStudent.Faculty.GetHashCode() != this.Faculty.GetHashCode())
            {
                return false;
            }
            if (objAsStudent.Specialty.GetHashCode() != this.Specialty.GetHashCode())
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.LastName.GetHashCode() ^ this.SSNumber;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} has SSNumber {3}, permanent address: {4}, Email: {5}. He is in {6} course in {7}, {8} faculty, specialty {9}", this.FirstName, this.MiddleName, this.LastName, this.SSNumber, this.PermanentAddress, this.Email, this.Course, this.University, this.Faculty, this.Specialty);
        }

        public static bool operator ==(Student st1, Student st2)
        {
            return Student.Equals(st1, st2);
        }
        public static bool operator !=(Student st1, Student st2)
        {
            return !Student.Equals(st1, st2);
        }


        object ICloneable.Clone()
        {
            return this.Clone();
        }
        public Student ShallowCopy()
        {
            return this;
        }
        public Student MemberwiseCopy()
        {
            return (Student)this.MemberwiseClone();
        }

        public Student Clone() //deep cloning
        {
            Student original = this;
            var properties = original.GetType().GetProperties();
            Student result = new Student();
            result.FirstName = original.FirstName;
            result.MiddleName = original.MiddleName;
            result.LastName = original.LastName;
            result.University = original.University;
            result.Faculty = original.Faculty;
            result.Specialty = original.Specialty;
            result.SSNumber = original.SSNumber;
            result.PermanentAddress = original.PermanentAddress;
            result.Email = original.Email;
            result.Course = original.Course;
            return result;
        }

        public int CompareTo(Student other)
        {
            int first = this.FirstName.CompareTo(other.FirstName);
            int second = this.LastName.CompareTo(other.LastName);
            if (first != 0)
            {
                return first;
            }
            else if (second != 0)
            {
                return second;
            }
            else if (this.SSNumber < other.SSNumber)
            {
                return -1;
            }
            else if(this.SSNumber > other.SSNumber)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
