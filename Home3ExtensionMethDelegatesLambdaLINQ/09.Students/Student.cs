using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public static void PrintStudent(List<Student> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine("Name: {0} {1} \nFN: {2} Tel.: {3}, Email: {4}\nMarks: {5}, GroupNumber: {6}", 
                    item.FirstName, item.LastName, item.FN, item.Tel, item.Email, string.Join(", ", item.Marks), item.GroupNumber);
                Console.WriteLine();
            }
        }
    }
}
