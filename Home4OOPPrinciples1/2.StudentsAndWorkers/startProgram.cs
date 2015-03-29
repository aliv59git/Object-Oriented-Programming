using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace _2.StudentsAndWorkers
{
    public class startProgram
    {
        static void Main()
        {
            var st1 = new Student("Pesho", "Peshev", 11);

            List<Student> students = new List<Student>();
            students.Add(st1);
            students.Add(new Student("Gosho", "Peshev", 1));
            students.Add(new Student("Ivan", "Draganov", 9));
            students.Add(new Student("Pepi", "Achev", 8));
            students.Add(new Student("Stamat", "Ivanov", 2));
            students.Add(new Student("Ivanka", "Pesheva", 4));
            students.Add(new Student("Gosho", "Tashev", 10));
            students.Add(new Student("Ivo", "Atanassov", 12));
            students.Add(new Student("Asen", "Nikolaev", 7));
            students.Add(new Student("Ani", "Tzolova", 6));

            var resultStudents = (from student in students
                                  orderby student.Grade
                                  select student).ToList();

            Student.PrintStudent(resultStudents);

            Console.WriteLine();
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Ivan", "Atanassov", 234, 8));
            workers.Add(new Worker("Krasi", "Tzolov", 432, 9));
            workers.Add(new Worker("Angel", "Peshev", 456, 8));
            workers.Add(new Worker("Lili", "Ivanova", 123, 5));
            workers.Add(new Worker("Eli", "Stojanova", 678, 7));
            workers.Add(new Worker("Katia", "Atanassova", 233, 4));
            workers.Add(new Worker("Ivan", "Petkanchin", 365, 8));
            workers.Add(new Worker("Stanimir", "Geshev", 190, 6));
            workers.Add(new Worker("Vla", "Valeriev", 789, 7));
            workers.Add(new Worker("Irina", "Kateva", 1234, 8));

            var resWorkers = workers.OrderByDescending(w => w.MoneyPerHour()).Select(w => w).ToList();
            Worker.PrintWorkers(resWorkers);

            List<Human> humans = new List<Human>();
            foreach (var item in students)
            {
                humans.Add(item);
            }
            foreach (var item in workers)
            {
                humans.Add(item);
            }
            var resHumanFName = humans.OrderBy(h => h.FirstName).Select(h => h).ToList();
            Console.WriteLine();
            Console.WriteLine("All humans ordered by FirstName: ");
            foreach (var item in resHumanFName)
            {
                Console.WriteLine(item);
            }

            var resHumanLName = humans.OrderBy(h => h.LastName).Select(h => h).ToList();
            Console.WriteLine();
            Console.WriteLine("All humans ordered by LastName: ");
            foreach (var item in resHumanLName)
            {
                Console.WriteLine(item);
            }
        }
    }
}
