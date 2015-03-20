

namespace CatSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FirstCat = CatSystem.Cat;
    using SecondCat = AnimalSystem.Cat;

    public class CatSystemStart
    {
        public static void ChangeNumber(int number)
        {
            number = 100;
        }
        public static void Main()
        {
            FirstCat catM = new FirstCat(CatColor.Brown);
            SecondCat catN = new SecondCat();
           

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

            //var myList = new GenericList<int>();
            //myList.Add(1);
            //myList.Add(123);
            Console.WriteLine();

            Cat myCat = new Cat(CatColor.Black);
            myCat.Name = "Maca";

            Dog myDog = new Dog();
            myDog.Name = "Bobi";
            myDog.SeyBow();

            var myList = new GenericList<Animal>();
            var anotherMyList = new GenericList<Cat>();
            var anotherList = new GenericList<Dog>();

            var value = GetString<int>(5);
            var anotherValue = GetString<bool>(true);

            var min = Min("Vgd", "ert");
            Console.WriteLine(min);

            var mNewCat = new AnimalSystem.Cat();
            Console.WriteLine(mNewCat.SomethisgElse);

            GenericList<int> myGeneric = new GenericList<int>();
            myGeneric.Add(123456);
            Console.WriteLine(myGeneric[0]); //missing Indexer

            var myStrings = new StringCouple();
            myStrings.Add("Pesho", "Peshov");
            myStrings.Add("Ivan", "Ivanov");
            Console.WriteLine("Pesho "+myStrings["Pesho"]);
            Console.WriteLine(myStrings["Ivan"]);
            myStrings["Pesho"] = "Stamatov";
            Console.WriteLine(myStrings["Pesho"]);

        }
        /// <summary>
        /// Generic Collection
        /// </summary>
        /// <typeparam name="T">Parameter</typeparam>
        /// <param name="element"></param>
        /// <returns></returns>

        public static string GetString<T>(T element) 
        {
            return element.ToString();
        }
        public static string GetString(object element)
        {
            return element.ToString();
        }

        public static T Min<T>(T first, T second) //no niamame sravnenie ot dvete
            where T: IComparable<T>
        {
            if (first.CompareTo(second) <=0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }





    }
}
