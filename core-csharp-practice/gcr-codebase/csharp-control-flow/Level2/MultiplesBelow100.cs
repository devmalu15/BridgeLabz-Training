using System;

public class MultiplesBelow100{
    public static void Main(String[] args){
        Console.WriteLine("Enter a number: ");
        String input = Console.ReadLine();
        int number = int.Parse(input);

        Console.WriteLine("Multiples of " + number + " below 100 are:");
        for(int i = 100; i >= 1; i--){
            if(i % number == 0){
                Console.WriteLine(i);
            }
        }
    }
}