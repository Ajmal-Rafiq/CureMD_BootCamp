using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace A2_T2_4831
{
    //public interface IBankAccount {

    //    public void  Deposit(double deposit);
    //    public void Withdraw(double withdraw);
    //}

    //public interface ITransaction {

    //    abstract void ExcecuteTransaction(double amount);
    //    abstract void PrintTransaction();
    
    //}
    //public abstract class BankAccount : IBankAccount
    //{
    //    private int AccountNumber { get; set; }
    //    private string AccountHolderName { get; set; }
    //    private double Balance { get; set; }


    //    public BankAccount(int account_number, string account_holder_name, double balance)
    //    {
    //        AccountNumber = account_number;
    //        AccountHolderName = account_holder_name;
    //        Balance = balance;

    //    }
    //    public virtual string GetName() { return AccountHolderName; }
    //    public virtual void SetName(string accountnholderame) {AccountHolderName= accountnholderame; }
    //    public virtual int GetAccountNumber() { return AccountNumber; }
    //    public virtual void SetAccountNumber(int accountno) { AccountNumber = accountno; }
    //    public virtual double GetBalance() { return Balance; }
    //    public virtual void SetBalance(double balance) { Balance = balance; }

    //    public virtual void Deposit() { }
    //    public virtual void Deposit(double deposit)
    //    {

    //        Balance += deposit;
    //        Console.WriteLine($"Deposit Amount {deposit} has been added in Account Number: {AccountNumber}|| Name: {AccountHolderName} || Current Amount: {Balance}");


    //    }

    //    public virtual void Withdraw() { }

    //    public virtual void Withdraw(double withdraw)
    //    {
    //        if (Balance >= withdraw)
    //        {
    //            Balance -= withdraw;
    //            Console.WriteLine($"Amount {withdraw} has been withdrawn from the  Account Number: {AccountNumber} Name: {AccountHolderName}.\nBalance Amount: {Balance} ");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Your Balance is Not Sufficient For This Transaction.");
    //        }
    //    }


    //    public virtual void DisplayAccountInfo()
    //    {
    //        Console.WriteLine($"Account Number: {AccountNumber} || Name: {AccountHolderName} || Balance Amount: {Balance}");


    //    }

    //    public  virtual void CalculateInterest(double deposit)
    //    { }
    //}

    //public class SavingAccounts : BankAccount, ITransaction
    //{
    //    private double InterestRate;
    //    BankAccount bankaccount;
    //    public SavingAccounts(int account_number, string account_holder_name, double balance, double interest_rate) : base(account_number, account_holder_name, balance)
    //    {
    //        InterestRate = interest_rate;
    //    }

    //    public override void Deposit(double deposit)
    //    {
    //        double amount = deposit;
    //        deposit += deposit * InterestRate;
    //        base.Deposit(deposit);
    //        Console.WriteLine($"Amount Deposited: {amount}.\nAfter Interest Deposited Amount {deposit} Has Been Added in your account.");
    //    }

    //    public override void Deposit()
    //    {

    //    }

    //    public override void Withdraw(double withdraw)
    //    {
    //        base.Withdraw(withdraw);
    //    }

    //    public override void Withdraw()
    //    { }

    //    public override void CalculateInterest(double deposit)
    //    {
    //        deposit = deposit * InterestRate;
    //        Console.WriteLine($"Calculated Interest on Deposit Amount: {deposit}");
    //    }

    //    public void ExcecuteTransaction(double amount)
    //    {
    //        int i;
    //        Console.WriteLine("For Deposit Press '1'. For Withdraw Press '2'. ");
    //        i = int.Parse(Console.ReadLine());
    //        if (i == 1)
    //        {
    //            Deposit(amount);
    //        }
    //        else if (i == 2)
    //        {
    //            Withdraw(amount);

    //        }
    //        else
    //        {
    //            Console.WriteLine("Error! Enter Correct Number. ");

    //        }
    //    }

    //    public void PrintTransaction()
    //    {
    //    }
    //}

//public class CheckingAccount : BankAccount, ITransaction
//    {
//        public CheckingAccount(int account_number, string account_holder_name, double balance) : base(account_number, account_holder_name, balance)
//        { }
//        public override void Withdraw(double withdraw)
//        {
//            base.Withdraw(withdraw);
//        }
//        public override void CalculateInterest(double deposit)
//        {
//            Console.WriteLine("No Interest on Checking Account.");
//        }

//        public override void Deposit(double deposit)
//        {
 
//            base.Deposit(deposit);
            
//        }

//        public void ExcecuteTransaction(double amount) {
//            int i;
//            Console.WriteLine("For Deposit Press '1'. For Withdraw Press '2'. ");
//            i = int.Parse(Console.ReadLine());
//            if (i == 1)
//            {
//                Deposit(amount);
//            }
//            else if (i == 2)
//            {
//                Withdraw(amount);

//            }
//            else
//            {
//                Console.WriteLine("Error! Enter Correct Number. ");

//            }
//       }

//        public void PrintTransaction() { }

//    }



    //public class LoanAccount: BankAccount, ITransaction
    //{
    //    public LoanAccount(int account_number, string account_holder_name, double balance) : base(account_number, account_holder_name, balance)
    //    { }
    //        public override void CalculateInterest(double loanamount)
    //    {   
    //        Console.WriteLine($"Interest on Loan Amount {loanamount}");
    //    }

    //    public override void Withdraw(double withdraw)
    //    {
    //        base.Withdraw(withdraw);
    //    }

    //    public override void Deposit(double deposit)
    //    {

    //        base.Deposit(deposit);

    //    }

    //    public void ExcecuteTransaction(double amount) {
    //        int i;
    //        Console.WriteLine("For Deposit Press '1'. For Withdraw Press '2'. ");
    //        i = int.Parse(Console.ReadLine());
    //        if (i == 1)
    //        {
    //            Deposit(amount);
    //        }
    //        else if (i == 2)
    //        {
    //            Withdraw(amount);

    //        }
    //        else
    //        {
    //            Console.WriteLine("Error! Enter Correct Number. ");

    //        }
    //    }

    //    public void PrintTransaction() {
    //        int i;
    //        i = int.Parse(Console.ReadLine());

    //    }


    //}





    //public class Bank
    //{
    //    public List<BankAccount> BankAccounts;
    //    public Bank()
    //    {
    //        BankAccounts = new List<BankAccount>();
    //    }


    //    public void AddAccount(BankAccount bankaccount)
    //    {
    //        BankAccounts.Add(bankaccount);
    //        Console.WriteLine($" Account Number {bankaccount.GetAccountNumber()} has been added in the Bank ");
    //    }
    //    public void DepositToAccount(int accountnumber, double depositamount)
    //    {
    //        foreach (var bankaccount in BankAccounts)
    //        {
    //            if (accountnumber == bankaccount.GetAccountNumber())
    //            {
    //                bankaccount.Deposit(depositamount);
    //            }
    //        }

    //    }

    //    public void WithdrawnFromAccount(int accountnumber, int withdraw)
    //    {
    //        foreach (var bankaccount in BankAccounts)
    //        {
    //            if (accountnumber == bankaccount.GetAccountNumber())
    //            {
    //                bankaccount.Withdraw(withdraw);
    //            }
    //        }
    //    }





    //}
    class Program
    {
        static void Main(string[] args)
        {

            Bank bank = new Bank();

            SavingAccounts savingAccounts = new SavingAccounts(21871, "John", 5000, 0.25);
            CheckingAccount checkingAccounts = new CheckingAccount(56545, "Alex", 2500);

            bank.AddAccount(savingAccounts);
            bank.AddAccount(checkingAccounts);

            bank.DepositToAccount(21871, 200);
            bank.WithdrawnFromAccount(21871, 5500);

            SavingAccounts account1 = new SavingAccounts(21851, "John", 5000,0.25);
            account1.CalculateInterest(500);
            LoanAccount loanAccount = new LoanAccount(717717,"Andrew", 10000);
            loanAccount.ExcecuteTransaction(500);
            loanAccount.ExcecuteTransaction(200);

            savingAccounts.GetTransactionHistory();
            
        }

    }
}
