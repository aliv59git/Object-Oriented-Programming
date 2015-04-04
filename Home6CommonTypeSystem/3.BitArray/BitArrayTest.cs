using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.BitArray
{
    public class BitArrayTest
    {
        static void Main(string[] args)
        {
            var numb1 = new BitArray(345);
            var numb2 = new BitArray(345);
            var numb3 = new BitArray(123345);
            Console.WriteLine(numb1.ToString());
            Console.WriteLine(numb1 == numb2);
            Console.WriteLine(numb1[33]);
            Console.WriteLine(numb3);
            numb3[33] = 1;
            Console.WriteLine(numb3[33]);
            Console.WriteLine(numb3);
            Console.WriteLine();

            Console.WriteLine(numb1.GetHashCode());
            Console.WriteLine(numb2.GetHashCode());
            Console.WriteLine(numb3.GetHashCode());


        }
    }
}
