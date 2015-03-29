using System;


namespace _1.SchoolClasses
{
    public class Person : IPerson, IComments
    {
        private string name;
        private string comments;

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
            internal set
            {
                if (value.Length < 2 || value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("The name is unusually long/short");
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                foreach (var ch in value)
                {
                    if (!IsAllowedSymbol(ch))
                    {
                        throw new ArgumentException();
                    }
                }
                this.name = value;
            }
        }

        public string Comments
        {
            get { return this.comments; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("You have no commemt!");
                }
                this.comments = value;
            }

        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Comments: {1}", this.Name, this.Comments);
        }


        internal bool IsAllowedSymbol(char ch)
        {
            bool isAllowed = Char.IsLetterOrDigit(ch) || ch == '-' || ch == ' ' || ch == '_';
            return isAllowed;
        }
    }
}
