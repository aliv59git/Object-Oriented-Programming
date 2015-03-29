using System;


namespace _3.AnimalHierarchy
{
    public class Dog : Animal
    {

        public Dog(int age, string name, string sex)
            : this(name)
        {
            this.Age = age;
            this.Sex = sex;
        }

        public Dog(string name)
            :this()
        {
            this.Name = name;
        }

        public Dog()
        {
        }

        public override void Sound()
        {
            Console.WriteLine("{0} {1} says Bou, bou!...", this.GetType(), this.Name);
        }
    }
}
