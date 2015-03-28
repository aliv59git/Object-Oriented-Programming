using System;

namespace _3.AnimalHierarchy
{
    public abstract class Animal : IComparable<Animal>, ISound
    {
        private int age;
        private string name;
        private string sex;

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentOutOfRangeException("The age of this Animals should be up to 30 years.");
                }
                this.age = value;
            }
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 2 || value.Length > 40)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.name = value;
            }
        }
        public string Sex
        {
            get { return this.sex; }
            set
            {
                if (value != "Male" && value != "Female")
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.sex = value;
            }
        }


        public abstract void Sound();



        public override string ToString()
        {
            return String.Format("{0} {1} is {2} years old. It is {3}.", this.GetType(), this.Name, this.Age, this.Sex);
        }

        public virtual int CompareTo(Animal other)
        {
            return this.Age.CompareTo(other.Age);
        }
    }
}
