using System;
using System.Collections.Generic;
using System.Text;

namespace A2_T2_4831
{
    class CheckingAccount : BankAccount, ITransaction
    {
        public CheckingAccount(int account_number, string account_holder_name, double balance) : base(account_number, account_holder_name, balance)
        { }
        public override void Withdraw(double withdraw)
        {
            base.Withdraw(withdraw);
        }
        public override void CalculateInterest(double deposit)
        {
            Console.WriteLine("No Interest on Checking Account.");
        }

        public override void Deposit(double deposit)
        {

            base.Deposit(deposit);

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

        public void PrintTransaction() {

            Console.WriteLine($"{GetAccountNumber()} || {GetName()}|| {GetBalance()}");
        }

    }
}
