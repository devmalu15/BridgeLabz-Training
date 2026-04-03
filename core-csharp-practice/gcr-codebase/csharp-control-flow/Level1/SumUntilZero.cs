using System;

public class SumUntilZero{
    public static void Main(String[] args){
        double total = 0.0;
        
        Console.WriteLine("Enter a number (0 to stop): ");
        double input = double.Parse(Console.ReadLine());

        while(input != 0){
            total = total + input;
            
            Console.WriteLine("Enter a number (0 to stop): ");
            input = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Total sum is: " + total);
    }
}