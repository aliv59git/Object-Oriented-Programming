using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GenericList
{
    public class GenericListTesting
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            arr.Add(1);
            arr.Add(5);
            arr.Add(7);
            arr.RemoveAt(2);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
