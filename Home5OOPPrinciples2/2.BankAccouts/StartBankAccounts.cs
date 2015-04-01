using System;
using System.Collections.Generic;
using System.Linq;


namespace _2.BankAccouts
{
    public class StartBankAccounts
    {
        static void Main(string[] args)
        {
            Customer pepi = new IndividualCustomer("Pesho");
            List<BankAccount> accounts = new List<BankAccount>();
            Console.WriteLine();
            BankAccount account1 = new DepositAccount(new IndividualCustomer("Pesho"), 1234.32, 3.75 / 12, 2345.23, 234.56);
            BankAccount account2 = new DepositAccount(new CompanyCustomer("Pepsi"), 1234234.32, 3.95 / 12, 22342345.23, 223434.56);
            BankAccount account3 = new DepositAccount(new IndividualCustomer("Gosho"), 834.32, 3.75 / 12, 2345.23, 234.56);
            BankAccount account4 = new LoanAccount(new CompanyCustomer("Kris"), 12344.32, 3.35 / 12, 2245.23);
            BankAccount account5 = new LoanAccount(new IndividualCustomer("Val"), 4234.32, 3.35 / 12, 226);
            BankAccount account6 = new MortageAccount(new CompanyCustomer("Volf"), 132344.32, 3.35 / 12, 2245.23);
            BankAccount account7 = new MortageAccount(new IndividualCustomer("Stefan"), 14234.32, 3.35 / 12, 226);
            Console.WriteLine(pepi.Name);
            accounts.Add(account1);
            accounts.Add(account2);
            accounts.Add(account3);
            accounts.Add(account4);
            accounts.Add(account5);
            accounts.Add(account6);
            accounts.Add(account7);
            foreach (var item in accounts)
            {
            Console.WriteLine("Customer: {0}, Balance: {1}, Interest_Rate: {2:F5}, DepositMoney: {3}, DrawMoney: {4}", item.Customer.Name, item.Balance, item.Interest_Rate, item.DepositMoney, item.DrawMoney);
            Console.WriteLine();   
            }
            Console.WriteLine("Interest Amount of account 1(Deposit Individual, 5 months): {0:F5}, Increased Balace: {1:F2}", account1.InterestAmount(5), account1.InterestAmount(5) * account1.Balance);
            Console.WriteLine("Interest Amount of account 2(Deposit Company), 3 months: {0:F5}, Increased Balace: {1:F2}", account2.InterestAmount(3), account2.InterestAmount(3) * account2.Balance);
            Console.WriteLine("Interest Amount of account 3(Deposit Individual), 5 months: {0:F5}, Increased Balace: {1:F2}", account3.InterestAmount(5), account3.InterestAmount(5) * account3.Balance);
            Console.WriteLine("Interest Amount of account 4(Loan Company), 3 months: {0:F5}, Increased Balace: {1:F2}", account4.InterestAmount(3), account4.InterestAmount(3) * account4.Balance);
            Console.WriteLine("Interest Amount of account 5(Loan Individual), 3 months: {0:F5}, Increased Balace: {1:F2}", account5.InterestAmount(3), account5.InterestAmount(3) * account5.Balance);
            Console.WriteLine("Interest Amount of account 6(Mortage Company):, 5 months: {0:F5}, Increased Balace: {1:F2}", account6.InterestAmount(5),  account6.InterestAmount(5)*account6.Balance);
            Console.WriteLine("Interest Amount of account 7(Mortage Individual), 5 months: {0:F5}, Increased Balace: {1:F2}", account7.InterestAmount(5), account7.InterestAmount(5)*account7.Balance);

        }
    }
}
