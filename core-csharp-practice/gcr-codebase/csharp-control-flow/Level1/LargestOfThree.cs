using System;

public class LargestOfThree{
    public static void Main(String[] args){
        Console.WriteLine("Enter number1: ");
        int number1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter number2: ");
        int number2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter number3: ");
        int number3 = int.Parse(Console.ReadLine());

        bool firstLargest = (number1 > number2) && (number1 > number3);
        bool secondLargest = (number2 > number1) && (number2 > number3);
        bool thirdLargest = (number3 > number1) && (number3 > number2);

        Console.WriteLine("Is the first number the largest? " + firstLargest);
        Console.WriteLine("Is the second number the largest? " + secondLargest);
        Console.WriteLine("Is the third number the largest? " + thirdLargest);
    }
}