using System;
using System.Collections.Generic;
using System.Text;

namespace A2_T2_4831
{
    abstract class BankAccount : IBankAccount
    {

        private int AccountNumber { get; set; }
        private string AccountHolderName { get; set; }
        private double Balance { get; set; }

        private List<Transaction> TransactionsHistory;


        public BankAccount(int account_number, string account_holder_name, double balance)
        {
            AccountNumber = account_number;
            AccountHolderName = account_holder_name;
            Balance = balance;
            TransactionsHistory = new List<Transaction>();

        }
        public virtual string GetName() { return AccountHolderName; }
        public virtual void SetName(string accountnholderame) { AccountHolderName = accountnholderame; }
        public virtual int GetAccountNumber() { return AccountNumber; }
        public virtual void SetAccountNumber(int accountno) { AccountNumber = accountno; }
        public virtual double GetBalance() { return Balance; }
        public virtual void SetBalance(double balance) { Balance = balance; }

        public virtual void Deposit() { }
        public virtual void Deposit(double deposit)
        {

            Balance += deposit;
            //AddTransaction(deposit, "Deposit");
            Console.WriteLine($"Deposit Amount {deposit} has been added in Account Number: {AccountNumber}|| Name: {AccountHolderName} || Current Amount: {Balance}");


        }

        public virtual void Withdraw() { }
        public  void GetTransactionHistory()
        {
            var report = new System.Text.StringBuilder();
            report.AppendLine("Date\t\tAccount No.\tBalance");
            foreach (var transaction in TransactionsHistory) 
            {
                report.AppendLine($"{transaction.Date.ToShortDateString()}\t{transaction.AccountNo}\t{transaction.Amount}");

            }

            Console.WriteLine(report);
        }

        public virtual void Withdraw(double withdraw)
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

        public virtual void CalculateInterest(double deposit)
        { }


       
    }

   
}
