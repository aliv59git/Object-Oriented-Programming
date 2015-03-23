using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FirstBeforeLast
{
    public static class FirstBefore
    {
        public static List<Student> FirstBeforeLast(List<Student> allStudents)
        {
            return allStudents.FindAll(st => st.FirstName.CompareTo(st.LastName) < 0);
        }

        public static List<Student> AgeBetween18And24(List<Student> allStudents)
        {
            return allStudents.FindAll(st => st.Age >= 18 && st.Age <= 24);
        }

        public static List<Student> OrderByNames(List<Student> allStudents)
        {
            var result = allStudents
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName)
                .Select(st => st)
                .ToList<Student>();

            return result;
        }

        public static void ToString(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName+" "+ student.LastName);
            }
        }
    }
}
