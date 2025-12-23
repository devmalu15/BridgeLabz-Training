using System;

public class SumUntilZeroBreak{
    public static void Main(String[] args){
        double total = 0.0;
        
        while(true){
            Console.WriteLine("Enter a number: ");
            double input = double.Parse(Console.ReadLine());

            if(input <= 0){
                break;
            }

            total = total + input;
        }

        Console.WriteLine("Total sum is: " + total);
    }
}