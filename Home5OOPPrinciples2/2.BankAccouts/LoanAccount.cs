using System;


namespace _2.BankAccouts
{
    public class LoanAccount: BankAccount
    {
        private double interest_rate;

        public LoanAccount(Customer customer, double balance, double interest_rate, double depositMoney)
            : this()
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Interest_Rate = interest_rate;
            this.DepositMoney = depositMoney;
        }
        public LoanAccount()
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

            return this.Interest_Rate * monts;
        }

    }
}
