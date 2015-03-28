using System;

namespace _3.AnimalHierarchy
{
    public class Frog : Animal
    {
        public Frog(int age, string name, string sex)
            : this(name)
        {
            this.Age = age;
            this.Sex = sex;
        }

        public Frog(string name)
            :this()
        {
            this.Name = name;
        }

        public Frog()
        {
        }



        public override void Sound()
        {
            Console.WriteLine("The {0} {1} like to say: Kwa, kwa, kwa!...", this.GetType(), this.Name);
        }
    }
}
