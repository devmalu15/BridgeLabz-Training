using System;

public class PowerCalculator{
    public static void Main(String[] args){
        Console.WriteLine("Enter base number: ");
        String input1 = Console.ReadLine();
        int number = int.Parse(input1);

        Console.WriteLine("Enter power: ");
        String input2 = Console.ReadLine();
        int power = int.Parse(input2);

        long result = 1;

        for(int i = 1; i <= power; i++){
            result = result * number;
        }

        Console.WriteLine("Result: " + result);
    }
}