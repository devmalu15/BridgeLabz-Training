using System;

public class FactorialWhile{
    public static void Main(String[] args){
        Console.WriteLine("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        if(number >= 0){
            long factorial = 1;
            int i = 1;
            while(i <= number){
                factorial = factorial * i;
                i++;
            }
            Console.WriteLine("Factorial of " + number + " is " + factorial);
        }
        else{
            Console.WriteLine("Invalid input");
        }
    }
}