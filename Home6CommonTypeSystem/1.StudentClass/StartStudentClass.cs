using System;

namespace _1.StudentClass
{
    public class StartStudentClass
    {
        static void Main(string[] args)
        {
            var st1 = new Student("Ivan", "Peshev", "Ivanov", University.SofiaUniversity, Faculty.Mathematics, Specialty.ComputerScience, 12345678);
            Console.WriteLine(st1.Specialty);
            Console.WriteLine(st1);
            var st2 = st1.Clone();
            Console.WriteLine();
            Console.WriteLine("For Clonable object: ");
            var properties = st2.GetType().GetProperties();
            foreach (var prop in properties)
            {
                Console.WriteLine(prop.Name);
            }
            Console.WriteLine(st2.ToString());
            Console.WriteLine(st1 == st2 ? "The objects are equals." : "The objects are not equals.");
            Console.WriteLine();
            var st3 = new Student("Pesho", "Peshev", sSNumber: 2345678);
            var st4 = new Student("Pesho", "Peshev", sSNumber: 1236783);
            Console.WriteLine(st1.CompareTo(st3));
            Console.WriteLine(st3.CompareTo(st4));
        }
    }
}
