using System;

public class KMtoMiles{
    public static void Main(String[] args){
	Console.WriteLine("enter distance (KMs)");
        double distanceKM = double.Parse(Console.ReadLine());

	double distanceMiles = distanceKM * 0.621371;
	
	Console.WriteLine(distanceMiles);
	}
    }