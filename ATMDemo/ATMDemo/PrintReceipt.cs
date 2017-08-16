using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ATMDemo
{
   public class PrintReceipt :Transaction
    {
        public StreamWriter filewriter;
        
        public PrintReceipt(int userAccountNumber, Screen atmScreen, BankDatabase atmBakDatabase)
            : base(userAccountNumber, atmScreen, atmBakDatabase) { }

        // Override the execute method of interface Itransaction
        public override void Execute()
        {
            // get available balance
            decimal availableBalance = Database.GetAvailableBalance(AccountNumber);

            // get total balance
            decimal totalBalance = Database.GetTotalBalance(AccountNumber);

            //checking if the file already exists
            if (!File.Exists("receipt.txt"))
            {
                filewriter = new StreamWriter("receipt.txt");
            }
            else
            {
                File.Delete("receipt.txt");//delete the existing file from the location
                filewriter = new StreamWriter("receipt.txt"); // create new receipt
            }
            //write information to file related to the account
            filewriter.WriteLine("Details of account number: " + AccountNumber);
            filewriter.WriteLine("Available balance is {0:C}", availableBalance);
            filewriter.WriteLine("Total balance is {0:C}", totalBalance);
            filewriter.Close();// close file
            // Display message on screen
            UserScreen.Execute();
             

        }
    }
}
