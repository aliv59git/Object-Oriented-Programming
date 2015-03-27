using System;
using System.Collections.Generic;

namespace _1.SchoolClasses
{
    public class TestSchool
    {
        static void Main(string[] args)
        {
            ClassOfStudents classSt = new ClassOfStudents("7A Class");

            classSt.Teachers = new List<Teacher>();
            Teacher t1 = new Teacher();
            Teacher t2 = new Teacher();
            Teacher t3 = new Teacher();
            Teacher t4 = new Teacher();
            classSt.Teachers.Add(t1);
            classSt.Teachers.Add(t2);
            classSt.Teachers.Add(t3);
            classSt.Teachers.Add(t4);
            
            t1.Name = "Ivanov";
            t2.Name = "Peshev";
            t3.Name = "Pesho Stojanov";
            t4.Name = "Draganov";
            foreach (var item in classSt.Teachers)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
