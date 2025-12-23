using System;

public class MultiplicationTable{
    public static void Main(String[] args){
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        for(int i = 6; i <= 9; i++){
            int result = number * i;
            Console.WriteLine(number + " * " + i + " = " + result);
        }
    }
}