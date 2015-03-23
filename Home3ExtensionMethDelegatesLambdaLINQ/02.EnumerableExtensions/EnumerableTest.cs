using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnumerableExtensions
{
    public class EnumerableTest
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            myList.Add(23);
            myList.Add(2);
            myList.Add(16);
            myList.Add(32);
            myList.Add(7);
            Console.WriteLine("Sum: " + myList.SumOfElements());
            Console.WriteLine("Product: " + myList.ProductOfElements());
            Console.WriteLine("Max element: " + myList.MaxOfElements());
            Console.WriteLine("Min element: " + myList.MinOfElements());
            Console.WriteLine("Average of elements: " + myList.AverageOfElements());

        }
    }
}
