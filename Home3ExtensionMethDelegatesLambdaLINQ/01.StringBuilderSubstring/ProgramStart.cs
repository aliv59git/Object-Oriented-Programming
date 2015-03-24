using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilderSubstring
{
    class ProgramStart
    {
        static void Main(string[] args)
        {
            StringBuilder strB = new StringBuilder();
            for (int i = 0; i < 26; i++)
            {
                strB.Append((char)(i+65));
            }
            Console.WriteLine(strB[5]);
            Console.WriteLine(strB);
            Console.WriteLine(strB.Length);
            StringBuilder sb = Extensions.SubstringStringBuilder(strB, 3, 5);
            Console.WriteLine(sb);
            Console.WriteLine(strB.SubstringStringBuilder(1, 10));
            Console.WriteLine(strB);
            Console.WriteLine();
        }
    }
}
