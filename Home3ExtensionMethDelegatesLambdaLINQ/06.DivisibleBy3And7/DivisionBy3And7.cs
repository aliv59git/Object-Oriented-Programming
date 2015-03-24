using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DivisibleBy3And7
{
    public static class DivisionBy3And7
    {
        public static int[] DivisiobleBy7And3(int[] arr)
        {
            if (arr.Length <=0)
            {
                throw new ArgumentException();
            }
            return arr.Where(n => (n % 3 == 0) && (n % 7 == 0)).ToArray();
        }
        public static int[] DivisiobleBy7And3New(int[] arr)
        {
            if (arr.Length <= 0)
            {
                throw new ArgumentException();
            }
            return (from num in arr
                   where num % 3 == 0 && num % 7 == 0
                   select num).ToArray();
        }

        public static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
