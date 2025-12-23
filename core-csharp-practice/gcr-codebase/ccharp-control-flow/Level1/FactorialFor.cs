using System;

public class FactorialFor{
    public static void Main(String[] args){
        Console.WriteLine("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        if(number >= 0){
            long factorial = 1;
            for(int i = 1; i <= number; i++){
                factorial = factorial * i;
            }
            Console.WriteLine("Factorial of " + number + " is " + factorial);
        }
        else{
            Console.WriteLine("Invalid input");
        }
    }
}