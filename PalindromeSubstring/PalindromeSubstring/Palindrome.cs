using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PalindromeSubstring
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string input = Convert.ToString(Console.ReadLine());
            /* Declaring ArrayList in order to store each word in the string
               based on the position of space character */
            ArrayList subStore = new ArrayList();
            int pos = input.IndexOf(" ");
            while (pos > 0)
            {
                string partialString = input.Substring(0, pos);
                subStore.Add(partialString);
                // restructure the input string omitting the previous word
                input = input.Substring(pos + 1, input.Length - (pos + 1));
                pos = input.IndexOf(" ");
                if (pos == -1)
                {
                    partialString = input.Substring(0, input.Length);
                    subStore.Add(partialString);
                }
            }
            /*
             * Processing each word from the arraylist
             * Each character is pushed into a stack and then matched with the 
             * character at the specific position
             */
            foreach (string word in subStore)
            {
                string initial = word.ToLower();
                bool isPalindrome = true;
                string check;
                int position = 0;
                Stack charStack = new Stack();
                for (int i = 0; i < initial.Length; i++)
                {
                    charStack.Push(initial.Substring(i, 1));
                }
                while(charStack.Count > 0)
                {
                    check = charStack.Pop().ToString();
                    if (check != initial.Substring(position, 1))
                    {
                        isPalindrome = false;
                        break;
                    }
                    position++;
                }
                if (isPalindrome)
                    Console.WriteLine(word + " is a palindrome");
                else
                    Console.WriteLine(word + " is not a palindrome");

            }

        }
    }
}
