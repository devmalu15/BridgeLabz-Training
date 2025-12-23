using System;

public class SmallestOfThree{
    public static void Main(String[] args){
        Console.WriteLine("Enter number1: ");
        int number1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter number2: ");
        int number2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter number3: ");
        int number3 = int.Parse(Console.ReadLine());

        bool isSmallest = (number1 < number2) && (number1 < number3);

        Console.WriteLine("Is the first number the smallest? " + isSmallest);
    }
}