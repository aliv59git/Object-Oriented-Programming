using System;


namespace _2.BankAccouts
{
    public abstract class BankAccount
    {
        private double depositMoney;

        public string Customer { get; protected set; }
        public double Balance { get; protected set; }
        public abstract double Interest_Rate { get; set; }
        public double DepositMoney
        {
            get { return this.depositMoney; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Deposit has'n have negative values.");
                }
                this.depositMoney = value;
            }
        }

        public abstract double InterestAmount(int monts);


    }
}
