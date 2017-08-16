using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ATMDemo.cs
//Application for instantiation 
namespace ATMDemo
{
   public class ATMDemo
    {
       public static void Main(string[] args)
        {
            ATM demoATM = new ATM();
            demoATM.Run();
        }
    }
}
