using System;
using System.Collections.Generic;

namespace _1.SchoolClasses
{
    public class Teacher : Person, IPerson
    {
        private List<Subject> subjects;

        public Teacher(string name)
            :this()
        {
            this.Name = name;
            this.subjects = new List<Subject>();
        }
        public Teacher()
        {
        }





    }
}
