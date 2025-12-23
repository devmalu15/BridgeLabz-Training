using System;

public class FizzBuzzWhile{
    public static void Main(String[] args){
        Console.WriteLine("Enter a number: ");
        String input = Console.ReadLine();
        int number = int.Parse(input);

        int i = 0;
        while(i <= number){
            if(i % 3 == 0 && i % 5 == 0){
                Console.WriteLine("FizzBuzz");
            }
            else if(i % 3 == 0){
                Console.WriteLine("Fizz");
            }
            else if(i % 5 == 0){
                Console.WriteLine("Buzz");
            }
            else{
                Console.WriteLine(i);
            }
            i++;
        }
    }
}