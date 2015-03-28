using System;
using System.Collections.Generic;
using System.Linq;


namespace _3.AnimalHierarchy
{
    public class StartProgram
    {
        static void Main(string[] args)
        {
            List<Frog> frogs = new List<Frog>();
            frogs.Add(new Frog(2, "Maja", "Female"));
            frogs.Add(new Frog(3, "Lala", "Female"));
            frogs.Add(new Frog(5, "Jeri", "Male"));
            frogs.Add(new Frog(4, "Katia", "Female"));
            frogs.Add(new Frog(1, "Uri", "Male"));
            frogs.Add(new Frog(2, "Cha-Cha", "Female"));
            double averageAgeFrogs = frogs.Select(fr => fr.Age).Average();
            Console.WriteLine("The average age of frogs is: "+averageAgeFrogs);

            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog(2, "Pesho", "Male"));
            dogs.Add(new Dog(7, "Lala", "Female"));
            dogs.Add(new Dog(3, "Jeri", "Male"));
            dogs.Add(new Dog(1, "Kali", "Female"));
            dogs.Add(new Dog(9, "Urko", "Male"));
            dogs.Add(new Dog(12, "Atila", "Male"));
            double averageAgeDogs = dogs.Select(d => d.Age).Average();
            Console.WriteLine("The average age of Dogs is: "+averageAgeDogs);

            List<Kitten> kittens = new List<Kitten>();
            kittens.Add(new Kitten(2, "Maja", "Female"));
            kittens.Add(new Kitten(7, "Lala", "Female"));
            kittens.Add(new Kitten(13, "Jeri", "Female"));
            kittens.Add(new Kitten(11, "Katia", "Female"));
            kittens.Add(new Kitten(4, "Ursula", "Female"));
            kittens.Add(new Kitten(6, "Chaina", "Female"));
            double averageAgeKittens = kittens.Select(k => k.Age).Average();
            Console.WriteLine("The average age of kittens is: " + averageAgeKittens);

            List<Tomcat> tomcats = new List<Tomcat>();
            tomcats.Add(new Tomcat(3, "Pesho", "Male"));
            tomcats.Add(new Tomcat(7, "Gesho", "Male"));
            tomcats.Add(new Tomcat(5, "Jeri", "Male"));
            tomcats.Add(new Tomcat(1, "Kali", "Male"));
            tomcats.Add(new Tomcat(7, "Urko", "Male"));
            tomcats.Add(new Tomcat(11, "Atila", "Male"));
            double averageAgeTomcats = tomcats.Select(tc => tc.Age).Average();
            Console.WriteLine("The average age of Tomcats is: " + averageAgeTomcats);


        }
    }
}
