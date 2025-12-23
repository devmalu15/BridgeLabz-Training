using System;

public class RocketLaunchFor{
    public static void Main(String[] args){
        Console.WriteLine("Enter start number: ");
        int start = int.Parse(Console.ReadLine());

        for(int counter = start; counter >= 1; counter--){
            Console.WriteLine(counter);
        }
    }
}