using System;

public class OddEvenLoop{
    public static void Main(String[] args){
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if(number > 0){
            for(int i = 1; i <= number; i++){
                if(i % 2 == 0){
                    Console.WriteLine(i + " is even number");
                }
                else{
                    Console.WriteLine(i + " is odd number");
                }
            }
        }
    }
}