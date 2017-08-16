//BankDatabase.cs
//Database system
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDemo
{
  public class BankDatabase
    {
        private Accounts[] validaccounts; // array of bank account

        public BankDatabase()
        {
            // Create accounts for testing
            // place them in the accounts array
            validaccounts = new Accounts[3];
            validaccounts[0] = new Accounts(2087, 1200, 10000.00M, 11000.00M);
            validaccounts[1] = new Accounts(2088, 1400, 12000.00M, 15000.00M);
            validaccounts[2] = new Accounts(2089, 1600, 18000.00M, 20000.00M);
        }

        //retrieve account with the account number

        private Accounts GetAccount(int accountNumber)
        {
            //loop through accounts to find a match

            foreach (Accounts currentAccount in validaccounts)
            {
                if (currentAccount.AccountNumber == accountNumber)
                    return currentAccount;
            }
            // account not found
            return null;
        }

        public bool AuthenticateUser(int userAccountNumber, int userPIN)
        {
            //attempt to retrieve the account with the account number

            Accounts userAccount = GetAccount(userAccountNumber);

            //if accounts exists,return result of account function ValidatePIN
            if (userAccount != null)

                return userAccount.ValidatePIN(userPIN);

            else
                return false; //account number not found so return false
        }
        // return available balance
        public decimal GetAvailableBalance(int userAccountNumber)
        {
            Accounts userAccount = GetAccount(userAccountNumber);
            return userAccount.AvailableBalance;
        }
        // return total Balance
        public decimal GetTotalBalance(int userAccountNumber)
        {
            Accounts userAccount = GetAccount(userAccountNumber);
            return userAccount.TotalBalance;
        }
        // credit the amount with specified account number
        public void Credit(int userAccountNumber, decimal amount)
        {
            Accounts userAccount = GetAccount(userAccountNumber);
            userAccount.Credit(amount);
        }

        //debit the account with accountNumber

        public void Debit(int userAccountNumber, decimal amount)
        {
            Accounts userAccount = GetAccount(userAccountNumber);
            userAccount.Debit(amount);
        }

    }
}
