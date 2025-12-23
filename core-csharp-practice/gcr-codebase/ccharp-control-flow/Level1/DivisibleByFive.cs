using System;

public class DivisibleByFive{
    public static void Main(String[] args){
        Console.WriteLine("Enter number: ");
        String input = Console.ReadLine();
        int number = int.Parse(input);

        bool isDivisible = (number % 5 == 0);

        Console.WriteLine("Is the number " + number + " divisible by 5? " + isDivisible);
    }
}