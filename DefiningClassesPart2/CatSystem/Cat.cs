using System;


namespace CatSystem
{
    public class Cat
    {
        public static int NumberOfLegs
        {
            get
            {
                return 4;
            }
        }

        public Cat(CatColor color)
        {
            this.Color = color;
        }

        public string Name { get; set; }

        public int Age { get; private set; }

        public Owner Owner { get; set; }

        public CatColor Color { get; private set; }

        public static string WhatDoesTheCatsSay()
        {
            return "Miauuuu!";
        }

    }
}
