using SchoolSystem.Inetrface;
using System;


namespace SchoolSystem
{
    public class Teacher : Person, IPerson
    {
        public Teacher()
        {
        }

        public Teacher(string name, string email, string subject)
            : base(name, email)
        {
            this.Subject = subject;
        }
        
        public string Subject { get; set; }



    }
}
