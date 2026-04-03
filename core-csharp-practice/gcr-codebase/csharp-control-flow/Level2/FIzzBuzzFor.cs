using System;

public class FizzBuzzFor{
    public static void Main(String[] args){
        Console.WriteLine("Enter a number: ");
        String input = Console.ReadLine();
        int number = int.Parse(input);

        for(int i = 0; i <= number; i++){
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
        }
    }
}