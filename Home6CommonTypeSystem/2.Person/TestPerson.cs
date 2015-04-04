using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Person
{
    public class TestPerson
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Pesho");
            Console.WriteLine(person1.ToString());
            var person2 = new Person("Pesho", 26);
            Console.WriteLine(person2.ToString());

        }
        
    }
}
