using System;
using System.Linq;

// pag 95

namespace CSharpLearn
{
    class Account
    {
        public string Name {get; set;}
        private decimal balance; // instance variable

        public Account(string accountName, decimal initialBalance){
            Name = accountName;
            Balance = initialBalance;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }

            private set
            {
                // can be used only within the class
                if(value > 0.0m)
                {
                    balance = value;
                }
            }
        }
        
        public void Deposit(decimal depositAmount)
        {
            if(depositAmount > 0.0m)
            {
                Balance = Balance
                          + depositAmount;
            }
        }

    } 
}