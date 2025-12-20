using System;

public class VolumeOfEarth{
    public static void Main(String[] args){
	int rKms = 6378;
	double rMiles = rKms / 1.66;
	

	double volumeKms3 = 3.14 * (Math.Pow(rKms, 3));
	double volumeMiles3 = 3.14 * (Math.Pow(rMiles, 3));
	
	Console.WriteLine("Volume of Earth in cubic Kms : " + volumeKms3 + " and cubic miles : " + volumeMiles3);
}
}