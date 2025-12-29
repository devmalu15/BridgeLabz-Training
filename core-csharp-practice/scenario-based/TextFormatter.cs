using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased
{
    public class TextFormatter
    {
        //public static String tockenizer(String str)
        //{

        //    String[] strArr = new 
        //    for(int i = 0; i < str.Length; i++)
        //    {

        //    }



        //    return "abc";
        //}

        public static String PuncSpace(String str)
        {

            StringBuilder result = new StringBuilder();

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == ',' || str[i] == ':' || str[i] == ';' || str[i] == '?' || str[i] == '.' || str[i] == '!')
                {
                    result.Append(str[i]);
                    result.Append(" ");
                }
                else
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }

        public static String Capitalizer(String str)
        {

            StringBuilder result = new StringBuilder();
            for(int i = 0; i < str.Length; i++)
            {
                if(i < str.Length - 2)
                {
                    if (str[i] == '.' || str[i] == '?' || str[i] == '!')
                    {
                        result.Append(str[i]);
                        result.Append(str[i + 1]);
                        result.Append(char.ToUpper(str[i + 2]));
                        i = i + 2;
                    }
                    else
                    {
                        result.Append(str[i]);
                    }
                }

                else
                {
                    result.Append(str[i]);

                }
                

            }

            return result.ToString();
        }

        public static String SpaceTrimmer(String str)
        {
            StringBuilder result = new StringBuilder();

            for(int i = 0; i < str.Length; i++)
            {
                if(i < str.Length - 1)
                {
                    if (str[i] == ' ' && str[i + 1] == ' ')
                    {
                        //doing nothing
                    }
                    else
                    {
                        result.Append(str[i]);
                    }
                }

                else
                {
                    result.Append(str[i]);
                }
                
            }


            return result.ToString();
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(" Welcome to the Text Formatter Tool ");
            Console.WriteLine("------------------------------------------");

            Console.Write("Enter the string to process: ");
            String str = Console.ReadLine();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n------------------------------------------");
                Console.WriteLine($"CURRENT STRING: {str}");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("1. Fix Punctuation (Add spaces)");
                Console.WriteLine("2. Fix Capitalization (First letter after . ? !)");
                Console.WriteLine("3. Trim Extra Spaces");
                Console.WriteLine("4. Apply ALL Fixes (1 -> 2 -> 3)");
                Console.WriteLine("5. Enter New String");
                Console.WriteLine("6. Exit");
                Console.WriteLine("------------------------------------------");
                Console.Write("Select an option (1-6): ");

                String choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        str = PuncSpace(str);
                        Console.WriteLine(" > Applied Punctuation Fix.");
                        break;
                    case "2":
                        str = Capitalizer(str);
                        Console.WriteLine(" > Applied Capitalization.");
                        break;
                    case "3":
                        str = SpaceTrimmer(str);
                        Console.WriteLine(" > Trimmer Applied.");
                        break;
                    case "4":
                        str = PuncSpace(str);
                        str = Capitalizer(str);
                        str = SpaceTrimmer(str);
                        Console.WriteLine(" > All formats applied successfully.");
                        break;
                    case "5":
                        Console.Write("Enter new string: ");
                        str = Console.ReadLine();
                        break;
                    case "6":
                        exit = true;
                        Console.WriteLine("Exiting... Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }

        public static void Main(String[] args)
        {
            DisplayMenu();
        }
    }
}
