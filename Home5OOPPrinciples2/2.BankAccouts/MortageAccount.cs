using System;


namespace _2.BankAccouts
{
    public class MortageAccount: BankAccount
    {
        private double interest_rate;

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
