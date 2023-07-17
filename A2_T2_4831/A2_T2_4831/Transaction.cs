using System;
using System.Collections.Generic;
using System.Text;

namespace A2_T2_4831
{
    class Transaction
    {
        public DateTime Date { get; }
        public int AccountNo { get; }
        public double Amount { get; }
       
        public Transaction(double amount, DateTime date,int accountNo)
        {
            Amount = amount;
            Date = date;
            AccountNo = accountNo;

        }



     
    }
}
