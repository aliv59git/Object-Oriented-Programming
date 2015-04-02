using System;

namespace _1.StudentClass
{
    public class Student
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int? sSNumber;
        private string permanentAddress;
        private string email;
        private int? course;
        private University uinversity;
        private Specialty speialty;
        private Faculty faculty;

        public Student(string firstName, string middleName = null, string lastName, int? sSNumber=null, string permanentAddress = null, string email = null, int? course = null, University university, Faculty faculty, Specialty specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            //this.SSNumber = sSNumber;
            this.PermanentAddress = permanentAddress;
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
        
        

    }
}
