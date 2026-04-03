using System;

public class GreatestFactor{
    public static void Main(String[] args){
        Console.WriteLine("Enter a number: ");
        String input = Console.ReadLine();
        int number = int.Parse(input);

        int greatestFactor = 1;

        for(int i = number - 1; i >= 1; i--){
            if(number % i == 0){
                greatestFactor = i;
                break;
            }
        }

        Console.WriteLine("The greatest factor beside itself is: " + greatestFactor);
    }
}