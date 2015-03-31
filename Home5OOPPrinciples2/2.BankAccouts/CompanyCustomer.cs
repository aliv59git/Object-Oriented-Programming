using System;


namespace _2.BankAccouts
{
    public class CompanyCustomer : Customer
    {
        private string name;

        public CompanyCustomer(string name)
            : this()
        {
            this.Name = name;
        }
        public CompanyCustomer()
        {
        }

        public override string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Customer must have name!");
                }
                if (value.Length < 2 || value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.name = value;
            }
        }

    }
}
