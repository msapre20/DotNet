using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ATM.cs represents ATM
namespace ATMDemo
{
    public class ATM
    {
        private bool userAuthenticated; // true if user is authenticated
        private int currentAccountNumber; // users account number
        private Screen screen; // ATM screen
        private Keypad keypad; // ATM keypad
        private CashDispenser cashDispenser; // ATM cash dispenser
        private BankDatabase bankDatabase; //account info Database

        //enumeration for main menu options
        private enum Menuoption
        {
            BALANCE_INQUIRY = 1,            
            DEPOSIT = 2,
            WITHDRAWAL = 3,            
            PRINT_RECEIPT = 4,
            EXIT_ATM = 5
        }

        public ATM()
        {
            userAuthenticated = false; // false till user enters valid information
            currentAccountNumber = 0; // no current account to start
            screen = new Screen(); // create screen
            keypad = new Keypad(); // create keypad
            cashDispenser = new CashDispenser();//create CashDispenser object
            bankDatabase = new BankDatabase();// create account info database
        }

        // start ATM
        public void Run()
        {
            //welcome and authenticate user
            while (true)
            {
                while (!userAuthenticated)
                {
                    screen.DisplayMessageLine("\n Welcome!");
                    AuthenticateUser();
                }
                PerformTransactions();
                userAuthenticated = false;
                currentAccountNumber = 0;
                screen.DisplayMessageLine("\n Thank you! GoodBye");
            }   
        }

        private void AuthenticateUser()
        {
            //Ask for account number and input it from user
            screen.DisplayMessage("\n Please enter your account number:");
            int accountNumber = keypad.GetInput();

            //Ask for pin and input it from user
            screen.DisplayMessage("\n Enter you PIN:");
            int pin = keypad.GetInput();

            //set userAuthenticated to boolean value returned by database
            userAuthenticated = bankDatabase.AuthenticateUser(accountNumber, pin);

            // check whether authentication succeeded
            if (userAuthenticated)
                currentAccountNumber = accountNumber;
            else
                screen.DisplayMessageLine("Invalid account number or PIN. Please try again later");

        }
        private void PerformTransactions()
        {
            Transaction currentTransaction;
            bool userExit = false; // user has not yet exited

            while (!userExit)
            {
                //main menu display
                int mainmenuSelection = DisplayMainMenu();
                 
                //Swtch according to menu selection
                switch ((Menuoption)mainmenuSelection)
                {
                    case Menuoption.BALANCE_INQUIRY:
                    case Menuoption.DEPOSIT:
                    case Menuoption.WITHDRAWAL:
                    case Menuoption.PRINT_RECEIPT:
                        currentTransaction = CreateTransaction(mainmenuSelection);
                        currentTransaction.Execute(); //executes transaction based on the type of transaction selected
                        break;
                    case Menuoption.EXIT_ATM: // user cancels the transaction
                        screen.DisplayMessageLine(" Cancelling the transaction");
                        userExit = true;
                        break;
                    default: // when user does not enter proper option
                        screen.DisplayMessageLine("Enter a valid option");
                        break;
                }
            }
        }

        private int DisplayMainMenu()
        {
            screen.DisplayMessageLine("\nMain menu:");
            screen.DisplayMessageLine("1 - View my balance");
            screen.DisplayMessageLine("2 - Deposit cash");
            screen.DisplayMessageLine("3 - Withdraw Cash");
            screen.DisplayMessageLine("4 - Print Reciept");
            screen.DisplayMessageLine("5 - Exit\n");
            screen.DisplayMessage("Enter a choice: ");
            return keypad.GetInput();
        }

        private Transaction CreateTransaction(int type)
        {
            Transaction tempTransaction = null; // null transaction reference

            //switch according to menu selected
            switch ((Menuoption)type)
            {
                case Menuoption.BALANCE_INQUIRY:
                    tempTransaction = new BalannceInquiry(currentAccountNumber, screen, bankDatabase);
                    break;
                case Menuoption.DEPOSIT:
                    tempTransaction = new Deposit(currentAccountNumber, screen, bankDatabase, keypad);
                    break;
                case Menuoption.WITHDRAWAL:
                    tempTransaction = new Withdrawal(currentAccountNumber, screen, bankDatabase, keypad, cashDispenser);
                    break;
                case Menuoption.PRINT_RECEIPT:
                    tempTransaction = new PrintReceipt(currentAccountNumber, screen, bankDatabase);
                    break;
            }
            return tempTransaction;
        }

    }
}
