using System;


namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.Name = "Pesho";
            var cat2 = new Cat();
            cat2.Name = "Gosho";
            Console.WriteLine(cat1 == cat2);  //== ReferenceEquals() така се нарича методът на == оператора. При обекти сравнява мястото им в паметта. 
            Console.WriteLine(cat1.Equals(cat2));
            Console.WriteLine(Object.Equals(cat1.Name, cat2.Name));
            Console.WriteLine(cat1.GetHashCode()); 
            Console.WriteLine(cat2.GetHashCode());
            Console.WriteLine(cat1.ToString());
        
        }
    }
}
