using System;
using System.Collections.Generic;
using System.Linq;


namespace CTS
{
    public class EntryPoints
    {
        public static void PrintIfCat(IAnimal animal)
        {
            if (animal is Cat)
            {
                Console.WriteLine("Yes");
            }
            else if (animal is Dog)
            {
                Console.WriteLine("No, I am dog. ");
            }
            else
            {
                Console.WriteLine("No");
            }
        }


        static void Main(string[] args)
        {
            var cat = new Cat();
            cat.Name = "Pesho";

            var anotherCat = new Cat();
            anotherCat.Name = "Gosho";

            Console.WriteLine(cat.Equals(anotherCat));
            Console.WriteLine(cat==anotherCat);
            Console.WriteLine(cat.GetHashCode());
            Console.WriteLine(anotherCat.GetHashCode());
            Console.WriteLine(cat.ToString());

            var propeties = cat.GetType().GetProperties();
            foreach (var property in propeties)
            {
                Console.WriteLine(property.Name + " " + property.GetValue(cat));
            }

            var propertisTheSame = typeof(Cat).GetProperties(); //прави същото. В единия случай
            //вземаме информация през конкретната инстанция, в другия от конкретния тип (класа). 
            //Тук могат да се вземат методи, и др. много много неща. 
            //метод.Invoke(...) - извиква метода с конкретни параметри/обекти. 
            //Примерно може да изкара всички методи от конзолата така: 

            var consoleType = typeof(Console);
            var methods = consoleType.GetMethods();
            foreach (var item in methods)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();
            //когато не знам какъв обект искам да създам
            var catRunTime = Activator.CreateInstance<Cat>();
            //веднъж като дръпнем пропертитата, методите, трябва да си ги запазим някъде и да си ги извикваме. 
            //При MembewiseClone() трябва да имплементираме IClonamble 
            var myEqual = object.ReferenceEquals(cat, anotherCat); 
            //сравнява само адресите в паметта 
            Console.WriteLine(myEqual);
            // как се използват операторите is и as
            Console.WriteLine(cat is object);
            IAnimal firstAnimal = new Dog();
            PrintIfCat(cat);
            PrintIfCat(firstAnimal);

            //dog. няма  Name, т.е . преди да сме го кастнали към дог, няма име, защото работи през интерфейса. 

             if (firstAnimal is Dog)
            {
                var dogAsDog = (Dog)firstAnimal;
                dogAsDog.Name = "Pesho";
                Console.WriteLine(dogAsDog.Name);
            }
             Console.WriteLine();
             IAnimal secondAnimal = new Cat();
             var firstAnimalAsDog = firstAnimal as Dog;

             if (firstAnimalAsDog != null)
             {
                 Console.WriteLine(firstAnimalAsDog.Name);
             }
             var secondAnimalAsDog = secondAnimal as Dog;
             Console.WriteLine(secondAnimalAsDog== null);







        }


    }


}
