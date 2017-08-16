//Balance Inquiry for transaction
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDemo
{
    public class BalannceInquiry : Transaction
    {
        public BalannceInquiry(int userAccountNumber, Screen atmScreen, BankDatabase atmBakDatabase)
            : base(userAccountNumber, atmScreen, atmBakDatabase) { }

        // Override the execute method of interface Itransaction
        public override void Execute()
        {
            // get available balance
            decimal availableBalance = Database.GetAvailableBalance(AccountNumber);

            // get total balance
            decimal totalBalance = Database.GetTotalBalance(AccountNumber);
            // display the balance information on the screen
            UserScreen.DisplayMessageLine("\nBalance Information:");
            UserScreen.DisplayMessage(" - Available balance: ");
            UserScreen.DisplayDollarAmount(availableBalance);
            UserScreen.DisplayMessage("\n - Total balance: ");
            UserScreen.DisplayDollarAmount(totalBalance);
            UserScreen.DisplayMessageLine("");

        }


    }
}
