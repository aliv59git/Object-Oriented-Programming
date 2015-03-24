using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Students
{
    class ProgramStudentsTest
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student { FirstName = "Maria", LastName = "Toneva", FN = 1234065, Tel = "02-975-22-23", Email = "kajiIme@abv.bg", Marks = new List<int>(){2, 2, 3, 4, 5, 6}, GroupNumber = 2},
                new Student {FirstName = "Ivan", LastName = "Petkov", FN = 123408577, Tel = "0910-975-22-23", Email = "imeKaji@abv.bg", Marks = new List<int>(){2, 5, 3, 5, 6, 6}, GroupNumber = 1}, 
                new Student {FirstName = "Ani", LastName = "Tzolova", FN = 123406411, Tel = "034-975-22-23", Email = "kajiImtoSi@gmail.com", Marks = new List<int>(){6, 4, 6, 3, 4, 5, 6}, GroupNumber = 2}, 
                new Student {FirstName = "Pepi", LastName = "Achev", FN = 123405139, Tel = "02-975-22-23", Email = "kajiImeNew@abv.bg", Marks = new List<int>(){5, 4, 2, 3, 4, 5, 6}, GroupNumber = 2}, 
                new Student {FirstName = "Val", LastName = "Wrangler", FN = 123406417, Tel = "02-975-22-23", Email = "kajiImence@gmail.com", Marks = new List<int>(){3, 2, 6, 5, 6}, GroupNumber = 2}, 
                new Student {FirstName = "Ivan", LastName = "Kostov", FN = 123406123, Tel = "092-975-22-23", Email = "kajiI@abv.bg", Marks = new List<int>(){2, 3, 4, 5, 6}, GroupNumber = 3}, 
                new Student {FirstName = "Cici", LastName = "Cvetanov", FN = 123406232, Tel = "02-975-22-23", Email = "Ime@gmail.com", Marks = new List<int>(){4, 2, 3, 4, 5, 6}, GroupNumber = 2}, 
                new Student {FirstName = "Ivan", LastName = "Atanassov", FN = 123407340, Tel = "02-975-22-23", Email = "kajiSi@abv.bg", Marks = new List<int>(){3, 6, 2, 3, 4, 5, 6}, GroupNumber = 1}, 
                new Student {FirstName = "Ivan", LastName = "Ivanov", FN = 12340667, Tel = "02-975-22-23", Email = "ime@gmail.com", Marks = new List<int>(){4, 6, 2, 3, 4, 5, 6}, GroupNumber = 2}, 
            };

            //Student.PrintStudent(students);

            var studentsWithGroup2 = students.FindAll(st => st.GroupNumber == 2).OrderBy(st => st.FirstName).ToList();
            Console.WriteLine("Students with GroupNumber 2: ");
            Student.PrintStudent(studentsWithGroup2);
            Console.WriteLine();
            Console.WriteLine("Students with GroupNumber 2: (other way)");
            var studentsFromGroup2 = (from st in students
                                     where st.GroupNumber == 2
                                     orderby st.FirstName
                                     select st).ToList();
            Student.PrintStudent(studentsFromGroup2);

            var studentsInGr2 = StudentsExtension.StudentsInGroup2Ext(students);
            Student.PrintStudent(studentsInGr2);
        }
    }
}
