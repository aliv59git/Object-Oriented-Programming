using System;
using SchoolSystem.Inetrface;

namespace SchoolSystem
{
    public class Person: IPerson
    {
        private string name;

        public Person() 
        {
        }
        public Person(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }


        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                if (value.Length < 2 || value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.name = value;
            }
        }

        public string Email { get; private set; }


        public void Walk()
        {
            Console.WriteLine("{0} is walking. ", this.Name);
        }

    }
}
