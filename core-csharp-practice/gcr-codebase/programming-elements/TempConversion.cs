using System;

public class TempConversion{
    public static void Main(String[] args){
	Console.WriteLine("enter temp Celcius");
        double tempCel = double.Parse(Console.ReadLine());
	double tempFar = (tempCel * (9 / 5)) + 32;
	
	Console.WriteLine(tempFar);
	}
    }