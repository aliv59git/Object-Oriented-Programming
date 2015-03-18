using System;
using System.Collections.Generic;
using System.Linq;


namespace CatSystem
{
    public static class Printer
    {
        public static void PrintCat(Cat cat)
        {
            Console.WriteLine(cat.Name + " " + cat.Age);
        }
    }
}
