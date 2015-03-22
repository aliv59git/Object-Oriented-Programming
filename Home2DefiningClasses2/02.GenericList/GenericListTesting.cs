using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GenericList
{
    public class GenericListTesting
    {
        static void Main(string[] args)
        {
            GenericList<int> arr = new GenericList<int>();
            arr.Add(1);
            arr.Add(5);
            arr.Add(7);
            arr.Add(11);
            arr.Add(25);
            arr.Add(73);
            Console.WriteLine(arr.IndexOf(25));
            Console.WriteLine(arr[3]);
            Console.WriteLine(arr[2]);
            Console.WriteLine();

            arr.Add(11);
            arr.Add(15);
            arr.Add(17);
            arr.Add(21);
            arr.Add(35);
            arr.Add(63);
            arr.Remove(11);
            arr.RemoveAt(2);
            for (int i = 0; i < arr.Count(); i++)
            {
                Console.WriteLine(arr[i]);
            }


        }
    }
}
