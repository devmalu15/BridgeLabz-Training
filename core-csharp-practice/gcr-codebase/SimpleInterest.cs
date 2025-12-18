using System;

public class SimpleInterest{
    public static void Main(String[] args){
	
	Console.WriteLine("enter principal");
        double principal = double.Parse(Console.ReadLine());

	Console.WriteLine("enter rate");
        double rate = double.Parse(Console.ReadLine());

	Console.WriteLine("enter time");
        double time = double.Parse(Console.ReadLine());
	

	double simpleInterest = (principal * rate * time) / 100;
	
	Console.WriteLine(simpleInterest);
	}
    }