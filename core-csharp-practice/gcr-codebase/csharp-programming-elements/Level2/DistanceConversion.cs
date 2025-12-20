using System;

public class DistanceConversion{
    public static void Main(String[] args){
        Console.WriteLine("Enter distanceInFeet : ");
        String input1 = Console.ReadLine();
        double distanceInFeet = double.Parse(input1);

        double distanceInYards = distanceInFeet / 3;
        double distanceInMiles = distanceInYards / 1760;

        Console.WriteLine("The distance in yards is " + distanceInYards + " and in miles is " + distanceInMiles);
    }
}