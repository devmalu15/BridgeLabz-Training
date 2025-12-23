using System;

public class AbundantNumberCheck
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int num = int.Parse(input);

        int sum = 0;

        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }

        if (sum > num)
        {
            Console.WriteLine("Abundant Number");
        }
        else
        {
            Console.WriteLine("Not an Abundant Number");
        }
    }
}