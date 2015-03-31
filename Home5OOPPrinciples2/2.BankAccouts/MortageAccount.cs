using System;


namespace _2.BankAccouts
{
    public class MortageAccount: BankAccount
    {
        private double interest_rate;

        public MortageAccount(Customer customer, double balance, double interest_rate, double depositMoney)
            : this()
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Interest_Rate = interest_rate;
            this.DepositMoney = depositMoney;
        }

        public MortageAccount()
            : base()
        {
        }
        public override double Interest_Rate
        {
            get { return this.interest_rate; }
            set
            {
                if (value < 0.01 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("Invalid Interest rate!");
                }
                this.interest_rate = value;
            }
        }

        public override double InterestAmount(int monts)
        {
            if (this.Customer.GetType().Name == "IndividualCustomer" && monts <= 6)
            {
                return 0;
            }
            else if (this.Customer.GetType().Name == "CompanyCustomer" && monts <= 12)
            {
                return this.Interest_Rate * monts/2;
            }
            else
            {
                return this.Interest_Rate * monts;
            }
        }
    }
}
