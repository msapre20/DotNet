//Keypad.cs
//Represents the keypad of the ATM
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDemo
{
    public class Keypad
    {
        // return integer value from string
        public int GetInput()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
