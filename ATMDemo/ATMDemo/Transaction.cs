using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDemo
{
   public class Transaction :ITransaction
    {
        private int accountNumber; // account in transaction
        private Screen userScreen;// message to be displayed on screen
        private BankDatabase database; //reference to the account database

      public Transaction(int userAccount, Screen theScreen,
      BankDatabase theDatabase)
        {
            accountNumber = userAccount;
            userScreen = theScreen;
            database = theDatabase;
        } // end constructor

        // read-only property that gets the account number
        public int AccountNumber
        {
            get
            {
                return accountNumber;
            } // end get
        } // end property AccountNumber

        // read-only property that gets the screen reference
        public Screen UserScreen
        {
            get
            {
                return userScreen;
            } // end get
        } // end property UserScreen

        // read-only property that gets the bank database reference
        public BankDatabase Database
        {
            get
            {
                return database;
            } // end get
        } // end property Database

        public virtual void Execute()
        {
            UserScreen.DisplayMessageLine("Please select one transaction");
        }

    }
}
