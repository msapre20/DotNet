using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Account.cs
//Used to represent the account
namespace ATMDemo
{
   public class Accounts
    {

        private int accountNumber; // account number
        private int pin;          // pin used to validate
        private decimal availableBalance; //available to withdraw
        private decimal totalBalance; // available cash + deposit;

        // Constructor for Initialization of attributes
        public Accounts(int theAccountNumber, int thePIN, decimal theAvailableBalance, decimal theTotalBalance)
        {
            accountNumber = theAccountNumber;
            pin = thePIN;
            availableBalance = theAvailableBalance;
            totalBalance = theTotalBalance;
        }

        //read only propert to get the account number
        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }

        // read only property that gets the available balance
        public decimal AvailableBalance
        {
            get
            {
                return availableBalance;
            }
        }
        // read only property that gets the total balance
        public decimal TotalBalance
        {
            get
            {
                return totalBalance;
            }
        }

        // determines whether a user-specified PIN matches PIN in Account

        public bool ValidatePIN(int userPIN)
        {
            return (userPIN == pin);
        }
        //adds to the balance
        public void Credit(decimal amount)
        {
            totalBalance += amount;
        }
        //debits the account
        public void Debit(decimal amount)
        {
            availableBalance -= amount;
            totalBalance -= amount;
        }


    }
}
