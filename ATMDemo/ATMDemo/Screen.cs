//Screen.cs
//Represents the screen of the ATM
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDemo
{
   public class Screen : ITransaction
    {
        //display message without carriage return
        public void DisplayMessage(string message)
        {
            Console.Write(message);
        }
        // display a message without carriage return
        public void DisplayMessageLine(string message)
        {
            Console.WriteLine(message);
        }
        //display dollar amount
        public void DisplayDollarAmount(decimal amount)
        {
            Console.WriteLine("{0:C}", amount);
        }
        public void Execute()
        {
            Console.WriteLine("Please collect your receipt");
        }
    }
}
