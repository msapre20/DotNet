using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDemo
{
  public class Withdrawal :Transaction
    {
        private decimal amount; // amount to withdraw
        private Keypad keypad; // refernce to Keypad
        private CashDispenser cashDispenser; // reference to cash dispenser

        //constant that corresponds to menu option to cancel

        private const int CANCELED = 6;

        public Withdrawal(int userAccountNumber, Screen atmScreen,
            BankDatabase atmBankDatabase, Keypad atmKeypad, CashDispenser atmCashDispenser) : base(userAccountNumber, atmScreen, atmBankDatabase)
        {
            //initialize keypad and CashDispenser
            keypad = atmKeypad;
            cashDispenser = atmCashDispenser;
        }

        //perform transaction

        public override void Execute()
        {
            bool cashDispensed = false; // cash not dispensed yet

            bool transactioncanceled = false;

            // perform looping for dispensing cash
            do
            {
                int selection = DisplayMenuOfAmounts();

                //check if transaction is cancelled or user has selected display amount
                if (selection != CANCELED)
                {
                    //set amount to slected amount
                    amount = selection;

                    //get available balance of account involved
                    decimal availableBalance = Database.GetAvailableBalance(AccountNumber);

                    //check if enough money available
                    if (amount <= availableBalance)
                    {
                        if (cashDispenser.IsSufficientCashAvailable(amount))
                        {
                            //debit account to reflect withdrawal
                            Database.Debit(AccountNumber, amount);
                            cashDispenser.DispenseCash(amount);
                            cashDispensed = true;

                            UserScreen.DisplayMessageLine("\n Please take your cash");
                        }
                        else
                            UserScreen.DisplayMessageLine("Insufficient funds available. Please choose a smaller amount");
                    }
                    else
                        UserScreen.DisplayMessageLine("Insufficient funds available. Please choose a smaller amount");
                }
                else
                {
                    UserScreen.DisplayMessageLine("\n cancelling transaction...");
                }
            } while ((!cashDispensed) && (!transactioncanceled));

        }

        private int DisplayMenuOfAmounts()
        {
            int userChoice = 0;//variable to return value

            //array of amounts to correspond to menu
            int[] amounts = { 0, 20, 40, 60, 100, 200 };

            //loop until a valid choice is entered

            while (userChoice == 0)
            {
                UserScreen.DisplayMessageLine("\n Withdrawal options:");
                UserScreen.DisplayMessageLine("1 - $20");
                UserScreen.DisplayMessageLine("2 - $40");
                UserScreen.DisplayMessageLine("3 - $60");
                UserScreen.DisplayMessageLine("4 - $100");
                UserScreen.DisplayMessageLine("5 - $200");
                UserScreen.DisplayMessageLine("6 - Cancel Transaction");
                UserScreen.DisplayMessageLine(" \n Choose a withdrawl option(1-6):");

                //get user input
                int input = keypad.GetInput();

                //switch according to entered option
                switch (input)
                {
                    case 1: case 2: case 3: case 4: case 5:
                        userChoice = amounts[input];// return corresponding amount
                        break;
                    case CANCELED:
                        userChoice = CANCELED; // to cancel
                        break;
                    default:
                        UserScreen.DisplayMessageLine("Invalid Selection");
                        break;
                }

            }
            return userChoice;
        }
    }
}
