using System;

public class PowerCalc{
    public static void Main(String[] args){
	
	Console.WriteLine("enter base number");
        double baseNumber = double.Parse(Console.ReadLine());

	Console.WriteLine("enter exponent");
        double exponent = double.Parse(Console.ReadLine());
	

	double result = Math.Pow(baseNumber, exponent);
	
	Console.WriteLine(result);
	}
    }