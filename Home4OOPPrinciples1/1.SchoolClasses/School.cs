using System;
using System.Collections.Generic;


namespace _1.SchoolClasses
{
    public class School
    {
        public string Name { get; private set; }
        public List<ClassOfStudents> Classes { get; set; }

        public School(string name)
        {
            this.Name = name;
            this.Classes = new List<ClassOfStudents>();
        }

        public void AddClass(ClassOfStudents classNew)
        {
            this.Classes.Add(classNew);
        }

        public void RemoveClass(ClassOfStudents classOld)
        {
            this.Classes.Remove(classOld);
        }
        public override string ToString()
        {
            return this.Name;
        }

    }
}
