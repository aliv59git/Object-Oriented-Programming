using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccouts
{
    public class Customer
    {
        private string name;
        private LoanCustomer customerType;

        public Customer(string name, LoanCustomer customerType)
            : this()
        {
            this.Name = name;
            this.CustomerType = customerType;
        }
        public Customer()
        {
        }

        public string Name
        {
            get { return this.name; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                if (value.Length < 1 || value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.name = value;
            }
        }
        public LoanCustomer CustomerType
        {
            get { return this.customerType; }
            protected set
            {
                if (this.customerType != LoanCustomer.Individual || this.customerType != LoanCustomer.Company)
                {
                    throw new ArgumentOutOfRangeException("Customer types must be Individual or Company!");
                }
                this.customerType = value;
            }
        }

    }
}
