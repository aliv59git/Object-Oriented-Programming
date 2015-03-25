using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Students
{
    public class ProgramStudentsTest
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student { FirstName = "Maria", LastName = "Toneva", FN = "1234065", Tel = "02-975-22-23", Email = "kajiIme@abv.bg", Marks = new List<int>(){2, 2, 3, 4, 5, 6}, GroupNumber = 2, Group = new Group { GroupNumber = 2, DepartmentName = "Mathematics"}},
                new Student {FirstName = "Ivan", LastName = "Petkov", FN = "123408577", Tel = "0910-975-28-42", Email = "imeKaji@abv.bg", Marks = new List<int>(){2, 5, 3, 5, 2, 3, 4}, GroupNumber = 1, Group = new Group { GroupNumber = 2, DepartmentName = "Physics"}}, 
                new Student {FirstName = "Ani", LastName = "Tzolova", FN = "123406411", Tel = "034-973-32-14", Email = "kajiImtoSi@gmail.com", Marks = new List<int>(){6, 4, 6, 3, 4, 5, 6}, GroupNumber = 2, Group = new Group { GroupNumber = 2, DepartmentName = "Mathematics"}}, 
                new Student {FirstName = "Pepi", LastName = "Achev", FN = "123405139", Tel = "02-875-22-23", Email = "kajiImeNew@abv.bg", Marks = new List<int>(){5, 4, 2, 3, 4, 5, 5}, GroupNumber = 2, Group = new Group { GroupNumber = 2, DepartmentName = "Chemistry"}}, 
                new Student {FirstName = "Val", LastName = "Wrangler", FN = "123406417", Tel = "02-873-67-87", Email = "kajiImence@gmail.com", Marks = new List<int>(){3, 2, 6, 5, 6}, GroupNumber = 2, Group = new Group { GroupNumber = 2, DepartmentName = "Mathematics"}}, 
                new Student {FirstName = "Ivan", LastName = "Kostov", FN = "123406123", Tel = "092-875-22-23", Email = "kajiI@abv.bg", Marks = new List<int>(){2, 3, 4, 5, 2, 4}, GroupNumber = 3, Group = new Group { GroupNumber = 2, DepartmentName = "Mathematics"}}, 
                new Student {FirstName = "Cici", LastName = "Cvetanov", FN = "123406232", Tel = "023-5-22-23", Email = "Ime@gmail.com", Marks = new List<int>(){4, 2, 3, 4, 5, 4}, GroupNumber = 2, Group = new Group { GroupNumber = 2, DepartmentName = "Biology"}}, 
                new Student {FirstName = "Ivan", LastName = "Atanassov", FN = "123407340", Tel = "02-875-28-13", Email = "kajiSi@abv.bg", Marks = new List<int>(){3, 6, 2, 3, 4, 5, 6}, GroupNumber = 1, Group = new Group { GroupNumber = 2, DepartmentName = "Mathematics"}}, 
                new Student {FirstName = "Ivan", LastName = "Ivanov", FN = "12340667", Tel = "02-975-06-08", Email = "ime@gmail.com", Marks = new List<int>(){4, 6, 2, 3, 4, 2, 5, 6}, GroupNumber = 2, Group = new Group { GroupNumber = 2, DepartmentName = "Mathematics"}} 
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

            Console.WriteLine();
            Console.WriteLine("The same with Extended methods: ");
            var res = MethodsExt.OrderByNames(students);
            Student.PrintStudent(res);
            //Problem 10
            Console.WriteLine();
            Console.WriteLine("//Problem10");
            Console.WriteLine("The same with Extended methods(Students with GroupNumber 2): (second way)");
            var res1 = MethodsExt.OrderByNames1(students);
            Student.PrintStudent(res1);
            //Problem 11
            Console.WriteLine();
            Console.WriteLine("//Problem 11: Students with Email in abv.bg");
            var studentsInAbvBg = students.FindAll(st => st.Email.Contains("@abv.bg")).OrderBy(st => st.FirstName).ToList();
            Student.PrintStudent(studentsInAbvBg);
            //Problem 12
            Console.WriteLine();
            Console.WriteLine("//Problem 12: Students with phones in Sofia");
            var studentsFromSofia = students.FindAll(st => st.Tel.IndexOf("02-", 0) == 0).OrderBy(st => st.FirstName).ToList();
            Student.PrintStudent(studentsFromSofia);
            //Problem 13
            Console.WriteLine();
            Console.WriteLine("//Problem 13: Students with Excelent (6): ");
            var studentsWithExcelent = students.FindAll(st => st.Marks.Contains(6)).OrderBy(st => st.FirstName).ToList();
            Student.PrintStudent(studentsWithExcelent);
            Console.WriteLine();
            foreach (var student in studentsWithExcelent)
            {
                Console.WriteLine(student.FullName);
            }
            Console.WriteLine( );
            foreach (var st in studentsWithExcelent)
            {
                Console.WriteLine(st.ToString());
            }
            //Problem 14
            Console.WriteLine();
            Console.WriteLine("//Problem14");
            Console.WriteLine("The students with exactly two marks 2): ");
            var resultSt = MethodsExt.StudentsWithTwoMarks2(students);
            Student.PrintStudent(resultSt);

            //Problem 15
            Console.WriteLine();
            Console.WriteLine("//Problem 15");
            Console.WriteLine("The students that enrolled in 2006");
            var studentsEnrolledIn2006 = students.FindAll(st => st.FN.IndexOf("06") == 4).OrderBy(st => st.FirstName).ToList();
            Student.PrintStudent(studentsEnrolledIn2006);

            //Problem 16
            Console.WriteLine();
            Console.WriteLine("//Problem 16");
            Console.WriteLine("The students studied Mathematics: ");
            var studentsInMathematics = students.FindAll(st => st.Group.DepartmentName == "Mathematics").OrderBy(st => st.FirstName).ToList();
            Console.WriteLine(string.Join("\n", studentsInMathematics.Select(st => st.ToString())));
            Console.WriteLine();
            Console.WriteLine("The same: ");
            Console.WriteLine(string.Join("\n", studentsInMathematics.Select(st => st.FullName)));
            
        }
    }
}
