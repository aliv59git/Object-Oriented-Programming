using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DivisibleBy3And7
{
    class ProgramTest
    {
        static void Main(string[] args)
        {
            int[] arr = new []{ 3, 5, 63, 7, 8, 12, -12, 24, -126, 35, 11, 18, 21};
            DivisionBy3And7.PrintArray(DivisionBy3And7.DivisiobleBy7And3(arr));
            Console.WriteLine();
            DivisionBy3And7.PrintArray(DivisionBy3And7.DivisiobleBy7And3New(arr));

        }
    }
}
