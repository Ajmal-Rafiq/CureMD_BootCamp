using System;
using System.Collections.Generic;
using System.Text;

namespace A2_T2_4831
{
    interface ITransaction
    {

        abstract void ExcecuteTransaction(double amount);
        abstract void PrintTransaction();
    }
}
