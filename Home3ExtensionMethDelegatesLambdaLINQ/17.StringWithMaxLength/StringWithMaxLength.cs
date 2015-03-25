using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.StringWithMaxLength
{
    public class StringWithMaxLength
    {
        static void Main(string[] args)
        {
            string[] strings = { 
                               "The string woth mad mength is probably in this row. ",
                               "Ivan Ivanov says:", 
                               "May Dog doggy barks very well.",
                               "The Scientific Calculator is not simple for implamantations without using JavaScript."
                               };
            string result = strings.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
            Console.WriteLine(result);
        }
    }
}
