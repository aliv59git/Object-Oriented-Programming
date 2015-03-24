using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FirstBeforeLast
{
    class ProgramTest
    {
        static void Main(string[] args)
        {
            var allStudents = new List<Student>()
            {
                new Student {FirstName = "Ivan", LastName = "Petkov", Age = 17}, 
                new Student {FirstName = "Ani", LastName = "Tzolova", Age = 21}, 
                new Student {FirstName = "Pepi", LastName = "Achev", Age = 19}, 
                new Student {FirstName = "Val", LastName = "Wrangler", Age = 27}, 
                new Student {FirstName = "Ivan", LastName = "Kostov", Age = 24}, 
                new Student {FirstName = "Cici", LastName = "Cvetanov", Age = 22}, 
                new Student {FirstName = "Ivan", LastName = "Atanassov", Age = 20}, 
                new Student {FirstName = "Ivan", LastName = "Ivanov", Age = 37}, 
            };
            var ourStudents = FirstBefore.FirstBeforeLast(allStudents);
            Console.WriteLine("Students with first name before last name: ");
            FirstBefore.ToString(ourStudents);
            
            Console.WriteLine();
            Console.WriteLine("Students with age between 18 and 24 years: ");
            var ourStudents1 = FirstBefore.AgeBetween18And24(allStudents);
            FirstBefore.ToString(ourStudents1);

            Console.WriteLine();
            Console.WriteLine("Students ordered descending by First name, then by last name: ");
            var ourSrudents2 = FirstBefore.OrderByNames(allStudents);
            FirstBefore.ToString(ourSrudents2);

            Console.WriteLine();
            Console.WriteLine("Students ordered descending by First name, then by last name: ");
            var ourSrudents3 = FirstBefore.OrderByNames1(allStudents);
            FirstBefore.ToString(ourSrudents3);

        }
    }
}
