using System;
using System.Collections.Generic;
using System.Text;

namespace A2_T2_4831
{
    class Bank
    {
        

        public List<BankAccount> BankAccounts;
        public Bank()
        {
            BankAccounts = new List<BankAccount>();
        }

     


        public void AddAccount(BankAccount bankaccount)
        {
            BankAccounts.Add(bankaccount);
            Console.WriteLine($" Account {bankaccount.GetAccountNumber()} has been added in the Bank ");
        }
        public void DepositToAccount(int accountnumber, double depositamount)
        {
            foreach (var bankaccount in BankAccounts)
            {
                if (accountnumber == bankaccount.GetAccountNumber())
                {
                    bankaccount.Deposit(depositamount);
                }
            }

        }

        public void WithdrawnFromAccount(int accountnumber, int withdraw)
        {
            foreach (var bankaccount in BankAccounts)
            {
                if (accountnumber == bankaccount.GetAccountNumber())
                {
                    bankaccount.Withdraw(withdraw);
                }
            }
        }

    }
}
