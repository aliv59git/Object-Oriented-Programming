using System;
using System.Collections.Generic;

namespace _1.SchoolClasses
{
    public class TestSchool
    {
        static void Main(string[] args)
        {
            ClassOfStudents classSt = new ClassOfStudents();
            
            classSt.Teachers = new List<Teacher>();
            Teacher t1 = new Teacher();
            Teacher t2 = new Teacher();
            Teacher t3 = new Teacher();
            Teacher t4 = new Teacher();
            t1.Name = "Ivanov";
            t2.Name = "Peshev";
            t3.Name = "Pesho Stojanov";
            t4.Name = "Draganov"; 
            classSt.Teachers.Add(t1);
            classSt.Teachers.Add(t2);
            classSt.Teachers.Add(t3);
            classSt.Teachers.Add(t4);


            foreach (var item in classSt.Teachers)
            {
                Console.WriteLine(item.Name);
            }

            classSt.TextIdentifier = "7A class";
            Console.WriteLine(classSt.TextIdentifier);

        }
    }
}
