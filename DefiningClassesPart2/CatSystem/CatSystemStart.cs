using System;
using System.Collections.Generic;
using System.Linq;

namespace CatSystem
{
    public class CatSystemStart
    {
        public static void ChangeNumber(int number)
        {
            number = 100;
        }


        public static void Main()
        {
            int number = 1000000;
            ChangeNumber(number);
            Console.WriteLine(number);

            var peshoOwner = new Owner("Pesho", "Ivanov");
            var goshoOwner = new Owner("Gosho", "Stojanov");

            peshoOwner.IncreaseAge();
            peshoOwner.IncreaseAge();
            peshoOwner.IncreaseAge();
            peshoOwner.IncreaseAge();

            Console.WriteLine(peshoOwner.Age);
            Console.WriteLine(peshoOwner.FullName);

            Cat cat = new Cat(CatColor.Mixed);
            Cat anotherCat = new Cat(CatColor.Black);
            Cat yetAnotherCat = new Cat(CatColor.Brown);
            peshoOwner.AddCats(cat, "Maca");
            peshoOwner.AddCats(anotherCat, "Silvester");

            Console.WriteLine(peshoOwner.AllCats);
            Console.WriteLine(Cat.NumberOfLegs);
            Console.WriteLine(Cat.WhatDoesTheCatsSay());

            Printer.PrintCat(yetAnotherCat);

            var point = new Point();
            point.X = 12.3f;
            point.Y = 3.14f;

            Console.WriteLine(point.GetCoordinates());

            var myList = new GenericList<int>();
            myList.Add(1);
            myList.Add(123);
            Console.WriteLine();




        }
    }
}
