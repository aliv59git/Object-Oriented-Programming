using System;
using System.Collections.Generic;
using System.Linq;


namespace _2.BankAccouts
{
    public class StartBankAccounts
    {
        static void Main(string[] args)
        {
            Customer pepi = new Customer("Pesho", LoanCustomer.Individual);
            BankAccount account1 = new DepositAccount( new Customer("Pesho", LoanCustomer.Individual), 1234.32, 3.75, 2345.23, 234.56);
            Console.WriteLine(pepi.CustomerType);
        }
    }
}
