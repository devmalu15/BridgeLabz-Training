using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.String.Built_in.Problem_Statement
{
    public class Palindrome
    {
        static bool IsPalindrome(string text)
        {
            int start = 0, end = text.Length - 1;

            while (start < end)
            {
                if (text[start] != text[end]) return false;
                start++;
                end--;
            }

            return true;
        }

        static void Main()
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();

            Console.WriteLine(IsPalindrome(text) ? "Palindrome" : "Not a Palindrome");
        }
    }
}
