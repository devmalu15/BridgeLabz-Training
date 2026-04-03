using System;

public class RocketLaunchWhile{
    public static void Main(String[] args){
        Console.WriteLine("Enter start number: ");
        int counter = int.Parse(Console.ReadLine());

        while(counter >= 1){
            Console.WriteLine(counter);
            counter--;
        }
    }
}