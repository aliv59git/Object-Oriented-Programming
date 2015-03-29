using System;



namespace _3.AnimalHierarchy
{
    public class Kitten : Cat
    {
        public Kitten(int age, string name, string sex)
            : this(name)
        {
            this.Age = age;
            this.Sex = "Female";
        }
        public Kitten(string name)
            : this()
        {
            this.Name = name;
        }
        public Kitten()
        {
        }



    }
}
