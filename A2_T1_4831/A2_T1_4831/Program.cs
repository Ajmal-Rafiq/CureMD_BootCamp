using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace A2_T1_4831
{

    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double Balance { get; set; }


        public BankAccount(int account_number, string account_holder_name, double balance)
        {
            AccountNumber = account_number;
            AccountHolderName = account_holder_name;
            Balance = balance;

        }

        public virtual void Deposit(double deposit)
        {

            Balance += deposit;
            Console.WriteLine($"Deposit Amount {deposit} has been added in Account Number: {AccountNumber}|| Name: {AccountHolderName} || Current Amount: {Balance}");


        }

        public virtual void Withdraw(int withdraw)
        {
            if (Balance >= withdraw)
            {
                Balance -= withdraw;
                Console.WriteLine($"Amount {withdraw} has been withdrawn from the  Account Number: {AccountNumber} Name: {AccountHolderName}.\nBalance Amount: {Balance} ");
            }
            else
            {
                Console.WriteLine("Your Balance is Not Sufficient For This Transaction.");
            }
        }


        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber} || Name: {AccountHolderName} || Balance Amount: {Balance}");


        }

    }

    public class SavingAccounts : BankAccount
    {
        private double InterestRate;
        public SavingAccounts(int account_number, string account_holder_name, double balance, double interest_rate) : base(account_number, account_holder_name, balance)
        {
            InterestRate = interest_rate;

        }
        public override void Deposit(double deposit)
        {
            double amount = deposit;
            deposit += deposit * InterestRate;
            base.Deposit(deposit);
            Console.WriteLine($"Amount Deposited: {amount}. \nAfter Interest Deposited Amount {deposit} Has Been Added in your account. Current Amount: {Balance}");
        }


    }

    public class CheckingAccounts : BankAccount
    {
        public CheckingAccounts(int account_number, string account_holder_name, double balance) : base(account_number, account_holder_name, balance)
        { }
        public override void Withdraw(int withdraw)
        {
            if (Balance >= withdraw)
            {
                Balance -= withdraw;
                Console.WriteLine($"Amount {withdraw} has been withdrawn from the  Account Number: {AccountNumber} Name: {AccountHolderName}.\nBalance Amount: {Balance} ");
            }
            else
            {
                Console.WriteLine("Your Balance is Not Sufficient For This Transaction.");
            }
        }
    }

    public class Bank
    {
        public List<BankAccount> BankAccounts;
        public Bank()
        {
            BankAccounts = new List<BankAccount>();
        }


        public void AddAccount(BankAccount bankaccount)
        {
            BankAccounts.Add(bankaccount);
            Console.WriteLine($"User {bankaccount.AccountHolderName} of Account {bankaccount.AccountNumber} has been added in the Bank ");
        }
        public void DepositToAccount(int accountnumber, double depositamount)
        {
            foreach (var bankaccount in BankAccounts)
            {
                if (accountnumber == bankaccount.AccountNumber)
                {
                    bankaccount.Deposit(depositamount);
                }
            }

        }

        public void WithdrawnFromAccount(int accountnumber, int withdraw)
        {
            foreach (var bankaccount in BankAccounts)
            {
                if (accountnumber == bankaccount.AccountNumber)
                {
                    bankaccount.Withdraw(withdraw);
                }
            }
        }


        


    }
    class Program
    {
        static void Main(string[] args)
        {

            Bank bank = new Bank();

            SavingAccounts savingAccounts = new SavingAccounts(21871, "John", 5000, 0.25);
            CheckingAccounts checkingAccounts = new CheckingAccounts(56545, "Alex", 2500);

            bank.AddAccount(savingAccounts);
            bank.AddAccount(checkingAccounts);

            bank.DepositToAccount(21871, 200);
            bank.WithdrawnFromAccount(21871, 5500);

            BankAccount account1 = new BankAccount(21871, "John", 5000);
            account1.Deposit(2000);
            account1.Deposit(2000);
            account1.Deposit(2000);
            account1.DisplayAccountInfo();
        }
    }
}
