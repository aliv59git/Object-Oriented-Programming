using System;

namespace _1.StudentClass
{
    public class Student
    {
        public Specialty specialty;

        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public int SSNumber { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public string Speciality
        {
            get { return Specialty.specialty; }
            set { this.specialty = value; }
        }

    }
}
