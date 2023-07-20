using System;
using System.Collections.Generic;
using System.Text;

namespace A2_T2_4831
{
    class SavingAccounts : BankAccount, ITransaction
    {
        private double InterestRate;
        BankAccount bankaccount;
        public SavingAccounts(int account_number, string account_holder_name, double balance, double interest_rate) : base(account_number, account_holder_name, balance)
        {
            InterestRate = interest_rate;
        }

        public override void Deposit(double deposit)
        {
            double amount = deposit;
            deposit += deposit * InterestRate;
            base.Deposit(deposit);
            Console.WriteLine($"Amount Deposited: {amount}.\nAfter Interest Deposited Amount {deposit} Has Been Added in your account.");
        }

        public override void Deposit()
        {

        }

        public override void Withdraw(double withdraw)
        {
            base.Withdraw(withdraw);
        }

        public override void Withdraw()
        { }

        public override void CalculateInterest(double deposit)
        {
            deposit = deposit * InterestRate;
            Console.WriteLine($"Calculated Interest on Deposit Amount: {deposit}");
        }

        public void ExcecuteTransaction(double amount)
        {
            int i;
            Console.WriteLine("For Deposit Press '1'. For Withdraw Press '2'. ");
            i = int.Parse(Console.ReadLine());
            if (i == 1)
            {
                Deposit(amount);
            }
            else if (i == 2)
            {
                Withdraw(amount);

            }
            else
            {
                Console.WriteLine("Error! Enter Correct Number. ");

            }
        }

        public void PrintTransaction()
        {
            Console.WriteLine($"{GetAccountNumber()} || {GetName()}|| {GetBalance()}");
        }
    }
}

