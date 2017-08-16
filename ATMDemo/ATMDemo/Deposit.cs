//Deposit.cs 
// Represents deposit transaction
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDemo
{
    public class Deposit: Transaction
    {
        private decimal amount; // amount to deposit
        private Keypad keypad; // reference to the Keypad
        private bool isDepositReceived; // variable to check if deposit is received

        // constant representing cancel option
        private const int CANCELED = 0;

        // Initialize constructor
        public Deposit(int userAccountNumber, Screen atmScreen,
           BankDatabase atmBankDatabase, Keypad atmKeypad)
           : base(userAccountNumber, atmScreen, atmBankDatabase)
        {
            // initialize references to keypad 
            keypad = atmKeypad;
            isDepositReceived = true;// will return true as this is a simulation
        }

        public override void Execute()
        {
            amount = GetDepositAmount(); //Get amount from user

            // check whether the amount is cancelled or has valid input
            if (amount != CANCELED)
            {
                UserScreen.DisplayMessage("\n Please insert your cash");
                UserScreen.DisplayDollarAmount(amount);
                UserScreen.DisplayMessageLine(" cash inserted");

                // will be true for this simulation
                if (isDepositReceived)
                {
                    UserScreen.DisplayMessageLine("Your deposit has been received. It may take some time to reflect");
                    //credit account to reflect deposit
                    Database.Credit(AccountNumber, amount);

                }
                else
                {
                    UserScreen.DisplayMessageLine("We did not receive your cash");
                }
            }
            else
                UserScreen.DisplayMessageLine("\n cancelling transaction");

        }

        private decimal GetDepositAmount()
        {
            UserScreen.DisplayMessage("\n Please eneter a deposit amount in CENTS(or 0 to cancel :)");
            int input = keypad.GetInput();

            //check whether the user cancelled a valid amount
            if (input == CANCELED)
                return CANCELED;
            else
                return input / 100.00M;
        }

    }
}
