using System;

public class TripDetails{
    public static void Main(String[] args){


        Console.WriteLine("Enter Name: ");
        String name = Console.ReadLine();

        Console.WriteLine("Enter From City: ");
        String fromCity = Console.ReadLine();

        Console.WriteLine("Enter Via City: ");
        String viaCity = Console.ReadLine();

        Console.WriteLine("Enter To City: ");
        String toCity = Console.ReadLine();

        Console.WriteLine("Enter distance from " + fromCity + " to " + viaCity + ": ");
        String inputDist1 = Console.ReadLine();
        double fromToVia = double.Parse(inputDist1);

        Console.WriteLine("Enter distance from " + viaCity + " to " + toCity + ": ");
        String inputDist2 = Console.ReadLine();
        double viaToFinalCity = double.Parse(inputDist2);

        Console.WriteLine("Enter time taken: ");
        String inputTime = Console.ReadLine();
        double timeTaken = double.Parse(inputTime);

        double totalDistance = fromToVia + viaToFinalCity;

        Console.WriteLine("The results of the trip are: " + name + ", " + totalDistance + " miles, and " + timeTaken + " hours");
    }
}