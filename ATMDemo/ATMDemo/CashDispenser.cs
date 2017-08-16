//CashDispenser.cs
// Represents the cash dispenser of the ATM
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDemo
{
   public class CashDispenser
    {
        // default number of bills in the cash dispenser

        private const int INITIAL_COUNT = 1000;
        private int billcount;// number of remaining $20bills

        public CashDispenser()
        {
            billcount = INITIAL_COUNT;// set bill count to INITAL count
        }

        //Simulation to dispense the cash
        public void DispenseCash(decimal amount)
        {
            //number of $20 bills required
            int billsRequired = ((int)amount) / 20;
            billcount -= billsRequired;
        }

        //indicates whether sufficient cash is available to dispense desired amount
        public bool IsSufficientCashAvailable(decimal amount)
        {
            //number of $20 bills required
            int billsRequired = ((int)amount) / 20;

            //return whether there are enough bills
            return (billcount >= billsRequired);
        }

        
    }
}
