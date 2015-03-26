using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.GroupinByGroupName
{
    public class GroupingByGroupName
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student {FullName = "Ivan Ivanov", GroupName = "Bambi"},
                new Student {FullName = "Pepi Achev", GroupName = "Geri"},
                new Student {FullName = "Sasho Nikolov", GroupName = "Eagles"},
                new Student {FullName = "Ivan Tzvetaniv", GroupName = "Bambi"},
                new Student {FullName = "Ani Ivanova", GroupName = "Geri"},
                new Student {FullName = "Lili Ivanova", GroupName = "Bambi"},
                new Student {FullName = "Katia Petzeva", GroupName = "Bambi"},
                new Student {FullName = "Ivanka Ivanova", GroupName = "Eagles"},
                new Student {FullName = "Gosho Gachev", GroupName = "Bambi"},
                new Student {FullName = "Pesho Peshev", GroupName = "Eagles"},
                new Student {FullName = "Ivan Peshev", GroupName = "Bambi"}
            };
            List<Student> res = new List<Student>();
            var result = from st in students
                         group st by st.GroupName into g
                         select new { GroupName = g.Key, students= g.ToList()};

            PrintStudent(students);
            Console.WriteLine();
            //PrintStudent(result.OrderBy(st => st.FullName));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


        }
        public static void PrintStudent(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.GroupName + " - > " + student.FullName);
            }
        }
    }
}