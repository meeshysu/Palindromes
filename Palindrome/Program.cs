using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a word to see if it is a Palindrome.");
            string palindromeString, rev;
            palindromeString = Console.ReadLine();
            char[] characterReverse = palindromeString.ToCharArray();

            Array.Reverse(characterReverse);
            rev = new string(characterReverse);

            bool reversePal = palindromeString.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (reversePal == true)
            {
                Console.WriteLine("" + palindromeString + " is s Palindrome!");
            } else
            {
                Console.WriteLine("" + palindromeString + " is not a Palindrome!");
            }
            Console.ReadLine();
        }
    }
}
