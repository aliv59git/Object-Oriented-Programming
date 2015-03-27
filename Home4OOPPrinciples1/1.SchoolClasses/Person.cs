using System;


namespace _1.SchoolClasses
{
    public class Person : IPerson
    {
        private string name;

        public Person(string name)
            : this()
        {
            this.Name = name;
        }

        public Person()
        {
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 2 || value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("The name is unusually long/short");
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }
    }
}
