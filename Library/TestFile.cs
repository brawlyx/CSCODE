using System;

namespace Library
{
    public class BankAccount
    {
        public string Number{ get;}
        public string Owner {get; set;}
        public string Balance {get;}

        public void MakeDeposit (decimal amount, DateTime date, string note)
        {
        }
         public void MakeWithdrawal (decimal amount, DateTime date, string note)
        {
        }

    }
}