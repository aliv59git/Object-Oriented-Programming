using SchoolSystem.Inetrface;
using System;


namespace SchoolSystem
{
    public class Employse: Person, IPerson
    {
        public int EmployseID { get; set; }
        public string JobTitle { get; set; }

    }
}
