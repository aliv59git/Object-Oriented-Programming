using System;


namespace _2.BankAccouts
{
    public class DepositAccount : BankAccount
    {
        private double interest_rate;
        private double drawMoney;

        public DepositAccount(Customer customer, double balance, double interest_rate, double depositMoney, double drawMoney)
            : this()
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Interest_Rate = interest_rate;
            this.DepositMoney = depositMoney;
            this.DrawMoney = drawMoney;
        }
        public DepositAccount()
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
                    throw new ArgumentOutOfRangeException();
                }
                this.interest_rate = value;
            }
        }
        public override double DrawMoney
        {
            get { return this.drawMoney; }
            set
            {
                if (value > this.Balance)
                {
                    throw new ArgumentOutOfRangeException("You can draw money up to your Balance!");
                }
                this.drawMoney = value;
            }
        }

        public override double InterestAmount(int monts)
        {
            if (this.Balance < 1000 && this.Balance > 0)
            {
                return 0;
            }
            else
            {
                return this.Interest_Rate * monts;
            }
        }

    }
}
