using System;
using System.Collections;
using System.Collections.Generic;

namespace _2.StudentsAndWorkers
{
    public class Worker : Human
    {
        public  const int WorkDaysPerWeek = 5;

        private int weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : this(firstName, lastName)
        { 
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay; 
        }
        public Worker(string firstName, string lastName)
            : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public Worker()
        {
        }

        public int WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 5 || value > int.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("Invalid weekSalary value.");
                }
                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 1 || value > 15)
                {
                    throw new ArgumentOutOfRangeException("Invalid value hours!");
                }
                this.workHoursPerDay = value;
            }
        }
        public float MoneyPerHour()
        {
            return (float)this.weekSalary/(WorkDaysPerWeek * this.workHoursPerDay);
        }

        public int CompareTo(Worker other)
        {
            return this.MoneyPerHour().CompareTo(other.MoneyPerHour());
        }

        public static void PrintWorkers(List<Worker> workers)
        {
            foreach (var item in workers)
            {
                Console.WriteLine(item.ToString() + " -> {0:F2}",item.MoneyPerHour());
            }
        }    
    
    }
}
