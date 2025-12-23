using System;

public class PrimeCheck{
    public static void Main(String[] args){
        Console.WriteLine("Enter a number: ");
        String input = Console.ReadLine();
        int number = int.Parse(input);
        
        bool isPrime = true;

        if (number <= 1) {
            isPrime = false;
        } else {
            for (int i = 2; i < number; i++) {
                if (number % i == 0) {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime) {
            Console.WriteLine(number + " is a Prime Number");
        } else {
            Console.WriteLine(number + " is not a Prime Number");
        }
    }
}