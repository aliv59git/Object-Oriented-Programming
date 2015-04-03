using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Person
{
    public class Person
    {
        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }
        
        public string Name { get; private set; }
        public int? Age { get; protected set; }

        public override string ToString()
        {
            return String.Format("Person (Name: {0}, Age: {1})", this.Name, this.Age.ToString()?? "");
        }

    }
}
