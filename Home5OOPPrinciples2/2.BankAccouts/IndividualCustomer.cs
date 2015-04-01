using System;


namespace _2.BankAccouts
{
    public class IndividualCustomer : Customer
    {
        private string name;

        public IndividualCustomer(string name)
            : this()
        {
            this.Name = name;
        }
        public IndividualCustomer()
        {
        }

        public override string Name
        {
            get { return this.name; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Customer must have name!");
                }
                if (value.Length < 1 || value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.name = value;
            }
        }

    }
}
