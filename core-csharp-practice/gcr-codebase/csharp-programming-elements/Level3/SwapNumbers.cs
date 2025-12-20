using System;

public class SwapNumbers{
    public static void Main(String[] args){


        Console.WriteLine("Enter number1: ");

        String input1 = Console.ReadLine();
        int number1 = int.Parse(input1);

        Console.WriteLine("Enter number2: ");
        String input2 = Console.ReadLine();
        int number2 = int.Parse(input2);

        int temp = number1;
        number1 = number2;
        number2 = temp;

        Console.WriteLine("The swapped numbers are " + number1 + " and " + number2);
    }
}