using System;



namespace CatSystem
{
    using System.Collections.Generic;
    using System.Linq;

    public class Owner
    {
        private string firstName;
        private string lastName;

        private List<Cat> cats;

        public Owner(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Age = 0;
            this.cats = new List<Cat>(); 
        }

        public string FirstName 
        {
            get
            {
                return this.firstName;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", this.firstName, this.lastName);
            }
        }

        public int Age { get; private set; }

        public string AllCats
        {
            get
            {
                return string.Join(", ", this.cats.Select(c => c.Name));
            }
        }




        public void IncreaseAge()
        {
            this.Age++;
        }

        public void AddCats(Cat cat, string name)
        {
            if (this.cats.Contains(cat))
            {
                throw new ArgumentException();  
            }

            cat.Name = name;
            cat.Owner = this;
            this.cats.Add(cat);
        }

    }
}
