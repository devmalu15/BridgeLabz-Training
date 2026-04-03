using System;

public class FactorsPrinter{
    public static void Main(String[] args){
        Console.WriteLine("Enter a number: ");
        String input = Console.ReadLine();
        int number = int.Parse(input);

        Console.WriteLine("Factors of " + number + " are:");
        for(int i = 1; i < number; i++){
            if(number % i == 0){
                Console.WriteLine(i);
            }
        }
    }
}