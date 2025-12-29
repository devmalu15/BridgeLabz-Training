using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.String.Extras
{
    public class VowelsAndConsonants
    {
        static void CountVowelsAndConsonants(string input)
        {
            int vowels = 0;
            int consonants = 0;

            input = input.ToLower(); // make comparison easy


            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                // check if character is a letter
                if (ch >= 'a' && ch <= 'z')
                {
                    if (ch == 'a' || ch == 'e' || ch == 'i' ||
                        ch == 'o' || ch == 'u')
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }

            Console.WriteLine("Vowels: " + vowels);
            Console.WriteLine("Consonants: " + consonants);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            CountVowelsAndConsonants(input);
        }
    }
}
